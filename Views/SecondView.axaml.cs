using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace lab.Views
{
    public partial class SecondView : UserControl
    {
        public SecondView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
