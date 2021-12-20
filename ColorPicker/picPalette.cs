using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class picPalette : PictureBox
    {
        public bool WasSet { get; set; }
        public picPalette()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void picPalette_Click(object sender, EventArgs e)
        {
            frmMain.Instance.timPickColor_Tick(null, null);
            frmMain.Instance.timPickColor.Enabled = false;
        }

        private void cmsPalette_Opening(object sender, CancelEventArgs e)
        {

        }

        private void copyAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain.Instance.CopyAll();
        }

        private void copyHexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain.Instance.btnCopyHex_Click(null, null);
        }

        private void copyHSLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain.Instance.btnCopyHSL_Click(null, null);
        }

        private void copyRGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain.Instance.btnCopyFrom_Click(null, null);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WasSet = false;
            this.BackColor = Color.White;
        }

        private void picPalette_MouseDown(object sender, MouseEventArgs e)
        {
            picPalette_Click(null, null);
        }
    }
}
