namespace GymApp_Group9
{
    partial class ExterLoggedIn
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
            this.loginLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.PTListbx = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bookBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.loginLbl.Location = new System.Drawing.Point(42, 68);
            this.loginLbl.MaximumSize = new System.Drawing.Size(350, 0);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(267, 34);
            this.loginLbl.TabIndex = 25;
            this.loginLbl.Text = "Personal Trainers that match your Motivation";
            this.loginLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.NameLbl.Location = new System.Drawing.Point(12, 12);
            this.NameLbl.MaximumSize = new System.Drawing.Size(260, 44);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(0, 18);
            this.NameLbl.TabIndex = 24;
            // 
            // PTListbx
            // 
            this.PTListbx.FormattingEnabled = true;
            this.PTListbx.Location = new System.Drawing.Point(12, 105);
            this.PTListbx.Name = "PTListbx";
            this.PTListbx.Size = new System.Drawing.Size(360, 199);
            this.PTListbx.Sorted = true;
            this.PTListbx.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(45, 319);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // bookBtn
            // 
            this.bookBtn.Location = new System.Drawing.Point(282, 319);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(90, 30);
            this.bookBtn.TabIndex = 21;
            this.bookBtn.Text = "Book Session";
            this.bookBtn.UseVisualStyleBackColor = true;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(282, 12);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(90, 30);
            this.editBtn.TabIndex = 20;
            this.editBtn.Text = "Edit Details";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // ExterLoggedIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.PTListbx);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bookBtn);
            this.Controls.Add(this.editBtn);
            this.Name = "ExterLoggedIn";
            this.Text = "ExterLoggedIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.ListBox PTListbx;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.Button editBtn;
    }
}