using Robust.Client.UserInterface.CustomControls;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.PenRename
{
    [GenerateTypedNameReferences]
    public sealed partial class PenRenameWindow : DefaultWindow
    {
        public event Action<string>? OnNameEntered;

        public PenRenameWindow()
        {
            RobustXamlLoader.Load(this);

            NameLineEdit.OnTextEntered += e => OnNameEntered?.Invoke(e.Text);
        }
        public void SetCurrentName(string name)
        {
            NameLineEdit.Text = name;
        }
    }
}
