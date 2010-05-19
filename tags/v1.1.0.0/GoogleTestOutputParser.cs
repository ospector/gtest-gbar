using System;
using System.Collections.Generic;
using System.Text;

namespace Guitar
{
    delegate void RegisterNumTests(int n);
    delegate void TestComplete(string error);

    class GoogleTestOutputParser
    {

        private RegisterNumTests setNumTests;
        private TestComplete notifyTestComplete;

        private string potentialErrorText;


        public GoogleTestOutputParser(RegisterNumTests a, TestComplete b)
        {
            setNumTests = a;
            notifyTestComplete = b;
        }

        public void submitLine(String l) {
            if (l.StartsWith("[==========] Running"))
            {
                string num = l.Substring(21, l.IndexOf(' ', 21) - 21);
                int numTests=Int32.Parse(num);
                setNumTests(numTests);
        } else if(l.StartsWith("[       OK ]")) {
            notifyTestComplete(null);
            potentialErrorText = "";
        } else if(l.StartsWith("[  FAILED  ]") && l.EndsWith(")")) {
            notifyTestComplete(potentialErrorText);
            potentialErrorText = "";
        }
            else if (!l.StartsWith("["))
            {
                potentialErrorText += l + "\r\n";
            }

    }
    }

}
