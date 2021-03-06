﻿using System;
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

namespace WebClient.MPRO
{
    /// <summary>
    /// Логика взаимодействия для Res4.xaml
    /// </summary>
    public partial class Res4 : Page
    {
        public Res4()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string uri = @"https://alexeyd.herokuapp.com/mpro4";
            var client = new HttpClient();
            byte[] request = await client.GetByteArrayAsync(new Uri(uri));
            Portable.Text.Encoding encoding = Portable.Text.Encoding.GetEncoding(1251);
            var s = encoding.GetString(request, 0, request.Length);
            otv.Content = s;
        }
    }
}
