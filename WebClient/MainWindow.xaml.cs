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

namespace WebClient
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    class Routes
    {
        public int id { get; set; }
        public string name { get; set; }
        public double longitude { get; set; }
        public double latitude { get; set; }
        public double rate { get; set; }
    }

    public partial class MainWindow : Window
    {
        public string uri = @"https://intense-shelf-88498.herokuapp.com/jsdb/";
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var client = new HttpClient();
            byte[] request = await client.GetByteArrayAsync(new Uri(uri));
            Portable.Text.Encoding encoding = Portable.Text.Encoding.GetEncoding(1251);
            var s = encoding.GetString(request, 0, request.Length);
            var routes = JsonConvert.DeserializeObject<Routes[]>(s);
            dataGrid1.ItemsSource = routes;
        }
    }
}
