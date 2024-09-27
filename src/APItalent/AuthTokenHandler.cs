using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

/// <summary>
///   Class that is handles processing the logic of obtaining, updating and deleting a unique token for the “talent” platform.
/// </summary>

namespace APItalent{
    public class AuthTokenHandler{
        /// <summary>
        ///   Singleton. "Lazy" is used to ensure thread safety
        /// </summary>
        private static readonly Lazy<AuthTokenHandler> SingletonInstance = new Lazy<AuthTokenHandler>(()=>new AuthTokenHandler());

        private bool isInit = false;

        /// <summary>
        ///   Authentication data
        /// </summary>
        private string? Application_ID {get;set;}
        private string? Player_ID {get;set;}
        private string? Player_Secret {get;set;}

        public string AuthToken {get;set;}
        private int AuthTokenExpires {get;set;}

        public string ErrorMessage {get;set;}
        public string? VerboseMessage {get;set;} = null

        private readonly HttpClient httpClient = new ()
        {
            BaseAddress = new Uri(Environment.GetEnvironmentVariable("BASE_ADRESS")),
        };

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
            
            //when you init instance Token already get ready for work
            await ReinitializeTokenAsync();
        }

        /// <summary>
        /// IMPORTANT!
        /// the first time you access this class, after creating an instance, you must initialize the properties for requests through the "Initialize()" method.
        /// 
        /// Example:
        ///     AuthTokenHandler obj = AuthTokenHandler.Instance;
        ///     obj.Initialize(app_id, player_id, player_secret);
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
                using (StringContent requestBody = new (
                    JsonSerializer.Serialize(new
                    {
                        application_id = Application_ID,
                        player_id = Player_ID,
                        player_secret = Player_Secret
                    }),
                    Encoding.UTF8,
                    "application/json"));

                using HttpResponseMessage response = await httpClient.PostAsync("berloga-idp/issue-token",requestBody);

                string jsonResponce = await response.Content.ReadAsStringAsync();
                
                if(response.StatusCode == System.Net.HttpStatusCode.Created){
                    SuccessResponse result = JsonSerializer.Deserialize<SuccessResponse>(jsonResponce);
                    AuthToken = result.token;
                    AuthTokenExpires = result.expires_in;
                }
                else{
                    DefaultResponce result = JsonSerializer.Deserialize<DefaultResponce>(jsonResponce);
                    ErrorMessage = result.error_message;
                    VerboseMessage = result.verbose_message;
                }
            }
            catch(Exception ex){
                throw new InvalidOperationException("Failed to reinitialize token", ex);
            }
        }
    }
}

class SuccessResponse{
    public string token {get;set;}
    public int expires_in {get;set;}
}
class DefaultResponce{
    public string error_message {get;set;}
    public string? verbose_message {get;set;} = null
}