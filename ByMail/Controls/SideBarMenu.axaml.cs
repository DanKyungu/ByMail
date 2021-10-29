using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ByMail.Controls
{
    public partial class SideBarMenu : UserControl
    {
        public SideBarMenu()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
