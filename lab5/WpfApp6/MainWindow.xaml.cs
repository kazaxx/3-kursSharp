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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
             Button1.MouseEnter += UIElement_OnMouseEnter;
            Button1.MouseLeave += UIElement_OnMouseLeave;

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Изменяем цвет фона окна при нажатии кнопки мыши
            this.Background = Brushes.Blue;
            UpdateStatus("MouseDown");
        }

        private void Window_MouseUp(object sender, MouseButtonEventArgs e)
        {
            // Возвращаем дефолтный цвет фона окна при отпускании кнопки мыши
            this.Background = SystemColors.ControlBrush;
            UpdateStatus("MouseUp");
        }

        private void UpdateStatus(string status)
        {
            // Обновляем текст в TextBlock для отображения текущего состояния
            StatusTextBlock.Text = status;
        }

        private void UpdateStatus1(string status)
        {
            StatusTextBlock1.Text = status;
        }

        private void Window_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
            {
                // Прокрутка вперед
                this.Background = Brushes.Red;
                UpdateStatus("MouseWhee-Вперед");
            }
            else
            {
                // Прокрутка назад
                this.Background = Brushes.Green;
                UpdateStatus("MouseWhee-Назад");
            }
        }
        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            // Получаем координаты мыши относительно окна
            Point mousePosition = e.GetPosition(this);

            // Обновляем заголовок окна с текущими координатами мыши
            UpdateStatus($"MouseMove - X={mousePosition.X}, Y={mousePosition.Y}");
        }

        private void Window_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.Background = SystemColors.ControlBrush;
            UpdateStatus("MouseRightButtonUp");
        }

        private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Background = Brushes.Aqua;
            UpdateStatus("MouseRightButtonDown");
        }
        private void Window_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.Background = Brushes.Lime;
            UpdateStatus("MouseLeftButtonUp");
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Background = Brushes.SlateGray;
            UpdateStatus("MouseLeftButtonDown");
        }

        private void UIElement_OnMouseLeave(object sender, MouseEventArgs e)
        {
            // Изменение цвета фона при выходе указателя мыши за пределы элемента
            this.Background = Brushes.White;
            UpdateStatus1("MouseLeave");
        }

        private void UIElement_OnMouseEnter(object sender, MouseEventArgs e)
        {
            // Изменение цвета фона при вхождении указателя мыши в пределы элемента
            this.Background = Brushes.Gold;
            UpdateStatus1("MouseEnter");
        }

        private void textbox_KeyDown(object sender, KeyEventArgs e)
        {
            this.Background = Brushes.Pink;
            UpdateStatus1("KeyDown");
        }

        private void textbox_KeyUp(object sender, KeyEventArgs e)
        {
            this.Background = SystemColors.ControlBrush;
            UpdateStatus1("KeyUp");
        }

        private void textbox1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            this.Background = Brushes.YellowGreen;
            UpdateStatus1($"PreviewTextInput - {e.Text}");
        }
    }
}
