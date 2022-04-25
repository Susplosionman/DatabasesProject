namespace FrontEnd
{
    partial class RegisterUserControl
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
            this.uxPasswordTB = new System.Windows.Forms.MaskedTextBox();
            this.uxUsernameTB = new System.Windows.Forms.TextBox();
            this.uxCustomerRegister = new System.Windows.Forms.Button();
            this.uxEmployeeRegister = new System.Windows.Forms.Button();
            this.uxPasswordLabel = new System.Windows.Forms.Label();
            this.uxUsernameLabel = new System.Windows.Forms.Label();
            this.uxRegisterLabel = new System.Windows.Forms.Label();
            this.uxReturnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxPasswordTB
            // 
            this.uxPasswordTB.Location = new System.Drawing.Point(62, 65);
            this.uxPasswordTB.Name = "uxPasswordTB";
            this.uxPasswordTB.Size = new System.Drawing.Size(100, 20);
            this.uxPasswordTB.TabIndex = 11;
            // 
            // uxUsernameTB
            // 
            this.uxUsernameTB.Location = new System.Drawing.Point(64, 31);
            this.uxUsernameTB.Name = "uxUsernameTB";
            this.uxUsernameTB.Size = new System.Drawing.Size(100, 20);
            this.uxUsernameTB.TabIndex = 10;
            // 
            // uxCustomerRegister
            // 
            this.uxCustomerRegister.Location = new System.Drawing.Point(89, 91);
            this.uxCustomerRegister.Name = "uxCustomerRegister";
            this.uxCustomerRegister.Size = new System.Drawing.Size(75, 46);
            this.uxCustomerRegister.TabIndex = 9;
            this.uxCustomerRegister.Text = "Register as Customer";
            this.uxCustomerRegister.UseVisualStyleBackColor = true;
            // 
            // uxEmployeeRegister
            // 
            this.uxEmployeeRegister.Location = new System.Drawing.Point(6, 91);
            this.uxEmployeeRegister.Name = "uxEmployeeRegister";
            this.uxEmployeeRegister.Size = new System.Drawing.Size(75, 46);
            this.uxEmployeeRegister.TabIndex = 8;
            this.uxEmployeeRegister.Text = "Register as Employee";
            this.uxEmployeeRegister.UseVisualStyleBackColor = true;
            // 
            // uxPasswordLabel
            // 
            this.uxPasswordLabel.AutoSize = true;
            this.uxPasswordLabel.Location = new System.Drawing.Point(3, 65);
            this.uxPasswordLabel.Name = "uxPasswordLabel";
            this.uxPasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.uxPasswordLabel.TabIndex = 7;
            this.uxPasswordLabel.Text = "Password";
            // 
            // uxUsernameLabel
            // 
            this.uxUsernameLabel.AutoSize = true;
            this.uxUsernameLabel.Location = new System.Drawing.Point(3, 34);
            this.uxUsernameLabel.Name = "uxUsernameLabel";
            this.uxUsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.uxUsernameLabel.TabIndex = 6;
            this.uxUsernameLabel.Text = "Username";
            // 
            // uxRegisterLabel
            // 
            this.uxRegisterLabel.AutoSize = true;
            this.uxRegisterLabel.Location = new System.Drawing.Point(61, 0);
            this.uxRegisterLabel.Name = "uxRegisterLabel";
            this.uxRegisterLabel.Size = new System.Drawing.Size(46, 13);
            this.uxRegisterLabel.TabIndex = 12;
            this.uxRegisterLabel.Text = "Register";
            // 
            // uxReturnButton
            // 
            this.uxReturnButton.Location = new System.Drawing.Point(170, 91);
            this.uxReturnButton.Name = "uxReturnButton";
            this.uxReturnButton.Size = new System.Drawing.Size(69, 46);
            this.uxReturnButton.TabIndex = 13;
            this.uxReturnButton.Text = "Return to Login";
            this.uxReturnButton.UseVisualStyleBackColor = true;
            // 
            // RegisterUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxReturnButton);
            this.Controls.Add(this.uxRegisterLabel);
            this.Controls.Add(this.uxPasswordTB);
            this.Controls.Add(this.uxUsernameTB);
            this.Controls.Add(this.uxCustomerRegister);
            this.Controls.Add(this.uxEmployeeRegister);
            this.Controls.Add(this.uxPasswordLabel);
            this.Controls.Add(this.uxUsernameLabel);
            this.Name = "RegisterUserControl";
            this.Size = new System.Drawing.Size(242, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox uxPasswordTB;
        private System.Windows.Forms.TextBox uxUsernameTB;
        private System.Windows.Forms.Button uxCustomerRegister;
        private System.Windows.Forms.Button uxEmployeeRegister;
        private System.Windows.Forms.Label uxPasswordLabel;
        private System.Windows.Forms.Label uxUsernameLabel;
        private System.Windows.Forms.Label uxRegisterLabel;
        private System.Windows.Forms.Button uxReturnButton;
    }
}
