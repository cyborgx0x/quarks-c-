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
using System.Diagnostics;

namespace quarks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox.Text;
            MessageBox.Show("Chúng ta bắt đầu quét: " + input);
            ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe");
            startInfo.Arguments = $"/C nuclei -u {input}";
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            // startInfo.RedirectStandardOutput = true;
            // startInfo.RedirectStandardError = true;
            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();
            // string output = process.StandardOutput.ReadToEnd();
            // string error = process.StandardError.ReadToEnd();
            // process.WaitForExit();

            // you can now use the output and error variables to access the output of the command
            // Debug.WriteLine("Output: " + output);
            //Debug.WriteLine("Error: " + error);
        }
    }
}
