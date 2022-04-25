namespace FrontEnd
{
    partial class BuyTicketControl
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
            this.uxShowingBox = new System.Windows.Forms.ListBox();
            this.uxShowingLabel = new System.Windows.Forms.Label();
            this.uxBuyTicketButton = new System.Windows.Forms.Button();
            this.uxBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxShowingBox
            // 
            this.uxShowingBox.FormattingEnabled = true;
            this.uxShowingBox.Location = new System.Drawing.Point(3, 28);
            this.uxShowingBox.Name = "uxShowingBox";
            this.uxShowingBox.Size = new System.Drawing.Size(128, 186);
            this.uxShowingBox.TabIndex = 0;
            // 
            // uxShowingLabel
            // 
            this.uxShowingLabel.AutoSize = true;
            this.uxShowingLabel.Location = new System.Drawing.Point(15, 12);
            this.uxShowingLabel.Name = "uxShowingLabel";
            this.uxShowingLabel.Size = new System.Drawing.Size(99, 13);
            this.uxShowingLabel.TabIndex = 1;
            this.uxShowingLabel.Text = "Available Showings";
            // 
            // uxBuyTicketButton
            // 
            this.uxBuyTicketButton.Location = new System.Drawing.Point(137, 28);
            this.uxBuyTicketButton.Name = "uxBuyTicketButton";
            this.uxBuyTicketButton.Size = new System.Drawing.Size(102, 86);
            this.uxBuyTicketButton.TabIndex = 2;
            this.uxBuyTicketButton.Text = "Buy Ticket To Selected Showing";
            this.uxBuyTicketButton.UseVisualStyleBackColor = true;
            this.uxBuyTicketButton.Click += new System.EventHandler(this.uxBuyTicketButton_Click);
            // 
            // uxBackButton
            // 
            this.uxBackButton.Location = new System.Drawing.Point(137, 120);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(102, 94);
            this.uxBackButton.TabIndex = 3;
            this.uxBackButton.Text = "Back";
            this.uxBackButton.UseVisualStyleBackColor = true;
            this.uxBackButton.Click += new System.EventHandler(this.uxBackButton_Click);
            // 
            // BuyTicketControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxBackButton);
            this.Controls.Add(this.uxBuyTicketButton);
            this.Controls.Add(this.uxShowingLabel);
            this.Controls.Add(this.uxShowingBox);
            this.Name = "BuyTicketControl";
            this.Size = new System.Drawing.Size(242, 219);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox uxShowingBox;
        private System.Windows.Forms.Label uxShowingLabel;
        private System.Windows.Forms.Button uxBuyTicketButton;
        private System.Windows.Forms.Button uxBackButton;
    }
}
