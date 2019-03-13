namespace Toolbox
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
            this.button_volume = new System.Windows.Forms.CheckBox();
            this.button_cursor = new System.Windows.Forms.CheckBox();
            this.button_clipboard = new System.Windows.Forms.CheckBox();
            this.box_settings = new System.Windows.Forms.CheckBox();
            this.layout_main = new System.Windows.Forms.TableLayoutPanel();
            this.panel_main_l = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_main_r = new System.Windows.Forms.Panel();
            this.panel_settings = new System.Windows.Forms.Panel();
            this.layout_settings = new System.Windows.Forms.TableLayoutPanel();
            this.panel_settings_l = new System.Windows.Forms.Panel();
            this.panel_settings_r = new System.Windows.Forms.Panel();
            this.box_notif = new System.Windows.Forms.CheckBox();
            this.box_edges = new System.Windows.Forms.CheckBox();
            this.box_taskbar = new System.Windows.Forms.CheckBox();
            this.box_title = new System.Windows.Forms.CheckBox();
            this.box_topmost = new System.Windows.Forms.CheckBox();
            this.box_startup = new System.Windows.Forms.CheckBox();
            this.button_minimize = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.notification = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_show = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_quit = new System.Windows.Forms.ToolStripMenuItem();
            this.layout_main.SuspendLayout();
            this.panel_settings.SuspendLayout();
            this.layout_settings.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_volume
            // 
            this.button_volume.Appearance = System.Windows.Forms.Appearance.Button;
            this.button_volume.AutoSize = true;
            this.button_volume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_volume.Location = new System.Drawing.Point(23, 3);
            this.button_volume.Name = "button_volume";
            this.button_volume.Size = new System.Drawing.Size(91, 23);
            this.button_volume.TabIndex = 0;
            this.button_volume.Text = "Volume reducer";
            this.toolTips.SetToolTip(this.button_volume, "Open the volume reducer tool");
            this.button_volume.UseVisualStyleBackColor = true;
            this.button_volume.CheckedChanged += new System.EventHandler(this.button_volume_CheckedChanged);
            // 
            // button_cursor
            // 
            this.button_cursor.Appearance = System.Windows.Forms.Appearance.Button;
            this.button_cursor.AutoSize = true;
            this.button_cursor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cursor.Location = new System.Drawing.Point(120, 3);
            this.button_cursor.Name = "button_cursor";
            this.button_cursor.Size = new System.Drawing.Size(86, 23);
            this.button_cursor.TabIndex = 0;
            this.button_cursor.Text = "Cursor position";
            this.toolTips.SetToolTip(this.button_cursor, "Open the cursor position tool");
            this.button_cursor.UseVisualStyleBackColor = true;
            this.button_cursor.CheckedChanged += new System.EventHandler(this.button_cursor_CheckedChanged);
            // 
            // button_clipboard
            // 
            this.button_clipboard.Appearance = System.Windows.Forms.Appearance.Button;
            this.button_clipboard.AutoSize = true;
            this.button_clipboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_clipboard.Location = new System.Drawing.Point(212, 3);
            this.button_clipboard.Name = "button_clipboard";
            this.button_clipboard.Size = new System.Drawing.Size(104, 23);
            this.button_clipboard.TabIndex = 0;
            this.button_clipboard.Text = "Multiple clipboards";
            this.toolTips.SetToolTip(this.button_clipboard, "Open the multiple clipboards manager tool");
            this.button_clipboard.UseVisualStyleBackColor = true;
            this.button_clipboard.CheckedChanged += new System.EventHandler(this.button_clipboard_CheckedChanged);
            // 
            // box_settings
            // 
            this.box_settings.Appearance = System.Windows.Forms.Appearance.Button;
            this.box_settings.AutoSize = true;
            this.box_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.box_settings.Location = new System.Drawing.Point(332, 3);
            this.box_settings.Name = "box_settings";
            this.box_settings.Size = new System.Drawing.Size(83, 23);
            this.box_settings.TabIndex = 0;
            this.box_settings.Text = "Show settings";
            this.toolTips.SetToolTip(this.box_settings, "Display settings");
            this.box_settings.UseVisualStyleBackColor = true;
            this.box_settings.CheckedChanged += new System.EventHandler(this.box_settings_CheckedChanged);
            // 
            // layout_main
            // 
            this.layout_main.AutoSize = true;
            this.layout_main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layout_main.ColumnCount = 9;
            this.layout_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout_main.Controls.Add(this.panel_main_l, 0, 0);
            this.layout_main.Controls.Add(this.button_volume, 1, 0);
            this.layout_main.Controls.Add(this.button_cursor, 2, 0);
            this.layout_main.Controls.Add(this.button_clipboard, 3, 0);
            this.layout_main.Controls.Add(this.panel1, 4, 0);
            this.layout_main.Controls.Add(this.box_settings, 5, 0);
            this.layout_main.Controls.Add(this.panel_main_r, 8, 0);
            this.layout_main.Controls.Add(this.panel_settings, 0, 1);
            this.layout_main.Controls.Add(this.button_minimize, 6, 0);
            this.layout_main.Controls.Add(this.button_close, 7, 0);
            this.layout_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_main.Location = new System.Drawing.Point(0, 0);
            this.layout_main.Margin = new System.Windows.Forms.Padding(0);
            this.layout_main.Name = "layout_main";
            this.layout_main.RowCount = 2;
            this.layout_main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout_main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout_main.Size = new System.Drawing.Size(851, 218);
            this.layout_main.TabIndex = 1;
            // 
            // panel_main_l
            // 
            this.panel_main_l.AutoSize = true;
            this.panel_main_l.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_main_l.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_main_l.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main_l.Location = new System.Drawing.Point(0, 0);
            this.panel_main_l.Margin = new System.Windows.Forms.Padding(0);
            this.panel_main_l.MinimumSize = new System.Drawing.Size(20, 29);
            this.panel_main_l.Name = "panel_main_l";
            this.panel_main_l.Size = new System.Drawing.Size(20, 29);
            this.panel_main_l.TabIndex = 4;
            this.toolTips.SetToolTip(this.panel_main_l, "Drag me to move the toolbox");
            this.panel_main_l.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panels_MouseDown);
            this.panel_main_l.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panels_MouseMove);
            this.panel_main_l.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panels_MouseUp);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(319, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MinimumSize = new System.Drawing.Size(10, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 29);
            this.panel1.TabIndex = 0;
            // 
            // panel_main_r
            // 
            this.panel_main_r.AutoSize = true;
            this.panel_main_r.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_main_r.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_main_r.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main_r.Location = new System.Drawing.Point(580, 0);
            this.panel_main_r.Margin = new System.Windows.Forms.Padding(0);
            this.panel_main_r.MinimumSize = new System.Drawing.Size(20, 29);
            this.panel_main_r.Name = "panel_main_r";
            this.panel_main_r.Size = new System.Drawing.Size(271, 29);
            this.panel_main_r.TabIndex = 3;
            this.toolTips.SetToolTip(this.panel_main_r, "Drag me to move the toolbox");
            this.panel_main_r.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panels_MouseDown);
            this.panel_main_r.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panels_MouseMove);
            this.panel_main_r.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panels_MouseUp);
            // 
            // panel_settings
            // 
            this.panel_settings.AutoSize = true;
            this.panel_settings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layout_main.SetColumnSpan(this.panel_settings, 9);
            this.panel_settings.Controls.Add(this.layout_settings);
            this.panel_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_settings.Location = new System.Drawing.Point(0, 29);
            this.panel_settings.Margin = new System.Windows.Forms.Padding(0);
            this.panel_settings.Name = "panel_settings";
            this.panel_settings.Size = new System.Drawing.Size(851, 189);
            this.panel_settings.TabIndex = 0;
            this.panel_settings.Visible = false;
            // 
            // layout_settings
            // 
            this.layout_settings.AutoSize = true;
            this.layout_settings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layout_settings.ColumnCount = 9;
            this.layout_settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout_settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout_settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout_settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout_settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout_settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout_settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout_settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout_settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_settings.Controls.Add(this.panel_settings_l, 0, 0);
            this.layout_settings.Controls.Add(this.panel_settings_r, 8, 0);
            this.layout_settings.Controls.Add(this.box_notif, 1, 0);
            this.layout_settings.Controls.Add(this.box_edges, 2, 0);
            this.layout_settings.Controls.Add(this.box_taskbar, 3, 0);
            this.layout_settings.Controls.Add(this.box_title, 4, 0);
            this.layout_settings.Controls.Add(this.box_topmost, 5, 0);
            this.layout_settings.Controls.Add(this.box_startup, 7, 0);
            this.layout_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_settings.Location = new System.Drawing.Point(0, 0);
            this.layout_settings.Margin = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.layout_settings.Name = "layout_settings";
            this.layout_settings.RowCount = 1;
            this.layout_settings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout_settings.Size = new System.Drawing.Size(851, 189);
            this.layout_settings.TabIndex = 1;
            // 
            // panel_settings_l
            // 
            this.panel_settings_l.AutoSize = true;
            this.panel_settings_l.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_settings_l.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_settings_l.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_settings_l.Location = new System.Drawing.Point(0, 0);
            this.panel_settings_l.Margin = new System.Windows.Forms.Padding(0);
            this.panel_settings_l.MinimumSize = new System.Drawing.Size(20, 29);
            this.panel_settings_l.Name = "panel_settings_l";
            this.panel_settings_l.Size = new System.Drawing.Size(20, 189);
            this.panel_settings_l.TabIndex = 5;
            this.toolTips.SetToolTip(this.panel_settings_l, "Drag me to move the toolbox");
            this.panel_settings_l.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panels_MouseDown);
            this.panel_settings_l.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panels_MouseMove);
            this.panel_settings_l.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panels_MouseUp);
            // 
            // panel_settings_r
            // 
            this.panel_settings_r.AutoSize = true;
            this.panel_settings_r.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_settings_r.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_settings_r.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_settings_r.Location = new System.Drawing.Point(675, 0);
            this.panel_settings_r.Margin = new System.Windows.Forms.Padding(0);
            this.panel_settings_r.MinimumSize = new System.Drawing.Size(20, 29);
            this.panel_settings_r.Name = "panel_settings_r";
            this.panel_settings_r.Size = new System.Drawing.Size(176, 189);
            this.panel_settings_r.TabIndex = 6;
            this.toolTips.SetToolTip(this.panel_settings_r, "Drag me to move the toolbox");
            this.panel_settings_r.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panels_MouseDown);
            this.panel_settings_r.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panels_MouseMove);
            this.panel_settings_r.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panels_MouseUp);
            // 
            // box_notif
            // 
            this.box_notif.Appearance = System.Windows.Forms.Appearance.Button;
            this.box_notif.AutoSize = true;
            this.box_notif.Checked = true;
            this.box_notif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.box_notif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.box_notif.Location = new System.Drawing.Point(23, 3);
            this.box_notif.Name = "box_notif";
            this.box_notif.Size = new System.Drawing.Size(121, 23);
            this.box_notif.TabIndex = 0;
            this.box_notif.Text = "Show notification icon";
            this.toolTips.SetToolTip(this.box_notif, "Display Notification icon in taskbar when the toolbox is visible");
            this.box_notif.UseVisualStyleBackColor = true;
            this.box_notif.CheckedChanged += new System.EventHandler(this.box_notif_CheckedChanged);
            // 
            // box_edges
            // 
            this.box_edges.Appearance = System.Windows.Forms.Appearance.Button;
            this.box_edges.AutoSize = true;
            this.box_edges.Checked = true;
            this.box_edges.CheckState = System.Windows.Forms.CheckState.Checked;
            this.box_edges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.box_edges.Location = new System.Drawing.Point(150, 3);
            this.box_edges.Name = "box_edges";
            this.box_edges.Size = new System.Drawing.Size(126, 23);
            this.box_edges.TabIndex = 0;
            this.box_edges.Text = "Show draggable edges";
            this.toolTips.SetToolTip(this.box_edges, "Show draggable edges in the toolbox");
            this.box_edges.UseVisualStyleBackColor = true;
            this.box_edges.CheckedChanged += new System.EventHandler(this.box_edges_CheckedChanged);
            // 
            // box_taskbar
            // 
            this.box_taskbar.Appearance = System.Windows.Forms.Appearance.Button;
            this.box_taskbar.AutoSize = true;
            this.box_taskbar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.box_taskbar.Location = new System.Drawing.Point(282, 3);
            this.box_taskbar.Name = "box_taskbar";
            this.box_taskbar.Size = new System.Drawing.Size(93, 23);
            this.box_taskbar.TabIndex = 0;
            this.box_taskbar.Text = "Show in taskbar";
            this.toolTips.SetToolTip(this.box_taskbar, "Display the toolbox in the taskbar");
            this.box_taskbar.UseVisualStyleBackColor = true;
            this.box_taskbar.CheckedChanged += new System.EventHandler(this.box_taskbar_CheckedChanged);
            // 
            // box_title
            // 
            this.box_title.Appearance = System.Windows.Forms.Appearance.Button;
            this.box_title.AutoSize = true;
            this.box_title.Checked = true;
            this.box_title.CheckState = System.Windows.Forms.CheckState.Checked;
            this.box_title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.box_title.Location = new System.Drawing.Point(381, 3);
            this.box_title.Name = "box_title";
            this.box_title.Size = new System.Drawing.Size(81, 23);
            this.box_title.TabIndex = 0;
            this.box_title.Text = "Show title bar";
            this.toolTips.SetToolTip(this.box_title, "Display the title bar of the toolbox");
            this.box_title.UseVisualStyleBackColor = true;
            this.box_title.CheckedChanged += new System.EventHandler(this.box_title_CheckedChanged);
            // 
            // box_topmost
            // 
            this.box_topmost.Appearance = System.Windows.Forms.Appearance.Button;
            this.box_topmost.AutoSize = true;
            this.box_topmost.Checked = true;
            this.box_topmost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.box_topmost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.box_topmost.Location = new System.Drawing.Point(468, 3);
            this.box_topmost.Name = "box_topmost";
            this.box_topmost.Size = new System.Drawing.Size(111, 23);
            this.box_topmost.TabIndex = 0;
            this.box_topmost.Text = "Always show on top";
            this.toolTips.SetToolTip(this.box_topmost, "Keep the toolox on top of others windows");
            this.box_topmost.UseVisualStyleBackColor = true;
            this.box_topmost.CheckedChanged += new System.EventHandler(this.box_topmost_CheckedChanged);
            // 
            // box_startup
            // 
            this.box_startup.Appearance = System.Windows.Forms.Appearance.Button;
            this.box_startup.AutoSize = true;
            this.box_startup.Checked = true;
            this.box_startup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.box_startup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.box_startup.Location = new System.Drawing.Point(585, 3);
            this.box_startup.Name = "box_startup";
            this.box_startup.Size = new System.Drawing.Size(87, 23);
            this.box_startup.TabIndex = 0;
            this.box_startup.Text = "Run on startup";
            this.toolTips.SetToolTip(this.box_startup, "Run the toolbox on startup");
            this.box_startup.UseVisualStyleBackColor = true;
            this.box_startup.CheckedChanged += new System.EventHandler(this.box_startup_CheckedChanged);
            // 
            // button_minimize
            // 
            this.button_minimize.Location = new System.Drawing.Point(421, 3);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(75, 23);
            this.button_minimize.TabIndex = 2;
            this.button_minimize.Text = "Minimize";
            this.toolTips.SetToolTip(this.button_minimize, "Minimze the toolbox");
            this.button_minimize.UseVisualStyleBackColor = true;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(502, 3);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 2;
            this.button_close.Text = "Close";
            this.toolTips.SetToolTip(this.button_close, "Close the toolbox");
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // notification
            // 
            this.notification.ContextMenuStrip = this.contextMenu;
            this.notification.Icon = ((System.Drawing.Icon)(resources.GetObject("notification.Icon")));
            this.notification.Text = "Toolbox is running in background";
            this.notification.Visible = true;
            this.notification.DoubleClick += new System.EventHandler(this.notification_DoubleClick);
            this.notification.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notification_MouseClick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_show,
            this.tsm_quit});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.ShowImageMargin = false;
            this.contextMenu.Size = new System.Drawing.Size(79, 48);
            // 
            // tsm_show
            // 
            this.tsm_show.Name = "tsm_show";
            this.tsm_show.Size = new System.Drawing.Size(78, 22);
            this.tsm_show.Text = "Show";
            this.tsm_show.Click += new System.EventHandler(this.tsm_show_Click);
            // 
            // tsm_quit
            // 
            this.tsm_quit.Name = "tsm_quit";
            this.tsm_quit.Size = new System.Drawing.Size(78, 22);
            this.tsm_quit.Text = "Quit";
            this.tsm_quit.Click += new System.EventHandler(this.tsm_close_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(851, 218);
            this.Controls.Add(this.layout_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Toolbox";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.layout_main.ResumeLayout(false);
            this.layout_main.PerformLayout();
            this.panel_settings.ResumeLayout(false);
            this.panel_settings.PerformLayout();
            this.layout_settings.ResumeLayout(false);
            this.layout_settings.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox button_volume;
        private System.Windows.Forms.CheckBox button_cursor;
        private System.Windows.Forms.CheckBox button_clipboard;
        private System.Windows.Forms.CheckBox box_settings;
        private System.Windows.Forms.TableLayoutPanel layout_main;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Panel panel_main_r;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.NotifyIcon notification;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem tsm_show;
        private System.Windows.Forms.ToolStripMenuItem tsm_quit;
        private System.Windows.Forms.TableLayoutPanel layout_settings;
        private System.Windows.Forms.CheckBox box_topmost;
        private System.Windows.Forms.CheckBox box_title;
        private System.Windows.Forms.CheckBox box_taskbar;
        private System.Windows.Forms.CheckBox box_notif;
        private System.Windows.Forms.CheckBox box_edges;
        private System.Windows.Forms.Panel panel_main_l;
        private System.Windows.Forms.Panel panel_settings_l;
        private System.Windows.Forms.Panel panel_settings_r;
        private System.Windows.Forms.Panel panel_settings;
        private System.Windows.Forms.CheckBox box_startup;
        private System.Windows.Forms.Button button_minimize;
        private System.Windows.Forms.Panel panel1;
    }
}

