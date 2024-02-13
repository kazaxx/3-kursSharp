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

namespace WpfApp7
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

        private void Button_OnAboutClicked(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_OnDeliveryClicked(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();
            window4.Show();
            this.Visibility = Visibility.Collapsed;
        }

        private void Button_OnStoresClicked(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
            this.Visibility = Visibility.Collapsed;
        }

        private void Button_OnAccountClicked(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            this.Visibility = Visibility.Collapsed; // Скрыть текущую форму
        }
    }
}
