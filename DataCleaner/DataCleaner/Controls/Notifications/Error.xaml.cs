using System;
using System.Windows;
using System.Windows.Controls;

namespace DataCleaner.Controls.Notifications
{
    public partial class Error : UserControl
    {
        public Error(string errorText)
        {
            InitializeComponent();
            textBlock.Text = errorText;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ((Panel)this.Parent).Children.Remove(this);
        }
    }
}
