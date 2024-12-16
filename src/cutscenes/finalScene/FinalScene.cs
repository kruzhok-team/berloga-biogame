using Godot;
using System;

public partial class FinalScene : Control
{
    [Export]
    public NodePath? StatisticPanelPath;

    private StatisticsManager instance = StatisticsManager.Instance;
    
#pragma warning disable CA2213
    private StatisticPanel? statisticPanel;
#pragma warning restore CA2213
    
    public override void _Ready()
    {
        TransitionManager.Instance.AddSequence(
            TransitionManager.Instance.CreateScreenFade(ScreenFade.FadeType.FadeIn, 1.5f));

        statisticPanel = GetNode<StatisticPanel>(StatisticPanelPath);

        Node2D dialog = GetNode<Node2D>("Dialog");
        dialog.Connect("cutscene_ended", Callable.From(OnCutsceneEnded));
        dialog.Connect("cutscene_statistics", Callable.From(OnShowStatisctics));
        Jukebox.Instance.PlayCategory("ArtGallery");
    }

    private void OnCutsceneEnded(){
        Jukebox.Instance.Stop();
        statisticPanel.Close();
        TransitionManager.Instance.AddSequence(
            TransitionManager.Instance.CreateScreenFade(ScreenFade.FadeType.FadeOut, 1.7f), ()=>{
                SceneManager.Instance.ReturnToMenu();
            });
    }

    private void OnShowStatisctics(){
        string statInfo = @$"Название вида: [b][color=green]{instance.PlayerMicrobeName}[/color][/b]
Время в игре: [b][color=green]{instance.InGameTime}[/color][/b]
Популяция вида: [b][color=green]{instance.PlayerMicrobePopulation}[/color][/b]
Количество поколений: [b][color=green]{instance.Generation}[/color][/b]
Осморегуляция: [b][color=green]{instance.Osmoregulation}[/color][/b]
Выработка АТФ (в секунду): [b][color=green]{instance.EnergyProduction}[/color][/b]
Количество органелл: [b][color=green]{instance.Organells}[/color][/b]";

        statisticPanel.OpenStatistic(statInfo);
    }

}
