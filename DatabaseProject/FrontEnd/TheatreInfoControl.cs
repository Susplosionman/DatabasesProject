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
    public partial class TheatreInfoControl : UserControl
    {
        public SqlMovieRepository smr = new SqlMovieRepository(@"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;");
        User CurUser { get; set; }
        public TheatreInfoControl(User u)
        {
            InitializeComponent();

            
        }

        private void uxGetMovieGrossSales_Click(object sender, EventArgs e)
        {
            uxDataView.Columns.Clear();
            uxDataView.DataSource = null;
            uxDataView.Rows.Clear();
            
            Dictionary<string, List<string>> grossDic = new Dictionary<string, List<string>>();
            grossDic = smr.GetAllMoviesGrossSales();

            uxDataView.Columns.Add("Key", "Movie Name");
            uxDataView.Columns.Add("Values", "Genre");
            uxDataView.Columns.Add("Values", "Release Date");
            uxDataView.Columns.Add("Values", "Director Name");
            uxDataView.Columns.Add("Values", "Gross Sales");
            foreach (KeyValuePair<string, List<string>> item in grossDic)
            {
               

                uxDataView.Rows.Add(item.Key, item.Value[0], item.Value[1], item.Value[2], item.Value[3]);
            }
            
        }

        private void uxGetShowingStats_Click(object sender, EventArgs e)
        {
            uxDataView.Columns.Clear();
            uxDataView.DataSource = null;
            uxDataView.Rows.Clear();

            uxDataView.Columns.Add("ShowTime", "Show Time");
            uxDataView.Columns.Add("MovieName", "Movie Name");
            uxDataView.Columns.Add("Showing Sales", "Showing Sales");
            uxDataView.Columns.Add("Average Review", "AverageReview");
            GetTimeframe gt = new GetTimeframe();
            
            if (gt.ShowDialog() == DialogResult.OK)
            {
                Dictionary<string, List<string>> statdic = smr.RetrieveShowingStats(gt.From, gt.To);

                foreach (KeyValuePair<string, List<string>> item in statdic)
                {
                    uxDataView.Rows.Add(item.Key, item.Value[0], item.Value[1], item.Value[2]);
                }
                //uxDataView.DataSource = statdic;
            }

            
            
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is UserInterface ui)
            {
                ui.Controls.Remove(this);
                EmployeeView ev = new EmployeeView(CurUser);
                ui.Controls.Add(ev);
                ui.Size = new Size(ev.Width + 50, ev.Height + 50);
            }
        }
    }
}
