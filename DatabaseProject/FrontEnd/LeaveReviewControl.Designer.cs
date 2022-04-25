namespace FrontEnd
{
    partial class LeaveReviewControl
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
            this.uxRatingLabel = new System.Windows.Forms.Label();
            this.uxRatingUpDown = new System.Windows.Forms.NumericUpDown();
            this.uxCommentTB = new System.Windows.Forms.TextBox();
            this.uxCommentLabel = new System.Windows.Forms.Label();
            this.uxLeaveReviewButton = new System.Windows.Forms.Button();
            this.uxBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxRatingUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // uxRatingLabel
            // 
            this.uxRatingLabel.AutoSize = true;
            this.uxRatingLabel.Location = new System.Drawing.Point(15, 16);
            this.uxRatingLabel.Name = "uxRatingLabel";
            this.uxRatingLabel.Size = new System.Drawing.Size(41, 13);
            this.uxRatingLabel.TabIndex = 0;
            this.uxRatingLabel.Text = "Rating:";
            // 
            // uxRatingUpDown
            // 
            this.uxRatingUpDown.Location = new System.Drawing.Point(75, 16);
            this.uxRatingUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxRatingUpDown.Name = "uxRatingUpDown";
            this.uxRatingUpDown.Size = new System.Drawing.Size(45, 20);
            this.uxRatingUpDown.TabIndex = 1;
            this.uxRatingUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // uxCommentTB
            // 
            this.uxCommentTB.Location = new System.Drawing.Point(75, 65);
            this.uxCommentTB.Name = "uxCommentTB";
            this.uxCommentTB.Size = new System.Drawing.Size(117, 20);
            this.uxCommentTB.TabIndex = 2;
            // 
            // uxCommentLabel
            // 
            this.uxCommentLabel.AutoSize = true;
            this.uxCommentLabel.Location = new System.Drawing.Point(15, 68);
            this.uxCommentLabel.Name = "uxCommentLabel";
            this.uxCommentLabel.Size = new System.Drawing.Size(54, 13);
            this.uxCommentLabel.TabIndex = 3;
            this.uxCommentLabel.Text = "Comment:";
            // 
            // uxLeaveReviewButton
            // 
            this.uxLeaveReviewButton.Location = new System.Drawing.Point(189, 106);
            this.uxLeaveReviewButton.Name = "uxLeaveReviewButton";
            this.uxLeaveReviewButton.Size = new System.Drawing.Size(75, 41);
            this.uxLeaveReviewButton.TabIndex = 4;
            this.uxLeaveReviewButton.Text = "Leave Review";
            this.uxLeaveReviewButton.UseVisualStyleBackColor = true;
            this.uxLeaveReviewButton.Click += new System.EventHandler(this.uxLeaveReviewButton_Click);
            // 
            // uxBackButton
            // 
            this.uxBackButton.Location = new System.Drawing.Point(3, 106);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(76, 41);
            this.uxBackButton.TabIndex = 5;
            this.uxBackButton.Text = "Back";
            this.uxBackButton.UseVisualStyleBackColor = true;
            this.uxBackButton.Click += new System.EventHandler(this.uxBackButton_Click);
            // 
            // LeaveReviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxBackButton);
            this.Controls.Add(this.uxLeaveReviewButton);
            this.Controls.Add(this.uxCommentLabel);
            this.Controls.Add(this.uxCommentTB);
            this.Controls.Add(this.uxRatingUpDown);
            this.Controls.Add(this.uxRatingLabel);
            this.Name = "LeaveReviewControl";
            this.Size = new System.Drawing.Size(267, 150);
            ((System.ComponentModel.ISupportInitialize)(this.uxRatingUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxRatingLabel;
        private System.Windows.Forms.NumericUpDown uxRatingUpDown;
        private System.Windows.Forms.TextBox uxCommentTB;
        private System.Windows.Forms.Label uxCommentLabel;
        private System.Windows.Forms.Button uxLeaveReviewButton;
        private System.Windows.Forms.Button uxBackButton;
    }
}
