namespace FrontEnd
{
    partial class ModifySelectedMovie
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
            this.uxShowingList = new System.Windows.Forms.ListBox();
            this.uxEditShowingButton = new System.Windows.Forms.Button();
            this.uxDeleteShowingButton = new System.Windows.Forms.Button();
            this.uxBackButton = new System.Windows.Forms.Button();
            this.uxAddShowing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxShowingList
            // 
            this.uxShowingList.FormattingEnabled = true;
            this.uxShowingList.Location = new System.Drawing.Point(4, 4);
            this.uxShowingList.Name = "uxShowingList";
            this.uxShowingList.Size = new System.Drawing.Size(197, 407);
            this.uxShowingList.TabIndex = 0;
            // 
            // uxEditShowingButton
            // 
            this.uxEditShowingButton.Location = new System.Drawing.Point(264, 13);
            this.uxEditShowingButton.Name = "uxEditShowingButton";
            this.uxEditShowingButton.Size = new System.Drawing.Size(139, 83);
            this.uxEditShowingButton.TabIndex = 1;
            this.uxEditShowingButton.Text = "Edit Showing";
            this.uxEditShowingButton.UseVisualStyleBackColor = true;
            this.uxEditShowingButton.Click += new System.EventHandler(this.uxEditShowingButton_Click);
            // 
            // uxDeleteShowingButton
            // 
            this.uxDeleteShowingButton.Location = new System.Drawing.Point(264, 208);
            this.uxDeleteShowingButton.Name = "uxDeleteShowingButton";
            this.uxDeleteShowingButton.Size = new System.Drawing.Size(139, 87);
            this.uxDeleteShowingButton.TabIndex = 2;
            this.uxDeleteShowingButton.Text = "Delete Showing";
            this.uxDeleteShowingButton.UseVisualStyleBackColor = true;
            this.uxDeleteShowingButton.Click += new System.EventHandler(this.uxDeleteShowingButton_Click);
            // 
            // uxBackButton
            // 
            this.uxBackButton.Location = new System.Drawing.Point(264, 301);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(139, 110);
            this.uxBackButton.TabIndex = 3;
            this.uxBackButton.Text = "Back to Movie View";
            this.uxBackButton.UseVisualStyleBackColor = true;
            this.uxBackButton.Click += new System.EventHandler(this.uxBackButton_Click);
            // 
            // uxAddShowing
            // 
            this.uxAddShowing.Location = new System.Drawing.Point(264, 102);
            this.uxAddShowing.Name = "uxAddShowing";
            this.uxAddShowing.Size = new System.Drawing.Size(139, 100);
            this.uxAddShowing.TabIndex = 4;
            this.uxAddShowing.Text = "Add Showing";
            this.uxAddShowing.UseVisualStyleBackColor = true;
            this.uxAddShowing.Click += new System.EventHandler(this.uxAddShowing_Click);
            // 
            // ModifySelectedMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxAddShowing);
            this.Controls.Add(this.uxBackButton);
            this.Controls.Add(this.uxDeleteShowingButton);
            this.Controls.Add(this.uxEditShowingButton);
            this.Controls.Add(this.uxShowingList);
            this.Name = "ModifySelectedMovie";
            this.Size = new System.Drawing.Size(477, 421);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox uxShowingList;
        private System.Windows.Forms.Button uxEditShowingButton;
        private System.Windows.Forms.Button uxDeleteShowingButton;
        private System.Windows.Forms.Button uxBackButton;
        private System.Windows.Forms.Button uxAddShowing;
    }
}
