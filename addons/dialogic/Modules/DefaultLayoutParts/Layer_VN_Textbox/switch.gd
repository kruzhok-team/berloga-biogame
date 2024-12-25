extends HBoxContainer


@export var switch_container_left: PanelContainer
@export var switch_container_right: PanelContainer

# Called when the node enters the scene tree for the first time.
func _ready():
    Dialogic.signal_event.connect(_switch_direction)

func _switch_direction(argument:String):
    if argument == "left":
        print("left recieved")
        switch_container_right.visible = true;
        switch_container_left.visible = true;
        switch_container_left.size_flags_stretch_ratio = 0.0;
        switch_container_right.size_flags_stretch_ratio = 2.0;
    elif argument == "right":
        print("right recieved")
        switch_container_right.visible = true;
        switch_container_left.visible = true;
        switch_container_right.size_flags_stretch_ratio = 0.0;
        switch_container_left.size_flags_stretch_ratio = 2.0;
    elif argument == "intro":
        print("defualt recieved")
        switch_container_right.visible = false;
        switch_container_left.visible = false;
