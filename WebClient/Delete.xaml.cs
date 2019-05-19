using System;
using System.Net.Http;
using System.Windows;
using System.Windows.Controls;

namespace WebClient
{
    /// <summary>
    /// Логика взаимодействия для Delete.xaml
    /// </summary>
    public partial class Delete : Page
    {
        public Delete()
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
