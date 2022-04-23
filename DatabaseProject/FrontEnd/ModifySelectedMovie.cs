using Data;
using Data.Models;
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
    public partial class ModifySelectedMovie : UserControl
    {
        public SqlMovieRepository smr = new SqlMovieRepository(@"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;");

        BindingList<Showing> Showings = new BindingList<Showing>();

        public ModifySelectedMovie(Movie m)
        {
            InitializeComponent();
            List<Showing> showings = (List<Showing>)smr.RetrieveShowingsForMovie(m.MovieID);
            for (int i = 0; i < showings.Count; i++)
            {
                Showings.Add(showings[i]);
            }
            uxShowingList.DataSource = Showings;
        }

        private void uxEditShowingButton_Click(object sender, EventArgs e)
        {

        }

        private void uxDeleteShowingButton_Click(object sender, EventArgs e)
        {

        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is UserInterface ui)
            {
                ui.Controls.Remove(this);
                ui.Controls.Add(new EmployeeView());
                ui.Size = new Size(ui._employeeView.Width + 50, ui._employeeView.Height + 50);
            }
        }

        private void uxAddShowing_Click(object sender, EventArgs e)
        {
            Showings.Add(smr.CreateShowing(DateTime.Now, 5, 1));
            
            uxShowingList.Update();
        }
    }
}
