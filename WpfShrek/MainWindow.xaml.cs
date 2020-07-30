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
using WpfShrek.some_support;

namespace WpfShrek
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bload_Click(object sender, RoutedEventArgs e)
        {
            tinput.Text = Files.LoadText();
        }

        private void bsave_Click(object sender, RoutedEventArgs e)
        {
            Files.SaveText(toutput.Text);
        }

        private void bencrypt_Click(object sender, RoutedEventArgs e)
        {
            toutput.Text=Cryptograph.Encrypt(tinput.Text, tkey.Text);
        }

        private void bdecrypt_Click(object sender, RoutedEventArgs e)
        {
            toutput.Text = Cryptograph.Decrypt(tinput.Text, tkey.Text);
        }


    }
}
