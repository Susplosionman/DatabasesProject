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
        public LoginControl()
        {
            InitializeComponent();
        }

        private void uxEmployeeLogin_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is UserInterface ui)
            {
                // if ui.UserRepository contains User with username uxUsernameTB
                // if User.Password == uxPasswordTB.Text
                // ui.Controls.Remove(this);
                // ui.Controls.Add(ui._employeeView)
                // else uxResponseLabel.Text = "Incorrect Password";
                //uxPasswordTB.Text = "";
                // else
                // uxResponseLabel.Text = "User does not exist"
                ui.Controls.Remove(this);
                ui.Controls.Add(ui._employeeView);
                ui.Size = new Size(ui._employeeView.Width + 50, ui._employeeView.Height + 50);
            }

        }

        private void uxCustomerLogin_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is UserInterface ui)
            {
                // if ui.UserRepository contains User with username uxUsernameTB
                // if User.Password == uxPasswordTB.Text
                // ui.Controls.Remove(this);
                // ui.Controls.Add(ui._customerView)
                // else uxResponseLabel.Text = "Incorrect Password";
                //uxPasswordTB.Text = "";
                // else
                // uxResponseLabel.Text = "User does not exist"
                ui.Controls.Remove(this);
                ui.Controls.Add(ui._customerView);
                ui.Size = new Size(ui._customerView.Width + 50, ui._customerView.Height + 50);
            }
        }
    }
}
