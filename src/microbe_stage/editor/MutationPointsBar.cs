using Godot;

/// <summary>
///   Mutation points bar that shows the remaining mutation points in the editor
/// </summary>
public partial class MutationPointsBar : HBoxContainer
{
	[Export]
	public NodePath? CurrentMutationPointsLabelPath;

	[Export]
	public NodePath MutationPointsArrowPath = null!;

	[Export]
	public NodePath ResultingMutationPointsLabelPath = null!;

	[Export]
	public NodePath BaseMutationPointsLabelPath = null!;

	[Export]
	public NodePath MutationPointsBarPath = null!;

	[Export]
	public NodePath MutationPointsSubtractBarPath = null!;

	[Export]
	public NodePath AnimationPlayerPath = null!;

#pragma warning disable CA2213
	private Label currentMutationPointsLabel = null!;
	private TextureRect mutationPointsArrow = null!;
	private Label resultingMutationPointsLabel = null!;
	private Label baseMutationPointsLabel = null!;
	private ProgressBar mutationPointsBar = null!;
	private ProgressBar mutationPointsSubtractBar = null!;
	private AnimationPlayer animationPlayer = null!;
#pragma warning restore CA2213

	private string freebuildingText = string.Empty;

	public override void _Ready()
	{
		currentMutationPointsLabel = GetNode<Label>(CurrentMutationPointsLabelPath);
		mutationPointsArrow = GetNode<TextureRect>(MutationPointsArrowPath);
		resultingMutationPointsLabel = GetNode<Label>(ResultingMutationPointsLabelPath);
		baseMutationPointsLabel = GetNode<Label>(BaseMutationPointsLabelPath);
		mutationPointsBar = GetNode<ProgressBar>(MutationPointsBarPath);
		mutationPointsSubtractBar = GetNode<ProgressBar>(MutationPointsSubtractBarPath);
		animationPlayer = GetNode<AnimationPlayer>(AnimationPlayerPath);

		freebuildingText = Localization.Translate("FREEBUILDING");
	}

	public void UpdateBar(float currentMutationPoints, float possibleMutationPoints, bool tween = true)
	{
		float newCurrentPoints = MicrobeStage.ChunkMutationCount>0 ? currentMutationPoints+(MicrobeStage.ChunkMutationCount*Constants.CHUNK_MUTATION_POINTS) : currentMutationPoints;
		float newPossiblePoints = MicrobeStage.ChunkMutationCount>0 ? possibleMutationPoints+(MicrobeStage.ChunkMutationCount*Constants.CHUNK_MUTATION_POINTS) : possibleMutationPoints;
		if (tween)
		{
			GUICommon.Instance.TweenBarValue(mutationPointsBar, newPossiblePoints, Constants.BASE_MUTATION_POINTS+(MicrobeStage.ChunkMutationCount*Constants.CHUNK_MUTATION_POINTS),
				0.5f);
			GUICommon.Instance.TweenBarValue(mutationPointsSubtractBar, newCurrentPoints,
				Constants.BASE_MUTATION_POINTS+(MicrobeStage.ChunkMutationCount*Constants.CHUNK_MUTATION_POINTS), 0.7f);
		}
		else
		{
			mutationPointsBar.Value = MicrobeStage.ChunkMutationCount>0 ? possibleMutationPoints+(MicrobeStage.ChunkMutationCount*Constants.CHUNK_MUTATION_POINTS) : possibleMutationPoints;
			mutationPointsBar.MaxValue = Constants.BASE_MUTATION_POINTS+(MicrobeStage.ChunkMutationCount*Constants.CHUNK_MUTATION_POINTS);
			mutationPointsSubtractBar.Value = newCurrentPoints;
			mutationPointsSubtractBar.MaxValue = Constants.BASE_MUTATION_POINTS+(MicrobeStage.ChunkMutationCount*Constants.CHUNK_MUTATION_POINTS);
		}

		mutationPointsSubtractBar.SelfModulate = possibleMutationPoints < 0 ?
			new Color(0.72f, 0.19f, 0.19f) :
			new Color(0.72f, 0.72f, 0.72f);
	}

	public void UpdateMutationPoints(bool freebuilding, bool showResultingPoints, float currentMutationPoints,
		float possibleMutationPoints)
	{
		float newCurrentPoints = MicrobeStage.ChunkMutationCount>0 ? currentMutationPoints+(MicrobeStage.ChunkMutationCount*Constants.CHUNK_MUTATION_POINTS) : currentMutationPoints;
		float newPossiblePoints = MicrobeStage.ChunkMutationCount>0 ? possibleMutationPoints+(MicrobeStage.ChunkMutationCount*Constants.CHUNK_MUTATION_POINTS) : possibleMutationPoints;
		if (freebuilding)
		{
			mutationPointsArrow.Hide();
			resultingMutationPointsLabel.Hide();
			baseMutationPointsLabel.Hide();

			currentMutationPointsLabel.Text = freebuildingText;
		}
		else
		{
			if (showResultingPoints)
			{
				mutationPointsArrow.Show();
				resultingMutationPointsLabel.Show();

				currentMutationPointsLabel.Text = $"({newCurrentPoints:F0}";
				resultingMutationPointsLabel.Text = $"{newPossiblePoints:F0})";
				baseMutationPointsLabel.Text = $"/ {newCurrentPoints:F0}";
			}
			else
			{
				mutationPointsArrow.Hide();
				resultingMutationPointsLabel.Hide();

				currentMutationPointsLabel.Text = $"{newCurrentPoints:F0}";
				baseMutationPointsLabel.Text = $"/ {newCurrentPoints:F0}";
			}
		}
	}

	public void PlayFlashAnimation()
	{
		animationPlayer.Play("FlashBar");
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (CurrentMutationPointsLabelPath != null)
			{
				CurrentMutationPointsLabelPath.Dispose();
				MutationPointsArrowPath.Dispose();
				ResultingMutationPointsLabelPath.Dispose();
				BaseMutationPointsLabelPath.Dispose();
				MutationPointsBarPath.Dispose();
				MutationPointsSubtractBarPath.Dispose();
				AnimationPlayerPath.Dispose();
			}
		}

		base.Dispose(disposing);
	}
}
