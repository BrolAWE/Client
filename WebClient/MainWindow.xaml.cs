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
using System.Net;
using System.Data;
using System.Net.Http;
using Newtonsoft.Json;
using WebSocketSharp;

namespace WebClient
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

        private void View_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = "View.xaml".ToUri();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = "Delete.xaml".ToUri();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = "Add.xaml".ToUri();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = "EditPass.xaml".ToUri();
        }

        private void MNK_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = "MNK.xaml".ToUri();
        }

        private void FTTM_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = "FTTM.xaml".ToUri();
        }
    }
}
