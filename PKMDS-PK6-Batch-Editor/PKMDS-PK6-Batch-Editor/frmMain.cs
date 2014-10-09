using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using PKMDS;
namespace PKMDS_PK6_Batch_Editor
{
    public partial class frmMain : Form
    {
        public String inpath = "";
        public String outpath = "";
        public frmMain()
        {
            InitializeComponent();
        }
        private void selectFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnApply.Enabled = false;
            inpath = "";
            FolderBrowserDialog folderbrowser = new FolderBrowserDialog();
            folderbrowser.Description = "Select an input folder.";
            if (folderbrowser.ShowDialog() != DialogResult.Cancel)
            {
                if (folderbrowser.SelectedPath != "")
                {
                    inpath = folderbrowser.SelectedPath;
                    btnApply.Enabled = true;
                }
            }
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            if (inpath != "")
            {
                FolderBrowserDialog folderbrowser = new FolderBrowserDialog();
                folderbrowser.Description = "Select an output folder.";
                if (folderbrowser.ShowDialog() != DialogResult.Cancel)
                {
                    if (folderbrowser.SelectedPath != "")
                    {
                        outpath = folderbrowser.SelectedPath;
                    }
                }
                DirectoryInfo indir = new DirectoryInfo(inpath);
                DirectoryInfo outdir = new DirectoryInfo(outpath);
                foreach (FileInfo file in indir.GetFiles("*.pk6"))
                {
                    PK6 pk6 = Functions.ReadPK6(file.FullName);
                    pk6.OTName = txtOTName.Text;
                    pk6.OTIsFemale = rbOTFemale.Checked;
                    pk6.TID = (UInt16)numTID.Value;
                    pk6.SID = (UInt16)numSID.Value;
                    pk6.CalcChecksum();
                    Functions.WritePK6(pk6, Path.Combine(outpath, file.Name));
                }
            }
        }
    }
}
