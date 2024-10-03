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
    private static readonly Lazy<AuthTokenHandler> SingletonInstance = new Lazy<AuthTokenHandler>(()=>new AuthTokenHandler());

    private bool isInit = false;
    private Timer timer;

    /// <summary>
    ///   Authentication data
    /// </summary>
    private string? Application_ID {get;set;}
    public string? Player_ID {get;set;}
    public string? Player_Secret {get;set;}

    public string? AuthToken {get;set;} = null;
    private int AuthTokenExpires {get;set;} = 0;

    public string ErrorMessage {get;set;}
    public string? VerboseMessage {get;set;} = null;

    private AuthTokenHandler(){

    }
    static AuthTokenHandler(){

    }

    public async Task Initialize(){
        if(isInit){
            throw new InvalidOperationException("You already initialize Auth data for this Instance. Cannot Initialize twice, use DeleteAuthData() for delete old Auth data and try Initialize() again");
        }
        Application_ID = Environment.GetEnvironmentVariable("APPLICATION_ID");
        isInit = true;
        await RegNewPlayerID();
            
        //when you init instance, token already get ready for work
        await ReinitializeTokenAsync();
        StartTimer(TimeSpan.FromSeconds(AuthTokenExpires));
    }

    /// <summary>
    /// IMPORTANT!
    /// the first time you access this class, after creating an instance, you must initialize the properties for requests through the "Initialize()" method.
    /// 
    /// Example:
    ///     AuthTokenHandler obj = AuthTokenHandler.Instance;
    ///     obj.Initialize();
    /// </summary>

    public static AuthTokenHandler Instance => SingletonInstance.Value;

    public void DeleteAuthData(){
        Application_ID = null;
        Player_ID = null;
        Player_Secret = null;
        AuthToken = null;
        timer.Stop();
        isInit = false;
    }

    public async Task ReinitializeTokenAsync(){
        if(!isInit){
            throw new InvalidOperationException("Cannot get Token without Initialize Auth Data, use Initialize() method and try again");
        }
        try{
            if(Application_ID != null && Player_ID != null && Player_Secret != null){
                var responce = await Http.Post<SuccessTokenResponse>(
                    path: "berloga-idp/issue-token",
                    data: new{application_id = Application_ID,
                        player_id = Player_ID,
                        player_secret = Player_Secret},
                    statusCode: HttpStatusCode.Created);
            
                AuthToken = responce.token != null ? responce.token : null;
                if(responce.expires_in != null){
                    AuthTokenExpires = responce.expires_in;
                }
            }

        }
        catch(HttpRequestException ex){
            Print("ReinitializeTokenAsync catch HttpRequestException " + ex.Message);
        }
        catch(JsonException ex){
            Print("ReinitializeTokenAsync catch JsonException " + ex.Message);
        }
        catch(TaskCanceledException ex){
            Print("ReinitializeTokenAsync catch TaskCanceledException " + ex.Message);
        }
        catch(Exception ex){
            Print("ReinitializeTokenAsync catch Exception " + ex.Message);
        }
    }

    private void StartTimer(TimeSpan interval){
        timer = new Timer(interval.TotalMilliseconds);
        timer.Elapsed += TimerElapsed;
        timer.AutoReset = false;
        timer.Start();
    }

    private async void TimerElapsed(object sender, ElapsedEventArgs e){
        await ReinitializeTokenAsync();
        if(isInit && AuthTokenExpires > 0){
            StartTimer(TimeSpan.FromSeconds(AuthTokenExpires));
        }
    }

    private async Task RegNewPlayerID(){
        try{
            var responce = await Http.Post<SuccessRegResponse>(
                path:"berloga-idp/players",
                data: new {application_id = Application_ID, device_id = "PC"},
                statusCode: HttpStatusCode.Created
            );

            Player_ID = responce.player_id;
            Player_Secret = responce.player_secret;
        }
        catch(HttpRequestException ex){
            Print("RegNewPlayerID catch HttpRequestException " + ex.Message);
        }
        catch(JsonException ex){
            Print("RegNewPlayerID catch JsonException " + ex.Message);
        }
        catch(TaskCanceledException ex){
            Print("RegNewPlayerID catch TaskCanceledException " + ex.Message);
        }
        catch(Exception ex){
            Print("RegNewPlayerID catch Exception " + ex.Message);
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