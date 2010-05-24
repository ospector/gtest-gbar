using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;
using System.Text.RegularExpressions;
using System.IO;

namespace Guitar
{
    public partial class GuitarForm : Form
    {
        List<string> Failures=new List<string>();
        private bool inWindows;
        private int maxHistory = 5;

        public GuitarForm()
        {
            inWindows = (System.Environment.OSVersion.Platform != System.PlatformID.Unix && System.Environment.OSVersion.Platform != System.PlatformID.MacOSX); 
            InitializeComponent();
        }

        private string buildArgs(bool onlyListTests)
        {
            StringBuilder cl = new StringBuilder();
            cl.Append(clParams.Text);
            if (onlyListTests) cl.Append("--gtest_list_tests ");
            if (shouldShuffle.Checked) cl.Append(' ').Append("--gtest_shuffle");
            if (shouldRunDisabled.Checked) cl.Append(' ').Append("--gtest_also_run_disabled_tests");
            if (filter.Text.Trim().Length > 0)
            {
                cl.Append(" --gtest_filter=").Append(filter.Text.Trim());
            }
            return cl.ToString();
        }

        private StreamReader runGtest(bool onlyListTests)
        {
            Process gtestApp = new Process();
            gtestApp.StartInfo.FileName = exeFilename.Text;
            gtestApp.StartInfo.Arguments = buildArgs(onlyListTests);
            gtestApp.StartInfo.UseShellExecute = false;
            gtestApp.StartInfo.RedirectStandardOutput = true;
            gtestApp.StartInfo.CreateNoWindow = (onlyListTests||(!onlyListTests && hideConsole.Checked));
            gtestApp.Start();
            return gtestApp.StandardOutput;
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            saveSettings();
			cls();

            GoogleTestOutputParser parser = new GoogleTestOutputParser(this.advanceProgressBar,this.lineRead);

			bool monoException=false;
            try {
				calibrateProgressBar(parser.countTests(runGtest(true)));
                parser.parseTests(runGtest(false));
			} catch (System.ObjectDisposedException ode) {
				monoException=true;
			}
			if (monoException) {
				cls();
				errorScreen.Text="Please Retry, Failure during run due to StreamReader close\n(This is a known issue in Mono on Ubuntu.)";
			} else {
				int disabled=(progressBar.Maximum-progressBar.Value);
                lineLabel.Text = "Done "+progressBar.Value+" of "+progressBar.Maximum+(disabled==0?". ":". "+disabled+" are disabled.");
                if (Failures.Count==0) errorScreen.Text = "All is well.";
			}
			goBtn.Enabled = canRun();
        }

        private void cls()
        {
            progressBar.Value = 0;
            failureListBox.Items.Clear();
            errorScreen.Text = "";
            errorScreen.Refresh();
        }

        private string manageHistoryCombo(ComboBox cb)
        {
            // Is this an old item selection or a new item
            string selText = cb.Text;
            Boolean isNew = (!selText.Equals((string)(cb.SelectedValue)));

            if (isNew || cb.SelectedIndex > 0)
            {
                // remove older reference to same file
				try {
                   if (cb.SelectedIndex >= 0) cb.Items.Remove(selText);
				} catch (Exception e) {
					// silently ignore this inconsistency
				}

                // add new file as highest item
                cb.Items.Insert(0, selText);
                cb.SelectedIndex = 0;
            }

            // Return setting string, limited to history length.
            StringBuilder builder = new StringBuilder();
            int i = 0;
            foreach (Object o in cb.Items)
            {
                string t = ((string)o).Trim();
                if (t.Length > 0)
                {
                    if (i > 0) builder.Append("|");
                    builder.Append(t);
                    i++;
                    if (i > maxHistory) break;
                }
            }

            return builder.ToString();

        }

        private void saveSettings()
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings["gtest"].Value = manageHistoryCombo(exeFilename);
            config.AppSettings.Settings["gtest-params"].Value = manageHistoryCombo(clParams);
            config.AppSettings.Settings["gtest-filters"].Value = manageHistoryCombo(filter);
            config.Save(ConfigurationSaveMode.Modified);
        }

        private void calibrateProgressBar(int n)
        {
            Failures.Clear();
            numTestsLabel.Text=""+n;
            numFailuresLabel.Text="0";
            failureListBox.Items.Clear();
            
            progressBar.Value = 0;
            progressBar.Minimum = 0;
            progressBar.Maximum = n;
            progressBar.ProgressBarColor = Color.Green;
			
			numTestsLabel.Refresh();
			numFailuresLabel.Refresh();
        }

        private void lineRead(string line,bool countStage)
        {
            if (countStage)
            {
                lineLabel.Text = "Counting tests..." + line;
            }
            else
            {
                lineLabel.Text = line;
            }
            lineLabel.Refresh();
        }

        private void advanceProgressBar(string testName,string error)
        {
            if (error!=null)
            {
                progressBar.ProgressBarColor = Color.Red;
                Failures.Add(error);
                numFailuresLabel.Text = "" + Failures.Count;
                failureListBox.Items.Add(testName);
                failureListBox.SelectedIndex = 0;
                failureListBox.Refresh();
            }

            progressBar.Value++;
            progressBar.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult r=openFileDialog1.ShowDialog();
            if (DialogResult.OK == r)
            {
                exeFilename.Text = openFileDialog1.FileName;
            }
        }

        private void exeFilename_TextChanged(object sender, EventArgs e)
        {
            goBtn.Enabled = canRun();
        }

        private bool canRun()
        {
            bool ret=System.IO.File.Exists(exeFilename.Text);
            
            if (inWindows) {
                ret=ret && (exeFilename.Text.TrimEnd().EndsWith("exe") || exeFilename.Text.TrimEnd().EndsWith("bat"));
            }
            return ret;
            
        }

        private void loadCombo(ComboBox cb,string vals)
        {
            if (vals.Trim().Length > 0)
            {
                string[] arr = vals.Split('|');
                foreach (string s in arr)
                {
                    cb.Items.Add(s);
                }
                cb.SelectedIndex = 0;
            }
        }

        private void GuitarForm_Load(object sender, EventArgs e)
        {
            maxHistory=int.Parse(System.Configuration.ConfigurationManager.AppSettings["maxHistory"]);
            loadCombo(exeFilename,System.Configuration.ConfigurationManager.AppSettings["gtest"]);
            loadCombo(clParams, System.Configuration.ConfigurationManager.AppSettings["gtest-params"]);
            loadCombo(filter, System.Configuration.ConfigurationManager.AppSettings["gtest-filters"]);
            goBtn.Enabled = canRun();

        }

        private void failureListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorScreen.Text = Failures[failureListBox.SelectedIndex];
        }

    }
}
