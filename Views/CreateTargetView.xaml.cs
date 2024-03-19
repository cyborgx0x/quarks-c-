using System.Windows; // This is needed for RoutedEventArgs and other WPF base elements
using System.Windows.Controls; // This is specifically needed for UserControl
namespace quarks.Views
{
    public partial class CreateTargetView : UserControl
    {
        public CreateTargetView()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Implementation
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            // Implementation
        }
    }
}
