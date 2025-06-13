using System.Diagnostics;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RunExternalExe()
        {
            // Set the path to the executable
            string executablePath = @"EasterHunt.exe";

            // Create a ProcessStartInfo object
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = executablePath;
            startInfo.UseShellExecute = false; // Required for some scenarios
            startInfo.CreateNoWindow = true;  // Hide the command prompt window
            startInfo.WorkingDirectory = Path.GetDirectoryName(executablePath); // Set working directory

            // Start the process
            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            RunExternalExe();
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
