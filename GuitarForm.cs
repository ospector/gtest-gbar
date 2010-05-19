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

namespace Guitar
{
    public partial class GuitarForm : Form
    {
        int numTests;
        List<string> Failures=new List<string>();
        Regex r=new Regex(".*\\\\([^\\\\]+\\.cpp\\([0-9]+\\)):.*");

        public GuitarForm()
        {
            InitializeComponent();
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            saveSettings();

            Process gtestApp = new Process();
            gtestApp.StartInfo.FileName = exeFilename.Text;
            gtestApp.StartInfo.UseShellExecute = false;
            gtestApp.StartInfo.RedirectStandardOutput = true;
            gtestApp.Start();

            GoogleTestOutputParser parser = new GoogleTestOutputParser(this.calibrateProgressBar, this.advanceProgressBar);

            String line;
            while ((line = gtestApp.StandardOutput.ReadLine()) != null)
            {
                lineLabel.Text = line;
                parser.submitLine(line);
                this.Refresh();
            }

            lineLabel.Text = "Done.";
            if (Failures.Count==0) errorScreen.Text = "All is well.";
        }

        private void saveSettings()
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings["gtest"].Value = exeFilename.Text;
            config.Save(ConfigurationSaveMode.Modified);
        }

        private void calibrateProgressBar(int n)
        {
            int numTests=n;
            Failures.Clear();
            numTestsLabel.Text=""+n;
            numFailuresLabel.Text="0";
            failureListBox.Items.Clear();
            
            progressBar.Value = 0;
            progressBar.Minimum = 0;
            progressBar.Maximum = n;
            progressBar.ProgressBarColor = Color.Green;
        }

        private void advanceProgressBar(string error)
        {
            if (error!=null)
            {
                progressBar.ProgressBarColor = Color.Red;
                Failures.Add(error);
                numFailuresLabel.Text = "" + Failures.Count;
                Match mc=r.Match(error);
                failureListBox.Items.Add(mc.Groups[1]);
                failureListBox.SelectedIndex = 0;
            }

            progressBar.Value++;
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
            return (System.IO.File.Exists(exeFilename.Text) && exeFilename.Text.EndsWith("exe"));
        }

        private void GuitarForm_Load(object sender, EventArgs e)
        {
            exeFilename.Text = System.Configuration.ConfigurationManager.AppSettings["gtest"]; 

            goBtn.Enabled = canRun();

        }

        private void failureListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorScreen.Text = Failures[failureListBox.SelectedIndex];
        }
    }
}
