namespace PKMDS_PK6_Batch_Editor
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtOTName = new System.Windows.Forms.TextBox();
            this.rbOTMale = new System.Windows.Forms.RadioButton();
            this.rbOTFemale = new System.Windows.Forms.RadioButton();
            this.numTID = new System.Windows.Forms.NumericUpDown();
            this.numSID = new System.Windows.Forms.NumericUpDown();
            this.gbOTGender = new System.Windows.Forms.GroupBox();
            this.lblOTName = new System.Windows.Forms.Label();
            this.lblTID = new System.Windows.Forms.Label();
            this.lblSID = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSID)).BeginInit();
            this.gbOTGender.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(303, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFolderToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // selectFolderToolStripMenuItem
            // 
            this.selectFolderToolStripMenuItem.Name = "selectFolderToolStripMenuItem";
            this.selectFolderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.selectFolderToolStripMenuItem.Text = "&Select Folder...";
            this.selectFolderToolStripMenuItem.Click += new System.EventHandler(this.selectFolderToolStripMenuItem_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.btnApply, 2);
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(114, 173);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "&Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtOTName
            // 
            this.txtOTName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOTName.Location = new System.Drawing.Point(154, 6);
            this.txtOTName.MaxLength = 12;
            this.txtOTName.Name = "txtOTName";
            this.txtOTName.Size = new System.Drawing.Size(146, 20);
            this.txtOTName.TabIndex = 1;
            // 
            // rbOTMale
            // 
            this.rbOTMale.AutoSize = true;
            this.rbOTMale.Checked = true;
            this.rbOTMale.Location = new System.Drawing.Point(6, 19);
            this.rbOTMale.Name = "rbOTMale";
            this.rbOTMale.Size = new System.Drawing.Size(48, 17);
            this.rbOTMale.TabIndex = 0;
            this.rbOTMale.TabStop = true;
            this.rbOTMale.Text = "Male";
            this.rbOTMale.UseVisualStyleBackColor = true;
            // 
            // rbOTFemale
            // 
            this.rbOTFemale.AutoSize = true;
            this.rbOTFemale.Location = new System.Drawing.Point(6, 42);
            this.rbOTFemale.Name = "rbOTFemale";
            this.rbOTFemale.Size = new System.Drawing.Size(59, 17);
            this.rbOTFemale.TabIndex = 1;
            this.rbOTFemale.Text = "Female";
            this.rbOTFemale.UseVisualStyleBackColor = true;
            // 
            // numTID
            // 
            this.numTID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numTID.Location = new System.Drawing.Point(154, 107);
            this.numTID.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numTID.Name = "numTID";
            this.numTID.Size = new System.Drawing.Size(55, 20);
            this.numTID.TabIndex = 4;
            this.numTID.Value = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            // 
            // numSID
            // 
            this.numSID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numSID.Location = new System.Drawing.Point(154, 140);
            this.numSID.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numSID.Name = "numSID";
            this.numSID.Size = new System.Drawing.Size(55, 20);
            this.numSID.TabIndex = 6;
            this.numSID.Value = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            // 
            // gbOTGender
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbOTGender, 2);
            this.gbOTGender.Controls.Add(this.rbOTMale);
            this.gbOTGender.Controls.Add(this.rbOTFemale);
            this.gbOTGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOTGender.Location = new System.Drawing.Point(3, 36);
            this.gbOTGender.Name = "gbOTGender";
            this.gbOTGender.Size = new System.Drawing.Size(297, 62);
            this.gbOTGender.TabIndex = 2;
            this.gbOTGender.TabStop = false;
            this.gbOTGender.Text = "OT Gender";
            // 
            // lblOTName
            // 
            this.lblOTName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOTName.Location = new System.Drawing.Point(3, 8);
            this.lblOTName.Name = "lblOTName";
            this.lblOTName.Size = new System.Drawing.Size(65, 17);
            this.lblOTName.TabIndex = 0;
            this.lblOTName.Text = "OT Name";
            this.lblOTName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTID
            // 
            this.lblTID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTID.Location = new System.Drawing.Point(3, 111);
            this.lblTID.Name = "lblTID";
            this.lblTID.Size = new System.Drawing.Size(65, 13);
            this.lblTID.TabIndex = 3;
            this.lblTID.Text = "TID";
            this.lblTID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSID
            // 
            this.lblSID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSID.Location = new System.Drawing.Point(3, 144);
            this.lblSID.Name = "lblSID";
            this.lblSID.Size = new System.Drawing.Size(65, 13);
            this.lblSID.TabIndex = 5;
            this.lblSID.Text = "SID";
            this.lblSID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblOTName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnApply, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.numSID, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblSID, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtOTName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numTID, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.gbOTGender, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTID, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(303, 203);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 227);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(306, 39);
            this.Name = "frmMain";
            this.Text = "PKMDS PK6 Batch Editor";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSID)).EndInit();
            this.gbOTGender.ResumeLayout(false);
            this.gbOTGender.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectFolderToolStripMenuItem;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtOTName;
        private System.Windows.Forms.RadioButton rbOTMale;
        private System.Windows.Forms.RadioButton rbOTFemale;
        private System.Windows.Forms.NumericUpDown numTID;
        private System.Windows.Forms.NumericUpDown numSID;
        private System.Windows.Forms.GroupBox gbOTGender;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblOTName;
        private System.Windows.Forms.Label lblSID;
        private System.Windows.Forms.Label lblTID;

    }
}

