namespace FrontEnd
{
    partial class EmployeeView
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
            this.uxTestAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee View";
            // 
            // uxTestAdd
            // 
            this.uxTestAdd.Location = new System.Drawing.Point(7, 37);
            this.uxTestAdd.Name = "uxTestAdd";
            this.uxTestAdd.Size = new System.Drawing.Size(116, 23);
            this.uxTestAdd.TabIndex = 1;
            this.uxTestAdd.Text = "Test Add Movie";
            this.uxTestAdd.UseVisualStyleBackColor = true;
            this.uxTestAdd.Click += new System.EventHandler(this.uxTestAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Test Add director";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uxTestAdd);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeView";
            this.Size = new System.Drawing.Size(320, 201);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uxTestAdd;
        private System.Windows.Forms.Button button1;
    }
}
