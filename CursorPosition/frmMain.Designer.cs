namespace CursorPosition
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
            this.label_x = new System.Windows.Forms.Label();
            this.value_x = new System.Windows.Forms.Label();
            this.label_y = new System.Windows.Forms.Label();
            this.value_y = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_trail_enable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_points_enable = new System.Windows.Forms.ToolStripMenuItem();
            this.tss4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsm_pause = new System.Windows.Forms.ToolStripMenuItem();
            this.tss5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsm_goto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_goto_x = new System.Windows.Forms.ToolStripTextBox();
            this.tsm_goto_y = new System.Windows.Forms.ToolStripTextBox();
            this.tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsm_trail_color = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_points_color = new System.Windows.Forms.ToolStripMenuItem();
            this.tss2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsm_delay_label = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_delay = new System.Windows.Forms.ToolStripTextBox();
            this.tss3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsm_startup = new System.Windows.Forms.ToolStripMenuItem();
            this.tss6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsm_reset = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_quit = new System.Windows.Forms.ToolStripMenuItem();
            this.posTimer = new System.Windows.Forms.Timer(this.components);
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_x
            // 
            this.label_x.BackColor = System.Drawing.Color.Transparent;
            this.label_x.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_x.Location = new System.Drawing.Point(0, 0);
            this.label_x.Margin = new System.Windows.Forms.Padding(3);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(20, 19);
            this.label_x.TabIndex = 0;
            this.label_x.Text = "X :";
            this.label_x.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_x.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            // 
            // value_x
            // 
            this.value_x.BackColor = System.Drawing.Color.Transparent;
            this.value_x.Dock = System.Windows.Forms.DockStyle.Left;
            this.value_x.Location = new System.Drawing.Point(20, 0);
            this.value_x.Margin = new System.Windows.Forms.Padding(3);
            this.value_x.Name = "value_x";
            this.value_x.Size = new System.Drawing.Size(43, 19);
            this.value_x.TabIndex = 1;
            this.value_x.Text = "-";
            this.value_x.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.value_x.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            // 
            // label_y
            // 
            this.label_y.BackColor = System.Drawing.Color.Transparent;
            this.label_y.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_y.Location = new System.Drawing.Point(63, 0);
            this.label_y.Margin = new System.Windows.Forms.Padding(3);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(20, 19);
            this.label_y.TabIndex = 0;
            this.label_y.Text = "Y :";
            this.label_y.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_y.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            // 
            // value_y
            // 
            this.value_y.BackColor = System.Drawing.Color.Transparent;
            this.value_y.Dock = System.Windows.Forms.DockStyle.Left;
            this.value_y.Location = new System.Drawing.Point(83, 0);
            this.value_y.Margin = new System.Windows.Forms.Padding(3);
            this.value_y.Name = "value_y";
            this.value_y.Size = new System.Drawing.Size(43, 19);
            this.value_y.TabIndex = 1;
            this.value_y.Text = "-";
            this.value_y.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.value_y.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_trail_enable,
            this.tsm_points_enable,
            this.tss4,
            this.tsm_pause,
            this.tss5,
            this.tsm_goto,
            this.tsm_goto_x,
            this.tsm_goto_y,
            this.tss1,
            this.tsm_trail_color,
            this.tsm_points_color,
            this.tss2,
            this.tsm_delay_label,
            this.tsm_delay,
            this.tss3,
            this.tsm_startup,
            this.tss6,
            this.tsm_reset,
            this.tsm_quit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip.ShowCheckMargin = true;
            this.contextMenuStrip.ShowImageMargin = false;
            this.contextMenuStrip.Size = new System.Drawing.Size(216, 335);
            this.contextMenuStrip.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenuStrip_Closed);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // tsm_trail_enable
            // 
            this.tsm_trail_enable.CheckOnClick = true;
            this.tsm_trail_enable.Name = "tsm_trail_enable";
            this.tsm_trail_enable.Size = new System.Drawing.Size(215, 22);
            this.tsm_trail_enable.Text = "Toggle trail";
            // 
            // tsm_points_enable
            // 
            this.tsm_points_enable.CheckOnClick = true;
            this.tsm_points_enable.Name = "tsm_points_enable";
            this.tsm_points_enable.Size = new System.Drawing.Size(215, 22);
            this.tsm_points_enable.Text = "Toggle point indicator";
            // 
            // tss4
            // 
            this.tss4.Name = "tss4";
            this.tss4.Size = new System.Drawing.Size(212, 6);
            // 
            // tsm_pause
            // 
            this.tsm_pause.CheckOnClick = true;
            this.tsm_pause.Name = "tsm_pause";
            this.tsm_pause.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.tsm_pause.Size = new System.Drawing.Size(215, 22);
            this.tsm_pause.Text = "Pause";
            // 
            // tss5
            // 
            this.tss5.Name = "tss5";
            this.tss5.Size = new System.Drawing.Size(212, 6);
            // 
            // tsm_goto
            // 
            this.tsm_goto.Name = "tsm_goto";
            this.tsm_goto.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.tsm_goto.Size = new System.Drawing.Size(215, 22);
            this.tsm_goto.Text = "Goto coordinates (x ; y)";
            // 
            // tsm_goto_x
            // 
            this.tsm_goto_x.MaxLength = 4;
            this.tsm_goto_x.Name = "tsm_goto_x";
            this.tsm_goto_x.Size = new System.Drawing.Size(100, 23);
            // 
            // tsm_goto_y
            // 
            this.tsm_goto_y.MaxLength = 4;
            this.tsm_goto_y.Name = "tsm_goto_y";
            this.tsm_goto_y.Size = new System.Drawing.Size(100, 23);
            // 
            // tss1
            // 
            this.tss1.Name = "tss1";
            this.tss1.Size = new System.Drawing.Size(212, 6);
            // 
            // tsm_trail_color
            // 
            this.tsm_trail_color.Name = "tsm_trail_color";
            this.tsm_trail_color.Size = new System.Drawing.Size(215, 22);
            this.tsm_trail_color.Text = "Trail color";
            // 
            // tsm_points_color
            // 
            this.tsm_points_color.Name = "tsm_points_color";
            this.tsm_points_color.Size = new System.Drawing.Size(215, 22);
            this.tsm_points_color.Text = "Points color";
            // 
            // tss2
            // 
            this.tss2.Name = "tss2";
            this.tss2.Size = new System.Drawing.Size(212, 6);
            // 
            // tsm_delay_label
            // 
            this.tsm_delay_label.Name = "tsm_delay_label";
            this.tsm_delay_label.Size = new System.Drawing.Size(215, 22);
            this.tsm_delay_label.Text = "Interval [ms]";
            // 
            // tsm_delay
            // 
            this.tsm_delay.BackColor = System.Drawing.Color.White;
            this.tsm_delay.MaxLength = 4;
            this.tsm_delay.Name = "tsm_delay";
            this.tsm_delay.Size = new System.Drawing.Size(100, 23);
            // 
            // tss3
            // 
            this.tss3.Name = "tss3";
            this.tss3.Size = new System.Drawing.Size(212, 6);
            // 
            // tsm_startup
            // 
            this.tsm_startup.Checked = true;
            this.tsm_startup.CheckOnClick = true;
            this.tsm_startup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsm_startup.Enabled = false;
            this.tsm_startup.Name = "tsm_startup";
            this.tsm_startup.Size = new System.Drawing.Size(215, 22);
            this.tsm_startup.Text = "Run on startup";
            this.tsm_startup.Visible = false;
            // 
            // tss6
            // 
            this.tss6.Name = "tss6";
            this.tss6.Size = new System.Drawing.Size(212, 6);
            this.tss6.Visible = false;
            // 
            // tsm_reset
            // 
            this.tsm_reset.Name = "tsm_reset";
            this.tsm_reset.Size = new System.Drawing.Size(215, 22);
            this.tsm_reset.Text = "Reset settings";
            // 
            // tsm_quit
            // 
            this.tsm_quit.Name = "tsm_quit";
            this.tsm_quit.Size = new System.Drawing.Size(215, 22);
            this.tsm_quit.Text = "Quit";
            // 
            // posTimer
            // 
            this.posTimer.Enabled = true;
            this.posTimer.Interval = 500;
            this.posTimer.Tick += new System.EventHandler(this.posTimer_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(126, 19);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.value_y);
            this.Controls.Add(this.label_y);
            this.Controls.Add(this.value_x);
            this.Controls.Add(this.label_x);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(126, 19);
            this.MinimumSize = new System.Drawing.Size(126, 19);
            this.Name = "frmMain";
            this.ShowInTaskbar = false;
            this.Text = "frmMain";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.contextMenuStrip.ResumeLayout(false);
            this.contextMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.Label value_x;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.Label value_y;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsm_quit;
        private System.Windows.Forms.Timer posTimer;
        private System.Windows.Forms.ToolStripMenuItem tsm_trail_color;
        private System.Windows.Forms.ToolStripTextBox tsm_delay;
        private System.Windows.Forms.ToolStripMenuItem tsm_trail_enable;
        private System.Windows.Forms.ToolStripSeparator tss1;
        private System.Windows.Forms.ToolStripSeparator tss2;
        private System.Windows.Forms.ToolStripMenuItem tsm_delay_label;
        private System.Windows.Forms.ToolStripSeparator tss3;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolStripMenuItem tsm_points_enable;
        private System.Windows.Forms.ToolStripMenuItem tsm_points_color;
        private System.Windows.Forms.ToolStripSeparator tss4;
        private System.Windows.Forms.ToolStripMenuItem tsm_pause;
        private System.Windows.Forms.ToolStripSeparator tss5;
        private System.Windows.Forms.ToolStripMenuItem tsm_goto;
        private System.Windows.Forms.ToolStripTextBox tsm_goto_x;
        private System.Windows.Forms.ToolStripTextBox tsm_goto_y;
        private System.Windows.Forms.ToolStripMenuItem tsm_startup;
        private System.Windows.Forms.ToolStripSeparator tss6;
        private System.Windows.Forms.ToolStripMenuItem tsm_reset;
    }
}

