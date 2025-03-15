namespace Tutorial;

using System;
using Godot;

/// <summary>
///   Tutorial for the patch map tab
/// </summary>
public class PatchMap : TutorialPhase
{
    private readonly string patchMapTab = EditorTab.PatchMap.ToString();
    private readonly string cellEditorTab = EditorTab.CellEditor.ToString();

    public override string ClosedByName => "PatchMap";

    public override void ApplyGUIState(MicrobeEditorTutorialGUI gui)
    {
        gui.PatchMapVisible = ShownCurrently;
    }

    public override bool CheckEvent(TutorialState overallState, TutorialEventType eventType, EventArgs args,
        object sender)
    {
        switch (eventType)
        {
            case TutorialEventType.MicrobeEditorTabChanged:
            {
                var tab = ((StringEventArgs)args).Data;

                if (!HasBeenShown && CanTrigger && tab == patchMapTab)
                {
                    Show();
                }
                else if (ShownCurrently && tab != patchMapTab)
                {
                    Hide();
                }

                break;
            }
        }

        return false;
    }
}
