namespace FrontEnd
{
    partial class AddOrEditShowing
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
            this.uxAoELabel = new System.Windows.Forms.Label();
            this.uxCurShowingLabel = new System.Windows.Forms.Label();
            this.uxCurShowingString = new System.Windows.Forms.Label();
            this.uxDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxTicketPricePicker = new System.Windows.Forms.NumericUpDown();
            this.uxSetShowtime = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.uxTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.uxTicketPricePicker)).BeginInit();
            this.SuspendLayout();
            // 
            // uxAoELabel
            // 
            this.uxAoELabel.AutoSize = true;
            this.uxAoELabel.Location = new System.Drawing.Point(13, 14);
            this.uxAoELabel.Name = "uxAoELabel";
            this.uxAoELabel.Size = new System.Drawing.Size(86, 13);
            this.uxAoELabel.TabIndex = 0;
            this.uxAoELabel.Text = "SetInConstructor";
            // 
            // uxCurShowingLabel
            // 
            this.uxCurShowingLabel.AutoSize = true;
            this.uxCurShowingLabel.Location = new System.Drawing.Point(186, 14);
            this.uxCurShowingLabel.Name = "uxCurShowingLabel";
            this.uxCurShowingLabel.Size = new System.Drawing.Size(91, 13);
            this.uxCurShowingLabel.TabIndex = 1;
            this.uxCurShowingLabel.Text = "Current Showing: ";
            // 
            // uxCurShowingString
            // 
            this.uxCurShowingString.AutoSize = true;
            this.uxCurShowingString.Location = new System.Drawing.Point(283, 14);
            this.uxCurShowingString.Name = "uxCurShowingString";
            this.uxCurShowingString.Size = new System.Drawing.Size(86, 13);
            this.uxCurShowingString.TabIndex = 2;
            this.uxCurShowingString.Text = "SetInConstructor";
            // 
            // uxDatePicker
            // 
            this.uxDatePicker.Location = new System.Drawing.Point(95, 79);
            this.uxDatePicker.Name = "uxDatePicker";
            this.uxDatePicker.Size = new System.Drawing.Size(200, 20);
            this.uxDatePicker.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Show Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ticket Price: ";
            // 
            // uxTicketPricePicker
            // 
            this.uxTicketPricePicker.DecimalPlaces = 2;
            this.uxTicketPricePicker.Location = new System.Drawing.Point(95, 151);
            this.uxTicketPricePicker.Name = "uxTicketPricePicker";
            this.uxTicketPricePicker.Size = new System.Drawing.Size(120, 20);
            this.uxTicketPricePicker.TabIndex = 6;
            // 
            // uxSetShowtime
            // 
            this.uxSetShowtime.Location = new System.Drawing.Point(219, 209);
            this.uxSetShowtime.Name = "uxSetShowtime";
            this.uxSetShowtime.Size = new System.Drawing.Size(159, 81);
            this.uxSetShowtime.TabIndex = 7;
            this.uxSetShowtime.Text = "Set New Showtime";
            this.uxSetShowtime.UseVisualStyleBackColor = true;
            this.uxSetShowtime.Click += new System.EventHandler(this.uxSetShowtime_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 81);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uxTimePicker
            // 
            this.uxTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uxTimePicker.Location = new System.Drawing.Point(301, 79);
            this.uxTimePicker.Name = "uxTimePicker";
            this.uxTimePicker.ShowUpDown = true;
            this.uxTimePicker.Size = new System.Drawing.Size(88, 20);
            this.uxTimePicker.TabIndex = 9;
            // 
            // AddOrEditShowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxTimePicker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uxSetShowtime);
            this.Controls.Add(this.uxTicketPricePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxDatePicker);
            this.Controls.Add(this.uxCurShowingString);
            this.Controls.Add(this.uxCurShowingLabel);
            this.Controls.Add(this.uxAoELabel);
            this.Name = "AddOrEditShowing";
            this.Size = new System.Drawing.Size(419, 307);
            ((System.ComponentModel.ISupportInitialize)(this.uxTicketPricePicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxAoELabel;
        private System.Windows.Forms.Label uxCurShowingLabel;
        private System.Windows.Forms.Label uxCurShowingString;
        private System.Windows.Forms.DateTimePicker uxDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown uxTicketPricePicker;
        private System.Windows.Forms.Button uxSetShowtime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker uxTimePicker;
    }
}
