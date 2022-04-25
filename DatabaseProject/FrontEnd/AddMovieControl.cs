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
    public partial class AddMovieControl : UserControl
    {
        public SqlMovieRepository smr = new SqlMovieRepository(@"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;");
        User CurUser { get; set; }
        public AddMovieControl(User u)
        {
            InitializeComponent();
            CurUser = u;
        }

        private void uxAddMovieButton_Click(object sender, EventArgs e)
        {
            // if this director does not already exist, add the director

            Director d = smr.FetchDirector(uxDirectorTB.Text);
            if (d.DirectorID > 0)
            {
                smr.CreateMovie(uxMovieNameTB.Text, uxDateTimePicker.Value, uxGenreTB.Text, d.DirectorID);
            }
            else
            {
                smr.CreateDirector(uxDirectorTB.Text);
                Director d2 = smr.FetchDirector(uxDirectorTB.Text);
                smr.CreateMovie(uxMovieNameTB.Text, uxDateTimePicker.Value, uxGenreTB.Text, d2.DirectorID);
            }
            

            if (this.FindForm() is UserInterface ui)
            {
                ui.Controls.Remove(this);
                ui.Controls.Add(new EmployeeView(CurUser));
                ui.Size = new Size(ui._employeeView.Width + 50, ui._employeeView.Height + 50);
            }
        }
    }
}
