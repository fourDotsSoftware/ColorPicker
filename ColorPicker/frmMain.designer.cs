namespace ColorPicker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblColor = new System.Windows.Forms.Label();
            this.lblFromDesc = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnCopRGB = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePaletteAsPNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paletteNumberOfColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runMinimizedAtWindowsStartupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToSystemTrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.languages1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languages2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pleaseDonateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiHelpFeedback = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForNewVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.followUsOnTwitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visit4dotsSoftwareWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtRGB = new System.Windows.Forms.TextBox();
            this.timPickColor = new System.Windows.Forms.Timer(this.components);
            this.picPickColor = new ColorPicker.PicColorPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHSL = new System.Windows.Forms.TextBox();
            this.btnCopyHSL = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.btnCopyHex = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.notMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fplPalette = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPickColor)).BeginInit();
            this.cmsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.White;
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lblColor, "lblColor");
            this.lblColor.Name = "lblColor";
            this.lblColor.BackColorChanged += new System.EventHandler(this.lblFromColor_BackColorChanged);
            this.lblColor.Click += new System.EventHandler(this.btnFromColor_Click);
            // 
            // lblFromDesc
            // 
            resources.ApplyResources(this.lblFromDesc, "lblFromDesc");
            this.lblFromDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblFromDesc.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblFromDesc.Name = "lblFromDesc";
            // 
            // btnOK
            // 
            this.btnOK.Image = global::ColorPicker.Properties.Resources.check;
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCopRGB
            // 
            resources.ApplyResources(this.btnCopRGB, "btnCopRGB");
            this.btnCopRGB.Image = global::ColorPicker.Properties.Resources.copy;
            this.btnCopRGB.Name = "btnCopRGB";
            this.btnCopRGB.UseVisualStyleBackColor = true;
            this.btnCopRGB.Click += new System.EventHandler(this.btnCopyFrom_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.languageToolStripMenuItem1,
            this.helpToolStripMenuItem1});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savePaletteAsPNGToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // savePaletteAsPNGToolStripMenuItem
            // 
            this.savePaletteAsPNGToolStripMenuItem.Image = global::ColorPicker.Properties.Resources.disk_blue;
            this.savePaletteAsPNGToolStripMenuItem.Name = "savePaletteAsPNGToolStripMenuItem";
            resources.ApplyResources(this.savePaletteAsPNGToolStripMenuItem, "savePaletteAsPNGToolStripMenuItem");
            this.savePaletteAsPNGToolStripMenuItem.Click += new System.EventHandler(this.savePaletteAsPNGToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Image = global::ColorPicker.Properties.Resources.exit;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            resources.ApplyResources(this.exitToolStripMenuItem1, "exitToolStripMenuItem1");
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paletteNumberOfColorsToolStripMenuItem,
            this.runMinimizedAtWindowsStartupToolStripMenuItem,
            this.minimizeToSystemTrayToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            // 
            // paletteNumberOfColorsToolStripMenuItem
            // 
            this.paletteNumberOfColorsToolStripMenuItem.Name = "paletteNumberOfColorsToolStripMenuItem";
            resources.ApplyResources(this.paletteNumberOfColorsToolStripMenuItem, "paletteNumberOfColorsToolStripMenuItem");
            this.paletteNumberOfColorsToolStripMenuItem.Click += new System.EventHandler(this.paletteNumberOfColorsToolStripMenuItem_Click);
            // 
            // runMinimizedAtWindowsStartupToolStripMenuItem
            // 
            this.runMinimizedAtWindowsStartupToolStripMenuItem.Name = "runMinimizedAtWindowsStartupToolStripMenuItem";
            resources.ApplyResources(this.runMinimizedAtWindowsStartupToolStripMenuItem, "runMinimizedAtWindowsStartupToolStripMenuItem");
            this.runMinimizedAtWindowsStartupToolStripMenuItem.Click += new System.EventHandler(this.runMinimizedAtWindowsStartupToolStripMenuItem_Click);
            // 
            // minimizeToSystemTrayToolStripMenuItem
            // 
            this.minimizeToSystemTrayToolStripMenuItem.Name = "minimizeToSystemTrayToolStripMenuItem";
            resources.ApplyResources(this.minimizeToSystemTrayToolStripMenuItem, "minimizeToSystemTrayToolStripMenuItem");
            this.minimizeToSystemTrayToolStripMenuItem.Click += new System.EventHandler(this.minimizeToSystemTrayToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem1
            // 
            this.languageToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languages1ToolStripMenuItem,
            this.languages2ToolStripMenuItem});
            this.languageToolStripMenuItem1.Name = "languageToolStripMenuItem1";
            resources.ApplyResources(this.languageToolStripMenuItem1, "languageToolStripMenuItem1");
            // 
            // languages1ToolStripMenuItem
            // 
            this.languages1ToolStripMenuItem.Name = "languages1ToolStripMenuItem";
            resources.ApplyResources(this.languages1ToolStripMenuItem, "languages1ToolStripMenuItem");
            // 
            // languages2ToolStripMenuItem
            // 
            this.languages2ToolStripMenuItem.Name = "languages2ToolStripMenuItem";
            resources.ApplyResources(this.languages2ToolStripMenuItem, "languages2ToolStripMenuItem");
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpGuideToolStripMenuItem,
            this.pleaseDonateToolStripMenuItem1,
            this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem,
            this.tiHelpFeedback,
            this.checkForNewVersionToolStripMenuItem,
            this.toolStripMenuItem1,
            this.followUsOnTwitterToolStripMenuItem,
            this.visit4dotsSoftwareWebsiteToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            resources.ApplyResources(this.helpToolStripMenuItem1, "helpToolStripMenuItem1");
            // 
            // helpGuideToolStripMenuItem
            // 
            this.helpGuideToolStripMenuItem.Image = global::ColorPicker.Properties.Resources.help2;
            this.helpGuideToolStripMenuItem.Name = "helpGuideToolStripMenuItem";
            resources.ApplyResources(this.helpGuideToolStripMenuItem, "helpGuideToolStripMenuItem");
            this.helpGuideToolStripMenuItem.Click += new System.EventHandler(this.helpGuideToolStripMenuItem_Click);
            // 
            // pleaseDonateToolStripMenuItem1
            // 
            this.pleaseDonateToolStripMenuItem1.BackColor = System.Drawing.Color.Gold;
            resources.ApplyResources(this.pleaseDonateToolStripMenuItem1, "pleaseDonateToolStripMenuItem1");
            this.pleaseDonateToolStripMenuItem1.Name = "pleaseDonateToolStripMenuItem1";
            this.pleaseDonateToolStripMenuItem1.Click += new System.EventHandler(this.pleaseDonateToolStripMenuItem1_Click);
            // 
            // dotsSoftwarePRODUCTCATALOGToolStripMenuItem
            // 
            resources.ApplyResources(this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem, "dotsSoftwarePRODUCTCATALOGToolStripMenuItem");
            this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem.Name = "dotsSoftwarePRODUCTCATALOGToolStripMenuItem";
            this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem.Click += new System.EventHandler(this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem_Click);
            // 
            // tiHelpFeedback
            // 
            this.tiHelpFeedback.Name = "tiHelpFeedback";
            resources.ApplyResources(this.tiHelpFeedback, "tiHelpFeedback");
            this.tiHelpFeedback.Click += new System.EventHandler(this.tiHelpFeedback_Click);
            // 
            // checkForNewVersionToolStripMenuItem
            // 
            this.checkForNewVersionToolStripMenuItem.Name = "checkForNewVersionToolStripMenuItem";
            resources.ApplyResources(this.checkForNewVersionToolStripMenuItem, "checkForNewVersionToolStripMenuItem");
            this.checkForNewVersionToolStripMenuItem.Click += new System.EventHandler(this.checkForNewVersionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // followUsOnTwitterToolStripMenuItem
            // 
            this.followUsOnTwitterToolStripMenuItem.Image = global::ColorPicker.Properties.Resources.twitter_24;
            this.followUsOnTwitterToolStripMenuItem.Name = "followUsOnTwitterToolStripMenuItem";
            resources.ApplyResources(this.followUsOnTwitterToolStripMenuItem, "followUsOnTwitterToolStripMenuItem");
            this.followUsOnTwitterToolStripMenuItem.Click += new System.EventHandler(this.followUsOnTwitterToolStripMenuItem_Click);
            // 
            // visit4dotsSoftwareWebsiteToolStripMenuItem
            // 
            this.visit4dotsSoftwareWebsiteToolStripMenuItem.Image = global::ColorPicker.Properties.Resources.earth;
            this.visit4dotsSoftwareWebsiteToolStripMenuItem.Name = "visit4dotsSoftwareWebsiteToolStripMenuItem";
            resources.ApplyResources(this.visit4dotsSoftwareWebsiteToolStripMenuItem, "visit4dotsSoftwareWebsiteToolStripMenuItem");
            this.visit4dotsSoftwareWebsiteToolStripMenuItem.Click += new System.EventHandler(this.visit4dotsSoftwareWebsiteToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // txtRGB
            // 
            resources.ApplyResources(this.txtRGB, "txtRGB");
            this.txtRGB.Name = "txtRGB";
            // 
            // timPickColor
            // 
            this.timPickColor.Enabled = true;
            this.timPickColor.Tick += new System.EventHandler(this.timPickColor_Tick);
            // 
            // picPickColor
            // 
            this.picPickColor.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.picPickColor, "picPickColor");
            this.picPickColor.Name = "picPickColor";
            this.picPickColor.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Name = "label2";
            // 
            // txtHSL
            // 
            resources.ApplyResources(this.txtHSL, "txtHSL");
            this.txtHSL.Name = "txtHSL";
            // 
            // btnCopyHSL
            // 
            resources.ApplyResources(this.btnCopyHSL, "btnCopyHSL");
            this.btnCopyHSL.Image = global::ColorPicker.Properties.Resources.copy;
            this.btnCopyHSL.Name = "btnCopyHSL";
            this.btnCopyHSL.UseVisualStyleBackColor = true;
            this.btnCopyHSL.Click += new System.EventHandler(this.btnCopyHSL_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Name = "label3";
            // 
            // txtHex
            // 
            resources.ApplyResources(this.txtHex, "txtHex");
            this.txtHex.Name = "txtHex";
            // 
            // btnCopyHex
            // 
            resources.ApplyResources(this.btnCopyHex, "btnCopyHex");
            this.btnCopyHex.Image = global::ColorPicker.Properties.Resources.copy;
            this.btnCopyHex.Name = "btnCopyHex";
            this.btnCopyHex.UseVisualStyleBackColor = true;
            this.btnCopyHex.Click += new System.EventHandler(this.btnCopyHex_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Name = "label4";
            // 
            // notMain
            // 
            this.notMain.ContextMenuStrip = this.cmsMain;
            resources.ApplyResources(this.notMain, "notMain");
            // 
            // cmsMain
            // 
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.cmsMain.Name = "cmsMain";
            resources.ApplyResources(this.cmsMain, "cmsMain");
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            resources.ApplyResources(this.showToolStripMenuItem, "showToolStripMenuItem");
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::ColorPicker.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fplPalette
            // 
            resources.ApplyResources(this.fplPalette, "fplPalette");
            this.fplPalette.BackColor = System.Drawing.Color.Black;
            this.fplPalette.Name = "fplPalette";
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.fplPalette);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHex);
            this.Controls.Add(this.btnCopyHex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHSL);
            this.Controls.Add(this.btnCopyHSL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picPickColor);
            this.Controls.Add(this.txtRGB);
            this.Controls.Add(this.btnCopRGB);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblFromDesc);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowInTaskbar = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmReplaceColor_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMain_KeyPress);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPickColor)).EndInit();
            this.cmsMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFromDesc;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnCopRGB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txtRGB;
        private PicColorPictureBox picPickColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHSL;
        private System.Windows.Forms.Button btnCopyHSL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.Button btnCopyHex;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Timer timPickColor;
        private System.Windows.Forms.NotifyIcon notMain;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runMinimizedAtWindowsStartupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToSystemTrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem languages1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languages2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pleaseDonateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dotsSoftwarePRODUCTCATALOGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiHelpFeedback;
        private System.Windows.Forms.ToolStripMenuItem checkForNewVersionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem followUsOnTwitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visit4dotsSoftwareWebsiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePaletteAsPNGToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel fplPalette;
        private System.Windows.Forms.ToolStripMenuItem paletteNumberOfColorsToolStripMenuItem;
    }
}
