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
    public partial class UserInterface : Form
    {
        public LoginControl _loginControl = new LoginControl();
        public EmployeeView _employeeView = new EmployeeView();
        public CustomerView _customerView = new CustomerView();
        public UserInterface()
        {
            InitializeComponent();
            this.Controls.Add(this._loginControl);
            this.Size = new Size(this._loginControl.Width + 50, this._loginControl.Height + 50);
        }
    }
}
