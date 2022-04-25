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
    public partial class LoginControl : UserControl
    {
        public SqlMovieRepository smr = new SqlMovieRepository(@"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;");

        private Dictionary<string, string> UserDictionary { get; set; } = new Dictionary<string, string>();
        private Dictionary<string, string> UserTypeDictionary { get; set; } = new Dictionary<string, string>();

        private Dictionary<string, User> ActualUsers { get; set; } = new Dictionary<string, User>();
        private List<User> Users { get; set; }
        public LoginControl()
        {
            InitializeComponent();

            Users = (List<User>)smr.RetrieveAllUsers();
            for (int i = 0; i < Users.Count; i++)
            {
                UserDictionary.Add(Users[i].Username, Users[i].Password);
                UserTypeDictionary.Add(Users[i].Username, Users[i].Type);
                ActualUsers.Add(Users[i].Username, Users[i]);
            }
        }

        private void uxEmployeeLogin_Click(object sender, EventArgs e)
        {
            if (UserDictionary.ContainsKey(uxUsernameTB.Text))
            {
                if (UserDictionary.TryGetValue(uxUsernameTB.Text, out string pw))
                {
                    if (pw.Equals(uxPasswordTB.Text))
                    {
                        if (UserTypeDictionary[uxUsernameTB.Text].Equals("Employee"))
                        {
                            if (this.FindForm() is UserInterface ui)
                            {
                                ui.Controls.Remove(this);
                                ui.Controls.Add(new EmployeeView(ActualUsers[uxUsernameTB.Text]));
                                ui.Size = new Size(ui._employeeView.Width + 50, ui._employeeView.Height + 50);
                            }
                        }
                        else
                        {
                            uxResponseLabel.Text = "User is not an employee.";
                        }
                        
                    }
                    else
                    {
                        uxResponseLabel.Text = "Incorrect Password.";
                    }
                }
            }
            else
            {
                uxResponseLabel.Text = "User does not exist";
            }
           

        }

        private void uxCustomerLogin_Click(object sender, EventArgs e)
        {
            if (UserDictionary.ContainsKey(uxUsernameTB.Text))
            {
                if (UserDictionary.TryGetValue(uxUsernameTB.Text, out string pw))
                {
                    if (pw.Equals(uxPasswordTB.Text))
                    {
                        if (UserTypeDictionary[uxUsernameTB.Text].Equals("Customer"))
                        {
                            if (this.FindForm() is UserInterface ui)
                            {
                                ui.Controls.Remove(this);
                                ui.Controls.Add(new CustomerView(ActualUsers[uxUsernameTB.Text]));
                                ui.Size = new Size(ui._customerView.Width + 50, ui._customerView.Height + 50);
                            }
                        }
                        else
                        {
                            uxResponseLabel.Text = "User is not a customer.";
                        }
                    }
                    else
                    {
                        uxResponseLabel.Text = "Incorrect Password.";
                    }
                }
            }
            else
            {
                uxResponseLabel.Text = "User does not exist";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is UserInterface ui)
            {
                ui.Controls.Remove(this);
                ui.Controls.Add(new CustomerView(null));
                ui.Size = new Size(ui._customerView.Width + 50, ui._customerView.Height + 50);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is UserInterface ui)
            {
                ui.Controls.Remove(this);
                ui.Controls.Add(new EmployeeView(null));
                ui.Size = new Size(ui._employeeView.Width + 50, ui._employeeView.Height + 50);
            }
        }

        private void uxEmployeeRegisterButton_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is UserInterface ui)
            {
                RegisterUserControl ruc = new RegisterUserControl(true);
                ui.Controls.Remove(this);
                ui.Controls.Add(ruc);
                ui.Size = new Size(ruc.Width + 50, ruc.Height + 50);
            }
        }

        private void uxCustomerRegisterButton_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is UserInterface ui)
            {
                RegisterUserControl ruc = new RegisterUserControl(false);
                ui.Controls.Remove(this);
                ui.Controls.Add(ruc);
                ui.Size = new Size(ruc.Width + 50, ruc.Height + 50);
            }
        }
    }
}
