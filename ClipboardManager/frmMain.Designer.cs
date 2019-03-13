namespace ClipboardManager
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_top = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_popup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_clearcurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_clearall = new System.Windows.Forms.ToolStripMenuItem();
            this.qutiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 437);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.qutiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_top,
            this.tsm_popup,
            this.tsm_clearcurrent,
            this.tsm_clearall});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.ToolTipText = "Display settings";
            // 
            // tsm_top
            // 
            this.tsm_top.CheckOnClick = true;
            this.tsm_top.Name = "tsm_top";
            this.tsm_top.Size = new System.Drawing.Size(195, 22);
            this.tsm_top.Text = "Always on top";
            this.tsm_top.ToolTipText = "Always show on top";
            this.tsm_top.CheckedChanged += new System.EventHandler(this.tsm_top_CheckedChanged);
            // 
            // tsm_popup
            // 
            this.tsm_popup.Checked = true;
            this.tsm_popup.CheckOnClick = true;
            this.tsm_popup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsm_popup.Name = "tsm_popup";
            this.tsm_popup.Size = new System.Drawing.Size(195, 22);
            this.tsm_popup.Text = "Popup window";
            this.tsm_popup.ToolTipText = "Show the window when a new clipboard is set";
            // 
            // tsm_clearcurrent
            // 
            this.tsm_clearcurrent.Name = "tsm_clearcurrent";
            this.tsm_clearcurrent.Size = new System.Drawing.Size(195, 22);
            this.tsm_clearcurrent.Text = "Clear current clipboard";
            this.tsm_clearcurrent.ToolTipText = "Erase the current clipboard";
            this.tsm_clearcurrent.Click += new System.EventHandler(this.tsm_clearcurrent_Click);
            // 
            // tsm_clearall
            // 
            this.tsm_clearall.Name = "tsm_clearall";
            this.tsm_clearall.Size = new System.Drawing.Size(195, 22);
            this.tsm_clearall.Text = "Clear all clipboards";
            this.tsm_clearall.Click += new System.EventHandler(this.tsm_clearall_Click);
            // 
            // qutiToolStripMenuItem
            // 
            this.qutiToolStripMenuItem.Name = "qutiToolStripMenuItem";
            this.qutiToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.qutiToolStripMenuItem.Text = "Close";
            this.qutiToolStripMenuItem.ToolTipText = "Close the application";
            this.qutiToolStripMenuItem.Click += new System.EventHandler(this.qutiToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(170, 220);
            this.Name = "frmMain";
            this.Text = "Multiple clipboards manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qutiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_top;
        private System.Windows.Forms.ToolStripMenuItem tsm_popup;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.ToolStripMenuItem tsm_clearcurrent;
        private System.Windows.Forms.ToolStripMenuItem tsm_clearall;
    }
}

