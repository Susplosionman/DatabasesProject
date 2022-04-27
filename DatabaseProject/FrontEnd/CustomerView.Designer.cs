namespace FrontEnd
{
    partial class CustomerView
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
            this.uxListView = new System.Windows.Forms.ListView();
            this.uxMovieColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxAvgRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxIsShowing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxSeeMovieInfo = new System.Windows.Forms.Button();
            this.uxBuyTicket = new System.Windows.Forms.Button();
            this.uxLogoutButton = new System.Windows.Forms.Button();
            this.uxUserProfileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer View";
            // 
            // uxListView
            // 
            this.uxListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.uxMovieColumn,
            this.uxAvgRating,
            this.uxIsShowing});
            this.uxListView.GridLines = true;
            this.uxListView.HideSelection = false;
            this.uxListView.Location = new System.Drawing.Point(5, 23);
            this.uxListView.Margin = new System.Windows.Forms.Padding(1);
            this.uxListView.Name = "uxListView";
            this.uxListView.Size = new System.Drawing.Size(482, 225);
            this.uxListView.TabIndex = 2;
            this.uxListView.UseCompatibleStateImageBehavior = false;
            this.uxListView.View = System.Windows.Forms.View.Details;
            // 
            // uxMovieColumn
            // 
            this.uxMovieColumn.Text = "Movie";
            this.uxMovieColumn.Width = 253;
            // 
            // uxAvgRating
            // 
            this.uxAvgRating.Text = "Average Rating";
            this.uxAvgRating.Width = 87;
            // 
            // uxIsShowing
            // 
            this.uxIsShowing.Text = "Is Currently Showing";
            this.uxIsShowing.Width = 136;
            // 
            // uxSeeMovieInfo
            // 
            this.uxSeeMovieInfo.Location = new System.Drawing.Point(266, 250);
            this.uxSeeMovieInfo.Margin = new System.Windows.Forms.Padding(1);
            this.uxSeeMovieInfo.Name = "uxSeeMovieInfo";
            this.uxSeeMovieInfo.Size = new System.Drawing.Size(88, 68);
            this.uxSeeMovieInfo.TabIndex = 3;
            this.uxSeeMovieInfo.Text = "See Movie Info";
            this.uxSeeMovieInfo.UseVisualStyleBackColor = true;
            this.uxSeeMovieInfo.Click += new System.EventHandler(this.uxSeeMovieInfo_Click);
            // 
            // uxBuyTicket
            // 
            this.uxBuyTicket.Location = new System.Drawing.Point(136, 250);
            this.uxBuyTicket.Margin = new System.Windows.Forms.Padding(1);
            this.uxBuyTicket.Name = "uxBuyTicket";
            this.uxBuyTicket.Size = new System.Drawing.Size(95, 68);
            this.uxBuyTicket.TabIndex = 4;
            this.uxBuyTicket.Text = "Buy Ticket";
            this.uxBuyTicket.UseVisualStyleBackColor = true;
            this.uxBuyTicket.Click += new System.EventHandler(this.uxBuyTicket_Click);
            // 
            // uxLogoutButton
            // 
            this.uxLogoutButton.Location = new System.Drawing.Point(392, 250);
            this.uxLogoutButton.Margin = new System.Windows.Forms.Padding(1);
            this.uxLogoutButton.Name = "uxLogoutButton";
            this.uxLogoutButton.Size = new System.Drawing.Size(95, 68);
            this.uxLogoutButton.TabIndex = 5;
            this.uxLogoutButton.Text = "Logout";
            this.uxLogoutButton.UseVisualStyleBackColor = true;
            this.uxLogoutButton.Click += new System.EventHandler(this.uxLogoutButton_Click);
            // 
            // uxUserProfileButton
            // 
            this.uxUserProfileButton.Location = new System.Drawing.Point(5, 250);
            this.uxUserProfileButton.Margin = new System.Windows.Forms.Padding(1);
            this.uxUserProfileButton.Name = "uxUserProfileButton";
            this.uxUserProfileButton.Size = new System.Drawing.Size(95, 68);
            this.uxUserProfileButton.TabIndex = 6;
            this.uxUserProfileButton.Text = "Go To User Profile";
            this.uxUserProfileButton.UseVisualStyleBackColor = true;
            this.uxUserProfileButton.Click += new System.EventHandler(this.uxUserProfileButton_Click);
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxUserProfileButton);
            this.Controls.Add(this.uxLogoutButton);
            this.Controls.Add(this.uxBuyTicket);
            this.Controls.Add(this.uxSeeMovieInfo);
            this.Controls.Add(this.uxListView);
            this.Controls.Add(this.label1);
            this.Name = "CustomerView";
            this.Size = new System.Drawing.Size(490, 319);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView uxListView;
        private System.Windows.Forms.ColumnHeader uxMovieColumn;
        private System.Windows.Forms.ColumnHeader uxAvgRating;
        private System.Windows.Forms.Button uxSeeMovieInfo;
        private System.Windows.Forms.Button uxBuyTicket;
        private System.Windows.Forms.Button uxLogoutButton;
        private System.Windows.Forms.ColumnHeader uxIsShowing;
        private System.Windows.Forms.Button uxUserProfileButton;
    }
}
