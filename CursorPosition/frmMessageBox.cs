using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursorPosition
{
    public partial class frmMessageBox : Form
    {
        public bool ShowAgain = false;
        public frmMessageBox()
        {
            InitializeComponent();
        }

        private void frmMessageBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShowAgain = !cb_again.Checked;
        }
    }
}
