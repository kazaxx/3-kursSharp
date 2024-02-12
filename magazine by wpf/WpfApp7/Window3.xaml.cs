using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Window3_Loaded(object sender, RoutedEventArgs e)
        {
            // Получаем элемент WebBrowser
            WebBrowser webBrowser = (WebBrowser)sender;

            // Отображаем веб-страницу Google Maps
            webBrowser.Navigate("https://maps.app.goo.gl/kwRBeyjSLRA3gzg79");
        }
    }
}
