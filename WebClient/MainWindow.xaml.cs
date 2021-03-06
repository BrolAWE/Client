﻿using System;
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
            frame.Source = "InfSyst/View.xaml".ToUri();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = "InfSyst/Delete.xaml".ToUri();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = "InfSyst/Add.xaml".ToUri();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = "InfSyst/EditPass.xaml".ToUri();
        }

        private void MNK_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = "MNK.xaml".ToUri();
        }

        private void FTTM_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = "FTTM.xaml".ToUri();
        }

        private void Lexema_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = "Lexema.xaml".ToUri();
        }

        private void Arithmetic_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = "Arithmetic/Arithmetic.xaml".ToUri();
        }

        private void Usl1_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = "MPRO/Usl1.xaml".ToUri();
        }

        private void Res1_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = "MPRO/Res1.xaml".ToUri();
        }

        private void Usl2_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = "MPRO/Usl2.xaml".ToUri();
        }

        private void Res2_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = "MPRO/Res2.xaml".ToUri();
        }

        private void Usl3_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = "MPRO/Usl3.xaml".ToUri();
        }

        private void Res3_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = "MPRO/Res3.xaml".ToUri();
        }

        private void Usl4_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = "MPRO/Usl4.xaml".ToUri();
        }

        private void Res4_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = "MPRO/Res4.xaml".ToUri();
        }

        private void Usl5_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = "MPRO/Usl5.xaml".ToUri();
        }

        private void Res5_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = "MPRO/Res5.xaml".ToUri();
        }
    }
}
