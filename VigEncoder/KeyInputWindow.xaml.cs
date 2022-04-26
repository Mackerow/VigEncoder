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

namespace VigEncoder
{
    /// <summary>
    /// Логика взаимодействия для KeyInputWindow.xaml
    /// </summary>
    public partial class KeyInputWindow : Window
    {
        public KeyInputWindow()
        {
            InitializeComponent();
        }

        private void KeyInput_Click(object sender, RoutedEventArgs e)
        {
            string myvar = KeyInput.Text;
            MainWindow.KeyInput = myvar;
            Close();
        }
    }
}
