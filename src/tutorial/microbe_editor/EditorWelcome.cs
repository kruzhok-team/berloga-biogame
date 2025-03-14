namespace Tutorial;

using System;
using Godot;

/// <summary>
///   Welcome message and intro to the report tab
/// </summary>
public class EditorWelcome : TutorialPhase
{
    private readonly string reportTab = EditorTab.Report.ToString();

    private int readyTrigger;
    public override string ClosedByName => "MicrobeEditorReport";
    public MicrobeEditorTutorialGUI? microbeGUI = null;

    public override void ApplyGUIState(MicrobeEditorTutorialGUI gui)
    {
        gui.EditorEntryReportVisible = ShownCurrently;
        microbeGUI = gui;
    }

    public override bool CheckEvent(TutorialState overallState, TutorialEventType eventType, EventArgs args,
        object sender)
    {
        switch (eventType)
        {

            case TutorialEventType.EnteredMicrobeEditor:
            {
                if (!HasBeenShown && CanTrigger && readyTrigger > 3)
                {
                    Show();
                    microbeGUI?.ShowEnvironmentPanel();
                }

                break;
            }

            case TutorialEventType.MicrobeEditorTabChanged:
            {
                var tab = ((StringEventArgs)args).Data;

                if (!HasBeenShown && CanTrigger && tab == reportTab)
                {
                    Show();
                    microbeGUI?.ShowEnvironmentPanel();
                }

                // Hide when switched to another tab
                if (tab != reportTab)
                {
                    if (ShownCurrently)
                    {
                        Hide();
                    }
                }

                break;
            }
            case TutorialEventType.MicrobeEditorTutorialStartChanged:
            {
                HasBeenShown = false;
                readyTrigger++;
                break;
            }
        }

        return false;
    }
}
