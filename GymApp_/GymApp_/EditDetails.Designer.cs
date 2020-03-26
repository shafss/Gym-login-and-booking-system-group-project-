namespace GymApp_Group9
{
    partial class EditDetails
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
            this.label2 = new System.Windows.Forms.Label();
            this.oldPassLbl = new System.Windows.Forms.Label();
            this.OldPassTB = new System.Windows.Forms.TextBox();
            this.ChangeDetailsButton = new System.Windows.Forms.Button();
            this.MotivationTBDB = new System.Windows.Forms.ComboBox();
            this.motivLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.FirstNameTB = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.NewPassTB = new System.Windows.Forms.TextBox();
            this.newPassLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "First Name";
            // 
            // oldPassLbl
            // 
            this.oldPassLbl.AutoSize = true;
            this.oldPassLbl.Location = new System.Drawing.Point(16, 215);
            this.oldPassLbl.Name = "oldPassLbl";
            this.oldPassLbl.Size = new System.Drawing.Size(72, 13);
            this.oldPassLbl.TabIndex = 56;
            this.oldPassLbl.Text = "Old Password";
            // 
            // OldPassTB
            // 
            this.OldPassTB.Location = new System.Drawing.Point(16, 231);
            this.OldPassTB.Name = "OldPassTB";
            this.OldPassTB.Size = new System.Drawing.Size(167, 20);
            this.OldPassTB.TabIndex = 55;
            this.OldPassTB.TabStop = false;
            this.OldPassTB.UseSystemPasswordChar = true;
            // 
            // ChangeDetailsButton
            // 
            this.ChangeDetailsButton.Location = new System.Drawing.Point(16, 320);
            this.ChangeDetailsButton.Name = "ChangeDetailsButton";
            this.ChangeDetailsButton.Size = new System.Drawing.Size(102, 29);
            this.ChangeDetailsButton.TabIndex = 54;
            this.ChangeDetailsButton.Text = "Change Details";
            this.ChangeDetailsButton.UseVisualStyleBackColor = true;
            this.ChangeDetailsButton.Click += new System.EventHandler(this.ChangeDetailsButton_Click);
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
            this.MotivationTBDB.TabIndex = 53;
            this.MotivationTBDB.TabStop = false;
            this.MotivationTBDB.Visible = false;
            // 
            // motivLbl
            // 
            this.motivLbl.AutoSize = true;
            this.motivLbl.Location = new System.Drawing.Point(16, 265);
            this.motivLbl.Name = "motivLbl";
            this.motivLbl.Size = new System.Drawing.Size(63, 13);
            this.motivLbl.TabIndex = 52;
            this.motivLbl.Text = "Motivation *";
            this.motivLbl.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "E-mail address";
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(16, 179);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(167, 20);
            this.EmailTB.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Surname";
            // 
            // LastNameTB
            // 
            this.LastNameTB.Location = new System.Drawing.Point(16, 122);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(167, 20);
            this.LastNameTB.TabIndex = 48;
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.Location = new System.Drawing.Point(16, 64);
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(167, 20);
            this.FirstNameTB.TabIndex = 47;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(131, 24);
            this.label.TabIndex = 46;
            this.label.Text = "Edit Details";
            // 
            // NewPassTB
            // 
            this.NewPassTB.Location = new System.Drawing.Point(189, 231);
            this.NewPassTB.Name = "NewPassTB";
            this.NewPassTB.Size = new System.Drawing.Size(167, 20);
            this.NewPassTB.TabIndex = 58;
            this.NewPassTB.TabStop = false;
            this.NewPassTB.UseSystemPasswordChar = true;
            // 
            // newPassLbl
            // 
            this.newPassLbl.AutoSize = true;
            this.newPassLbl.Location = new System.Drawing.Point(186, 215);
            this.newPassLbl.Name = "newPassLbl";
            this.newPassLbl.Size = new System.Drawing.Size(78, 13);
            this.newPassLbl.TabIndex = 59;
            this.newPassLbl.Text = "New Password";
            // 
            // EditDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.newPassLbl);
            this.Controls.Add(this.NewPassTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oldPassLbl);
            this.Controls.Add(this.OldPassTB);
            this.Controls.Add(this.ChangeDetailsButton);
            this.Controls.Add(this.MotivationTBDB);
            this.Controls.Add(this.motivLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastNameTB);
            this.Controls.Add(this.FirstNameTB);
            this.Controls.Add(this.label);
            this.Name = "EditDetails";
            this.Text = "EditDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label oldPassLbl;
        private System.Windows.Forms.TextBox OldPassTB;
        private System.Windows.Forms.Button ChangeDetailsButton;
        private System.Windows.Forms.ComboBox MotivationTBDB;
        private System.Windows.Forms.Label motivLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.TextBox FirstNameTB;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox NewPassTB;
        private System.Windows.Forms.Label newPassLbl;
    }
}