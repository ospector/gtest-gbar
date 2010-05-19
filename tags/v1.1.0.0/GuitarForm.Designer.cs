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
            this.progressBar = new ColorProgressBar.ColorProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.exeFilename = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.failureListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "exe";
            this.openFileDialog1.Filter = "Executable|*.exe";
            // 
            // errorScreen
            // 
            this.errorScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.errorScreen.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorScreen.Location = new System.Drawing.Point(169, 144);
            this.errorScreen.Multiline = true;
            this.errorScreen.Name = "errorScreen";
            this.errorScreen.Size = new System.Drawing.Size(451, 160);
            this.errorScreen.TabIndex = 6;
            // 
            // numFailuresLabel
            // 
            this.numFailuresLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numFailuresLabel.AutoSize = true;
            this.numFailuresLabel.Location = new System.Drawing.Point(606, 118);
            this.numFailuresLabel.Name = "numFailuresLabel";
            this.numFailuresLabel.Size = new System.Drawing.Size(13, 13);
            this.numFailuresLabel.TabIndex = 5;
            this.numFailuresLabel.Text = "0";
            // 
            // numTestsLabel
            // 
            this.numTestsLabel.AutoSize = true;
            this.numTestsLabel.Location = new System.Drawing.Point(104, 118);
            this.numTestsLabel.Name = "numTestsLabel";
            this.numTestsLabel.Size = new System.Drawing.Size(13, 13);
            this.numTestsLabel.TabIndex = 5;
            this.numTestsLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Failures:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of Tests:";
            // 
            // goBtn
            // 
            this.goBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.goBtn.Location = new System.Drawing.Point(283, 315);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(75, 23);
            this.goBtn.TabIndex = 0;
            this.goBtn.Text = "Go";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // lineLabel
            // 
            this.lineLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lineLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lineLabel.Location = new System.Drawing.Point(9, 78);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(610, 23);
            this.lineLabel.TabIndex = 2;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(9, 41);
            this.progressBar.Maximum = 9;
            this.progressBar.Minimum = 0;
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressBarColor = System.Drawing.Color.Blue;
            this.progressBar.Size = new System.Drawing.Size(610, 24);
            this.progressBar.TabIndex = 3;
            this.progressBar.Value = 0;
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
            // exeFilename
            // 
            this.exeFilename.Location = new System.Drawing.Point(101, 9);
            this.exeFilename.Name = "exeFilename";
            this.exeFilename.Size = new System.Drawing.Size(437, 20);
            this.exeFilename.TabIndex = 8;
            this.exeFilename.TextChanged += new System.EventHandler(this.exeFilename_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Select...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // failureListBox
            // 
            this.failureListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.failureListBox.FormattingEnabled = true;
            this.failureListBox.Location = new System.Drawing.Point(12, 144);
            this.failureListBox.Name = "failureListBox";
            this.failureListBox.Size = new System.Drawing.Size(151, 160);
            this.failureListBox.TabIndex = 10;
            this.failureListBox.SelectedIndexChanged += new System.EventHandler(this.failureListBox_SelectedIndexChanged);
            // 
            // GuitarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 350);
            this.Controls.Add(this.failureListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exeFilename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.errorScreen);
            this.Controls.Add(this.numFailuresLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.numTestsLabel);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lineLabel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuitarForm";
            this.Text = "Guitar 1.1 - Google Unit Test Runner";
            this.Load += new System.EventHandler(this.GuitarForm_Load);
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
        private System.Windows.Forms.TextBox exeFilename;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox failureListBox;

    }
}

