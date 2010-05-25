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
        private bool modeCountOnly;

        public GoogleTestOutputParser(TestComplete a, LineRead b)
        {
            notifyTestComplete = a;
            notifyLineRead = b;
        }

        private void parseLine(String l)
        {
            if (modeCountOnly)
            {
                if (l.StartsWith("  ")) numTests++;
            }
            else
            {
                if (TEST_START.IsMatch(l))
                {
                    currentTestName = TEST_START.Match(l).Groups[1].Value;
                    potentialErrorText = "";
                }
                else if (currentTestName != null)
                {
                    if (l.StartsWith("[       OK ] " + currentTestName))
                    {
                        notifyTestComplete(currentTestName, null);
                        currentTestName = null;
                    }
                    else if (l.StartsWith("[  FAILED  ] " + currentTestName))
                    {
                        notifyTestComplete(currentTestName, potentialErrorText);
                        currentTestName = null;
                    }
                    else if (!l.StartsWith("["))
                    {
                        potentialErrorText += l + "\r\n";
                    }
                }
            }

        }

        private void parseInputStream(StreamReader input)
        {
            String line;
            while ((line = input.ReadLine()) != null)
            {
                notifyLineRead(line, modeCountOnly);
                parseLine(line);
            }
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
