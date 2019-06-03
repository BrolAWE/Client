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
using WebSocketSharp;

namespace WebClient
{
    /// <summary>
    /// Логика взаимодействия для EditPass.xaml
    /// </summary>
    public partial class EditPass : Page
    {
        public EditPass()
        {
            InitializeComponent();
        }

        private async void Edit_Click(object sender, RoutedEventArgs e)
        {
            var mw = Application.Current.Windows
            .Cast<Window>()
            .FirstOrDefault(window => window is MainWindow) as MainWindow;
            string uri = @"https://alexeyd.herokuapp.com/inbase?pk=" + Id.Text;
            var client = new HttpClient();
            byte[] request = await client.GetByteArrayAsync(new Uri(uri));
            Portable.Text.Encoding encoding = Portable.Text.Encoding.GetEncoding(1251);
            var s = encoding.GetString(request, 0, request.Length);
            if (s == "OK")
            {
                mw.frame.Source = "InfSyst/Edit.xaml".ToUri();
            }
        }
    }
}
