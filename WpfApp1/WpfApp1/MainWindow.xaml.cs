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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int wynik = 0;

            wynik = Int32.Parse(textBox.Text) + Int32.Parse(textBox1.Text);

            textBox2.Text= wynik.ToString();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int wynik = 0;

            wynik = Int32.Parse(textBox.Text) - Int32.Parse(textBox1.Text);

            textBox2.Text = wynik.ToString();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int wynik = 0;

            wynik = Int32.Parse(textBox.Text) * Int32.Parse(textBox1.Text);

            textBox2.Text = wynik.ToString();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int wynik = 0;

            wynik = Int32.Parse(textBox.Text) / Int32.Parse(textBox1.Text);

            textBox2.Text = wynik.ToString();
        }
        private void hello_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Byłam tu ( ･ω･)ﾉ");
        }
    }
}
