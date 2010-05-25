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
            this.errorScreen = new System.Windows.Forms.TextBox();
            this.numFailuresLabel = new System.Windows.Forms.Label();
            this.numTestsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.goBtn = new System.Windows.Forms.Button();
            this.lineLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.progressBar = new ColorProgressBar.ColorProgressBar();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "exe";
            this.openFileDialog1.Filter = "Executable|*.exe|All files|*.*";
            // 
            // errorScreen
            // 
            this.errorScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.errorScreen.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorScreen.Location = new System.Drawing.Point(3, 0);
            this.errorScreen.Multiline = true;
            this.errorScreen.Name = "errorScreen";
            this.errorScreen.Size = new System.Drawing.Size(520, 197);
            this.errorScreen.TabIndex = 9;
            // 
            // numFailuresLabel
            // 
            this.numFailuresLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numFailuresLabel.AutoSize = true;
            this.numFailuresLabel.Location = new System.Drawing.Point(783, 164);
            this.numFailuresLabel.Name = "numFailuresLabel";
            this.numFailuresLabel.Size = new System.Drawing.Size(13, 13);
            this.numFailuresLabel.TabIndex = 5;
            this.numFailuresLabel.Text = "0";
            // 
            // numTestsLabel
            // 
            this.numTestsLabel.AutoSize = true;
            this.numTestsLabel.Location = new System.Drawing.Point(104, 164);
            this.numTestsLabel.Name = "numTestsLabel";
            this.numTestsLabel.Size = new System.Drawing.Size(13, 13);
            this.numTestsLabel.TabIndex = 5;
            this.numTestsLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(679, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Failures:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of Tests:";
            // 
            // goBtn
            // 
            this.goBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.goBtn.Location = new System.Drawing.Point(372, 382);
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
            this.lineLabel.Location = new System.Drawing.Point(9, 124);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(787, 23);
            this.lineLabel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Google Test exe:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(731, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // failureListBox
            // 
            this.failureListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.failureListBox.FormattingEnabled = true;
            this.failureListBox.Location = new System.Drawing.Point(0, 0);
            this.failureListBox.Name = "failureListBox";
            this.failureListBox.Size = new System.Drawing.Size(251, 199);
            this.failureListBox.TabIndex = 8;
            this.failureListBox.SelectedIndexChanged += new System.EventHandler(this.failureListBox_SelectedIndexChanged);
            // 
            // exeFilename
            // 
            this.exeFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.exeFilename.FormattingEnabled = true;
            this.exeFilename.Location = new System.Drawing.Point(125, 6);
            this.exeFilename.Name = "exeFilename";
            this.exeFilename.Size = new System.Drawing.Size(600, 21);
            this.exeFilename.TabIndex = 0;
            this.exeFilename.TextChanged += new System.EventHandler(this.exeFilename_TextChanged);
            // 
            // clParams
            // 
            this.clParams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.clParams.FormattingEnabled = true;
            this.clParams.Location = new System.Drawing.Point(125, 33);
            this.clParams.Name = "clParams";
            this.clParams.Size = new System.Drawing.Size(395, 21);
            this.clParams.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Command line params:";
            // 
            // shouldShuffle
            // 
            this.shouldShuffle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shouldShuffle.AutoSize = true;
            this.shouldShuffle.Checked = true;
            this.shouldShuffle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.shouldShuffle.Location = new System.Drawing.Point(537, 36);
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
            this.shouldRunDisabled.Location = new System.Drawing.Point(602, 37);
            this.shouldRunDisabled.Name = "shouldRunDisabled";
            this.shouldRunDisabled.Size = new System.Drawing.Size(119, 17);
            this.shouldRunDisabled.TabIndex = 4;
            this.shouldRunDisabled.Text = "Run Disabled Tests";
            this.shouldRunDisabled.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Filter:";
            // 
            // filter
            // 
            this.filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.filter.FormattingEnabled = true;
            this.filter.Location = new System.Drawing.Point(125, 59);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(600, 21);
            this.filter.TabIndex = 6;
            // 
            // hideConsole
            // 
            this.hideConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hideConsole.AutoSize = true;
            this.hideConsole.Checked = true;
            this.hideConsole.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hideConsole.Location = new System.Drawing.Point(719, 37);
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
            this.splitContainer1.Location = new System.Drawing.Point(12, 180);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.failureListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.errorScreen);
            this.splitContainer1.Size = new System.Drawing.Size(784, 202);
            this.splitContainer1.SplitterDistance = 254;
            this.splitContainer1.TabIndex = 17;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(9, 87);
            this.progressBar.Maximum = 9;
            this.progressBar.Minimum = 0;
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressBarColor = System.Drawing.Color.Blue;
            this.progressBar.Size = new System.Drawing.Size(787, 24);
            this.progressBar.TabIndex = 3;
            this.progressBar.Value = 0;
            // 
            // GuitarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 409);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.hideConsole);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.shouldRunDisabled);
            this.Controls.Add(this.shouldShuffle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clParams);
            this.Controls.Add(this.exeFilename);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numFailuresLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.numTestsLabel);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lineLabel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuitarForm";
            this.Text = "Guitar 1.2.2 - Google Unit Test Application Runner";
            this.Load += new System.EventHandler(this.GuitarForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox errorScreen;
        private System.Windows.Forms.Label numFailuresLabel;
        private System.Windows.Forms.Label numTestsLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.Label lineLabel;
        private ColorProgressBar.ColorProgressBar progressBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
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
    }
}

