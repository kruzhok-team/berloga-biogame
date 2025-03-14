namespace APItalent;

using System;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using System.Text.Json;
using System.Timers;
using System.Collections.Generic;
using static Godot.GD;
using APItalent;

class BerlogaAuthorization{
    public static async Task<string> GetConnectToTalentUrl(string redirectUri){
        try
        {
            using (var client = new HttpClient(new HttpClientHandler { AllowAutoRedirect = false })){
                client.DefaultRequestHeaders.Add("Authorization", AuthTokenHandler.Instance.AuthToken);
                var response = await client.GetAsync($"{Environment.GetEnvironmentVariable("BASE_ADRESS")}/berloga-idp/talent-oauth/connect?redirect_uri={redirectUri}");//
                
                return response.Headers.Location.ToString();
            }
        }
        catch (HttpRequestException ex)
        {
            PrintErr($"HTTP Error: {ex.Message}");
            return "0";
        }
        catch (Exception ex)
        {
            PrintErr($"Error: {ex.Message}");
            return "0";
        }
    }
}