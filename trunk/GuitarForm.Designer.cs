namespace Guitar
{
    partial class GuitarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuitarForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.numFailuresLabel = new System.Windows.Forms.Label();
            this.numTestsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.goBtn = new System.Windows.Forms.Button();
            this.lineLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.failureListBox = new System.Windows.Forms.ListBox();
            this.exeFilename = new System.Windows.Forms.ComboBox();
            this.clParams = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.shouldShuffle = new System.Windows.Forms.CheckBox();
            this.shouldRunDisabled = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.filter = new System.Windows.Forms.ComboBox();
            this.hideConsole = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.errorScreen3 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.startupFolder = new System.Windows.Forms.ComboBox();
            this.buttonSelectStartupFolder = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutGuitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.progressBar = new ColorProgressBar.ColorProgressBar();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.optionsPanel.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "exe";
            this.openFileDialog1.Filter = "Executable|*.exe|All files|*.*";
            // 
            // numFailuresLabel
            // 
            this.numFailuresLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numFailuresLabel.AutoSize = true;
            this.numFailuresLabel.Location = new System.Drawing.Point(741, 57);
            this.numFailuresLabel.Name = "numFailuresLabel";
            this.numFailuresLabel.Size = new System.Drawing.Size(13, 13);
            this.numFailuresLabel.TabIndex = 5;
            this.numFailuresLabel.Text = "0";
            // 
            // numTestsLabel
            // 
            this.numTestsLabel.AutoSize = true;
            this.numTestsLabel.Location = new System.Drawing.Point(100, 57);
            this.numTestsLabel.Name = "numTestsLabel";
            this.numTestsLabel.Size = new System.Drawing.Size(13, 13);
            this.numTestsLabel.TabIndex = 5;
            this.numTestsLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Failures:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of Tests:";
            // 
            // goBtn
            // 
            this.goBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.goBtn.Location = new System.Drawing.Point(321, 202);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(75, 23);
            this.goBtn.TabIndex = 7;
            this.goBtn.Text = "Go";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // lineLabel
            // 
            this.lineLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lineLabel.Location = new System.Drawing.Point(6, 30);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(744, 27);
            this.lineLabel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Google Test exe";
            // 
            // buttonSelect
            // 
            this.buttonSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelect.Location = new System.Drawing.Point(672, 9);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect.TabIndex = 1;
            this.buttonSelect.Text = "Select...";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // failureListBox
            // 
            this.failureListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.failureListBox.FormattingEnabled = true;
            this.failureListBox.Location = new System.Drawing.Point(4, 6);
            this.failureListBox.Name = "failureListBox";
            this.failureListBox.Size = new System.Drawing.Size(235, 121);
            this.failureListBox.TabIndex = 8;
            this.failureListBox.SelectedIndexChanged += new System.EventHandler(this.failureListBox_SelectedIndexChanged);
            // 
            // exeFilename
            // 
            this.exeFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exeFilename.FormattingEnabled = true;
            this.exeFilename.Location = new System.Drawing.Point(119, 9);
            this.exeFilename.Name = "exeFilename";
            this.exeFilename.Size = new System.Drawing.Size(549, 21);
            this.exeFilename.TabIndex = 0;
            this.exeFilename.TextChanged += new System.EventHandler(this.exeFilename_TextChanged);
            // 
            // clParams
            // 
            this.clParams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clParams.FormattingEnabled = true;
            this.clParams.Location = new System.Drawing.Point(119, 37);
            this.clParams.Name = "clParams";
            this.clParams.Size = new System.Drawing.Size(549, 21);
            this.clParams.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Command line params";
            // 
            // shouldShuffle
            // 
            this.shouldShuffle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shouldShuffle.AutoSize = true;
            this.shouldShuffle.Checked = true;
            this.shouldShuffle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.shouldShuffle.Location = new System.Drawing.Point(119, 64);
            this.shouldShuffle.Name = "shouldShuffle";
            this.shouldShuffle.Size = new System.Drawing.Size(59, 17);
            this.shouldShuffle.TabIndex = 3;
            this.shouldShuffle.Text = "Shuffle";
            this.shouldShuffle.UseVisualStyleBackColor = true;
            // 
            // shouldRunDisabled
            // 
            this.shouldRunDisabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shouldRunDisabled.AutoSize = true;
            this.shouldRunDisabled.Location = new System.Drawing.Point(119, 87);
            this.shouldRunDisabled.Name = "shouldRunDisabled";
            this.shouldRunDisabled.Size = new System.Drawing.Size(119, 17);
            this.shouldRunDisabled.TabIndex = 4;
            this.shouldRunDisabled.Text = "Run Disabled Tests";
            this.shouldRunDisabled.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Filter";
            // 
            // filter
            // 
            this.filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filter.FormattingEnabled = true;
            this.filter.Location = new System.Drawing.Point(119, 158);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(549, 21);
            this.filter.TabIndex = 6;
            // 
            // hideConsole
            // 
            this.hideConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hideConsole.AutoSize = true;
            this.hideConsole.Checked = true;
            this.hideConsole.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hideConsole.Location = new System.Drawing.Point(119, 109);
            this.hideConsole.Name = "hideConsole";
            this.hideConsole.Size = new System.Drawing.Size(89, 17);
            this.hideConsole.TabIndex = 5;
            this.hideConsole.Text = "Hide Console";
            this.hideConsole.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 73);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.failureListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.errorScreen3);
            this.splitContainer1.Size = new System.Drawing.Size(750, 123);
            this.splitContainer1.SplitterDistance = 242;
            this.splitContainer1.TabIndex = 17;
            // 
            // errorScreen3
            // 
            this.errorScreen3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorScreen3.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.errorScreen3.Location = new System.Drawing.Point(3, 6);
            this.errorScreen3.Name = "errorScreen3";
            this.errorScreen3.Size = new System.Drawing.Size(498, 114);
            this.errorScreen3.TabIndex = 10;
            this.errorScreen3.Text = "";
            this.errorScreen3.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Startup folder";
            // 
            // startupFolder
            // 
            this.startupFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startupFolder.Location = new System.Drawing.Point(119, 132);
            this.startupFolder.Name = "startupFolder";
            this.startupFolder.Size = new System.Drawing.Size(549, 21);
            this.startupFolder.TabIndex = 19;
            // 
            // buttonSelectStartupFolder
            // 
            this.buttonSelectStartupFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectStartupFolder.Location = new System.Drawing.Point(672, 130);
            this.buttonSelectStartupFolder.Name = "buttonSelectStartupFolder";
            this.buttonSelectStartupFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectStartupFolder.TabIndex = 20;
            this.buttonSelectStartupFolder.Text = "Select..";
            this.buttonSelectStartupFolder.UseVisualStyleBackColor = true;
            this.buttonSelectStartupFolder.Click += new System.EventHandler(this.buttonSelectStartupFolder_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveConfigurationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveConfigurationToolStripMenuItem
            // 
            this.saveConfigurationToolStripMenuItem.Name = "saveConfigurationToolStripMenuItem";
            this.saveConfigurationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveConfigurationToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.saveConfigurationToolStripMenuItem.Text = "Save Configuration";
            this.saveConfigurationToolStripMenuItem.Click += new System.EventHandler(this.saveConfigurationToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.optionsToolStripMenuItem.Text = "Options Panel";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutGuitarToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutGuitarToolStripMenuItem
            // 
            this.aboutGuitarToolStripMenuItem.Name = "aboutGuitarToolStripMenuItem";
            this.aboutGuitarToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.aboutGuitarToolStripMenuItem.Text = "About Guitar";
            this.aboutGuitarToolStripMenuItem.Click += new System.EventHandler(this.aboutGuitarToolStripMenuItem_Click);
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.buttonSelectStartupFolder);
            this.optionsPanel.Controls.Add(this.label6);
            this.optionsPanel.Controls.Add(this.startupFolder);
            this.optionsPanel.Controls.Add(this.buttonSelect);
            this.optionsPanel.Controls.Add(this.hideConsole);
            this.optionsPanel.Controls.Add(this.label4);
            this.optionsPanel.Controls.Add(this.shouldRunDisabled);
            this.optionsPanel.Controls.Add(this.filter);
            this.optionsPanel.Controls.Add(this.shouldShuffle);
            this.optionsPanel.Controls.Add(this.label3);
            this.optionsPanel.Controls.Add(this.label5);
            this.optionsPanel.Controls.Add(this.exeFilename);
            this.optionsPanel.Controls.Add(this.clParams);
            this.optionsPanel.Location = new System.Drawing.Point(3, 0);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(752, 186);
            this.optionsPanel.TabIndex = 22;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(12, 27);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.optionsPanel);
            this.splitContainer2.Panel1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.progressBar);
            this.splitContainer2.Panel2.Controls.Add(this.goBtn);
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Panel2.Controls.Add(this.numTestsLabel);
            this.splitContainer2.Panel2.Controls.Add(this.numFailuresLabel);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.lineLabel);
            this.splitContainer2.Panel2.Margin = new System.Windows.Forms.Padding(10);
            this.splitContainer2.Size = new System.Drawing.Size(756, 418);
            this.splitContainer2.SplitterDistance = 189;
            this.splitContainer2.TabIndex = 23;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(6, 3);
            this.progressBar.Maximum = 9;
            this.progressBar.Minimum = 0;
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressBarColor = System.Drawing.Color.Black;
            this.progressBar.Size = new System.Drawing.Size(743, 24);
            this.progressBar.TabIndex = 3;
            this.progressBar.Value = 0;
            // 
            // GuitarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 457);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GuitarForm";
            this.Text = "Guitar 1.2.3 - Google Unit Test Application Runner";
            this.Load += new System.EventHandler(this.GuitarForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label numFailuresLabel;
        private System.Windows.Forms.Label numTestsLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.Label lineLabel;
        private ColorProgressBar.ColorProgressBar progressBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.ListBox failureListBox;
        private System.Windows.Forms.ComboBox exeFilename;
        private System.Windows.Forms.ComboBox clParams;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox shouldShuffle;
        private System.Windows.Forms.CheckBox shouldRunDisabled;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox filter;
        private System.Windows.Forms.CheckBox hideConsole;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox startupFolder;
        private System.Windows.Forms.Button buttonSelectStartupFolder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutGuitarToolStripMenuItem;
        private System.Windows.Forms.RichTextBox errorScreen3;
        private System.Windows.Forms.ToolStripMenuItem saveConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}

