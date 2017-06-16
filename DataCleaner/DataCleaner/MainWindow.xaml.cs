using System;
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
using DataCleaner.Controls.Notifications;

namespace DataCleaner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MenuSelectionMarkerVisibility(selected_Home);
        }

        protected void MenuSelectionMarkerVisibility(Rectangle specificSelection)
        {
            selected_Home.Visibility = Visibility.Hidden;
            selected_Source.Visibility = Visibility.Hidden;
            selected_Process.Visibility = Visibility.Hidden;
            selected_Review.Visibility = Visibility.Hidden;
            selected_Change.Visibility = Visibility.Hidden;
            selected_Finalize.Visibility = Visibility.Hidden;
            selected_Settings.Visibility = Visibility.Hidden;
            specificSelection.Visibility = Visibility.Visible;
        }

        #region Menu Button Events
        private void button_Settings_Click(object sender, RoutedEventArgs e)
        {
            if(selected_Settings.Visibility == Visibility.Hidden) MenuSelectionMarkerVisibility(selected_Settings);
        }

        private void button_Finalize_Click(object sender, RoutedEventArgs e)
        {
            grid_NotificationArea.Children.Add(new Alert());
            if (selected_Finalize.Visibility == Visibility.Hidden) MenuSelectionMarkerVisibility(selected_Finalize);
        }

        private void button_Change_Click(object sender, RoutedEventArgs e)
        {
            if (selected_Change.Visibility == Visibility.Hidden) MenuSelectionMarkerVisibility(selected_Change);
        }

        private void button_Review_Click(object sender, RoutedEventArgs e)
        {
            if (selected_Review.Visibility == Visibility.Hidden) MenuSelectionMarkerVisibility(selected_Review);
        }

        private void button_Process_Click(object sender, RoutedEventArgs e)
        {
            if (selected_Process.Visibility == Visibility.Hidden) MenuSelectionMarkerVisibility(selected_Process);
        }

        private void button_Source_Click(object sender, RoutedEventArgs e)
        {
            if (selected_Source.Visibility == Visibility.Hidden) MenuSelectionMarkerVisibility(selected_Source);
        }

        private void button_Home_Click(object sender, RoutedEventArgs e)
        {
            if (selected_Home.Visibility == Visibility.Hidden) MenuSelectionMarkerVisibility(selected_Home);
        }

        private void button_Settings_MouseEnter(object sender, MouseEventArgs e)
        {
            if (selected_Settings.Visibility == Visibility.Hidden) button_Settings.Opacity = 0.08;
        }

        private void button_Settings_MouseLeave(object sender, MouseEventArgs e)
        {
            if (button_Settings.Opacity > 0.00) button_Settings.Opacity = 0.00;
        }

        private void button_Finalize_MouseEnter(object sender, MouseEventArgs e)
        {
            if (selected_Finalize.Visibility == Visibility.Hidden) button_Finalize.Opacity = 0.08;
        }

        private void button_Finalize_MouseLeave(object sender, MouseEventArgs e)
        {
            if (button_Finalize.Opacity > 0.00) button_Finalize.Opacity = 0.00;
        }

        private void button_Change_MouseEnter(object sender, MouseEventArgs e)
        {
            if (selected_Change.Visibility == Visibility.Hidden) button_Change.Opacity = 0.08;
        }

        private void button_Change_MouseLeave(object sender, MouseEventArgs e)
        {
            if (button_Change.Opacity > 0.00) button_Change.Opacity = 0.00;
        }

        private void button_Review_MouseEnter(object sender, MouseEventArgs e)
        {
            if (selected_Review.Visibility == Visibility.Hidden) button_Review.Opacity = 0.08;
        }

        private void button_Review_MouseLeave(object sender, MouseEventArgs e)
        {
            if (button_Review.Opacity > 0.00) button_Review.Opacity = 0.00;
        }

        private void button_Process_MouseEnter(object sender, MouseEventArgs e)
        {
            if (selected_Process.Visibility == Visibility.Hidden) button_Process.Opacity = 0.08;
        }

        private void button_Process_MouseLeave(object sender, MouseEventArgs e)
        {
            if (button_Process.Opacity > 0.00) button_Process.Opacity = 0.00;
        }

        private void button_Source_MouseEnter(object sender, MouseEventArgs e)
        {
            if (selected_Source.Visibility == Visibility.Hidden) button_Source.Opacity = 0.08;
        }

        private void button_Source_MouseLeave(object sender, MouseEventArgs e)
        {
            if (button_Source.Opacity > 0.00) button_Source.Opacity = 0.00;
        }

        private void button_Home_MouseEnter(object sender, MouseEventArgs e)
        {
            if (selected_Home.Visibility == Visibility.Hidden) button_Home.Opacity = 0.08;
        }

        private void button_Home_MouseLeave(object sender, MouseEventArgs e)
        {
            if (button_Home.Opacity > 0.00) button_Home.Opacity = 0.00;
        }
        #endregion

    }
}
