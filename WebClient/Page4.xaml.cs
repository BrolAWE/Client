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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string uri = @"https://intense-shelf-88498.herokuapp.com/edit?id=" + Id.Text+"&name=" + Name.Text + "&longitude=" + Longitude.Text + "&latitude=" + Latitude.Text + "&rate= " + Rate.Text + "&photo=" + Photo.Text;
            var client = new HttpClient();
            byte[] request = await client.GetByteArrayAsync(new Uri(uri));
        }
    }
}
