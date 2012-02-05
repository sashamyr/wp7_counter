using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace counter
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor

        public static int value = 0;

        public MainPage()
        {
            InitializeComponent();
            BlockResult.Text = value.ToString();
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage.value = value + 1;
            BlockResult.Text = value.ToString();
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage.value = value - 1;
            BlockResult.Text = value.ToString();
        }

        private void BlockResult_Tap(object sender, GestureEventArgs e)
        {
            MainPage.value = 0;
            BlockResult.Text = value.ToString();
        }
    }
}