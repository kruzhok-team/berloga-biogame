namespace Tutorial;

using System;
using Godot;
using Newtonsoft.Json;

/// <summary>
///   Tutorial pointing glucose collection out to the player
/// </summary>
public class CompoundTutorial : TutorialPhase
{
	private MicrobeTutorialGUI? microbeTutorialGUI;

	public CompoundTutorial()
	{
		UsesPlayerPositionGuidance = true;
		CanTrigger = false;
	}

	public override string ClosedByName => "CompoundTutorial";

	public override void ApplyGUIState(MicrobeTutorialGUI gui)
	{
		microbeTutorialGUI = gui;
		gui.CompoundTutorialVisible = ShownCurrently;
	}

	public override bool CheckEvent(TutorialState overallState, TutorialEventType eventType, EventArgs args,
		object sender)
	{
		if (microbeTutorialGUI != null && microbeTutorialGUI.ShowCompoundTutorial)
		{
			CanTrigger = true;
			Show();
			return true;
		}
		
		return false;
	}
}
