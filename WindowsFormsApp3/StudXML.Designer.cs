namespace WindowsFormsApp3
{
    partial class StudXML
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.DBAddress1 = new System.Windows.Forms.TextBox();
            this.DBAddress2 = new System.Windows.Forms.TextBox();
            this.DBEmail = new System.Windows.Forms.TextBox();
            this.DBPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DBFirstName = new System.Windows.Forms.TextBox();
            this.DBSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DBCity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.DBcomboCourse = new System.Windows.Forms.ComboBox();
            this.DBcomboCounty = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbtnUnder = new System.Windows.Forms.RadioButton();
            this.rdbtnPost = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(419, 72);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(113, 24);
            this.btnLoad.TabIndex = 12;
            this.btnLoad.Text = "Load from Database";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(249, 76);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(132, 20);
            this.txtID.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(130, 82);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(84, 13);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Enter Student Id";
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(640, 346);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(132, 20);
            this.txtFN.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(659, 310);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 20);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save to XML";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(65, 30);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DBAddress1
            // 
            this.DBAddress1.Location = new System.Drawing.Point(268, 303);
            this.DBAddress1.Name = "DBAddress1";
            this.DBAddress1.Size = new System.Drawing.Size(100, 20);
            this.DBAddress1.TabIndex = 6;
            // 
            // DBAddress2
            // 
            this.DBAddress2.Location = new System.Drawing.Point(268, 342);
            this.DBAddress2.Name = "DBAddress2";
            this.DBAddress2.Size = new System.Drawing.Size(100, 20);
            this.DBAddress2.TabIndex = 7;
            // 
            // DBEmail
            // 
            this.DBEmail.Location = new System.Drawing.Point(268, 232);
            this.DBEmail.Name = "DBEmail";
            this.DBEmail.Size = new System.Drawing.Size(100, 20);
            this.DBEmail.TabIndex = 4;
            // 
            // DBPhone
            // 
            this.DBPhone.Location = new System.Drawing.Point(268, 271);
            this.DBPhone.Name = "DBPhone";
            this.DBPhone.Size = new System.Drawing.Size(100, 20);
            this.DBPhone.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(416, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Course";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(417, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Level";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "County";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Address Line 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Address Line 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Email";
            // 
            // DBFirstName
            // 
            this.DBFirstName.Location = new System.Drawing.Point(268, 154);
            this.DBFirstName.Name = "DBFirstName";
            this.DBFirstName.Size = new System.Drawing.Size(100, 20);
            this.DBFirstName.TabIndex = 2;
            // 
            // DBSurname
            // 
            this.DBSurname.Location = new System.Drawing.Point(268, 193);
            this.DBSurname.Name = "DBSurname";
            this.DBSurname.Size = new System.Drawing.Size(100, 20);
            this.DBSurname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "First Name";
            // 
            // DBCity
            // 
            this.DBCity.Location = new System.Drawing.Point(488, 160);
            this.DBCity.Name = "DBCity";
            this.DBCity.Size = new System.Drawing.Size(100, 20);
            this.DBCity.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(659, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add to XML";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(560, 71);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(91, 24);
            this.btnView.TabIndex = 13;
            this.btnView.Text = "View from XML";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // DBcomboCourse
            // 
            this.DBcomboCourse.FormattingEnabled = true;
            this.DBcomboCourse.Items.AddRange(new object[] {
            "Computing",
            "Science",
            "Accounting",
            "French",
            "The Physics of Star Trek"});
            this.DBcomboCourse.Location = new System.Drawing.Point(488, 296);
            this.DBcomboCourse.Name = "DBcomboCourse";
            this.DBcomboCourse.Size = new System.Drawing.Size(100, 21);
            this.DBcomboCourse.TabIndex = 11;
            // 
            // DBcomboCounty
            // 
            this.DBcomboCounty.FormattingEnabled = true;
            this.DBcomboCounty.Items.AddRange(new object[] {
            "Antrim",
            "Armagh",
            "Carlow",
            "Cavan",
            "Clare",
            "Cork",
            "Derry",
            "Donegal",
            "Down",
            "Dublin",
            "Fermanagh",
            "Galway",
            "Kerry",
            "Kildare",
            "Kilkenny",
            "Laois",
            "Leitrim",
            "Limerick",
            "Longford",
            "Louth",
            "Mayo",
            "Meath",
            "Monaghan",
            "Offaly",
            "Roscommon",
            "Sligo",
            "Tipperary",
            "Tyrone",
            "Waterford",
            "Westmeath",
            "Wexford",
            "Wicklow"});
            this.DBcomboCounty.Location = new System.Drawing.Point(488, 198);
            this.DBcomboCounty.Name = "DBcomboCounty";
            this.DBcomboCounty.Size = new System.Drawing.Size(100, 21);
            this.DBcomboCounty.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbtnUnder);
            this.groupBox2.Controls.Add(this.rdbtnPost);
            this.groupBox2.Location = new System.Drawing.Point(488, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(87, 68);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // rdbtnUnder
            // 
            this.rdbtnUnder.AutoSize = true;
            this.rdbtnUnder.Location = new System.Drawing.Point(3, 39);
            this.rdbtnUnder.Name = "rdbtnUnder";
            this.rdbtnUnder.Size = new System.Drawing.Size(75, 17);
            this.rdbtnUnder.TabIndex = 1;
            this.rdbtnUnder.TabStop = true;
            this.rdbtnUnder.Text = "Undergrad";
            this.rdbtnUnder.UseVisualStyleBackColor = true;
            // 
            // rdbtnPost
            // 
            this.rdbtnPost.AutoSize = true;
            this.rdbtnPost.Location = new System.Drawing.Point(3, 16);
            this.rdbtnPost.Name = "rdbtnPost";
            this.rdbtnPost.Size = new System.Drawing.Size(67, 17);
            this.rdbtnPost.TabIndex = 0;
            this.rdbtnPost.TabStop = true;
            this.rdbtnPost.Text = "Postgrad";
            this.rdbtnPost.UseVisualStyleBackColor = true;
            // 
            // StudXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DBcomboCounty);
            this.Controls.Add(this.DBcomboCourse);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.DBCity);
            this.Controls.Add(this.DBAddress1);
            this.Controls.Add(this.DBAddress2);
            this.Controls.Add(this.DBEmail);
            this.Controls.Add(this.DBPhone);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DBFirstName);
            this.Controls.Add(this.DBSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnLoad);
            this.Name = "StudXML";
            this.Text = "StudXML";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox DBAddress1;
        private System.Windows.Forms.TextBox DBAddress2;
        private System.Windows.Forms.TextBox DBEmail;
        private System.Windows.Forms.TextBox DBPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DBFirstName;
        private System.Windows.Forms.TextBox DBSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DBCity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ComboBox DBcomboCourse;
        private System.Windows.Forms.ComboBox DBcomboCounty;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbtnUnder;
        private System.Windows.Forms.RadioButton rdbtnPost;
    }
}