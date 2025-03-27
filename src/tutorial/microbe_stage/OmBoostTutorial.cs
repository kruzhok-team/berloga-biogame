namespace Tutorial;

using System;
using Godot;

/// <summary>
///   Tutorial pointing glucose collection out to the player
/// </summary>
public class OmBoostTutorial : TutorialPhase
{
    public OmBoostTutorial()
    {
        CanTrigger = false;
    }

    public override string ClosedByName => "OmBoostTutorial";

    public override void ApplyGUIState(MicrobeTutorialGUI gui)
    {
        gui.OmBoostTutorialVisible = ShownCurrently;
    }

    public override bool CheckEvent(TutorialState overallState, TutorialEventType eventType, EventArgs args,
        object sender)
    {
        
        switch (eventType)
        {
            case TutorialEventType.MicrobeOmBoost:
            {
                if (!HasBeenShown && !CanTrigger && !overallState.TutorialActive())
                {
                    CanTrigger = true;
                    Show();
                    return true;
                }
                break;
            }
        }

        return false;
    }
}