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
    public partial class GetTimeframe : Form
    {
        public DateTimeOffset From { get; set; }
        public DateTimeOffset To { get; set; }
        public GetTimeframe()
        {
            InitializeComponent();
        }

        private void uxSubmitButton_Click(object sender, EventArgs e)
        {
            From = uxFromPicker.Value;
            To = uxToPicker.Value;
            this.DialogResult = DialogResult.OK;
        }
    }
}
