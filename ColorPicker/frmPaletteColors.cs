using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class frmPaletteColors : ColorPicker.CustomForm
    {
        public frmPaletteColors()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ColorNumber = (int)nudNumber.Value;

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmPaletteColors_Load(object sender, EventArgs e)
        {
            nudNumber.Value = Properties.Settings.Default.ColorNumber;
        }
    }
}
