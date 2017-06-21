using System;
using System.Windows.Controls;

namespace DataCleaner.Controls.Sources
{
    /// <summary>
    /// Interaction logic for DelimitedFile.xaml
    /// </summary>
    public partial class DelimitedFile : UserControl
    {
        // This is where the user specifies where the data to be processed is coming from.
        // Multiple data sources can be set as long as they all have the same header structure.
        // This is the only place where you can manually add new user controls(data sources).

        public DelimitedFile()
        {
            InitializeComponent();
        }
    }
}
