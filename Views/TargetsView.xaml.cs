using System.Windows;
using System.Windows.Controls;
using quarks.ViewModels;

namespace quarks.Views
{
    public partial class TargetsView : UserControl
    {
        public TargetsView()
        {
            InitializeComponent();
            // Assuming you are setting DataContext outside this UserControl,
            // for example, in MainWindow or using a Dependency Injection container
        }

        private void AddTarget_Click(object sender, RoutedEventArgs e)
        {
            // Implement logic to open the CreateTargetView
        }

        private void EditTarget_Click(object sender, RoutedEventArgs e)
        {
            // Implement logic to open the EditTargetView with the selected target
        }

        private void DeleteTarget_Click(object sender, RoutedEventArgs e)
        {
            // Implement logic to delete the selected target, with confirmation
        }
    }
}
