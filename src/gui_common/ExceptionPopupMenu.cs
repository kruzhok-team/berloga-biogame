using Godot;
using System;

/// <summary>
/// A popup menu for displaying API exceptions to the user.
/// </summary>

public partial class ExceptionPopupMenu : TopLevelContainer
{
    /// <summary>
    /// NodePath for the label that displays the exception message.
    /// </summary>
    [Export]
    public NodePath? BodyLabelPath;

    /// <summary>
    /// NodePath for the panel container that holds the UI elements of the popup.
    /// </summary>
    [Export]
    public NodePath? PanelContainerPath;

    /// <summary>
    /// NodePath for the button that allows the user to dismiss the popup.
    /// However user can dismiss the popyp by clicking outside of this popup <see cref="TopLevelContainer.Exclusive"/>
    /// </summary>
    [Export]
    public NodePath? ButtonPath;

#pragma warning disable CA2213
    private Label? bodyLabel;
    private PanelContainer? panelContainer;
    private Button? button;
#pragma warning restore CA2213

    /// <summary>
    /// Opens the exception popup menu, centering it on the screen.
    /// This method calculates the size of the panel and positions the popup accordingly.
    /// </summary>
    /// <param name="exceptionText">Text that will be inserted into the body of the popup menu</param>
    public void OpenException(string exceptionText)
    {
        bodyLabel.Text = $"Произошла ошибка:{exceptionText}\n Пожалуйста, попробуйте еще раз позже";
        var panelSize = panelContainer.GetCombinedMinimumSize();
        OpenCentered(true, new Vector2(panelSize.X, panelSize.Y));
    }

    public override void _Ready(){
        bodyLabel = GetNode<Label>(BodyLabelPath);
        panelContainer = GetNode<PanelContainer>(PanelContainerPath);
        button = GetNode<Button>(ButtonPath);

        button.Pressed += OnButtonPressed; // Connect the button pressed signal to the handler.
    }

    /// <summary>
    /// Event handler for the button pressed signal. Closes the popup when the button is clicked.
    /// <see cref="TopLevelContainer.Close"/>
    /// </summary>
    private void OnButtonPressed()
    {
        Close();
    }

    /// <summary>
    /// Disposes of the resources used by this instance of the popup
    /// and releases references to nodes when the popup is no longer needed.
    /// </summary>
    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (BodyLabelPath != null)
            {
                BodyLabelPath.Dispose();
            }
            if (PanelContainerPath != null)
            {
                PanelContainerPath.Dispose();
            }
            if (ButtonPath != null)
            {
                ButtonPath.Dispose();
            }
        }
        base.Dispose(disposing);
    }
}
