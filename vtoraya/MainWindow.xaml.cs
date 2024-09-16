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

namespace vtoraya
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

        private void xd_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_NewPage(object sender, RoutedEventArgs e)
        {
            if (a.Text.Any(Char.IsLetter) || b.Text.Any(Char.IsLetter) || c.Text.Any(Char.IsLetter))
            {
                double aa = int.Parse(a.Text);
                double bb = int.Parse(b.Text);
                double cc = int.Parse(c.Text);
                double p = 0;
                p = (aa + bb + cc) / 2;
                double S = 0;
                S = Math.Sqrt(p * (p - aa) * (p - bb) * (p - cc));
                string SS = Convert.ToString(S);
                xd.Text = SS;
            }
            else
            {
                xd.Text = "qweqewqweqwe";
            }
        }
    }
}
