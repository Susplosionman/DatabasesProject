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
    public partial class GetGenre : Form
    {
        public SqlMovieRepository smr = new SqlMovieRepository(@"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;");
        public string Genre { get; set; }
        public List<string> Genres { get; set; }
        public GetGenre()
        {
            InitializeComponent();
            Genres = (List<string>)smr.GetDistinctGenres();
            comboBox1.DataSource = Genres;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Genre = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0 && comboBox1.SelectedIndex < comboBox1.Items.Count)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }
    }
}
