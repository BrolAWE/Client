using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    class Routes
    {
        public int id { get; set; }
        public string name { get; set; }
        public double longitude { get; set; }
        public double latitude { get; set; }
        public double rate { get; set; }
        public string photo { get; set; }
    }
    public partial class Page1 : Page
    {

        public Page1()
        {
            InitializeComponent();
        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string first="",second="",how="";
            if (FirstName.IsChecked == true) {
                first = "name";
                if (SecondName.IsChecked == true)
                {
                    second = "name";
                }
                if (SecondLatitude.IsChecked == true)
                {
                    second = "latitude";
                }
                if (SecondLongitude.IsChecked == true)
                {
                    second = "longitude";
                }
                if (SecondRate.IsChecked == true)
                {
                    second = "rate";
                }
                if (SecondPhoto.IsChecked == true)
                {
                    second = "photo";
                }
            }
            if (FirstLatitude.IsChecked == true) {
                first = "latitude";
                if (SecondName.IsChecked == true)
                {
                    second = "name";
                }
                if (SecondLatitude.IsChecked == true)
                {
                    second = "latitude";
                }
                if (SecondLongitude.IsChecked == true)
                {
                    second = "longitude";
                }
                if (SecondRate.IsChecked == true)
                {
                    second = "rate";
                }
                if (SecondPhoto.IsChecked == true)
                {
                    second = "photo";
                }
            }
            if (FirstLongitude.IsChecked == true) {
                first = "longitude";
                if (SecondName.IsChecked == true)
                {
                    second = "name";
                }
                if (SecondLatitude.IsChecked == true)
                {
                    second = "latitude";
                }
                if (SecondLongitude.IsChecked == true)
                {
                    second = "longitude";
                }
                if (SecondRate.IsChecked == true)
                {
                    second = "rate";
                }
                if (SecondPhoto.IsChecked == true)
                {
                    second = "photo";
                }
            }
            if (FirstRate.IsChecked == true) {
                first = "rate";
                if (SecondName.IsChecked == true)
                {
                    second = "name";
                }
                if (SecondLatitude.IsChecked == true)
                {
                    second = "latitude";
                }
                if (SecondLongitude.IsChecked == true)
                {
                    second = "longitude";
                }
                if (SecondRate.IsChecked == true)
                {
                    second = "rate";
                }
                if (SecondPhoto.IsChecked == true)
                {
                    second = "photo";
                }
            }
            if (FirstPhoto.IsChecked == true) {
                first = "photo";
                if (SecondName.IsChecked == true)
                {
                    second = "name";
                }
                if (SecondLatitude.IsChecked == true)
                {
                    second = "latitude";
                }
                if (SecondLongitude.IsChecked == true)
                {
                    second = "longitude";
                }
                if (SecondRate.IsChecked == true)
                {
                    second = "rate";
                }
                if (SecondPhoto.IsChecked == true)
                {
                    second = "photo";
                }
            }
            if (Lower.IsChecked == true&&first!="")
            {
                first = "-"+first;
            }
            string uri = @"https://intense-shelf-88498.herokuapp.com/jsdb?first=" + first + "&second=" + second;
            var client = new HttpClient();
            byte[] request = await client.GetByteArrayAsync(new Uri(uri));
            Portable.Text.Encoding encoding = Portable.Text.Encoding.GetEncoding(1251);
            var s = encoding.GetString(request, 0, request.Length);
            var routes = JsonConvert.DeserializeObject<Routes[]>(s);
            dataGrid1.ItemsSource = routes;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
