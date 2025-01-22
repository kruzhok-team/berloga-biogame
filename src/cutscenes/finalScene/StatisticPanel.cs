using Godot;
using System;

public partial class StatisticPanel : TopLevelContainer
{
    [Export]
    public NodePath? PanelContainerPath;

    [Export]
    public NodePath? BodyLabelPath;
    
#pragma warning disable CA2213
    private PanelContainer? panelContainer;
    private RichTextLabel? bodyLabel;
#pragma warning restore CA2213

    public override void _Ready()
    {
        panelContainer = GetNode<PanelContainer>(PanelContainerPath);
        bodyLabel = GetNode<RichTextLabel>(BodyLabelPath);
    }
    
    public void OpenStatistic(string bodyText){
        bodyLabel.Text = bodyText;
        Vector2 panelSize = panelContainer.GetCombinedMinimumSize();
        OpenCentered(true, new Vector2(panelSize.X, panelSize.Y));
    }

    protected override void Dispose(bool disposing){
        if(disposing){
            if(PanelContainerPath != null){
                PanelContainerPath.Dispose();
            }
            if(BodyLabelPath != null){
                BodyLabelPath.Dispose();
            }
        }
        base.Dispose(disposing);
    }
}