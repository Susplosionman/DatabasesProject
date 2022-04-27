namespace FrontEnd
{
    partial class GetTimeframe
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxFromPicker = new System.Windows.Forms.DateTimePicker();
            this.uxToPicker = new System.Windows.Forms.DateTimePicker();
            this.uxFromLabel = new System.Windows.Forms.Label();
            this.uxToLabel = new System.Windows.Forms.Label();
            this.uxSubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxFromPicker
            // 
            this.uxFromPicker.Location = new System.Drawing.Point(51, 22);
            this.uxFromPicker.Name = "uxFromPicker";
            this.uxFromPicker.Size = new System.Drawing.Size(200, 20);
            this.uxFromPicker.TabIndex = 0;
            // 
            // uxToPicker
            // 
            this.uxToPicker.Location = new System.Drawing.Point(51, 70);
            this.uxToPicker.Name = "uxToPicker";
            this.uxToPicker.Size = new System.Drawing.Size(200, 20);
            this.uxToPicker.TabIndex = 1;
            // 
            // uxFromLabel
            // 
            this.uxFromLabel.AutoSize = true;
            this.uxFromLabel.Location = new System.Drawing.Point(12, 28);
            this.uxFromLabel.Name = "uxFromLabel";
            this.uxFromLabel.Size = new System.Drawing.Size(33, 13);
            this.uxFromLabel.TabIndex = 2;
            this.uxFromLabel.Text = "From:";
            // 
            // uxToLabel
            // 
            this.uxToLabel.AutoSize = true;
            this.uxToLabel.Location = new System.Drawing.Point(12, 70);
            this.uxToLabel.Name = "uxToLabel";
            this.uxToLabel.Size = new System.Drawing.Size(23, 13);
            this.uxToLabel.TabIndex = 3;
            this.uxToLabel.Text = "To:";
            // 
            // uxSubmitButton
            // 
            this.uxSubmitButton.Location = new System.Drawing.Point(273, 112);
            this.uxSubmitButton.Name = "uxSubmitButton";
            this.uxSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.uxSubmitButton.TabIndex = 4;
            this.uxSubmitButton.Text = "Submit";
            this.uxSubmitButton.UseVisualStyleBackColor = true;
            this.uxSubmitButton.Click += new System.EventHandler(this.uxSubmitButton_Click);
            // 
            // GetTimeframe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 147);
            this.Controls.Add(this.uxSubmitButton);
            this.Controls.Add(this.uxToLabel);
            this.Controls.Add(this.uxFromLabel);
            this.Controls.Add(this.uxToPicker);
            this.Controls.Add(this.uxFromPicker);
            this.Name = "GetTimeframe";
            this.Text = "GetTimeframe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker uxFromPicker;
        private System.Windows.Forms.DateTimePicker uxToPicker;
        private System.Windows.Forms.Label uxFromLabel;
        private System.Windows.Forms.Label uxToLabel;
        private System.Windows.Forms.Button uxSubmitButton;
    }
}