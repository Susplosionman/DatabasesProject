namespace FrontEnd
{
    partial class TheatreInfoControl
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
            this.uxDataView = new System.Windows.Forms.DataGridView();
            this.uxGetMovieGrossSales = new System.Windows.Forms.Button();
            this.uxGetShowingStats = new System.Windows.Forms.Button();
            this.uxBackButton = new System.Windows.Forms.Button();
            this.uxGetStatsForGenreButton = new System.Windows.Forms.Button();
            this.uxGetUserStatisticsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // uxDataView
            // 
            this.uxDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataView.Location = new System.Drawing.Point(4, 24);
            this.uxDataView.Name = "uxDataView";
            this.uxDataView.Size = new System.Drawing.Size(523, 215);
            this.uxDataView.TabIndex = 0;
            // 
            // uxGetMovieGrossSales
            // 
            this.uxGetMovieGrossSales.Location = new System.Drawing.Point(4, 246);
            this.uxGetMovieGrossSales.Name = "uxGetMovieGrossSales";
            this.uxGetMovieGrossSales.Size = new System.Drawing.Size(91, 49);
            this.uxGetMovieGrossSales.TabIndex = 1;
            this.uxGetMovieGrossSales.Text = "Get Gross Sales";
            this.uxGetMovieGrossSales.UseVisualStyleBackColor = true;
            this.uxGetMovieGrossSales.Click += new System.EventHandler(this.uxGetMovieGrossSales_Click);
            // 
            // uxGetShowingStats
            // 
            this.uxGetShowingStats.Location = new System.Drawing.Point(102, 246);
            this.uxGetShowingStats.Name = "uxGetShowingStats";
            this.uxGetShowingStats.Size = new System.Drawing.Size(107, 49);
            this.uxGetShowingStats.TabIndex = 2;
            this.uxGetShowingStats.Text = "Stats For Showings in Specified TimeFrame";
            this.uxGetShowingStats.UseVisualStyleBackColor = true;
            this.uxGetShowingStats.Click += new System.EventHandler(this.uxGetShowingStats_Click);
            // 
            // uxBackButton
            // 
            this.uxBackButton.Location = new System.Drawing.Point(423, 245);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(104, 49);
            this.uxBackButton.TabIndex = 3;
            this.uxBackButton.Text = "Back";
            this.uxBackButton.UseVisualStyleBackColor = true;
            this.uxBackButton.Click += new System.EventHandler(this.uxBackButton_Click);
            // 
            // uxGetStatsForGenreButton
            // 
            this.uxGetStatsForGenreButton.Location = new System.Drawing.Point(216, 245);
            this.uxGetStatsForGenreButton.Name = "uxGetStatsForGenreButton";
            this.uxGetStatsForGenreButton.Size = new System.Drawing.Size(86, 49);
            this.uxGetStatsForGenreButton.TabIndex = 4;
            this.uxGetStatsForGenreButton.Text = "Stats For Movies in a Genre";
            this.uxGetStatsForGenreButton.UseVisualStyleBackColor = true;
            this.uxGetStatsForGenreButton.Click += new System.EventHandler(this.uxGetStatsForGenreButton_Click);
            // 
            // uxGetUserStatisticsButton
            // 
            this.uxGetUserStatisticsButton.Location = new System.Drawing.Point(309, 246);
            this.uxGetUserStatisticsButton.Name = "uxGetUserStatisticsButton";
            this.uxGetUserStatisticsButton.Size = new System.Drawing.Size(95, 48);
            this.uxGetUserStatisticsButton.TabIndex = 5;
            this.uxGetUserStatisticsButton.Text = "User Statistics";
            this.uxGetUserStatisticsButton.UseVisualStyleBackColor = true;
            this.uxGetUserStatisticsButton.Click += new System.EventHandler(this.uxGetUserStatisticsButton_Click);
            // 
            // TheatreInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxGetUserStatisticsButton);
            this.Controls.Add(this.uxGetStatsForGenreButton);
            this.Controls.Add(this.uxBackButton);
            this.Controls.Add(this.uxGetShowingStats);
            this.Controls.Add(this.uxGetMovieGrossSales);
            this.Controls.Add(this.uxDataView);
            this.Name = "TheatreInfoControl";
            this.Size = new System.Drawing.Size(530, 298);
            ((System.ComponentModel.ISupportInitialize)(this.uxDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView uxDataView;
        private System.Windows.Forms.Button uxGetMovieGrossSales;
        private System.Windows.Forms.Button uxGetShowingStats;
        private System.Windows.Forms.Button uxBackButton;
        private System.Windows.Forms.Button uxGetStatsForGenreButton;
        private System.Windows.Forms.Button uxGetUserStatisticsButton;
    }
}
