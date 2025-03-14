namespace Tutorial;

using System;

/// <summary>
///   Introduction to the cell editor
/// </summary>
public class CellEditorIntroduction : TutorialPhase
{
    private readonly string cellEditorTab = EditorTab.CellEditor.ToString();

    public override string ClosedByName => "CellEditorIntroduction";

    public override void ApplyGUIState(MicrobeEditorTutorialGUI gui)
    {
        gui.CellEditorIntroductionVisible = ShownCurrently;
    }

    public override bool CheckEvent(TutorialState overallState, TutorialEventType eventType, EventArgs args,
        object sender)
    {
        switch (eventType)
        {

            case TutorialEventType.EnteredMicrobeEditor:
            {
                if (!HasBeenShown && CanTrigger)
                {
                    Show();
                }

                break;
            }

            case TutorialEventType.MicrobeEditorOrganellePlaced:
            {
                if (ShownCurrently)
                {
                    Hide();
                }

                break;
            }
            
            case TutorialEventType.MicrobeEditorTabChanged:
            {
                var tab = ((StringEventArgs)args).Data;

                if (!HasBeenShown && CanTrigger && tab == cellEditorTab)
                {
                    Show();
                }
                
                // Hide when switched to another tab
                if (tab != cellEditorTab)
                {
                    if (ShownCurrently)
                    {
                        Hide();
                    }
                }

                break;
            }
        }

        return false;
    }
}
