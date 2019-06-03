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

namespace WebClient
{
    /// <summary>
    /// Логика взаимодействия для Arithmetic.xaml
    /// </summary>
    public partial class Arithmetic : Page
    {
        ArithmeticC LA = new ArithmeticC();
        public Arithmetic()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!LA.ConvOps(textBox1.Text, textBox2.Text)) //"954976", "64025""954", "64"
                MessageBox.Show("Num Error");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LA.LAdd();
            lblResAdd.Content = LA.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            LA.LSub();
            lblResSub.Content = LA.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            LA.LMult();
            lblResMult.Content = LA.Show();
        }
    }
}
