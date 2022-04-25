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
            this.uxShowtimeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxTicketPriceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxAvgRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxSeeMovieInfo = new System.Windows.Forms.Button();
            this.uxBuyTicket = new System.Windows.Forms.Button();
            this.uxLogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer View";
            // 
            // uxListView
            // 
            this.uxListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.uxMovieColumn,
            this.uxShowtimeColumn,
            this.uxTicketPriceColumn,
            this.uxAvgRating});
            this.uxListView.GridLines = true;
            this.uxListView.HideSelection = false;
            this.uxListView.Location = new System.Drawing.Point(3, 65);
            this.uxListView.Name = "uxListView";
            this.uxListView.Size = new System.Drawing.Size(1166, 641);
            this.uxListView.TabIndex = 2;
            this.uxListView.UseCompatibleStateImageBehavior = false;
            this.uxListView.View = System.Windows.Forms.View.Details;
            // 
            // uxMovieColumn
            // 
            this.uxMovieColumn.Text = "Movie";
            this.uxMovieColumn.Width = 351;
            // 
            // uxShowtimeColumn
            // 
            this.uxShowtimeColumn.Text = "Showtime";
            this.uxShowtimeColumn.Width = 212;
            // 
            // uxTicketPriceColumn
            // 
            this.uxTicketPriceColumn.Text = "Ticket Price";
            this.uxTicketPriceColumn.Width = 192;
            // 
            // uxAvgRating
            // 
            this.uxAvgRating.Text = "Average Rating";
            this.uxAvgRating.Width = 343;
            // 
            // uxSeeMovieInfo
            // 
            this.uxSeeMovieInfo.Location = new System.Drawing.Point(419, 713);
            this.uxSeeMovieInfo.Name = "uxSeeMovieInfo";
            this.uxSeeMovieInfo.Size = new System.Drawing.Size(342, 193);
            this.uxSeeMovieInfo.TabIndex = 3;
            this.uxSeeMovieInfo.Text = "See Movie Info";
            this.uxSeeMovieInfo.UseVisualStyleBackColor = true;
            // 
            // uxBuyTicket
            // 
            this.uxBuyTicket.Location = new System.Drawing.Point(17, 712);
            this.uxBuyTicket.Name = "uxBuyTicket";
            this.uxBuyTicket.Size = new System.Drawing.Size(342, 193);
            this.uxBuyTicket.TabIndex = 4;
            this.uxBuyTicket.Text = "Buy Ticket";
            this.uxBuyTicket.UseVisualStyleBackColor = true;
            // 
            // uxLogoutButton
            // 
            this.uxLogoutButton.Location = new System.Drawing.Point(811, 712);
            this.uxLogoutButton.Name = "uxLogoutButton";
            this.uxLogoutButton.Size = new System.Drawing.Size(358, 193);
            this.uxLogoutButton.TabIndex = 5;
            this.uxLogoutButton.Text = "Logout";
            this.uxLogoutButton.UseVisualStyleBackColor = true;
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxLogoutButton);
            this.Controls.Add(this.uxBuyTicket);
            this.Controls.Add(this.uxSeeMovieInfo);
            this.Controls.Add(this.uxListView);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "CustomerView";
            this.Size = new System.Drawing.Size(1177, 909);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView uxListView;
        private System.Windows.Forms.ColumnHeader uxMovieColumn;
        private System.Windows.Forms.ColumnHeader uxShowtimeColumn;
        private System.Windows.Forms.ColumnHeader uxTicketPriceColumn;
        private System.Windows.Forms.ColumnHeader uxAvgRating;
        private System.Windows.Forms.Button uxSeeMovieInfo;
        private System.Windows.Forms.Button uxBuyTicket;
        private System.Windows.Forms.Button uxLogoutButton;
    }
}
