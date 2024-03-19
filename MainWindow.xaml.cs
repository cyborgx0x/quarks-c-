using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace quarks
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox.Text;
            MessageBox.Show("We start scanning: " + input);
            // Assume the scanning process is the same for all targets
            StartScanningProcess(input);
        }

        private void TargetsButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateMainContent("Targets management view");
        }

        private void TemplatesButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateMainContent("Templates management view");
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateMainContent("Settings view");
        }

        private void UpdateMainContent(string content)
        {
            // Here you would update the main content area, for example by changing a TextBlock or loading a new UserControl
            MainContentTextBlock.Text = content; // Assume you have a TextBlock with this name in your main area
        }

        private void StartScanningProcess(string input)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe")
            {
                Arguments = $"/C nuclei -u {input}",
                CreateNoWindow = false,
                UseShellExecute = false
                // You can redirect output and error if needed
            };
            Process process = new Process { StartInfo = startInfo };
            process.Start();
            // You can handle the output and errors if redirection is enabled
        }
    }
}
