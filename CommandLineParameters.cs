using System;
using System.Collections.Generic;
using System.Text;

namespace Guitar
{
    public class CommandLineParameters
    {
        public string testFilePath = "";
        public int autoCloseTimeout = 0;
        public bool printHelp = false;
        public bool closeOnEsc = false;
        private List<String>switches;

        public CommandLineParameters(string[] args)
        {
            setDefaultSwitches();

            for (int i = 0; i < args.Length; i++)
            {
                takeAction(args, i);
            }

            if (args.Length == 0)
            {
                return;
            }
            if (args.Length == 1 && printHelp == false)
            {
                testFilePath = args[0];
                return;
            }
            

        }
        private void setDefaultSwitches()
        {
            switches = new List<String>();
            switches.Add("--gtest-exe");
            switches.Add("--close-timeout");
            switches.Add("--help");
            switches.Add("-h");
            switches.Add("--close-on-esc");
        }
        private void takeAction(string []value, int index){
            switch (switches.IndexOf(value[index]))
            {
                case 0:
                    testFilePath = value[index+1];
                    break;
                case 1:
                    autoCloseTimeout = Int32.Parse(value[index+1]);
                    break;
                case 2:
                case 3:
                    printHelp = true;
                    break;
                case 4:
                    closeOnEsc = true;
                    break;
                default:                    
                    break;

            }
        }
    }
}
