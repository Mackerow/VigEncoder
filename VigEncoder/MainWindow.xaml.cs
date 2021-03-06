using Microsoft.Win32;
using System;
using System.IO;
using System.Text;
using System.Windows;

namespace VigEncoder
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static OpenFileDialog openfile;
        public static bool? browsefile;
        public static StreamReader sr;
        public static String KeyInput;
        public static string line;
        public static string result;
        public MainWindow()
        {
            InitializeComponent();
        }
        private async void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            openfile = new OpenFileDialog
            {
                DefaultExt = ".txt",
                Filter = "(.txt)|*.txt"
            };
            browsefile = openfile.ShowDialog();
            txtFileLine.Text = openfile.FileName;
            if (txtFileLine.Text == "")
            {
                MessageBox.Show("Вы не выбрали файл!");
            }
            else
            {
                using (StreamReader reader = new StreamReader(txtFileLine.Text, Encoding.UTF8))
                {
                    line = await reader.ReadToEndAsync();
                }
                txtFileLine.Text = line;
            }
        }
        private void WindowKeyInput_Click(object sender, RoutedEventArgs e)
        {
            var window = new KeyInputWindow { Owner = this };
            window.ShowDialog();
            KeyOutput.Text = KeyInput;
        }
        private void Encode_Click(object sender, RoutedEventArgs e)
        {
            if (txtFileLine.Text == null)
            {
                MessageBox.Show("Строчка пуста! Нечего шифровать!");
                return;
            }
            if (KeyInput == null)
            {
                MessageBox.Show("Ключ пустой! Нечем шифровать!");
                return;
            }
            result = (VigenerCode.Encode(txtFileLine.Text, KeyInput));
            OutPutCipher.Text = result;
        }

        private void SaveCoding_Click(object sender, RoutedEventArgs e)
        {
            if (result == null)
            {
                MessageBox.Show("Результата нет! Нечего записывать!");
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == true)
            {
                StreamWriter file = new StreamWriter(saveFileDialog.FileName, true, Encoding.UTF8);
                file.WriteLine(result);
                file.Close();
            }
            MessageBox.Show("Результат сохранен!");
        }

        private void Decode_Click(object sender, RoutedEventArgs e)
        {
            if (txtFileLine.Text == null)
            {
                MessageBox.Show("Строчка пуста! Нечего дешифровать!");
                return;
            }
            if (KeyInput == null)
            {
                MessageBox.Show("Ключ пустой! Нечем дешифровать!");
                return;
            }
            result = (VigenerCode.Decode(txtFileLine.Text, KeyInput));
            OutPutCipher.Text = result;
        }
    }
}
