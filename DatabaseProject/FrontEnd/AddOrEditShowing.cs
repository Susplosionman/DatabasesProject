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
    public partial class AddOrEditShowing : UserControl
    {
        public bool AddingOrEditing { get; set; }
        public Showing CurShowing { get; set; }
        public Movie CurMovie { get; set; }
        public User CurUser { get; set; }
        public SqlMovieRepository smr = new SqlMovieRepository(@"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;");
        public AddOrEditShowing(bool addingOrEditing, Showing s, Movie m, User u)
        {
            InitializeComponent();

            AddingOrEditing = addingOrEditing;
            CurShowing = s;
            CurMovie = m;
            CurUser = u;
            if (addingOrEditing)
            {
                uxAoELabel.Text = "Add Showing";
                uxCurShowingString.Text = "";
                uxCurShowingLabel.Text = "";
            }
            else
            {
                uxAoELabel.Text = "Edit Showing";
                uxCurShowingString.Text = s.ToString();
            }
           
        }

        private void uxSetShowtime_Click(object sender, EventArgs e)
        {
            if (AddingOrEditing)
            {
                CurShowing = smr.CreateShowing(uxDatePicker.Value.Date + uxTimePicker.Value.TimeOfDay, (int)uxTicketPricePicker.Value, CurMovie.MovieID);
            }
            else
            {
                //smr.DeleteShowing(CurShowing.ShowingID);
                smr.UpdateShowing(CurShowing.ShowingID, uxDatePicker.Value.Date + uxTimePicker.Value.TimeOfDay, (int)uxTicketPricePicker.Value, CurMovie.MovieID);
            }
            
            ModifySelectedMovie msm = new ModifySelectedMovie(CurMovie, CurUser);
            if (this.FindForm() is UserInterface ui)
            {
                ui.Controls.Remove(this);
                ui.Controls.Add(msm); 
                msm.ShowingAdded = CurShowing;
                ui.Size = new Size(ui._modifyMovieControl.Width + 50, ui._modifyMovieControl.Height + 50);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is UserInterface ui)
            {
                ModifySelectedMovie msm = new ModifySelectedMovie(CurMovie, CurUser);
                ui.Controls.Remove(this);
                ui.Controls.Add(msm); 
                ui.Size = new Size(ui._modifyMovieControl.Width + 50, ui._modifyMovieControl.Height + 50);
            }
        }
    }
}
