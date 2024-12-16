using System;
using Godot;

public sealed class InGameTimeManager{
    public double currentInGameTime {get;set;}

    public void AddCurrentTime(double deltaTime){
        currentInGameTime+=deltaTime;
    }

    public string GetTransformCurrentTime(){
        TimeSpan time = TimeSpan.FromSeconds(currentInGameTime);
        return time.ToString(@"hh\:mm\:ss");
    }
}