using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Guitar
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CommandLineParameters parameters = new CommandLineParameters(args);
            if (parameters.printHelp)
            {
                StringBuilder message = new StringBuilder();
                message.AppendLine("Welcome to Guitar!");
                message.AppendLine("Guitar is a grafic user interface for the Google Testing Framework.");
                message.AppendLine("Usage: guitar [gtest_file_name | options]");
                message.AppendLine("  options: ");
                message.AppendLine("    --help, -h                     displays this message");
                message.AppendLine("    --close-timeout timeout        The program closes after 'timeout' seconds");
                message.AppendLine("    --gtest-exe gtest_file_name    Filename of the googletest executable." );
                message.AppendLine("                                   The path can be both relative or absolute.");
                Console.WriteLine(message);
                //TODO : make the work!!! Doesn't displays in the console.
                return;
            }
            Application.Run(new GuitarForm(parameters));


        }
    }
}

