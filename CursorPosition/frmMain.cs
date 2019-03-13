// FTP update-write password :
// X7G6Wt6scWir5J9Bsw

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursorPosition
{
    public partial class frmMain : Form
    {
        private const string AppName = "CursorPos";
        //List<Point[]> listPoints;
        Point[] Points = new Point[4];
        Point LastPoint;

        ushort Interval;
        ushort Counter = 0;

        private bool TrailEnabled;
        private bool PointsEnabled;
        private bool PauseEnabled;
        Color TrailColor;
        Color PointColor;

        bool Startup;
        bool ShowFirstRun;
        Point WindowLocation;

        public frmMain()
        {
            InitializeComponent();

            // Placer le formulaire centré en haut de l'écran
            tsm_delay.KeyDown += tsm_delay_KeyDown;
            tsm_goto_x.KeyDown += tsm_goto_KeyDown;
            tsm_goto_y.KeyDown += tsm_goto_KeyDown;

            //listPoints = new List<Point[]>();

            Properties.Settings.Default.Reload();
            Interval = Properties.Settings.Default.Interval;

            TrailEnabled = Properties.Settings.Default.TrailEnable;
            PointsEnabled = Properties.Settings.Default.PointEnable;
            PauseEnabled = Properties.Settings.Default.PauseEnable;
            TrailColor = Properties.Settings.Default.TrailColor;
            PointColor = Properties.Settings.Default.PointColor;

            Startup = Properties.Settings.Default.Startup;
            ShowFirstRun = Properties.Settings.Default.ShowFirstRun;
            WindowLocation = Properties.Settings.Default.WindowLocation;

            SetStartup(Startup);
            tsm_trail_enable.Checked = TrailEnabled;
            tsm_points_enable.Checked = PointsEnabled;
            tsm_points_enable.Enabled = TrailEnabled;
            tsm_startup.Checked = Startup;
            tsm_pause.Checked = PauseEnabled;
            posTimer.Enabled = !PauseEnabled;
        }

        private void tsm_goto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tsm_goto.PerformClick();
        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);

        //    if (TrailEnabled)
        //    {
        //        IntPtr desktopPtr = GetDC(IntPtr.Zero);
        //        Graphics g = Graphics.FromHdc(desktopPtr);
        //        Pen pen = new Pen(TrailColor, 2);

        //        foreach (Point[] mPoints in listPoints)
        //        {
        //            g.DrawBeziers(pen, mPoints);
        //        }

        //        if (PointsEnabled)
        //        {
        //            Brush brush = new SolidBrush(PointColor);
        //            foreach (Point[] mPoints in listPoints)
        //            {
        //                g.FillEllipse(brush, new Rectangle(new Point(mPoints[3].X - 4, mPoints[3].Y - 4), new Size(8, 8)));
        //            }
        //        }
        //    }
        //}

        public void Draw()
        {
            if (TrailEnabled)
            {
                //listPoints.Add((Point[])Points.Clone());

                IntPtr desktopPtr = GetDC(IntPtr.Zero);
                Graphics g = Graphics.FromHdc(desktopPtr);

                Pen pen = new Pen(TrailColor, 2);

                g.DrawBeziers(pen, Points);

                if (PointsEnabled)
                {
                    Brush brush = new SolidBrush(PointColor);
                    LastPoint = Points[0];
                    g.FillEllipse(brush, new Rectangle(new Point(Points[3].X - 4, Points[3].Y - 4), new Size(8, 8)));
                    g.FillEllipse(brush, new Rectangle(new Point(LastPoint.X - 4, LastPoint.Y - 4), new Size(8, 8)));
                }

                g.Dispose();
                ReleaseDC(IntPtr.Zero, desktopPtr);
            }

            Counter = 1;
            Points[0] = Points[3];
            Array.Clear(Points, 1, 3);
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {   // Disable alt+f4
            if (e.KeyCode == Keys.F4 && e.Alt)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void tsm_delay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                contextMenuStrip.Close();
        }

        private void posTimer_Tick(object sender, EventArgs e)
        {
            if (Cursor.Position != Points[(((Counter - 1) >= 0) ? (Counter - 1) : 0)])
            {
                Points[Counter] = Cursor.Position;

                Counter++;

                if (Counter >= 4)
                    Draw();

                value_x.Text = Cursor.Position.X.ToString();
                value_y.Text = Cursor.Position.Y.ToString();
            }
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == tsm_trail_enable)
            {
                TrailEnabled = !TrailEnabled;
                tsm_trail_color.Enabled = TrailEnabled;
                tsm_points_enable.Enabled = TrailEnabled;
            }
            else if (e.ClickedItem == tsm_points_enable)
            {
                PointsEnabled = !PointsEnabled;
                tsm_points_color.Enabled = PointsEnabled;
            }
            else if (e.ClickedItem == tsm_pause)
            {
                PauseEnabled = !PauseEnabled;
                posTimer.Enabled = !PauseEnabled;
                tsm_goto_x.Text = value_x.Text;
                tsm_goto_y.Text = value_y.Text;
            }
            else if (e.ClickedItem == tsm_goto)
            {
                contextMenuStrip.Close();
                Application.DoEvents();

                if (ushort.TryParse(tsm_goto_x.Text, out ushort X) && ushort.TryParse(tsm_goto_y.Text, out ushort Y))
                {
                    Cursor.Position = new Point(X, Y);
                }
                else
                {
                    MessageBox.Show("Error, incorrect values !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.ClickedItem == tsm_trail_color)
            {
                colorDialog.Color = TrailColor;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    TrailColor = colorDialog.Color;
                }
            }
            else if (e.ClickedItem == tsm_points_color)
            {
                colorDialog.Color = PointColor;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    PointColor = colorDialog.Color;
                }
            }
            else if (e.ClickedItem == tsm_startup)
            {
                Startup = !Startup;
                SetStartup(Startup);
            }
            else if (e.ClickedItem == tsm_reset)
            {
                if (MessageBox.Show("Are you sure you want to reset settings ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Properties.Settings.Default.Reset();
                    Properties.Settings.Default.Reload();
                    Application.Restart();
                }
            }
            else if (e.ClickedItem == tsm_quit)
            {
                this.Close();
            }
        }

        #region Others

        // Permet de cacher le formulaire de ALT+TAB
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // turn on WS_EX_TOOLWINDOW style bit
                cp.ExStyle |= 0x80;
                return cp;
            }
        }

        // Permet de dessiner sur l'écran

        [DllImport("User32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);
        [DllImport("User32.dll")]
        public static extern void ReleaseDC(IntPtr hwnd, IntPtr dc);

        #endregion

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            tsm_delay.Text = Interval.ToString();
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Cursor.Position.X <= (Screen.PrimaryScreen.Bounds.Width - this.Size.Width))
                    this.Location = new Point(Cursor.Position.X, this.Location.Y);
                if (Cursor.Position.Y <= (Screen.PrimaryScreen.Bounds.Height - this.Size.Height))
                    this.Location = new Point(this.Location.X, Cursor.Position.Y);
            }
        }

        private void SetStartup(bool runOnStartup)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (runOnStartup)
                rk.SetValue(AppName, Application.ExecutablePath.ToString());
            else
                rk.DeleteValue(AppName, false);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Properties.Settings.Default.TrailEnable = TrailEnabled;
            Properties.Settings.Default.PointEnable = PointsEnabled;
            Properties.Settings.Default.PauseEnable = PauseEnabled;
            Properties.Settings.Default.TrailColor = TrailColor;
            Properties.Settings.Default.PointColor = PointColor;
            Properties.Settings.Default.Interval = Interval;
            Properties.Settings.Default.Startup = Startup;
            Properties.Settings.Default.WindowLocation = this.Location;
            Properties.Settings.Default.Save();

        }

        private void CheckInterval()
        {
            if ((ushort.TryParse(tsm_delay.Text, out ushort delay) && (delay > 0)))
            {
                Interval = delay;
                posTimer.Interval = Interval;
            }
            else
            {
                MessageBox.Show($"Value must be between 1 and 9999", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void contextMenuStrip_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            CheckInterval();
        }
    }
}