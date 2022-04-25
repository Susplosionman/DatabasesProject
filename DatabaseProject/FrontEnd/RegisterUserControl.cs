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
    public partial class RegisterUserControl : UserControl
    {
        public SqlMovieRepository smr = new SqlMovieRepository(@"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;");
        private bool EmployeeOrCustomer { get; set; }
        private Dictionary<string, string> UserDictionary { get; set; } = new Dictionary<string, string>();
        private Dictionary<string, string> UserTypeDictionary { get; set; } = new Dictionary<string, string>();
        private List<User> Users { get; set; }
        public RegisterUserControl(bool employeeOrCustomer)
        {
            
            InitializeComponent();

            EmployeeOrCustomer = employeeOrCustomer;
            Users = (List<User>)smr.RetrieveAllUsers();

            for (int i = 0; i < Users.Count; i++)
            {
                UserDictionary.Add(Users[i].Username, Users[i].Password);
                UserTypeDictionary.Add(Users[i].Username, Users[i].Type);
            }
        }

        private void uxReturnButton_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is UserInterface ui)
            {
                ui.Controls.Remove(this);
                ui.Controls.Add(new LoginControl());
                ui.Size = new Size(ui._loginControl.Width + 50, ui._loginControl.Height + 50);
            }
        }

        private void uxEmployeeRegister_Click(object sender, EventArgs e)
        {
            if (!UserDictionary.ContainsKey(uxUsernameTB.Text))
            {
                if (EmployeeOrCustomer)
                {
                    smr.CreateUser("Employee", uxUsernameTB.Text, uxPasswordTB.Text);
                }
                else
                {
                    smr.CreateUser("Customer", uxUsernameTB.Text, uxPasswordTB.Text);
                }
                if (this.FindForm() is UserInterface ui)
                {
                    ui.Controls.Remove(this);
                    ui.Controls.Add(new LoginControl());
                    ui.Size = new Size(ui._loginControl.Width + 50, ui._loginControl.Height + 50);
                }
            }
            else
            {
                uxResponseLabel.Text = "User already exists.";
            }
        }

        
    }
}
