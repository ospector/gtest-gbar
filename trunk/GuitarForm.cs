using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Guitar
{
    public partial class GuitarForm : Form
    {
        const int DEFAULT_MAX_HISTORY = 5;
        const string SETTING_MAX_HISTORY = "maxHistory";
        const string SETTING_GTEST_EXES = "gtest";
        const string SETTING_GTEST_PARAMS = "gtest-params";
        const string SETTING_GTEST_STARTUP_FOLDER = "gtest-startupFolder";
        const string SETTING_GTEST_FILTERS = "gtest-filters";

        List<string> Failures = new List< string>();
        private bool inWindows;
        private bool gotCommandlinePath = false;
        private String commmandlinePath;

        private Dictionary<string, ComboBox> controls;

        Configurator configurator;
        public GuitarForm()
        {
            initializeForm(); // TODO: find a way to call GuitarForm() from GuitarForm(String fileName)
        }
		public GuitarForm(String fileName)
        {
            initializeForm();

            guitarReceivedAPathToATestExecutable();
            setFileNameInputbox(fileName);
        }
        private void initializeForm(){
            inWindows = (System.Environment.OSVersion.Platform != System.PlatformID.Unix && System.Environment.OSVersion.Platform != System.PlatformID.MacOSX);
            InitializeComponent();

            controls = new Dictionary<string, ComboBox>();
            controls.Add(SETTING_GTEST_EXES, exeFilename);
            controls.Add(SETTING_GTEST_PARAMS, clParams);
            controls.Add(SETTING_GTEST_FILTERS, filter);
            controls.Add(SETTING_GTEST_STARTUP_FOLDER, startupFolder);

            configurator = new Configurator(controls);

            //setConfigurationFile();
        }
      
        private void guitarReceivedAPathToATestExecutable()
        {
            gotCommandlinePath = true;
        }
        private void setFileNameInputbox(String filename)
        {
            commmandlinePath = filename;
        }
        
        private void GuitarForm_Load(object sender, EventArgs e)
        {
            configurator.autoloadFromValues();

            goBtn.Enabled = canRun();
            errorScreen.Text = configurator.getFilePath();

            if (gotCommandlinePath && goBtn.Enabled)
            {
                exeFilename.Text = commmandlinePath;
                goBtn_Click(sender, e);
            }
        }
       
        private void goBtn_Click(object sender, EventArgs e)
        {
            int exitCode = 0;
            try
            {
                autoNewComboboxesItemsInHistory();
                configurator.saveSettings();
                errorScreen.Text = configurator.getFilePath();

                cls();

                GoogleTestOutputParser parser = new GoogleTestOutputParser(this.advanceProgressBar, this.lineRead);

                bool monoException = false;
                try
                {
                    calibrateProgressBar(parser.countTests(runGtest(true).StandardOutput));

                    Process gtestexe = runGtest(false);
                    parser.parseTests(gtestexe.StandardOutput);

                    exitCode = gtestexe.ExitCode;
                }
                catch (System.ObjectDisposedException)
                {
                    monoException = true;
                }

                if (monoException)
                {
                    cls();
                    errorScreen.Text = "Please Retry, Failure during run due to StreamReader close\n" +
                                        "(This is a known issue in Mono on Ubuntu.)";
                }
                else
                {
                    int disabled = (progressBar.Maximum - progressBar.Value);
                    
                    lineLabel.Text = "Done " + progressBar.Value + 
                                     " of " + progressBar.Maximum + 
                                     (disabled == 0 ? ". " : ". " + disabled + " are disabled.") +
                                     ". Pass: " + ((progressBar.Value - Failures.Count ) * 100 / progressBar.Value) + "%" ;
                    if (Failures.Count == 0 && exitCode == 0) 
                        errorScreen.Text = "All is well.";
                    else
                    {
                        if (exitCode != 0)
                        {
                            errorScreen.Text = "Exit code != 0. Maybe an assertion failed.";
                        }
                    }
                        
                }
                goBtn.Enabled = canRun();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void autoNewComboboxesItemsInHistory()
        {
            Dictionary<string, ComboBox>.Enumerator en = controls.GetEnumerator();
            while (en.MoveNext())
            {
                putNewItemOnHistorysTop(en.Current.Value);
            }
        }

        private void putNewItemOnHistorysTop(ComboBox cb)
        {
            // Is this an old item selection or a new item
            string selText = cb.Text;

            Boolean isNew = !cb.Items.Contains(selText);
            if (!isNew)
            {
                // remove older reference to same file
                cb.Items.Remove(selText);
            }
            cb.Items.Insert(0, selText);
            cb.SelectedIndex = 0;

            maintainHistoryLength(cb.Items);
        }
        private void maintainHistoryLength(ComboBox.ObjectCollection items)
        {
            if (items.Count > DEFAULT_MAX_HISTORY)
            {
                int lastIndex = items.Count - 1;
                items.RemoveAt(lastIndex);
            }

        }
       
        private void cls()
        {
            progressBar.Value = 0;
            failureListBox.Items.Clear();
            errorScreen.Text = "";
            errorScreen.Refresh();
        }

        private void calibrateProgressBar(int n)
        {
            Failures.Clear();
            numTestsLabel.Text = "" + n;
            numFailuresLabel.Text = "0";
            failureListBox.Items.Clear();

            progressBar.Value = 0;
            progressBar.Minimum = 0;
            progressBar.Maximum = n;


            numTestsLabel.Refresh();
            numFailuresLabel.Refresh();
        }

        private Process runGtest(bool onlyListTests)
        {
            Process gtestApp = new Process();
            gtestApp.StartInfo.FileName = exeFilename.Text;
            gtestApp.StartInfo.Arguments = buildArgs(onlyListTests);
            gtestApp.StartInfo.UseShellExecute = false;
            gtestApp.StartInfo.RedirectStandardOutput = true;
            gtestApp.StartInfo.CreateNoWindow = (onlyListTests || (!onlyListTests && hideConsole.Checked));

            if (startupFolder.Text != "")
            {
                if (System.IO.Directory.Exists(startupFolder.Text))
                {
                    gtestApp.StartInfo.WorkingDirectory = startupFolder.Text;
                }
                else
                {
                    MessageBox.Show("Selected startup folder not found.");
                }
            }

            gtestApp.Start();
            return gtestApp;
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

        
        
       

       

        

        private void lineRead(string line, bool countStage)
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

        private void advanceProgressBar(string testName, string error)
        {
            if (error != null)
            {
                progressBar.ProgressBarColor = Color.Red;
                Failures.Add(error);
                numFailuresLabel.Text = "" + Failures.Count;
                failureListBox.Items.Add(testName);
                failureListBox.SelectedIndex = 0;
                failureListBox.Refresh();
            }
            else
            {
                progressBar.ProgressBarColor = Color.Green;
            }

            progressBar.Value++;
            progressBar.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult r = openFileDialog1.ShowDialog();
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
            bool ret = System.IO.File.Exists(exeFilename.Text);

            if (inWindows)
            {
                ret = ret && (exeFilename.Text.TrimEnd().EndsWith("exe") || exeFilename.Text.TrimEnd().EndsWith("bat"));
            }
            return ret;
        }

        

        private void failureListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorScreen.Text = Failures[failureListBox.SelectedIndex];
        }

        private void buttonSelectStartupFolder_Click(object sender, EventArgs e)
        {
            try
            {
                string startupPath = Application.StartupPath;
                using (FolderBrowserDialog dialog = new FolderBrowserDialog())
                {
                    dialog.Description = "Select a startup folder";
                    dialog.ShowNewFolderButton = false;
                    dialog.RootFolder = Environment.SpecialFolder.MyComputer;

                    // Select current startup folder
                    if (startupFolder.Text != "")
                    {
                        if (System.IO.Directory.Exists(startupFolder.Text))
                            dialog.SelectedPath = startupFolder.Text;
                    }
                    else
                    {
                        // try to select folder where google test exe is located
                        string strExePath = exeFilename.Text;
                        if (System.IO.File.Exists(strExePath))
                        {           
                            string folder = System.IO.Path.GetDirectoryName(strExePath);
                            dialog.SelectedPath = folder;
                        }
                    }
                    
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        string folder = dialog.SelectedPath;
                        startupFolder.Text = folder;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Selection of a startup folder failed (" + exc.Message + ").");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutGuitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Guitar a UI for a Google Test (https://code.google.com/p/gtest-gbar/)", "About");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
