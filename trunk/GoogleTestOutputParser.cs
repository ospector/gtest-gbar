using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Guitar
{
    delegate void TestComplete(string testName, string error);
    delegate void LineRead(string line, bool countOnly);



    class GoogleTestOutputParser
    {

        private string currentTestName;
        private static Regex TEST_START = new Regex(@"\[ RUN      ] ([\w/]+\.[\w/]+)");

        private TestComplete notifyTestComplete;
        private LineRead notifyLineRead;

        private string potentialErrorText;
        private int numTests = 0;
        private int checkNumTests = 0;
        private bool modeCountOnly;

        public GoogleTestOutputParser(TestComplete a, LineRead b)
        {
            notifyTestComplete = a;
            notifyLineRead = b;
        }

        private void parseLine(String parsedLine)
        {
            if (modeCountOnly)
            {
                if (parsedLine.StartsWith("  ") && parsedLine.Length != 2) numTests++;
            }
            else
            {
                if (TEST_START.IsMatch(parsedLine))
                {
                    currentTestName = TEST_START.Match(parsedLine).Groups[1].Value;
                    potentialErrorText = "";
                }
                else if (currentTestName != null)
                {
                    if (parsedLine.StartsWith("[       OK ] " + currentTestName))
                    {
                        notifyTestComplete(currentTestName, null);
                        currentTestName = null;
                    }
                    else if (parsedLine.StartsWith("[  FAILED  ] " + currentTestName))
                    {
                        notifyTestComplete(currentTestName, potentialErrorText);
                        currentTestName = null;
                    }
                    else if (!parsedLine.StartsWith("["))
                    {
                        int errorStringIndex = parsedLine.IndexOf(": error:");
                        if (errorStringIndex != -1)
                        {
                            int errorStringStartsAt = errorStringIndex + 8;
                            parsedLine = parsedLine.Remove(errorStringStartsAt, 1);
                            parsedLine = parsedLine.Insert(errorStringStartsAt, "\r\n");
                        }
                        potentialErrorText += parsedLine + "\r\n";
                    }
                }
            }

        }

        //int i = 0;
        private void parseInputStream(StreamReader input)
        {
            //i++; StreamWriter debugStream = new StreamWriter(@"C:\Users\Julian\Desktop\log" + i + ".txt");

            String line; 
            while ((line = input.ReadLine()) != null)
            {
                //debugStream.WriteLine(line);
                
                notifyLineRead(line, modeCountOnly);
                parseLine(line);
            }
            
            //debugStream.Close();
        }

        public int countTests(StreamReader input)
        {
            numTests = 0;
            modeCountOnly = true;
            parseInputStream(input);
            return numTests;
        }

        public void parseTests(StreamReader input)
        {
            modeCountOnly = false;
            parseInputStream(input);
        }
    }

}
