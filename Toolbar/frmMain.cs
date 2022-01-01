using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toolbox
{
    public partial class frmMain : Form
    {
        private const string APP_NAME = "ToolBar";

        public frmMain()
        {
            InitializeComponent();
            Properties.Settings.Default.Reload();
            box_notif.Checked = Properties.Settings.Default.Notification;
            box_edges.Checked = Properties.Settings.Default.Edges;
            box_taskbar.Checked = Properties.Settings.Default.Taskbar;
            box_title.Checked = Properties.Settings.Default.TitleBar;
            box_topmost.Checked = Properties.Settings.Default.Topmost;
            button_volume.Checked = Properties.Settings.Default.Tool_Volume;
            button_cursor.Checked = Properties.Settings.Default.Tool_Cursor;
            button_clipboard.Checked = Properties.Settings.Default.Tool_Clipboard;
            box_startup.Checked = Properties.Settings.Default.Startup;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            SaveSettings();
            notification.Visible = true;
            this.Hide();
        }

        private void box_topmost_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = box_topmost.Checked;
        }

        private void box_title_CheckedChanged(object sender, EventArgs e)
        {
            this.FormBorderStyle = box_title.Checked ? FormBorderStyle.FixedToolWindow : FormBorderStyle.None;
        }

        private void box_taskbar_CheckedChanged(object sender, EventArgs e)
        {
            this.ShowInTaskbar = box_taskbar.Checked;
        }

        private void notification_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.TopMost = true;
                this.TopMost = box_topmost.Checked;
            }
        }

        private void tsm_show_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Show();
            this.TopMost = true;
            this.TopMost = box_topmost.Checked;
            Application.DoEvents();
            notification.Visible = box_notif.Checked;
        }

        private void tsm_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void box_settings_CheckedChanged(object sender, EventArgs e)
        {
            panel_settings.Visible = box_settings.Checked;
            if (!box_settings.Checked)
                SaveSettings();
        }

        private void box_edges_CheckedChanged(object sender, EventArgs e)
        {
            panel_main_r.Visible = box_edges.Checked;
            panel_settings_l.Visible = box_edges.Checked;
            panel_main_l.Visible = box_edges.Checked;
            panel_settings_r.Visible = box_edges.Checked;
        }

        private void box_notif_CheckedChanged(object sender, EventArgs e)
        {
            this.notification.Visible = box_notif.Checked;
        }

        #region Drag on edges
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void panels_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void panels_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void panels_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        SoundReducer.frmMain SoundReducer;
        private void button_volume_CheckedChanged(object sender, EventArgs e)
        {
            if (button_volume.Checked)
            {
                SoundReducer = new SoundReducer.frmMain();
                try
                {
                    SoundReducer.Show();
                    SoundReducer.FormClosed += delegate { button_volume.Checked = false; };
                }
                catch (Exception)
                {
                    button_volume.Checked = false;
                    SoundReducer.Dispose();
                }
            }
            else
            {
                SoundReducer.Close();
                SoundReducer.Dispose();
            }
        }

        CursorPosition.frmMain cursorPosition;
        private void button_cursor_CheckedChanged(object sender, EventArgs e)
        {
            if (button_cursor.Checked)
            {
                cursorPosition = new CursorPosition.frmMain();
                cursorPosition.Show();
                cursorPosition.FormClosed += delegate { button_cursor.Checked = false; };
            }
            else
            {
                cursorPosition.Close();
                cursorPosition.Dispose();
            }
        }

        ClipboardManager.frmMain clipboardManager;
        private void button_clipboard_CheckedChanged(object sender, EventArgs e)
        {
            if (button_clipboard.Checked)
            {
                clipboardManager = new ClipboardManager.frmMain();
                clipboardManager.Show();
                clipboardManager.FormClosed += delegate { button_clipboard.Checked = false; };
            }
            else
            {
                clipboardManager.Close();
                clipboardManager.Dispose();
            }
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.Notification = box_notif.Checked;
            Properties.Settings.Default.Edges = box_edges.Checked;
            Properties.Settings.Default.Taskbar = box_taskbar.Checked;
            Properties.Settings.Default.TitleBar = box_title.Checked;
            Properties.Settings.Default.Topmost = box_topmost.Checked;
            Properties.Settings.Default.Tool_Volume = button_volume.Checked;
            Properties.Settings.Default.Tool_Cursor = button_cursor.Checked;
            Properties.Settings.Default.Tool_Clipboard = button_clipboard.Checked;
            Properties.Settings.Default.Startup = box_startup.Checked;
            Properties.Settings.Default.Save();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
            SoundReducer?.Close();
            cursorPosition?.Close();
            clipboardManager?.Close();
            Application.DoEvents();
        }

        private void box_startup_CheckedChanged(object sender, EventArgs e)
        {
            EsseivaN.Tools.Tools.SetStartup(APP_NAME, box_startup.Checked);
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void notification_DoubleClick(object sender, EventArgs e)
        {
            tsm_show.PerformClick();
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else if (this.WindowState == FormWindowState.Minimized)
                button_minimize.PerformClick();
        }
    }
}
