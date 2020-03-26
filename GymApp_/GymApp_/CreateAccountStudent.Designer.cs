namespace GymApp_Group9
{
    partial class CreateAccountStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.MotivationTBDB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SurnameTB = new System.Windows.Forms.TextBox();
            this.ForenameTB = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Password *";
            // 
            // PassTB
            // 
            this.PassTB.Location = new System.Drawing.Point(16, 231);
            this.PassTB.Name = "PassTB";
            this.PassTB.Size = new System.Drawing.Size(167, 20);
            this.PassTB.TabIndex = 39;
            this.PassTB.TabStop = false;
            this.PassTB.UseSystemPasswordChar = true;
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.Location = new System.Drawing.Point(16, 320);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(102, 29);
            this.CreateAccountButton.TabIndex = 38;
            this.CreateAccountButton.Text = "Create Account";
            this.CreateAccountButton.UseVisualStyleBackColor = true;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // MotivationTBDB
            // 
            this.MotivationTBDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MotivationTBDB.FormattingEnabled = true;
            this.MotivationTBDB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.MotivationTBDB.Location = new System.Drawing.Point(16, 281);
            this.MotivationTBDB.Name = "MotivationTBDB";
            this.MotivationTBDB.Size = new System.Drawing.Size(167, 21);
            this.MotivationTBDB.TabIndex = 37;
            this.MotivationTBDB.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Motivation *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "E-mail address *";
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(16, 179);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(167, 20);
            this.EmailTB.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Surname *";
            // 
            // SurnameTB
            // 
            this.SurnameTB.Location = new System.Drawing.Point(16, 122);
            this.SurnameTB.Name = "SurnameTB";
            this.SurnameTB.Size = new System.Drawing.Size(167, 20);
            this.SurnameTB.TabIndex = 31;
            // 
            // ForenameTB
            // 
            this.ForenameTB.Location = new System.Drawing.Point(16, 64);
            this.ForenameTB.Name = "ForenameTB";
            this.ForenameTB.Size = new System.Drawing.Size(167, 20);
            this.ForenameTB.TabIndex = 30;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(171, 24);
            this.label.TabIndex = 29;
            this.label.Text = "Create Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "First Name *";
            // 
            // CreateAccountStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.MotivationTBDB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SurnameTB);
            this.Controls.Add(this.ForenameTB);
            this.Controls.Add(this.label);
            this.Name = "CreateAccountStudent";
            this.Text = "CreateAccountStudent";
            this.Load += new System.EventHandler(this.CreateAccountStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.Button CreateAccountButton;
        private System.Windows.Forms.ComboBox MotivationTBDB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SurnameTB;
        private System.Windows.Forms.TextBox ForenameTB;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
    }
}