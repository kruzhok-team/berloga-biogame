extends Node2D

signal cutscene_ended
signal cutscene_statistics

func _ready():
    Dialogic.start("FinalScene")
    Dialogic.timeline_ended.connect(on_end)
    Dialogic.signal_event.connect(on_show_statistics)
    pass

func on_end():
    Dialogic.timeline_ended.disconnect(on_end)
    #Emmit signal for scene manager in c# script
    #See FinalScene.cs
    cutscene_ended.emit();

func on_show_statistics(argument:String):
    if argument == "Stat":
        Dialogic.signal_event.disconnect(on_show_statistics)
        cutscene_statistics.emit();
