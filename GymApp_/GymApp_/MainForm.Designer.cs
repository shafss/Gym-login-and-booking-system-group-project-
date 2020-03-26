namespace GymApp_Group9
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.IDTxtbx = new System.Windows.Forms.TextBox();
            this.passTxtbx = new System.Windows.Forms.TextBox();
            this.loginLbl = new System.Windows.Forms.Label();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.typeLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.selectUserCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.callCreateAccount = new System.Windows.Forms.Button();
            this.createUserType = new System.Windows.Forms.ComboBox();
            this.SelectUserLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.IDTxtbx);
            this.splitContainer1.Panel1.Controls.Add(this.passTxtbx);
            this.splitContainer1.Panel1.Controls.Add(this.loginLbl);
            this.splitContainer1.Panel1.Controls.Add(this.LogInBtn);
            this.splitContainer1.Panel1.Controls.Add(this.typeLbl);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.selectUserCombo);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.callCreateAccount);
            this.splitContainer1.Panel2.Controls.Add(this.createUserType);
            this.splitContainer1.Panel2.Controls.Add(this.SelectUserLbl);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(384, 361);
            this.splitContainer1.SplitterDistance = 236;
            this.splitContainer1.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 33);
            this.label3.TabIndex = 14;
            this.label3.Text = "University of Hull Gym";
            // 
            // IDTxtbx
            // 
            this.IDTxtbx.Location = new System.Drawing.Point(44, 140);
            this.IDTxtbx.MaxLength = 9;
            this.IDTxtbx.Name = "IDTxtbx";
            this.IDTxtbx.Size = new System.Drawing.Size(153, 20);
            this.IDTxtbx.TabIndex = 7;
            // 
            // passTxtbx
            // 
            this.passTxtbx.Location = new System.Drawing.Point(44, 179);
            this.passTxtbx.Name = "passTxtbx";
            this.passTxtbx.ShortcutsEnabled = false;
            this.passTxtbx.Size = new System.Drawing.Size(153, 20);
            this.passTxtbx.TabIndex = 8;
            this.passTxtbx.TabStop = false;
            this.passTxtbx.UseSystemPasswordChar = true;
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.loginLbl.Location = new System.Drawing.Point(41, 48);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(55, 17);
            this.loginLbl.TabIndex = 18;
            this.loginLbl.Text = "Log in";
            // 
            // LogInBtn
            // 
            this.LogInBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.LogInBtn.Location = new System.Drawing.Point(44, 205);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(121, 23);
            this.LogInBtn.TabIndex = 10;
            this.LogInBtn.Text = "Sign In";
            this.LogInBtn.UseVisualStyleBackColor = true;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click_1);
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.typeLbl.Location = new System.Drawing.Point(41, 84);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(102, 13);
            this.typeLbl.TabIndex = 17;
            this.typeLbl.Text = "Select type of user *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(41, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "User ID *";
            // 
            // selectUserCombo
            // 
            this.selectUserCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectUserCombo.ForeColor = System.Drawing.Color.DarkBlue;
            this.selectUserCombo.FormattingEnabled = true;
            this.selectUserCombo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.selectUserCombo.Items.AddRange(new object[] {
            "External User",
            "Management Staff",
            "Student",
            "Personal Trainer",
            "Volunteer"});
            this.selectUserCombo.Location = new System.Drawing.Point(44, 100);
            this.selectUserCombo.Name = "selectUserCombo";
            this.selectUserCombo.Size = new System.Drawing.Size(121, 21);
            this.selectUserCombo.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(44, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(41, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Create Account";
            // 
            // callCreateAccount
            // 
            this.callCreateAccount.ForeColor = System.Drawing.Color.DarkBlue;
            this.callCreateAccount.Location = new System.Drawing.Point(44, 85);
            this.callCreateAccount.Name = "callCreateAccount";
            this.callCreateAccount.Size = new System.Drawing.Size(125, 23);
            this.callCreateAccount.TabIndex = 21;
            this.callCreateAccount.Text = "Go to Create Account";
            this.callCreateAccount.UseVisualStyleBackColor = true;
            this.callCreateAccount.Click += new System.EventHandler(this.callCreateAccount_Click_1);
            // 
            // createUserType
            // 
            this.createUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.createUserType.ForeColor = System.Drawing.Color.DarkBlue;
            this.createUserType.FormattingEnabled = true;
            this.createUserType.Items.AddRange(new object[] {
            "External User",
            "Management Staff",
            "Personal Trainer",
            "Student",
            "Volunteer"});
            this.createUserType.Location = new System.Drawing.Point(44, 58);
            this.createUserType.Name = "createUserType";
            this.createUserType.Size = new System.Drawing.Size(121, 21);
            this.createUserType.Sorted = true;
            this.createUserType.TabIndex = 19;
            // 
            // SelectUserLbl
            // 
            this.SelectUserLbl.AutoSize = true;
            this.SelectUserLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectUserLbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.SelectUserLbl.Location = new System.Drawing.Point(44, 41);
            this.SelectUserLbl.Name = "SelectUserLbl";
            this.SelectUserLbl.Size = new System.Drawing.Size(102, 13);
            this.SelectUserLbl.TabIndex = 20;
            this.SelectUserLbl.Text = "Select type of user *";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IDTxtbx;
        private System.Windows.Forms.TextBox passTxtbx;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectUserCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button callCreateAccount;
        private System.Windows.Forms.ComboBox createUserType;
        private System.Windows.Forms.Label SelectUserLbl;
    }
}