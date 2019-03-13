﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardManager
{
    public partial class TextBox : Component
    {
        public TextBox()
        {
            InitializeComponent();
        }

        public void Show(string Text)
        {
            frmDialogForm frmDialogForm = new frmDialogForm { DisplayedText = Text };
            frmDialogForm.Show();
        }

        public void ShowDialog(string Text)
        {
            frmDialogForm frmDialogForm = new frmDialogForm { DisplayedText = Text };
            frmDialogForm.ShowDialog();
        }

        class frmDialogForm : Form
        {
            #region Constructor

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
                this.panel1 = new System.Windows.Forms.Panel();
                this.richTextBox1 = new System.Windows.Forms.RichTextBox();
                this.button1 = new System.Windows.Forms.Button();
                this.panel1.SuspendLayout();
                this.SuspendLayout();
                // 
                // panel1
                // 
                this.panel1.AutoScroll = true;
                this.panel1.Controls.Add(this.richTextBox1);
                this.panel1.Controls.Add(this.button1);
                this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
                this.panel1.Location = new System.Drawing.Point(0, 0);
                this.panel1.Name = "panel1";
                this.panel1.Size = new System.Drawing.Size(284, 261);
                this.panel1.TabIndex = 0;
                // 
                // richTextBox1
                // 
                this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                this.richTextBox1.Location = new System.Drawing.Point(0, 0);
                this.richTextBox1.Name = "richTextBox1";
                this.richTextBox1.ReadOnly = true;
                this.richTextBox1.Size = new System.Drawing.Size(284, 220);
                this.richTextBox1.TabIndex = 2;
                this.richTextBox1.Text = "";
                // 
                // button1
                // 
                this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.button1.Location = new System.Drawing.Point(197, 226);
                this.button1.Name = "button1";
                this.button1.Size = new System.Drawing.Size(75, 23);
                this.button1.TabIndex = 1;
                this.button1.Text = "OK";
                this.button1.UseVisualStyleBackColor = true;
                this.button1.Click += new System.EventHandler(this.button1_Click);
                // 
                // frmDialog
                // 
                this.AcceptButton = this.button1;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.CancelButton = this.button1;
                this.ClientSize = new System.Drawing.Size(284, 261);
                this.Controls.Add(this.panel1);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
                this.Name = "frmDialog";
                this.ShowIcon = false;
                this.ShowInTaskbar = false;
                this.Text = "Clipboard content";
                this.panel1.ResumeLayout(false);
                this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.Panel panel1;
            private System.Windows.Forms.Button button1;
            private System.Windows.Forms.RichTextBox richTextBox1;

            #endregion Constructor

            public frmDialogForm() => InitializeComponent();

            public string DisplayedText
            {
                get
                {
                    return richTextBox1.Text;
                }
                set
                {
                    richTextBox1.Text = value;
                }
            }

            private void button1_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    }
}
