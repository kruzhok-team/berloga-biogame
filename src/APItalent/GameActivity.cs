namespace APItalent;

using System;
using System.Collections.Generic;

public class GameActivity{
    
    public GameActivity(string appVersion, string contextId, Dictionary<string, double>? gameMetrics = null){
        app_version = appVersion;
        context_id = contextId;
        metrics = gameMetrics;
    }

    public string app_version {get; set;}
    public string context_id {get; set;}
    public Dictionary<string, double>? metrics {get; set;} = null;
}