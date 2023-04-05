using System.Diagnostics;

namespace MaintainanceKit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_proxy_on_Click(object sender, EventArgs e)
        {
            string batchFilePath = @"Y:\!Henrique\_tkit\S_Proxy_BR_on.bat";
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe"; // Command prompt executable
            process.StartInfo.Arguments = "/c " + batchFilePath; // Command line arguments to run the batch file
            process.StartInfo.UseShellExecute = false; // Don't use the system shell to start the process
            process.StartInfo.RedirectStandardOutput = true; // Redirect the standard output to read the output of the batch file
                                                             // Start the process
            process.Start();

            // Read the output of the batch file
            string output = process.StandardOutput.ReadToEnd();

            // Wait for the process to exit
            process.WaitForExit();

            // Display the output of the batch file
            Console.WriteLine(output);
        }

        private void btn_proxy_off_Click(object sender, EventArgs e)
        {
            string batchFilePath = @"Y:\!Henrique\_tkit\S_Proxy_BR_off.bat";
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe"; // Command prompt executable
            process.StartInfo.Arguments = "/c " + batchFilePath; // Command line arguments to run the batch file
            process.StartInfo.UseShellExecute = false; // Don't use the system shell to start the process
            process.StartInfo.RedirectStandardOutput = true; // Redirect the standard output to read the output of the batch file
                                                             // Start the process
            process.Start();

            // Read the output of the batch file
            string output = process.StandardOutput.ReadToEnd();

            // Wait for the process to exit
            process.WaitForExit();

            // Display the output of the batch file
            Console.WriteLine(output);
        }
    }
}