using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ByMail.Controls
{
    public partial class CustomTitleBar : UserControl
    {
        public CustomTitleBar()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
