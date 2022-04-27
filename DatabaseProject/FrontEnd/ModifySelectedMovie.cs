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
        Movie CurMovie { get; set; }
        User CurUser { get; set; }
        public Showing ShowingAdded { get; set; }
        public ModifySelectedMovie(Movie m, User u)
        {
            InitializeComponent();
            CurMovie = m;
            CurUser = u;
            List<Showing> showings = (List<Showing>)smr.RetrieveShowingsForMovie(m.MovieID);
            
            for (int i = 0; i < showings.Count; i++)
            {
                Showings.Add(showings[i]);
            }
            uxShowingList.DataSource = Showings;
            uxShowingList.Update();
        }

        private void uxEditShowingButton_Click(object sender, EventArgs e)
        {
            Showing s = uxShowingList.SelectedItem as Showing;
            AddOrEditShowing aoes = new AddOrEditShowing(false, s, CurMovie, CurUser);
            if (this.FindForm() is UserInterface ui)
            {
                ui.Controls.Remove(this);
                ui.Controls.Add(aoes); // passing in true for adding, false for editing.
                ui.Size = new Size(aoes.Width + 50, aoes.Height + 50);
            }
        }

        private void uxDeleteShowingButton_Click(object sender, EventArgs e)
        {
            Showing s = uxShowingList.SelectedItem as Showing;
            List<ShowingAttendance> sa = (List<ShowingAttendance>)smr.RetrieveAttendeesForShowing(s.ShowingID);

            
            //delete each showing attendance
            smr.DeleteShowingAttendance(s.ShowingID);

            smr.DeleteShowing(s.ShowingID);
            Showings.Remove(s);
            uxShowingList.Update();
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is UserInterface ui)
            {
                ui.Controls.Remove(this);
                ui.Controls.Add(new EmployeeView(CurUser));
                ui.Size = new Size(ui._employeeView.Width + 50, ui._employeeView.Height + 50);
            }
        }

        private void uxAddShowing_Click(object sender, EventArgs e)
        {
            AddOrEditShowing aoes = new AddOrEditShowing(true, null, CurMovie, CurUser);
            if (this.FindForm() is UserInterface ui)
            {
                ui.Controls.Remove(this);
                ui.Controls.Add(aoes); // passing in true for adding, false for editing.
                ui.Size = new Size(aoes.Width + 50, aoes.Height + 50);
            }
        }
    }
}
