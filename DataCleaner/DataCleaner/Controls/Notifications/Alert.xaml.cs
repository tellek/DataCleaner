﻿using System;
using System.Windows;
using System.Windows.Controls;

namespace DataCleaner.Controls.Notifications
{
    public partial class Alert : UserControl
    {
        public Alert(string alertText)
        {
            InitializeComponent();
            textBlock.Text = alertText;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ((Panel)this.Parent).Children.Remove(this);
        }
    }
}
