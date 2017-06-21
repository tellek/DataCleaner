using System;
using System.Windows;
using System.Windows.Controls;

namespace DataCleaner.Controls.Notifications
{
    public partial class Warning : UserControl
    {
        public Warning(string warningText)
        {
            InitializeComponent();
            textBlock.Text = warningText;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ((Panel)this.Parent).Children.Remove(this);
        }
    }
}
