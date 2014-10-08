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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtOTName = new System.Windows.Forms.TextBox();
            this.rbOTMale = new System.Windows.Forms.RadioButton();
            this.rbOTFemale = new System.Windows.Forms.RadioButton();
            this.numTID = new System.Windows.Forms.NumericUpDown();
            this.numSID = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSID)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(428, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.selectFolderToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.selectFolderToolStripMenuItem.Text = "&Select Folder...";
            this.selectFolderToolStripMenuItem.Click += new System.EventHandler(this.selectFolderToolStripMenuItem_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(163, 265);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "&Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtOTName
            // 
            this.txtOTName.Location = new System.Drawing.Point(101, 49);
            this.txtOTName.Name = "txtOTName";
            this.txtOTName.Size = new System.Drawing.Size(100, 20);
            this.txtOTName.TabIndex = 1;
            // 
            // rbOTMale
            // 
            this.rbOTMale.AutoSize = true;
            this.rbOTMale.Location = new System.Drawing.Point(101, 75);
            this.rbOTMale.Name = "rbOTMale";
            this.rbOTMale.Size = new System.Drawing.Size(48, 17);
            this.rbOTMale.TabIndex = 2;
            this.rbOTMale.TabStop = true;
            this.rbOTMale.Text = "Male";
            this.rbOTMale.UseVisualStyleBackColor = true;
            // 
            // rbOTFemale
            // 
            this.rbOTFemale.AutoSize = true;
            this.rbOTFemale.Location = new System.Drawing.Point(101, 98);
            this.rbOTFemale.Name = "rbOTFemale";
            this.rbOTFemale.Size = new System.Drawing.Size(59, 17);
            this.rbOTFemale.TabIndex = 3;
            this.rbOTFemale.TabStop = true;
            this.rbOTFemale.Text = "Female";
            this.rbOTFemale.UseVisualStyleBackColor = true;
            // 
            // numTID
            // 
            this.numTID.Location = new System.Drawing.Point(101, 123);
            this.numTID.Name = "numTID";
            this.numTID.Size = new System.Drawing.Size(120, 20);
            this.numTID.TabIndex = 4;
            // 
            // numSID
            // 
            this.numSID.Location = new System.Drawing.Point(101, 149);
            this.numSID.Name = "numSID";
            this.numSID.Size = new System.Drawing.Size(120, 20);
            this.numSID.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 388);
            this.Controls.Add(this.numSID);
            this.Controls.Add(this.numTID);
            this.Controls.Add(this.rbOTFemale);
            this.Controls.Add(this.rbOTMale);
            this.Controls.Add(this.txtOTName);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(306, 28);
            this.Name = "frmMain";
            this.Text = "PKMDS PK6 Batch Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectFolderToolStripMenuItem;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtOTName;
        private System.Windows.Forms.RadioButton rbOTMale;
        private System.Windows.Forms.RadioButton rbOTFemale;
        private System.Windows.Forms.NumericUpDown numTID;
        private System.Windows.Forms.NumericUpDown numSID;

    }
}

