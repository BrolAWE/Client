using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Логика взаимодействия для View.xaml
    /// </summary>
    class Routes
    {
        public int id { get; set; }
        public string name { get; set; }
        public double longitude { get; set; }
        public double latitude { get; set; }
        public double rate { get; set; }
        public string photo { get; set; }
        public string url { get; set; }
    }
    public partial class View : Page
    {
        HttpClient client;
        public View()
        {
            InitializeComponent();
            client = new HttpClient();
        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string first="",second="", firstsearch = "", howfirstsearch = "", secondsearch = "", howsecondsearch = "", interval="", down="", up="";
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

            if (LowerFirst.IsChecked == true&&first!="")
            {
                first = "-"+first;
            }
            if (LowerSecond.IsChecked == true && second != "")
            {
                second = "-" + second;
            }

            if (FirstSearchName.IsChecked == true)
            {
                howfirstsearch = "name";
                firstsearch = FirstSearchBox.Text;
            }
            if (FirstSearchLatitude.IsChecked == true)
            {
                howfirstsearch = "latitude";
                firstsearch = FirstSearchBox.Text;
            }
            if (FirstSearchLongitude.IsChecked == true)
            {
                howfirstsearch = "longitude";
                firstsearch = FirstSearchBox.Text;
            }
            if (FirstSearchRate.IsChecked == true)
            {
                howfirstsearch = "rate";
                firstsearch = FirstSearchBox.Text;
            }
            if (FirstSearchPhoto.IsChecked == true)
            {
                howfirstsearch = "photo";
                firstsearch = FirstSearchBox.Text;
            }

            if (SecondSearchName.IsChecked == true && howfirstsearch != "")
            {
                howsecondsearch = "name";
                secondsearch = SecondSearchBox.Text;
            }
            if (SecondSearchLatitude.IsChecked == true && howfirstsearch != "")
            {
                howsecondsearch = "latitude";
                secondsearch = SecondSearchBox.Text;
            }
            if (SecondSearchLongitude.IsChecked == true && howfirstsearch != "")
            {
                howsecondsearch = "longitude";
                secondsearch = SecondSearchBox.Text;
            }
            if (SecondSearchRate.IsChecked == true && howfirstsearch != "")
            {
                howsecondsearch = "rate";
                secondsearch = SecondSearchBox.Text;
            }
            if (SecondSearchPhoto.IsChecked == true && howfirstsearch != "")
            {
                howsecondsearch = "photo";
                secondsearch = SecondSearchBox.Text;
            }
            if (IntervalRate.IsChecked == true)
            {
                interval = "rate";
                down = Down.Text;
                up = Up.Text;
            }
            if (IntervalLongitude.IsChecked == true)
            {
                interval = "longitude";
                down = Down.Text;
                up = Up.Text;
            }
            if (IntervalLatitude.IsChecked == true)
            {
                interval = "latitude";
                down = Down.Text;
                up = Up.Text;
            }

            string uri = @"https://alexeyd.herokuapp.com/jsdb?first=" + first + "&second=" + second + "&firstsearch=" + firstsearch + "&howfirstsearch=" + howfirstsearch + "&secondsearch=" + secondsearch + "&howsecondsearch=" + howsecondsearch + "&interval=" + interval + "&down=" + down + "&up=" + up;
            byte[] request = await client.GetByteArrayAsync(new Uri(uri));
            Portable.Text.Encoding encoding = Portable.Text.Encoding.GetEncoding(1251);
            var s = encoding.GetString(request, 0, request.Length);
            var routes = JsonConvert.DeserializeObject<Routes[]>(s);
            DGView.ItemsSource = routes;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void FirstSearchBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
        }

        private void FirstSearchBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
        }

        private void FirstSearchBox_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            BK.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
        }
    }
}
