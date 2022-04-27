namespace FrontEnd
{
    partial class EmployeeView
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
            this.uxSelectButton = new System.Windows.Forms.Button();
            this.uxDeleteSelectedButton = new System.Windows.Forms.Button();
            this.uxMovieBox = new System.Windows.Forms.ListBox();
            this.uxAddMovieButton = new System.Windows.Forms.Button();
            this.uxLogoutButton = new System.Windows.Forms.Button();
            this.uxViewTheatreInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxSelectButton
            // 
            this.uxSelectButton.Location = new System.Drawing.Point(331, 57);
            this.uxSelectButton.Name = "uxSelectButton";
            this.uxSelectButton.Size = new System.Drawing.Size(72, 48);
            this.uxSelectButton.TabIndex = 6;
            this.uxSelectButton.Text = "Modify Selected";
            this.uxSelectButton.UseVisualStyleBackColor = true;
            this.uxSelectButton.Click += new System.EventHandler(this.uxSelectButton_Click);
            // 
            // uxDeleteSelectedButton
            // 
            this.uxDeleteSelectedButton.Location = new System.Drawing.Point(331, 111);
            this.uxDeleteSelectedButton.Name = "uxDeleteSelectedButton";
            this.uxDeleteSelectedButton.Size = new System.Drawing.Size(72, 50);
            this.uxDeleteSelectedButton.TabIndex = 7;
            this.uxDeleteSelectedButton.Text = "Delete Selected";
            this.uxDeleteSelectedButton.UseVisualStyleBackColor = true;
            this.uxDeleteSelectedButton.Click += new System.EventHandler(this.uxDeleteSelectedButton_Click);
            // 
            // uxMovieBox
            // 
            this.uxMovieBox.FormattingEnabled = true;
            this.uxMovieBox.Location = new System.Drawing.Point(3, 3);
            this.uxMovieBox.Name = "uxMovieBox";
            this.uxMovieBox.Size = new System.Drawing.Size(322, 238);
            this.uxMovieBox.TabIndex = 8;
            this.uxMovieBox.SelectedIndexChanged += new System.EventHandler(this.uxMovieBox_SelectedIndexChanged);
            // 
            // uxAddMovieButton
            // 
            this.uxAddMovieButton.Location = new System.Drawing.Point(331, 3);
            this.uxAddMovieButton.Name = "uxAddMovieButton";
            this.uxAddMovieButton.Size = new System.Drawing.Size(72, 48);
            this.uxAddMovieButton.TabIndex = 9;
            this.uxAddMovieButton.Text = "Add Movie";
            this.uxAddMovieButton.UseVisualStyleBackColor = true;
            this.uxAddMovieButton.Click += new System.EventHandler(this.uxAddMovieButton_Click);
            // 
            // uxLogoutButton
            // 
            this.uxLogoutButton.Location = new System.Drawing.Point(331, 167);
            this.uxLogoutButton.Name = "uxLogoutButton";
            this.uxLogoutButton.Size = new System.Drawing.Size(72, 74);
            this.uxLogoutButton.TabIndex = 10;
            this.uxLogoutButton.Text = "Logout";
            this.uxLogoutButton.UseVisualStyleBackColor = true;
            this.uxLogoutButton.Click += new System.EventHandler(this.uxLogoutButton_Click);
            // 
            // uxViewTheatreInfo
            // 
            this.uxViewTheatreInfo.Location = new System.Drawing.Point(3, 247);
            this.uxViewTheatreInfo.Name = "uxViewTheatreInfo";
            this.uxViewTheatreInfo.Size = new System.Drawing.Size(87, 43);
            this.uxViewTheatreInfo.TabIndex = 11;
            this.uxViewTheatreInfo.Text = "View Theatre Info";
            this.uxViewTheatreInfo.UseVisualStyleBackColor = true;
            this.uxViewTheatreInfo.Click += new System.EventHandler(this.uxViewTheatreInfo_Click);
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxViewTheatreInfo);
            this.Controls.Add(this.uxLogoutButton);
            this.Controls.Add(this.uxAddMovieButton);
            this.Controls.Add(this.uxMovieBox);
            this.Controls.Add(this.uxDeleteSelectedButton);
            this.Controls.Add(this.uxSelectButton);
            this.Name = "EmployeeView";
            this.Size = new System.Drawing.Size(413, 293);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button uxSelectButton;
        private System.Windows.Forms.Button uxDeleteSelectedButton;
        private System.Windows.Forms.ListBox uxMovieBox;
        private System.Windows.Forms.Button uxAddMovieButton;
        private System.Windows.Forms.Button uxLogoutButton;
        private System.Windows.Forms.Button uxViewTheatreInfo;
    }
}
