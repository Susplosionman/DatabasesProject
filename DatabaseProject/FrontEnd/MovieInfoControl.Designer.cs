namespace FrontEnd
{
    partial class MovieInfoControl
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
            this.uxMovieName = new System.Windows.Forms.Label();
            this.uxDirector = new System.Windows.Forms.Label();
            this.uxRating = new System.Windows.Forms.Label();
            this.uxMovieLabel = new System.Windows.Forms.Label();
            this.uxDirectorLabel = new System.Windows.Forms.Label();
            this.uxRatingLabel = new System.Windows.Forms.Label();
            this.uxBackButton = new System.Windows.Forms.Button();
            this.uxLeaveReviewButton = new System.Windows.Forms.Button();
            this.uxShowingBox = new System.Windows.Forms.ListBox();
            this.uxShowingsLabel = new System.Windows.Forms.Label();
            this.uxBuyTicketButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxMovieName
            // 
            this.uxMovieName.AutoSize = true;
            this.uxMovieName.Location = new System.Drawing.Point(12, 36);
            this.uxMovieName.Name = "uxMovieName";
            this.uxMovieName.Size = new System.Drawing.Size(70, 13);
            this.uxMovieName.TabIndex = 0;
            this.uxMovieName.Text = "Movie Name:";
            // 
            // uxDirector
            // 
            this.uxDirector.AutoSize = true;
            this.uxDirector.Location = new System.Drawing.Point(12, 84);
            this.uxDirector.Name = "uxDirector";
            this.uxDirector.Size = new System.Drawing.Size(47, 13);
            this.uxDirector.TabIndex = 1;
            this.uxDirector.Text = "Director:";
            // 
            // uxRating
            // 
            this.uxRating.AutoSize = true;
            this.uxRating.Location = new System.Drawing.Point(12, 136);
            this.uxRating.Name = "uxRating";
            this.uxRating.Size = new System.Drawing.Size(41, 13);
            this.uxRating.TabIndex = 3;
            this.uxRating.Text = "Rating:";
            // 
            // uxMovieLabel
            // 
            this.uxMovieLabel.AutoSize = true;
            this.uxMovieLabel.Location = new System.Drawing.Point(88, 36);
            this.uxMovieLabel.Name = "uxMovieLabel";
            this.uxMovieLabel.Size = new System.Drawing.Size(70, 13);
            this.uxMovieLabel.TabIndex = 5;
            this.uxMovieLabel.Text = "Movie Name:";
            // 
            // uxDirectorLabel
            // 
            this.uxDirectorLabel.AutoSize = true;
            this.uxDirectorLabel.Location = new System.Drawing.Point(88, 84);
            this.uxDirectorLabel.Name = "uxDirectorLabel";
            this.uxDirectorLabel.Size = new System.Drawing.Size(70, 13);
            this.uxDirectorLabel.TabIndex = 6;
            this.uxDirectorLabel.Text = "Movie Name:";
            // 
            // uxRatingLabel
            // 
            this.uxRatingLabel.AutoSize = true;
            this.uxRatingLabel.Location = new System.Drawing.Point(88, 136);
            this.uxRatingLabel.Name = "uxRatingLabel";
            this.uxRatingLabel.Size = new System.Drawing.Size(70, 13);
            this.uxRatingLabel.TabIndex = 8;
            this.uxRatingLabel.Text = "Movie Name:";
            // 
            // uxBackButton
            // 
            this.uxBackButton.Location = new System.Drawing.Point(3, 251);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(111, 68);
            this.uxBackButton.TabIndex = 11;
            this.uxBackButton.Text = "Back";
            this.uxBackButton.UseVisualStyleBackColor = true;
            this.uxBackButton.Click += new System.EventHandler(this.uxBackButton_Click);
            // 
            // uxLeaveReviewButton
            // 
            this.uxLeaveReviewButton.Location = new System.Drawing.Point(148, 251);
            this.uxLeaveReviewButton.Name = "uxLeaveReviewButton";
            this.uxLeaveReviewButton.Size = new System.Drawing.Size(105, 68);
            this.uxLeaveReviewButton.TabIndex = 12;
            this.uxLeaveReviewButton.Text = "Leave Review";
            this.uxLeaveReviewButton.UseVisualStyleBackColor = true;
            this.uxLeaveReviewButton.Click += new System.EventHandler(this.uxLeaveReviewButton_Click);
            // 
            // uxShowingBox
            // 
            this.uxShowingBox.FormattingEnabled = true;
            this.uxShowingBox.Location = new System.Drawing.Point(248, 36);
            this.uxShowingBox.Name = "uxShowingBox";
            this.uxShowingBox.Size = new System.Drawing.Size(120, 186);
            this.uxShowingBox.TabIndex = 13;
            // 
            // uxShowingsLabel
            // 
            this.uxShowingsLabel.AutoSize = true;
            this.uxShowingsLabel.Location = new System.Drawing.Point(262, 20);
            this.uxShowingsLabel.Name = "uxShowingsLabel";
            this.uxShowingsLabel.Size = new System.Drawing.Size(90, 13);
            this.uxShowingsLabel.TabIndex = 14;
            this.uxShowingsLabel.Text = "Current Showings";
            // 
            // uxBuyTicketButton
            // 
            this.uxBuyTicketButton.Location = new System.Drawing.Point(294, 251);
            this.uxBuyTicketButton.Name = "uxBuyTicketButton";
            this.uxBuyTicketButton.Size = new System.Drawing.Size(105, 68);
            this.uxBuyTicketButton.TabIndex = 15;
            this.uxBuyTicketButton.Text = "Buy Ticket";
            this.uxBuyTicketButton.UseVisualStyleBackColor = true;
            this.uxBuyTicketButton.Click += new System.EventHandler(this.uxBuyTicketButton_Click);
            // 
            // MovieInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxBuyTicketButton);
            this.Controls.Add(this.uxShowingsLabel);
            this.Controls.Add(this.uxShowingBox);
            this.Controls.Add(this.uxLeaveReviewButton);
            this.Controls.Add(this.uxBackButton);
            this.Controls.Add(this.uxRatingLabel);
            this.Controls.Add(this.uxDirectorLabel);
            this.Controls.Add(this.uxMovieLabel);
            this.Controls.Add(this.uxRating);
            this.Controls.Add(this.uxDirector);
            this.Controls.Add(this.uxMovieName);
            this.Name = "MovieInfoControl";
            this.Size = new System.Drawing.Size(402, 322);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxMovieName;
        private System.Windows.Forms.Label uxDirector;
        private System.Windows.Forms.Label uxRating;
        private System.Windows.Forms.Label uxMovieLabel;
        private System.Windows.Forms.Label uxDirectorLabel;
        private System.Windows.Forms.Label uxRatingLabel;
        private System.Windows.Forms.Button uxBackButton;
        private System.Windows.Forms.Button uxLeaveReviewButton;
        private System.Windows.Forms.ListBox uxShowingBox;
        private System.Windows.Forms.Label uxShowingsLabel;
        private System.Windows.Forms.Button uxBuyTicketButton;
    }
}
