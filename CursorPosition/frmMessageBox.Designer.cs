namespace CursorPosition
{
    partial class frmMessageBox
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
            this.btnOK = new System.Windows.Forms.Button();
            this.cb_again = new System.Windows.Forms.CheckBox();
            this.mLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(9, 112);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 28);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // cb_again
            // 
            this.cb_again.AutoSize = true;
            this.cb_again.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_again.Location = new System.Drawing.Point(12, 84);
            this.cb_again.Name = "cb_again";
            this.cb_again.Size = new System.Drawing.Size(141, 22);
            this.cb_again.TabIndex = 1;
            this.cb_again.Text = "Don\'t show again";
            this.cb_again.UseVisualStyleBackColor = true;
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabel.Location = new System.Drawing.Point(9, 6);
            this.mLabel.Margin = new System.Windows.Forms.Padding(3);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(194, 72);
            this.mLabel.TabIndex = 6;
            this.mLabel.Text = "Right click on the movable\r\nposition indicator to open\r\nthe contextual menu, many" +
    "\r\noptions can befound in there";
            // 
            // frmMessageBox
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnOK;
            this.ClientSize = new System.Drawing.Size(210, 150);
            this.ControlBox = false;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cb_again);
            this.Controls.Add(this.mLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(150, 140);
            this.Name = "frmMessageBox";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Information";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMessageBox_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox cb_again;
        private System.Windows.Forms.Label mLabel;
    }
}