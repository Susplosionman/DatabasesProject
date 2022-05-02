namespace FrontEnd
{
    partial class UserProfile
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
            this.uxDataGrid = new System.Windows.Forms.DataGridView();
            this.uxUsernameLabel = new System.Windows.Forms.Label();
            this.uxViewReviewsButton = new System.Windows.Forms.Button();
            this.uxViewMoviesAttendedButton = new System.Windows.Forms.Button();
            this.uxBackButton = new System.Windows.Forms.Button();
            this.uxDeleteReview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxDataGrid
            // 
            this.uxDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataGrid.Location = new System.Drawing.Point(3, 42);
            this.uxDataGrid.Name = "uxDataGrid";
            this.uxDataGrid.RowHeadersWidth = 123;
            this.uxDataGrid.Size = new System.Drawing.Size(503, 185);
            this.uxDataGrid.TabIndex = 0;
            // 
            // uxUsernameLabel
            // 
            this.uxUsernameLabel.AutoSize = true;
            this.uxUsernameLabel.Location = new System.Drawing.Point(3, 12);
            this.uxUsernameLabel.Name = "uxUsernameLabel";
            this.uxUsernameLabel.Size = new System.Drawing.Size(50, 13);
            this.uxUsernameLabel.TabIndex = 1;
            this.uxUsernameLabel.Text = "x\'s profile";
            // 
            // uxViewReviewsButton
            // 
            this.uxViewReviewsButton.Location = new System.Drawing.Point(6, 234);
            this.uxViewReviewsButton.Name = "uxViewReviewsButton";
            this.uxViewReviewsButton.Size = new System.Drawing.Size(109, 50);
            this.uxViewReviewsButton.TabIndex = 2;
            this.uxViewReviewsButton.Text = "View User Reviews";
            this.uxViewReviewsButton.UseVisualStyleBackColor = true;
            this.uxViewReviewsButton.Click += new System.EventHandler(this.uxViewReviewsButton_Click);
            // 
            // uxViewMoviesAttendedButton
            // 
            this.uxViewMoviesAttendedButton.Location = new System.Drawing.Point(121, 233);
            this.uxViewMoviesAttendedButton.Name = "uxViewMoviesAttendedButton";
            this.uxViewMoviesAttendedButton.Size = new System.Drawing.Size(109, 50);
            this.uxViewMoviesAttendedButton.TabIndex = 3;
            this.uxViewMoviesAttendedButton.Text = "View User Movies Attended";
            this.uxViewMoviesAttendedButton.UseVisualStyleBackColor = true;
            this.uxViewMoviesAttendedButton.Click += new System.EventHandler(this.uxViewMoviesAttendedButton_Click);
            // 
            // uxBackButton
            // 
            this.uxBackButton.Location = new System.Drawing.Point(397, 233);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(109, 50);
            this.uxBackButton.TabIndex = 4;
            this.uxBackButton.Text = "Back";
            this.uxBackButton.UseVisualStyleBackColor = true;
            this.uxBackButton.Click += new System.EventHandler(this.uxBackButton_Click);
            // 
            // uxDeleteReview
            // 
            this.uxDeleteReview.Location = new System.Drawing.Point(237, 234);
            this.uxDeleteReview.Margin = new System.Windows.Forms.Padding(1);
            this.uxDeleteReview.Name = "uxDeleteReview";
            this.uxDeleteReview.Size = new System.Drawing.Size(110, 50);
            this.uxDeleteReview.TabIndex = 5;
            this.uxDeleteReview.Text = "Delete Selected Review";
            this.uxDeleteReview.UseVisualStyleBackColor = true;
            this.uxDeleteReview.Click += new System.EventHandler(this.uxDeleteReview_Click);
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxDeleteReview);
            this.Controls.Add(this.uxBackButton);
            this.Controls.Add(this.uxViewMoviesAttendedButton);
            this.Controls.Add(this.uxViewReviewsButton);
            this.Controls.Add(this.uxUsernameLabel);
            this.Controls.Add(this.uxDataGrid);
            this.Name = "UserProfile";
            this.Size = new System.Drawing.Size(511, 287);
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uxDataGrid;
        private System.Windows.Forms.Label uxUsernameLabel;
        private System.Windows.Forms.Button uxViewReviewsButton;
        private System.Windows.Forms.Button uxViewMoviesAttendedButton;
        private System.Windows.Forms.Button uxBackButton;
        private System.Windows.Forms.Button uxDeleteReview;
    }
}
