using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace ColorPicker
{
    public partial class frmMain : ColorPicker.CustomForm
    {
        public static frmMain Instance = null;

        private bool forColorPickOnly = false;

        public frmMain(bool hide)
        {
            InitializeComponent();

            Instance = this;

            InterceptKeys.HookKeys();

            if (hide)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Visible = false;
            }
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //3frmMain.Instance.MainImageArgs.PickColorMode = 0;

            //3frmMain.Instance.Cursor = null;

            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFromColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = lblColor.BackColor;
            colorDialog1.FullOpen = true;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                lblColor.BackColor = colorDialog1.Color;
            }               
        }

        private void btnToColor_Click(object sender, EventArgs e)
        {
            
        }

        private void frmReplaceColor_Load(object sender, EventArgs e)
        {
            lblColor.BackColor = Properties.Settings.Default.ReplaceColorFrom;
            
            tbReplaceColor_Scroll(null, null);

            lblFromColor_BackColorChanged(null, null);
            
            lblToColor_BackColorChanged(null, null);

            picPickColor.Image = bmp1;

            SetupOnLoad();
        }

        private void tbReplaceColor_Scroll(object sender, EventArgs e)
        {
            
        }

        private void btnFromColorPick_Click(object sender, EventArgs e)
        {
            /*
            frmMain.Instance.Cursor = Cursors.Cross;

            frmMain.Instance.MainImageArgs.PickColorMode = 1;
            */

            picPickColor.Visible = true;

            //lblPickColor.Visible = true;
        }

        private void btnToColorPick_Click(object sender, EventArgs e)
        {
            /*
            frmMain.Instance.Cursor = Cursors.Cross;

            frmMain.Instance.MainImageArgs.PickColorMode = 2;
            */

            picPickColor.Visible = true;

            //lblPickColor.Visible = true;
        }

        public void lblFromColor_BackColorChanged(object sender, EventArgs e)
        {
            GetColorString(lblColor.BackColor);
        }

        public string GetColorString(Color c)
        {
            double hue;
            double saturation;
            double value;            

            //3ColorToHSV(c,out hue,out saturation,out value);
            /*
            int ihue = (int)(240 * hue);
            int isat = (int)(240 * saturation);
            int ival = (int)(240 * value);            
            */
            
            //240 1
            // x  getsat

            // 240 360
            // x  gethue
            /*
            int isat = (int)(240 * c.GetSaturation());
            int ival = (int)(240 * c.GetBrightness());

            int ihue = (int)((c.GetHue()/360));
            */
            txtRGB.Text = c.R.ToString() + " ," + c.G.ToString() + " ," + c.B.ToString(); // +" ," + c.A.ToString();

            //3txtHSL.Text = hue.ToString("#0.0##") + " ," + saturation.ToString("#0.0##") + " ," + value.ToString("#0.0##");
            //3txtHSL.Text = c.GetHue().ToString() + " ," + c.GetSaturation().ToString() + " ," + c.GetBrightness().ToString();

            HSLColor hc = new HSLColor(c);

            txtHSL.Text = hc.ToString();

            //txtHSL.Text = ihue.ToString() + " ," + isat.ToString() + " ," + ival.ToString();

            txtHex.Text = "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");

            /*
            return "R:" + c.R.ToString() + " G:" + c.G.ToString() + " B:" + c.B.ToString() + " A:" + c.A.ToString()
                + " - H:" + hue.ToString("#0.0##") + " S:" + saturation.ToString("#0.0##") + " V:" + value.ToString("#0.0##")
                + " Hex: #" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");*/

            return string.Empty;
        }

        private void lblToColor_BackColorChanged(object sender, EventArgs e)
        {
            
        }

        public static void ColorToHSV(Color color, out double hue, out double saturation, out double value)
        {
            int max = Math.Max(color.R, Math.Max(color.G, color.B));
            int min = Math.Min(color.R, Math.Min(color.G, color.B));

            hue = color.GetHue();
            saturation = (max == 0) ? 0 : 1d - (1d * min / max);
            value = max / 255d;
        }

        public void btnCopyFrom_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(txtRGB.Text);
        }

        private void btnToCopy_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            
        }


        enum IDC_STANDARD_CURSORS : uint
        {
            IDC_ARROW = 32512,
            IDC_IBEAM = 32513,
            IDC_WAIT = 32514,
            IDC_CROSS = 32515,
            IDC_UPARROW = 32516,
            IDC_SIZE = 32640,
            IDC_ICON = 32641,
            IDC_SIZENWSE = 32642,
            IDC_SIZENESW = 32643,
            IDC_SIZEWE = 32644,
            IDC_SIZENS = 32645,
            IDC_SIZEALL = 32646,
            IDC_NO = 32648,
            IDC_APPSTARTING = 32650,
            IDC_HELP = 32651
        }

        [DllImport("user32.dll")]
        static extern bool SetSystemCursor(IntPtr hcur, uint id);

        [DllImport("user32.dll")]
        static extern IntPtr LoadCursor(IntPtr hInstance, int lpCursorName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SystemParametersInfo(UInt32 uiAction, UInt32
        uiParam, String pvParam, UInt32 fWinIni);

        [DllImport("user32.dll")]
        public static extern IntPtr CopyIcon(IntPtr pcur);

        private static uint CROSS = 32515;
        private static uint NORMAL = 32512;
        private static uint IBEAM = 32513;        

        private void SetSystemCursorCross()
        {
            SetSystemCursor(CopyIcon(LoadCursor(IntPtr.Zero, (int)CROSS)), NORMAL);
            SetSystemCursor(CopyIcon(LoadCursor(IntPtr.Zero, (int)CROSS)), IBEAM);

            //SystemParametersInfo(0x0057, 0, null, 0);
        }

        private void SetSystemCursorNormal()
        {
            SetSystemCursor(CopyIcon(LoadCursor(IntPtr.Zero, (int)NORMAL)), NORMAL);
            SetSystemCursor(CopyIcon(LoadCursor(IntPtr.Zero, (int)IBEAM)), IBEAM);

            SystemParametersInfo(0x0057, 0, null, 0);
        }

        private void SetupOnLoad()
        {                       
            this.Text = Module.ApplicationTitle;
            
            AddLanguageMenuItems();            

            AdjustSizeLocation();

            this.AcceptButton = null;

            SetSystemCursorCross();

            RegistryKey key = Registry.CurrentUser;

            try
            {
                key = key.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", false);

                if (key != null)
                {
                    if (key.GetValue(Module.ApplicationName) != null)
                    {
                        runMinimizedAtWindowsStartupToolStripMenuItem.Checked = true;
                    }

                    key.Close();
                }                
            }
            catch (Exception ex)
            {
                Module.ShowError("Error could not read Registry !", ex.Message);
            }

            ResizeControls();

            SetupPaletteColors();
        }

        public void SetPaletteColor()
        {
            bool found = false;

            for (int k = 0; k < fplPalette.Controls.Count;k++)
            {
                picPalette pic = (picPalette)fplPalette.Controls[k];

                if (pic.WasSet) continue;
                else
                {
                    found = true;

                    pic.WasSet = true;

                    pic.BackColor = lblColor.BackColor;

                    break;
                }
            }

            if (!found)
            {
                picPalette pic = (picPalette)fplPalette.Controls[0];

                pic.BackColor = lblColor.BackColor;
            }
        }
        private void SetupPaletteColors()
        {
            fplPalette.Controls.Clear();

            fplPalette.SuspendLayout();

            string[] sz = Properties.Settings.Default.PaletteColors.Split(new string[] { "|||" }, StringSplitOptions.None);

            for (int k=0;k<Properties.Settings.Default.ColorNumber;k++)
            {
                picPalette pic = new picPalette();
                pic.Width = 16;
                pic.Height = 16;

                if (k<sz.Length)
                {
                    if (sz[k].Length == 11)
                    {
                        string sr = sz[k].Substring(0, 3);
                        string sg = sz[k].Substring(4, 3);
                        string sb = sz[k].Substring(8, 3);

                        int r = int.Parse(sr);
                        int g = int.Parse(sg);
                        int b = int.Parse(sb);

                        pic.BackColor = Color.FromArgb(r, g, b);
                        pic.WasSet = true;
                    }
                    else
                    {
                        pic.BackColor = Color.White;
                    }
                }
                else
                {
                    pic.BackColor = Color.White;
                }

                fplPalette.Controls.Add(pic);

                if (fplPalette.Controls.Count > 0)
                {
                    if ((fplPalette.Controls[fplPalette.Controls.Count - 1].Right + pic.Width + 12) >= fplPalette.Width)
                    {
                        fplPalette.SetFlowBreak(pic, true);
                    }
                }

            }

            fplPalette.ResumeLayout();
        }
        #region Language - Size

        private void AdjustSizeLocation()
        {
            if (Properties.Settings.Default.Left != -1)
            {
                this.Left = Properties.Settings.Default.Left;
            }

            if (Properties.Settings.Default.Top != -1)
            {
                this.Top = Properties.Settings.Default.Top;
            }

            if (this.Left < 0)
            {
                this.Left = 0;
            }

            if (this.Top < 0)
            {
                this.Top = 0;
            }
        }

        private void SaveSizeLocation()
        {            
            Properties.Settings.Default.Left = this.Left;
            Properties.Settings.Default.Top = this.Top;
            
            Properties.Settings.Default.Save();
        }

        #region Localization

        private void AddLanguageMenuItems()
        {
            for (int k = 0; k < frmLanguage.LangCodes.Count; k++)
            {
                ToolStripMenuItem ti = new ToolStripMenuItem();
                ti.Text = frmLanguage.LangDesc[k];
                ti.Tag = frmLanguage.LangCodes[k];
                ti.Image = frmLanguage.LangImg[k];

                if (Properties.Settings.Default.Language == frmLanguage.LangCodes[k])
                {
                    ti.Checked = true;
                }

                ti.Click += new EventHandler(tiLang_Click);

                if (k < 25)
                {
                    languages1ToolStripMenuItem.DropDownItems.Add(ti);
                }
                else
                {
                    languages2ToolStripMenuItem.DropDownItems.Add(ti);
                }

                //languageToolStripMenuItem.DropDownItems.Add(ti);
            }
        }

        void tiLang_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem ti = (ToolStripMenuItem)sender;
            string langcode = ti.Tag.ToString();
            ChangeLanguage(langcode);

            //for (int k = 0; k < languageToolStripMenuItem.DropDownItems.Count; k++)
            for (int k = 0; k < languages1ToolStripMenuItem.DropDownItems.Count; k++)
            {
                ToolStripMenuItem til = (ToolStripMenuItem)languages1ToolStripMenuItem.DropDownItems[k];
                if (til == ti)
                {
                    til.Checked = true;
                }
                else
                {
                    til.Checked = false;
                }
            }

            for (int k = 0; k < languages2ToolStripMenuItem.DropDownItems.Count; k++)
            {
                ToolStripMenuItem til = (ToolStripMenuItem)languages2ToolStripMenuItem.DropDownItems[k];
                if (til == ti)
                {
                    til.Checked = true;
                }
                else
                {
                    til.Checked = false;
                }
            }
        }

        private bool InChangeLanguage = false;

        private void ChangeLanguage(string language_code)
        {
            try
            {
                InChangeLanguage = true;

                Properties.Settings.Default.Language = language_code;
                frmLanguage.SetLanguage();

                bool maximized = (this.WindowState == FormWindowState.Maximized);
                this.WindowState = FormWindowState.Normal;

                /*
                RegistryKey key = Registry.CurrentUser;
                RegistryKey key2 = Registry.CurrentUser;

                try
                {
                    key = key.OpenSubKey("Software\\4dots Software", true);

                    if (key == null)
                    {
                        key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\4dots Software");
                    }

                    key2 = key.OpenSubKey(frmLanguage.RegKeyName, true);

                    if (key2 == null)
                    {
                        key2 = key.CreateSubKey(frmLanguage.RegKeyName);
                    }

                    key = key2;

                    //key.SetValue("Language", language_code);
                    key.SetValue("Menu Item Caption", TranslateHelper.Translate("Change PDF Properties"));
                }
                catch (Exception ex)
                {
                    Module.ShowError(ex);
                    return;
                }
                finally
                {
                    key.Close();
                    key2.Close();
                }
                */
                //1SaveSizeLocation();

                //3SavePositionSize();

                this.Controls.Clear();

                InitializeComponent();

                SetupOnLoad();

                if (maximized)
                {
                    this.WindowState = FormWindowState.Maximized;
                }

                this.ResumeLayout(true);
            }
            finally
            {
                InChangeLanguage = false;
            }
        }

        #endregion


        #endregion

        #region Help

        private void helpGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Module.HelpURL);
        }

        private void pleaseDonateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.4dots-software.com/donate.php");
        }

        private void dotsSoftwarePRODUCTCATALOGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.4dots-software.com/downloads/4dots-Software-PRODUCT-CATALOG.pdf");
        }

        private void tiHelpFeedback_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.4dots-software.com/support/bugfeature.php?app=" + System.Web.HttpUtility.UrlEncode(Module.ShortApplicationTitle));
        }

        private void checkForNewVersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateHelper.CheckVersion(false);
        }

        private void followUsOnTwitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.twitter.com/4dotsSoftware");
        }

        private void visit4dotsSoftwareWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.4dots-software.com");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout f = new frmAbout();
            f.ShowDialog();
        }        

        #endregion

        public Bitmap bmp1 = new Bitmap(60, 60);

        public bool InPaint = false;

        public void timPickColor_Tick(object sender, EventArgs e)
        {
            try
            {
                if (InPaint) return;

                int x = Control.MousePosition.X;
                int y = Control.MousePosition.Y;

                int width = 60;

                using (Graphics g = Graphics.FromImage(bmp1))
                {
                    g.Clear(Color.DimGray);

                    g.CopyFromScreen(x - width / 2, y - width / 2, 0, 0, new Size(width, width));
                }

                picPickColor.Refresh();

                //this.Left = x + 50;
                //this.Top = y + 50;
            }
            catch { }
        }

        private void picPickColor_Paint(object sender, PaintEventArgs e)
        {
            int a = 1;

        }

        public void CopyAll()
        {
            Clipboard.Clear();
            Clipboard.SetText("RGB:"+txtRGB.Text + Environment.NewLine + "HSL:"+txtHSL.Text + Environment.NewLine + "Hex:"+txtHex.Text);
        }
        public void btnCopyHSL_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(txtHSL.Text);
        }

        public void btnCopyHex_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(txtHex.Text);
        }

        private void frmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                timPickColor.Enabled = !timPickColor.Enabled;
            }
        }

        private void SavePaletteColors()
        {
            string str = "";

            for (int k = 0; k < fplPalette.Controls.Count; k++)
            {
                picPalette pic = (picPalette)fplPalette.Controls[k];

                if (pic.WasSet)
                {
                    str += pic.BackColor.R.ToString("D3") + "-" +
                        pic.BackColor.G.ToString("D3") + "-" +
                        pic.BackColor.B.ToString("D3") + "|||";
                }
                else
                {
                    str += "|||";
                }
            }

            Properties.Settings.Default.PaletteColors = str;

            Properties.Settings.Default.Save();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SavePaletteColors();

            SetSystemCursorNormal();

            InterceptKeys.UnHookAll();

            Properties.Settings.Default.Save();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [System.Runtime.InteropServices.DllImport("coredll.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern bool EnableWindow(IntPtr hwnd, bool enabled);
        private int SW_SHOW=5;

        private bool InShowing = false;

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                InShowing = true;

                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
                this.Visible = true;
                this.BringToFront();

                this.WindowState = FormWindowState.Normal;
                this.Visible = true;
                this.BringToFront();

                SetSystemCursorCross();

            }
            finally
            {
                InShowing = false;
            }
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (InShowing) return;

            if (this.WindowState == FormWindowState.Minimized)
            {
                if (Properties.Settings.Default.MinimizeSystemTray)
                {
                    this.Visible = false;
                }

                SetSystemCursorNormal();
            }
            else
            {
                SetSystemCursorCross();
            }
        }

        private void runMinimizedAtWindowsStartupToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            RegistryKey key = Registry.CurrentUser;

            try
            {
                key = key.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);

                if (key != null)
                {
                    if (key.GetValue(Module.ApplicationName) != null)
                    {
                        key.DeleteValue(Module.ApplicationName);
                    }

                    if (!runMinimizedAtWindowsStartupToolStripMenuItem.Checked)
                    {
                        key.SetValue(Module.ApplicationName, "\"" + Application.ExecutablePath + "\" /hide");
                    }

                    runMinimizedAtWindowsStartupToolStripMenuItem.Checked = !runMinimizedAtWindowsStartupToolStripMenuItem.Checked;

                    key.Close();
                }
            }
            catch (Exception ex)
            {
                Module.ShowError("Error could not read Registry !", ex.Message);
            }
            finally
            {
                if (key != null)
                {
                    try
                    {
                        key.Close();
                    }
                    catch { }
                }
            }
        }

        private void minimizeToSystemTrayToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void minimizeToSystemTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            minimizeToSystemTrayToolStripMenuItem.Checked = !minimizeToSystemTrayToolStripMenuItem.Checked;

            Properties.Settings.Default.MinimizeSystemTray = minimizeToSystemTrayToolStripMenuItem.Checked;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void paletteNumberOfColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaletteColors f = new frmPaletteColors();

            if (f.ShowDialog(this)==DialogResult.OK)
            {
                SavePaletteColors();

                SetupPaletteColors();
            }
        }

        private void savePaletteAsPNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Files (*.png)|*.png";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                int x = 0;
                int y = 0;
                int maxx = 0;
                int maxy = 0;

                int curx = 0;
                int cury = 0;

                for (int k = 0; k < fplPalette.Controls.Count; k++)
                {
                    if (k == 0)
                    {
                        y = fplPalette.Controls[k].Top;
                        cury = fplPalette.Controls[k].Top;
                    }

                    if (fplPalette.Controls[k].Top != y)
                    {
                        x = 0;
                        y = fplPalette.Controls[k].Top;

                        curx = 0;
                        cury += fplPalette.Controls[k].Height + 1;
                    }                    

                    curx += fplPalette.Controls[k].Width + 1;

                    maxx = Math.Max(curx+ fplPalette.Controls[k].Width + 1, maxx);
                    maxy = Math.Max(cury+ fplPalette.Controls[k].Height + 1, maxy);
                }

                Bitmap bmp = new Bitmap(maxx, maxy);

                using (Graphics g = Graphics.FromImage(bmp))
                {
                    x = 0;
                    y = 0;

                    curx = 0;
                    cury = 0;

                    for (int k=0;k<fplPalette.Controls.Count;k++)
                    {
                        if (k==0)
                        {
                            y = fplPalette.Controls[k].Top;
                            cury = fplPalette.Controls[k].Top;
                        }

                        if (fplPalette.Controls[k].Top!=y)
                        {
                            x = 0;
                            y = fplPalette.Controls[k].Top;

                            curx = 0;
                            cury += fplPalette.Controls[k].Height + 1;
                        }

                        g.DrawRectangle(Pens.Black, curx, cury, 17, 17);

                        SolidBrush sb = new SolidBrush(fplPalette.Controls[k].BackColor);

                        g.FillRectangle(sb, curx + 1, cury + 1, 16, 16);

                        sb.Dispose();

                        curx += fplPalette.Controls[k].Width + 1;
                    }

                    bmp.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
        }
    }

    public class PicColorPictureBox : PictureBox
    {
        public PicColorPictureBox():base()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
 	        base.OnPaint(pe);

            if (frmMain.Instance == null) return;

            try
            {
                frmMain.Instance.InPaint = true;

                pe.Graphics.Clear(Color.DimGray);

                int width = 60;

                pe.Graphics.DrawImage(frmMain.Instance.bmp1, new Rectangle(0, 0, 180, 180), new Rectangle(0, 0, width, width), GraphicsUnit.Pixel);

                int cw = 5;

                pe.Graphics.DrawLine(Pens.DimGray, this.Width / 2 - cw, this.Height / 2, this.Width / 2 - 1, this.Height / 2);
                pe.Graphics.DrawLine(Pens.DimGray, this.Width / 2 + 1, this.Height / 2, this.Width / 2 + cw, this.Height / 2);

                pe.Graphics.DrawLine(Pens.DimGray, this.Width / 2, this.Height / 2 - cw, this.Width / 2, this.Height / 2 - 1);
                pe.Graphics.DrawLine(Pens.DimGray, this.Width / 2, this.Height / 2 + 1, this.Width / 2, this.Height / 2 + cw);

                Color c = frmMain.Instance.bmp1.GetPixel(frmMain.Instance.bmp1.Width / 2, frmMain.Instance.bmp1.Height / 2);

                frmMain.Instance.lblColor.BackColor = c;
                frmMain.Instance.lblFromColor_BackColorChanged(null, null);
            }
            finally
            {
                frmMain.Instance.InPaint = false;
            }
        }
    }

}
