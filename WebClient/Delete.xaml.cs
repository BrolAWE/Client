using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }
        private async void Delete_Click(object sender, RoutedEventArgs e)
        {
            string uri = @"https://alexeyd.herokuapp.com/delete?id=" + Id.Text;
            var client = new HttpClient();
            byte[] request = await client.GetByteArrayAsync(new Uri(uri));
        }
    }
}
