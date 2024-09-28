namespace APItalent;

using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Timers;
using APItalent;

/// <summary>
///   Class that is handles processing the logic of obtaining, updating and deleting a unique token for the “talent” platform.
/// </summary>


public class AuthTokenHandler{
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
    private string? Player_ID {get;set;}
    private string? Player_Secret {get;set;}

    public string? AuthToken {get;set;} = null;
    private int AuthTokenExpires {get;set;}

    public string ErrorMessage {get;set;}
    public string? VerboseMessage {get;set;} = null

    private AuthTokenHandler(){

    }
    static AuthTokenHandler(){

    }

    public async void Initialize(string player_id, string player_secret){
        if(isInit){
            throw new InvalidOperationException("You already initialize Auth data for this Instance. Cannot Initialize twice, use DeleteAuthData() for delete old Auth data and try Initialize() again");
        }
        Application_ID = Environment.GetEnvironmentVariable("APPLICATION_ID");
        Player_ID = player_id;
        Player_Secret = player_secret;
        isInit = true;
            
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
    ///     obj.Initialize(player_id, player_secret);
    /// </summary>

    public static AuthTokenHandler Instance => SingletonInstance.Value;

    public void DeleteAuthData(){
        Application_ID = null;
        Player_ID = null;
        Player_Secret = null;
        isInit = false;
    }

    public async Task ReinitializeTokenAsync(){
        if(!isInit){
            throw new InvalidOperationException("Cannot get Token without Initialize Auth Data, use Initialize() method and try again");
        }
        try{
            var responce = await Http.Post<SuccessResponse>("berloga-idp/issue-token",new{application_id = Application_ID,
                player_id = Player_ID,
                player_secret = Player_Secret},
                HttpStatusCode.Created);
            
            AuthToken = responce?.token;
            AuthTokenExpires = responce?.expires_in;
        }
        catch(HttpRequestException ex){
            //TODO:do something when exception
        }
        catch(JsonException ex){
            //TODO:do something when exception
        }
        catch(TaskCanceledException ex){
            //TODO:do something when exception
        }
        catch(Exception ex){
            //TODO:do something when exception
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
        if(isInit){
            StartTimer(TimeSpan.FromSeconds(AuthTokenExpires));
        }
    }
}   

class SuccessResponse{
    public string token {get;set;}
    public int expires_in {get;set;}
}