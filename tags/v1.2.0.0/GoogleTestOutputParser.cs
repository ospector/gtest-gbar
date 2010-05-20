using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Guitar
{
    delegate void TestComplete(string error);
    delegate void LineRead(string line,bool countOnly);

    class GoogleTestOutputParser
    {

        private TestComplete notifyTestComplete;
        private LineRead notifyLineRead;
        
        private string potentialErrorText;
        private int numTests=0;
        private bool modeCountOnly;
        
        public GoogleTestOutputParser(TestComplete a,LineRead b)
        {
            notifyTestComplete = a;
            notifyLineRead = b;
        }

        private void parseLine(String l) {
            if (modeCountOnly)
            {
                if (l.StartsWith("  ")) numTests++;
            }
            else
            {
                if (l.StartsWith("[       OK ]"))
                {
                    notifyTestComplete(null);
                    potentialErrorText = "";
                }
                else if (l.StartsWith("[  FAILED  ]") && l.EndsWith(")"))
                {
                    notifyTestComplete(potentialErrorText);
                    potentialErrorText = "";
                }
                else if (!l.StartsWith("["))
                {
                    potentialErrorText += l + "\r\n";
                }
            }

    }

        private void parseInputStream(StreamReader input)
        {
            String line;
            while ((line = input.ReadLine()) != null)
            {
                notifyLineRead(line,modeCountOnly);
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
