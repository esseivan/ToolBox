using EsseivaN.Controls;
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

namespace ClipboardManager
{
    public partial class frmMain : Form
    {
        HashSet<string> ClipboardList = new HashSet<string>();
        private ushort Column = 0;
        private ushort Row = 0;

        public frmMain()
        {
            InitializeComponent();
            
            Properties.Settings.Default.Reload();
            this.TopMost = Properties.Settings.Default.Topmost;
            this.tsm_top.Checked = Properties.Settings.Default.Topmost;
            this.tsm_popup.Checked = Properties.Settings.Default.Popup;


            tableLayoutPanel1.HorizontalScroll.Maximum = 0;
            tableLayoutPanel1.AutoScroll = false;
            tableLayoutPanel1.VerticalScroll.Visible = false;
            tableLayoutPanel1.AutoScroll = true;
            ClipboardNotification.ClipboardUpdate += ClipboardNotification_ClipboardUpdate;
            UpdateClipboard((DataObject)Clipboard.GetDataObject());

        }

        private void ClipboardNotification_ClipboardUpdate(object sender, EventArgs e)
        {
            this.TopMost = tsm_popup.Checked;
            this.TopMost = tsm_top.Checked;
            UpdateClipboard((DataObject)Clipboard.GetDataObject());
        }

        private void UpdateClipboard(DataObject dataObject, bool Add = true)
        {
            try
            {
                if (Add)
                    ClipboardList.Add(dataObject.GetData(DataFormats.UnicodeText).ToString());
            }
            catch (Exception) { }

            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.AutoScroll = false;
            tableLayoutPanel1.AutoScroll = true;
            Column = 0;
            Row = 0;
            foreach (string text in ClipboardList)
            {
                TextPanel textPanel = new TextPanel(text, Color.LightBlue);
                textPanel.Clipboard_Delete += TextPanel_Clipboard_Delete;
                tableLayoutPanel1.Controls.Add(textPanel, Column, Row);
                if (++Column % 3 == 0)
                {
                    Column = 0;
                    Row++;
                }
            }
        }

        private void TextPanel_Clipboard_Delete(object sender, EventArgs e)
        {
            ClipboardList.Remove((string)sender);
            UpdateClipboard(null, false);
        }

        private void qutiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsm_top_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = tsm_top.Checked;
            tsm_popup.Enabled = !tsm_top.Checked;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

            Properties.Settings.Default.Topmost = tsm_top.Checked;
            Properties.Settings.Default.Popup = tsm_popup.Checked;
            Properties.Settings.Default.Save();
        }

        private void tsm_clearcurrent_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }

        private void tsm_clearall_Click(object sender, EventArgs e)
        {
            ClipboardList.Clear();
            UpdateClipboard(null, false);
        }
    }

    /// <summary>
    /// Provides notifications when the contents of the clipboard is updated.
    /// </summary>
    public sealed class ClipboardNotification
    {
        /// <summary>
        /// Occurs when the contents of the clipboard is updated.
        /// </summary>
        public static event EventHandler ClipboardUpdate;

        private static NotificationForm _form = new NotificationForm();

        /// <summary>
        /// Raises the <see cref="ClipboardUpdate"/> event.
        /// </summary>
        /// <param name="e">Event arguments for the event.</param>
        private static void OnClipboardUpdate(EventArgs e)
        {
            var handler = ClipboardUpdate;
            if (handler != null)
            {
                handler(null, e);
            }
        }

        /// <summary>
        /// Hidden form to recieve the WM_CLIPBOARDUPDATE message.
        /// </summary>
        private class NotificationForm : Form
        {
            public NotificationForm()
            {
                NativeMethods.SetParent(Handle, NativeMethods.HWND_MESSAGE);
                NativeMethods.AddClipboardFormatListener(Handle);
            }

            protected override void WndProc(ref Message m)
            {
                if (m.Msg == NativeMethods.WM_CLIPBOARDUPDATE)
                {
                    OnClipboardUpdate(null);
                }
                base.WndProc(ref m);
            }
        }

        internal static class NativeMethods
        {
            // See http://msdn.microsoft.com/en-us/library/ms649021%28v=vs.85%29.aspx
            public const int WM_CLIPBOARDUPDATE = 0x031D;
            public static IntPtr HWND_MESSAGE = new IntPtr(-3);

            // See http://msdn.microsoft.com/en-us/library/ms632599%28VS.85%29.aspx#message_only
            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool AddClipboardFormatListener(IntPtr hwnd);

            // See http://msdn.microsoft.com/en-us/library/ms633541%28v=vs.85%29.aspx
            // See http://msdn.microsoft.com/en-us/library/ms649033%28VS.85%29.aspx
            [DllImport("user32.dll", SetLastError = true)]
            public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        }
    }
}
