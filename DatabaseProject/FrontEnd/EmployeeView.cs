using Data;
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
    public partial class EmployeeView : UserControl
    {
        SqlMovieRepository smr = new SqlMovieRepository(@"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;");
        public EmployeeView()
        {
            InitializeComponent();
        }

        private void uxTestAdd_Click(object sender, EventArgs e)
        {
            smr.CreateMovie("TestMovie", new DateTimeOffset(), "testgenre", 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            smr.CreateDirector("Bob Jones");
        }
    }
}
