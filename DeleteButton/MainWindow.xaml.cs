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

namespace DeleteButton
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

        private void Button_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            //  Button
            if (sender is Button button)
            {
                //  Left click to button
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    var red = Random.Shared.Next(0, 255);
                    var green = Random.Shared.Next(0, 255);
                    var blue = Random.Shared.Next(0, 255);

                    button.Background = new SolidColorBrush(Color.FromRgb((byte)red,(byte)green, (byte)blue));
                }

                //  Right click to button
                else if (e.RightButton == MouseButtonState.Pressed)
                {
                    AllElements.Children.Remove(button);
                    MessageBox.Show($"Content of button: {button.Content}\nColor of button: {button.Background.ToString()}", "Process of delete button");
                }
            }
        }
    }
}
