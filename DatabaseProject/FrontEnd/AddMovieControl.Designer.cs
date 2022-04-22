namespace FrontEnd
{
    partial class AddMovieControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.uxMovieNameTB = new System.Windows.Forms.TextBox();
            this.uxMovieNameLabel = new System.Windows.Forms.Label();
            this.uxDirectorNameLabel = new System.Windows.Forms.Label();
            this.uxDirectorTB = new System.Windows.Forms.TextBox();
            this.Genre = new System.Windows.Forms.Label();
            this.uxGenreTB = new System.Windows.Forms.TextBox();
            this.uxDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.uxAddMovieButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Movie";
            // 
            // uxMovieNameTB
            // 
            this.uxMovieNameTB.Location = new System.Drawing.Point(89, 56);
            this.uxMovieNameTB.Name = "uxMovieNameTB";
            this.uxMovieNameTB.Size = new System.Drawing.Size(100, 20);
            this.uxMovieNameTB.TabIndex = 1;
            // 
            // uxMovieNameLabel
            // 
            this.uxMovieNameLabel.AutoSize = true;
            this.uxMovieNameLabel.Location = new System.Drawing.Point(13, 59);
            this.uxMovieNameLabel.Name = "uxMovieNameLabel";
            this.uxMovieNameLabel.Size = new System.Drawing.Size(70, 13);
            this.uxMovieNameLabel.TabIndex = 2;
            this.uxMovieNameLabel.Text = "Movie Name:";
            // 
            // uxDirectorNameLabel
            // 
            this.uxDirectorNameLabel.AutoSize = true;
            this.uxDirectorNameLabel.Location = new System.Drawing.Point(13, 97);
            this.uxDirectorNameLabel.Name = "uxDirectorNameLabel";
            this.uxDirectorNameLabel.Size = new System.Drawing.Size(78, 13);
            this.uxDirectorNameLabel.TabIndex = 3;
            this.uxDirectorNameLabel.Text = "Director Name:";
            // 
            // uxDirectorTB
            // 
            this.uxDirectorTB.Location = new System.Drawing.Point(89, 97);
            this.uxDirectorTB.Name = "uxDirectorTB";
            this.uxDirectorTB.Size = new System.Drawing.Size(100, 20);
            this.uxDirectorTB.TabIndex = 4;
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Location = new System.Drawing.Point(13, 143);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(39, 13);
            this.Genre.TabIndex = 5;
            this.Genre.Text = "Genre:";
            // 
            // uxGenreTB
            // 
            this.uxGenreTB.Location = new System.Drawing.Point(89, 140);
            this.uxGenreTB.Name = "uxGenreTB";
            this.uxGenreTB.Size = new System.Drawing.Size(100, 20);
            this.uxGenreTB.TabIndex = 6;
            // 
            // uxDateTimePicker
            // 
            this.uxDateTimePicker.Location = new System.Drawing.Point(89, 183);
            this.uxDateTimePicker.Name = "uxDateTimePicker";
            this.uxDateTimePicker.Size = new System.Drawing.Size(265, 20);
            this.uxDateTimePicker.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Release Date:";
            // 
            // uxAddMovieButton
            // 
            this.uxAddMovieButton.Location = new System.Drawing.Point(224, 56);
            this.uxAddMovieButton.Name = "uxAddMovieButton";
            this.uxAddMovieButton.Size = new System.Drawing.Size(130, 104);
            this.uxAddMovieButton.TabIndex = 9;
            this.uxAddMovieButton.TabStop = false;
            this.uxAddMovieButton.Text = "Add Movie";
            this.uxAddMovieButton.UseVisualStyleBackColor = true;
            this.uxAddMovieButton.Click += new System.EventHandler(this.uxAddMovieButton_Click);
            // 
            // AddMovieControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxAddMovieButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxDateTimePicker);
            this.Controls.Add(this.uxGenreTB);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.uxDirectorTB);
            this.Controls.Add(this.uxDirectorNameLabel);
            this.Controls.Add(this.uxMovieNameLabel);
            this.Controls.Add(this.uxMovieNameTB);
            this.Controls.Add(this.label1);
            this.Name = "AddMovieControl";
            this.Size = new System.Drawing.Size(381, 262);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxMovieNameTB;
        private System.Windows.Forms.Label uxMovieNameLabel;
        private System.Windows.Forms.Label uxDirectorNameLabel;
        private System.Windows.Forms.TextBox uxDirectorTB;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.TextBox uxGenreTB;
        private System.Windows.Forms.DateTimePicker uxDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uxAddMovieButton;
    }
}
