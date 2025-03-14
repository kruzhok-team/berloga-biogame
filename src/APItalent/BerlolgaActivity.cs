namespace APItalent;

using APItalent;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Godot;

public class BerlogaActivity{

    public string[] ActivitiList(){
        return new string[] {"error"};
    }

    public static async Task CreateActivitiesAsync(List<GameActivity> activity)
    {
        
        var json = JsonSerializer.Serialize(activity);
        if(!String.IsNullOrEmpty(AuthTokenHandler.Instance.AuthToken)){
            var responce = await Http.Post<List<ResponceCreateList>>(
                path:"berloga-activities/activities",
                data:activity,
                authRequire:true,
                statusCode: HttpStatusCode.Created
            );
            foreach (var list in responce){
                StatisticsManager.Instance.ActivityList.Add(list);
                if(list.scores.HasValue){
                    double score = list.scores.Value;
                    SaveStatusOverlay.Instance.CallDeferred("ShowMessage", $"Активность выполненна! Полученные очки: {score}", 2f);
                }
                else{
                    SaveStatusOverlay.Instance.CallDeferred("ShowMessage", $"Активность выполненна!", 2f);
                }
            }
        }
    }

}

public class ResponceCreateList{
    public string id {get; set;}
    public double? scores {get;set;}
}
