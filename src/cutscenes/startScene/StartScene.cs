using System;
using Godot;

public partial class StartScene : Node2D{

    public MicrobeStage? newMicrobeStage = null;

    public override void _Ready(){
        Node2D dialog = GetNode<Node2D>("Dialog");

        TransitionManager.Instance.AddSequence(
            TransitionManager.Instance.CreateScreenFade(ScreenFade.FadeType.FadeIn, 1.5f));
        
        dialog.Connect("cutscene_ended", Callable.From(OnCutsceneEnded));
        Jukebox.Instance.PlayCategory("ArtGallery");
    }

    private void OnCutsceneEnded(){
        Jukebox.Instance.Stop();
        TransitionManager.Instance.AddSequence(
            TransitionManager.Instance.CreateScreenFade(ScreenFade.FadeType.FadeOut, 1.7f), StartGameCallback);
    
        void StartGameCallback(){
            GD.Print("newStage: "+newMicrobeStage);
            SceneManager.Instance.SwitchToScene(newMicrobeStage);
        }
    }
}