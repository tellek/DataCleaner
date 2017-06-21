using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace DataCleaner.Controls.Notifications
{
    public partial class Question : UserControl
    {
        public Question(string questionText, string yesOption = "Ok", string noOption = "Cancel")
        {
            InitializeComponent();
            textBlock.Text = questionText;
            OkButton.Content = yesOption;
            CancelButton.Content = noOption;

            //Remove if this is fixed up to be used.
            textBlock.Text = "The question notification should not be used. If it must be used, then it needs to be fixed first.";
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            ((Panel)this.Parent).Children.Remove(this);
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            ((Panel)this.Parent).Children.Remove(this);
        }
    }
}
