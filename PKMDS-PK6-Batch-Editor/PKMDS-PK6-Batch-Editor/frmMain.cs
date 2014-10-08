using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PKMDS;
namespace PKMDS_PK6_Batch_Editor
{
    public partial class frmMain : Form
    {
        public string Paras = @"..\..\Samples\Paras.pk6";
        /*
         Sample data:
         B15 - 3,6 - Paras (F) - Impish - Effect Spore - 05.08.12.05.08.05
         */
        public frmMain()
        {
            InitializeComponent();
        }
        private void selectFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            PK6 pk6 = new PK6();
            pk6.CalcChecksum();
            MessageBox.Show("Done!");
        }
    }
}
