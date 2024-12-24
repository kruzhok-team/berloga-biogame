using Godot;
using System;

public partial class IntroScene : Control
{
    public override void _Ready(){
        Node2D dialog = GetNode<Node2D>("Dialog");

        TransitionManager.Instance.AddSequence(
            TransitionManager.Instance.CreateScreenFade(ScreenFade.FadeType.FadeIn, 1.5f));
        
        dialog.Connect("cutscene_ended", Callable.From(OnCutsceneEnded));
    }

    private void OnCutsceneEnded(){
        Settings.Instance.PlayIntroVideo = new(false);
        Jukebox.Instance.Stop();
        TransitionManager.Instance.AddSequence(
            TransitionManager.Instance.CreateScreenFade(ScreenFade.FadeType.FadeOut, 1.7f), ()=>{
                SceneManager.Instance.ReturnToMenu();
            });
    }
}
