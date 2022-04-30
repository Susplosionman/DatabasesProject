using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class SelectHighest : Form
    {
        public int Top { get; set; }
        public SelectHighest()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Top = (int)numericUpDown1.Value;
        }

        private void uxSubmitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void uxSelectAllButton_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;
            Top = 10000;
        }
    }
}
