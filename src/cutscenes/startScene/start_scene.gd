extends Node2D

signal cutscene_ended

func _ready():
    Dialogic.start("StartScene")
    Dialogic.timeline_ended.connect(on_end)
    pass

func on_end():
    Dialogic.timeline_ended.disconnect(on_end)
    #Emmit signal for scene manager in c# script
    #See StartScene.cs
    cutscene_ended.emit();