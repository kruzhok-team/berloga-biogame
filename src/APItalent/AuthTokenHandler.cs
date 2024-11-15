namespace APItalent;

using System;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using System.Text.Json;
using System.Timers;
using static Godot.GD;
using APItalent;

/// <summary>
///   Class that is handles processing the logic of obtaining, updating and deleting a unique token for the “talent” platform.
/// </summary>

public sealed class AuthTokenHandler{
    /// <summary>
    ///   Singleton. "Lazy" is used to ensure thread safety
    /// </summary>
    private static readonly Lazy<AuthTokenHandler> SingletonInstance = new(()=>new AuthTokenHandler());

    private bool isInit;
    private Timer timer;

    /// <summary>
    /// Authentication data corresponding to the application and player.
    /// </summary>
    private string? Application_ID {get;set;}
    public string? Player_ID {get;set;}
    public string? Player_Secret {get;set;}

    /// <summary>
    /// The current authentication token.
    /// </summary>
    public string? AuthToken {get;set;}
    private int AuthTokenExpires {get;set;}

    /// <summary>
    /// Popup menu to display exception
    /// </summary>
    private ExceptionPopupMenu exceptionPopupMenu {get;set;}

    private AuthTokenHandler()
    {

    }
    static AuthTokenHandler()
    {

    }

    /// <summary>
    /// Initializes the authentication handler with exception popup menu and obtains a new player ID.
    /// </summary>
    /// <param name="popup">
    /// The ExceptionPopupMenu instance to be used for displaying errors.
    /// </param>
    public async Task Initialize(ExceptionPopupMenu popup)
    {
        if (isInit)
        {
            throw new InvalidOperationException("You already initialize Auth data for this Instance. Cannot Initialize twice, use DeleteAuthData() for delete old Auth data and try Initialize() again");
        }

        exceptionPopupMenu = popup;

        Application_ID = Environment.GetEnvironmentVariable("APPLICATION_ID");
        isInit = true;
        await RegNewPlayerID();

        // when you init instance, token already get ready for work
        await ReinitializeTokenAsync();
        StartTimer(TimeSpan.FromSeconds(AuthTokenExpires));
    }

    /// <summary>
    /// Gets the singleton instance of the AuthTokenHandler class.
    /// </summary>
    public static AuthTokenHandler Instance => SingletonInstance.Value;

    /// <summary>
    /// Deletes all authentication data and resets the handler state.
    /// </summary>
    public void DeleteAuthData()
    {
        Application_ID = null;
        Player_ID = null;
        Player_Secret = null;
        AuthToken = null;
        timer.Stop();
        isInit = false;
    }

    /// <summary>
    /// Async reinitialize the authentication token.
    /// </summary>
    public async Task ReinitializeTokenAsync()
    {
        if (!isInit)
        {
            throw new InvalidOperationException("Cannot get Token without Initialize Auth Data, use Initialize() method and try again");
        }
        try{
            if (Application_ID != null && Player_ID != null && Player_Secret != null)
            {
                var responce = await Http.Post<SuccessTokenResponse>(
                    path: "berloga-idp/issue-token",
                    data: new{application_id = Application_ID,
                        player_id = Player_ID,
                        player_secret = Player_Secret},
                    statusCode: HttpStatusCode.Created);
                AuthToken = responce.token != null ? responce.token : null;
                AuthTokenExpires = responce.expires_in;
            }
        }
        catch (HttpError ex)
        {
            exceptionPopupMenu.OpenException("HttpError: " + ex.ErrorMessage);
        }
        catch (HttpRequestException ex)
        {
            exceptionPopupMenu.OpenException("HttpRequestException:" + ex.Message);
        }
        catch (JsonException ex)
        {
            exceptionPopupMenu.OpenException("JsonException: " + ex.Message);
        }
        catch (TaskCanceledException ex)
        {
            exceptionPopupMenu.OpenException("TaskCanceledException: " + ex.Message);
        }
        catch (Exception ex)
        {
            exceptionPopupMenu.OpenException("UnknownException: " + ex.Message);
        }
    }

    /// <summary>
    /// Starts a timer that will trigger token reinitialization after the specified interval.
    /// </summary>
    /// <param name="interval">The time span after which the token should be reinitialized.</param>
    private void StartTimer(TimeSpan interval)
    {
        timer = new Timer(interval.TotalMilliseconds);
        timer.Elapsed += TimerElapsed;
        timer.AutoReset = false;
        timer.Start();
    }

    /// <summary>
    /// Event handler for the timer elapsed event; reinitializes the token.
    /// </summary>
    private async void TimerElapsed(object sender, ElapsedEventArgs e)
    {
        await ReinitializeTokenAsync();
        if (isInit && AuthTokenExpires > 0)
        {
            StartTimer(TimeSpan.FromSeconds(AuthTokenExpires));
        }
    }

    /// <summary>
    /// Register a new player ID.
    /// </summary>
    private async Task RegNewPlayerID()
    {
        try{
            var responce = await Http.Post<SuccessRegResponse>(
                path:"berloga-idp/players",
                data: new {application_id = Application_ID, device_id = "PC"},
                statusCode: HttpStatusCode.Created
            );

            Player_ID = responce.player_id;
            Player_Secret = responce.player_secret;
        }
        catch (HttpError ex)
        {
            exceptionPopupMenu.OpenException("HttpError: " + ex.ErrorMessage);
        }
        catch (HttpRequestException ex)
        {
            exceptionPopupMenu.OpenException("HttpRequestException: " + ex.Message);
        }
        catch (JsonException ex)
        {
            exceptionPopupMenu.OpenException("JsonException: " + ex.Message);
        }
        catch (TaskCanceledException ex)
        {
            exceptionPopupMenu.OpenException("TaskCanceledException: " + ex.Message);
        }
        catch (Exception ex)
        {
            exceptionPopupMenu.OpenException("UnknownException: " + ex.Message);
        }
    }
}

class SuccessTokenResponse{
    public string token {get;set;}
    public int expires_in {get;set;}
}

class SuccessRegResponse{
    public string player_id {get;set;}
    public string player_secret {get;set;}
}