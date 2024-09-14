using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bruckner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MenuListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // mediaPlayer.Stop();
                    if (MenuListBox.SelectedItem is ListBoxItem selectedItem)
            {
                string pageName = selectedItem.Tag.ToString();
                ContentFrame.Navigate(new Uri($"Vistas/{pageName}.xaml", UriKind.Relative));
            }
        }
    }

}