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
    public partial class UserInterface : Form
    {
        //public SqlMovieRepository smr = new SqlMovieRepository(@"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;");

        public LoginControl _loginControl;
        public EmployeeView _employeeView;
        public CustomerView _customerView;
        public AddMovieControl _addMovieControl;
        public UserInterface()
        {
            InitializeComponent();
            
            
            _loginControl = new LoginControl();
            _employeeView = new EmployeeView();
            _customerView = new CustomerView();
            _addMovieControl = new AddMovieControl();
            this.Controls.Add(this._loginControl);
            this.Size = new Size(this._loginControl.Width + 50, this._loginControl.Height + 50);
        }
    }
}
