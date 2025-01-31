using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using APItalent;

// Manager that handle in game stats
public sealed class StatisticsManager{
    /// <summary>
    ///   Singleton. "Lazy" is used to ensure thread safety
    /// </summary>
    private static readonly Lazy<StatisticsManager> SingletonInstance = new Lazy<StatisticsManager>(()=>new StatisticsManager());

    public static StatisticsManager Instance => SingletonInstance.Value ?? throw new InstanceNotLoadedYetException();

    private StatisticsManager(){

    }
    static StatisticsManager(){

    }

    public string PlayerMicrobePopulation {get;set;} = "0";
    public string InGameTime {get;set;} = "0";
    public string Generation {get;set;} = "0";
    public string Osmoregulation {get;set;} = "0";
    public string Organells {get;set;} = "0";
    public string EnergyProduction {get;set;} = "0";
    public string PlayerMicrobeName {get;set;} = "defualt";

    [JsonProperty]
    public List<ResponceCreateList> ActivityList {get;set;} = new List<ResponceCreateList>();
}