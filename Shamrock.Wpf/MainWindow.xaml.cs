using System.Windows;

namespace Shamrock.Wpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var bootStrap = new BootstrapWpf(Navigator);
            bootStrap.Start();
        }
    }
}
