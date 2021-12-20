namespace ColorPicker
{
    partial class picPalette
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmsPalette = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyRGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyHSLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyHexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPalette.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsPalette
            // 
            this.cmsPalette.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.copyAllToolStripMenuItem,
            this.copyRGBToolStripMenuItem,
            this.copyHSLToolStripMenuItem,
            this.copyHexToolStripMenuItem});
            this.cmsPalette.Name = "cmsPalette";
            this.cmsPalette.Size = new System.Drawing.Size(128, 114);
            this.cmsPalette.Opening += new System.ComponentModel.CancelEventHandler(this.cmsPalette_Opening);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Image = global::ColorPicker.Properties.Resources.delete;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // copyAllToolStripMenuItem
            // 
            this.copyAllToolStripMenuItem.Image = global::ColorPicker.Properties.Resources.copy;
            this.copyAllToolStripMenuItem.Name = "copyAllToolStripMenuItem";
            this.copyAllToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.copyAllToolStripMenuItem.Text = "&Copy All";
            this.copyAllToolStripMenuItem.Click += new System.EventHandler(this.copyAllToolStripMenuItem_Click);
            // 
            // copyRGBToolStripMenuItem
            // 
            this.copyRGBToolStripMenuItem.Image = global::ColorPicker.Properties.Resources.copy;
            this.copyRGBToolStripMenuItem.Name = "copyRGBToolStripMenuItem";
            this.copyRGBToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.copyRGBToolStripMenuItem.Text = "Copy &RGB";
            this.copyRGBToolStripMenuItem.Click += new System.EventHandler(this.copyRGBToolStripMenuItem_Click);
            // 
            // copyHSLToolStripMenuItem
            // 
            this.copyHSLToolStripMenuItem.Image = global::ColorPicker.Properties.Resources.copy;
            this.copyHSLToolStripMenuItem.Name = "copyHSLToolStripMenuItem";
            this.copyHSLToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.copyHSLToolStripMenuItem.Text = "Copy &HSL";
            this.copyHSLToolStripMenuItem.Click += new System.EventHandler(this.copyHSLToolStripMenuItem_Click);
            // 
            // copyHexToolStripMenuItem
            // 
            this.copyHexToolStripMenuItem.Image = global::ColorPicker.Properties.Resources.copy;
            this.copyHexToolStripMenuItem.Name = "copyHexToolStripMenuItem";
            this.copyHexToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.copyHexToolStripMenuItem.Text = "Copy &Hex";
            this.copyHexToolStripMenuItem.Click += new System.EventHandler(this.copyHexToolStripMenuItem_Click);
            // 
            // picPalette
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextMenuStrip = this.cmsPalette;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximumSize = new System.Drawing.Size(16, 16);
            this.MinimumSize = new System.Drawing.Size(16, 16);
            this.Size = new System.Drawing.Size(16, 16);
            this.Click += new System.EventHandler(this.picPalette_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picPalette_MouseDown);
            this.cmsPalette.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmsPalette;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyRGBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyHSLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyHexToolStripMenuItem;
    }
}
