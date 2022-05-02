namespace FrontEnd
{
    partial class LoginControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxUsernameLabel = new System.Windows.Forms.Label();
            this.uxPasswordLabel = new System.Windows.Forms.Label();
            this.uxEmployeeLogin = new System.Windows.Forms.Button();
            this.uxCustomerLogin = new System.Windows.Forms.Button();
            this.uxUsernameTB = new System.Windows.Forms.TextBox();
            this.uxPasswordTB = new System.Windows.Forms.MaskedTextBox();
            this.uxEmployeeRegisterButton = new System.Windows.Forms.Button();
            this.uxCustomerRegisterButton = new System.Windows.Forms.Button();
            this.uxResponseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxUsernameLabel
            // 
            this.uxUsernameLabel.AutoSize = true;
            this.uxUsernameLabel.Location = new System.Drawing.Point(14, 11);
            this.uxUsernameLabel.Name = "uxUsernameLabel";
            this.uxUsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.uxUsernameLabel.TabIndex = 0;
            this.uxUsernameLabel.Text = "Username";
            // 
            // uxPasswordLabel
            // 
            this.uxPasswordLabel.AutoSize = true;
            this.uxPasswordLabel.Location = new System.Drawing.Point(14, 42);
            this.uxPasswordLabel.Name = "uxPasswordLabel";
            this.uxPasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.uxPasswordLabel.TabIndex = 1;
            this.uxPasswordLabel.Text = "Password";
            // 
            // uxEmployeeLogin
            // 
            this.uxEmployeeLogin.Location = new System.Drawing.Point(17, 68);
            this.uxEmployeeLogin.Name = "uxEmployeeLogin";
            this.uxEmployeeLogin.Size = new System.Drawing.Size(75, 46);
            this.uxEmployeeLogin.TabIndex = 2;
            this.uxEmployeeLogin.Text = "Login as Employee";
            this.uxEmployeeLogin.UseVisualStyleBackColor = true;
            this.uxEmployeeLogin.Click += new System.EventHandler(this.uxEmployeeLogin_Click);
            // 
            // uxCustomerLogin
            // 
            this.uxCustomerLogin.Location = new System.Drawing.Point(100, 68);
            this.uxCustomerLogin.Name = "uxCustomerLogin";
            this.uxCustomerLogin.Size = new System.Drawing.Size(75, 46);
            this.uxCustomerLogin.TabIndex = 3;
            this.uxCustomerLogin.Text = "Login as Customer";
            this.uxCustomerLogin.UseVisualStyleBackColor = true;
            this.uxCustomerLogin.Click += new System.EventHandler(this.uxCustomerLogin_Click);
            // 
            // uxUsernameTB
            // 
            this.uxUsernameTB.Location = new System.Drawing.Point(75, 8);
            this.uxUsernameTB.Name = "uxUsernameTB";
            this.uxUsernameTB.Size = new System.Drawing.Size(100, 20);
            this.uxUsernameTB.TabIndex = 4;
            // 
            // uxPasswordTB
            // 
            this.uxPasswordTB.Location = new System.Drawing.Point(75, 42);
            this.uxPasswordTB.Name = "uxPasswordTB";
            this.uxPasswordTB.PasswordChar = '*';
            this.uxPasswordTB.Size = new System.Drawing.Size(100, 20);
            this.uxPasswordTB.TabIndex = 5;
            // 
            // uxEmployeeRegisterButton
            // 
            this.uxEmployeeRegisterButton.Location = new System.Drawing.Point(17, 146);
            this.uxEmployeeRegisterButton.Name = "uxEmployeeRegisterButton";
            this.uxEmployeeRegisterButton.Size = new System.Drawing.Size(75, 46);
            this.uxEmployeeRegisterButton.TabIndex = 10;
            this.uxEmployeeRegisterButton.Text = "Register as Employee";
            this.uxEmployeeRegisterButton.UseVisualStyleBackColor = true;
            this.uxEmployeeRegisterButton.Click += new System.EventHandler(this.uxEmployeeRegisterButton_Click);
            // 
            // uxCustomerRegisterButton
            // 
            this.uxCustomerRegisterButton.Location = new System.Drawing.Point(98, 146);
            this.uxCustomerRegisterButton.Name = "uxCustomerRegisterButton";
            this.uxCustomerRegisterButton.Size = new System.Drawing.Size(75, 46);
            this.uxCustomerRegisterButton.TabIndex = 11;
            this.uxCustomerRegisterButton.Text = "Register as Customer";
            this.uxCustomerRegisterButton.UseVisualStyleBackColor = true;
            this.uxCustomerRegisterButton.Click += new System.EventHandler(this.uxCustomerRegisterButton_Click);
            // 
            // uxResponseLabel
            // 
            this.uxResponseLabel.AutoSize = true;
            this.uxResponseLabel.Location = new System.Drawing.Point(31, 117);
            this.uxResponseLabel.Name = "uxResponseLabel";
            this.uxResponseLabel.Size = new System.Drawing.Size(132, 26);
            this.uxResponseLabel.TabIndex = 12;
            this.uxResponseLabel.Text = "Enter credentials to log in, \r\nor register below.";
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxResponseLabel);
            this.Controls.Add(this.uxCustomerRegisterButton);
            this.Controls.Add(this.uxEmployeeRegisterButton);
            this.Controls.Add(this.uxPasswordTB);
            this.Controls.Add(this.uxUsernameTB);
            this.Controls.Add(this.uxCustomerLogin);
            this.Controls.Add(this.uxEmployeeLogin);
            this.Controls.Add(this.uxPasswordLabel);
            this.Controls.Add(this.uxUsernameLabel);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(187, 204);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxUsernameLabel;
        private System.Windows.Forms.Label uxPasswordLabel;
        private System.Windows.Forms.Button uxEmployeeLogin;
        private System.Windows.Forms.Button uxCustomerLogin;
        private System.Windows.Forms.TextBox uxUsernameTB;
        private System.Windows.Forms.MaskedTextBox uxPasswordTB;
        private System.Windows.Forms.Button uxEmployeeRegisterButton;
        private System.Windows.Forms.Button uxCustomerRegisterButton;
        private System.Windows.Forms.Label uxResponseLabel;
    }
}
