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

namespace WebClient
{
    /// <summary>
    /// Логика взаимодействия для Edit.xaml
    /// </summary>
    public partial class Edit : Page
    {
        public Edit()
        {
            InitializeComponent();
        }

        private async void Edit_Click(object sender, RoutedEventArgs e)
        {
            string uri = @"https://alexeyd.herokuapp.com/edit?id=" + Id.Text+"&name=" + Name.Text + "&longitude=" + Longitude.Text + "&latitude=" + Latitude.Text + "&rate= " + Rate.Text + "&photo=" + Photo.Text;
            var client = new HttpClient();
            byte[] request = await client.GetByteArrayAsync(new Uri(uri));
        }
    }
}
