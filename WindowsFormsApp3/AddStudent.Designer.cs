namespace WindowsFormsApp3
{
    partial class AddStudent
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
            this.label2 = new System.Windows.Forms.Label();
            this.rbAddStudent = new System.Windows.Forms.RadioButton();
            this.rbEditStudent = new System.Windows.Forms.RadioButton();
            this.rbDeleteStudent = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.DBSurname = new System.Windows.Forms.TextBox();
            this.DBFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DBEmail = new System.Windows.Forms.TextBox();
            this.DBPhone = new System.Windows.Forms.TextBox();
            this.DBAddress1 = new System.Windows.Forms.TextBox();
            this.DBAddress2 = new System.Windows.Forms.TextBox();
            this.DBCity = new System.Windows.Forms.TextBox();
            this.DBCounty = new System.Windows.Forms.TextBox();
            this.DBCourse = new System.Windows.Forms.TextBox();
            this.comboxLevel = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLoadStd = new System.Windows.Forms.Button();
            this.txtStudID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // rbAddStudent
            // 
            this.rbAddStudent.AutoSize = true;
            this.rbAddStudent.Location = new System.Drawing.Point(654, 14);
            this.rbAddStudent.Name = "rbAddStudent";
            this.rbAddStudent.Size = new System.Drawing.Size(84, 17);
            this.rbAddStudent.TabIndex = 2;
            this.rbAddStudent.TabStop = true;
            this.rbAddStudent.Text = "Add Student";
            this.rbAddStudent.UseVisualStyleBackColor = true;
            this.rbAddStudent.CheckedChanged += new System.EventHandler(this.rbAddStudent_CheckedChanged);
            // 
            // rbEditStudent
            // 
            this.rbEditStudent.AutoSize = true;
            this.rbEditStudent.Location = new System.Drawing.Point(654, 37);
            this.rbEditStudent.Name = "rbEditStudent";
            this.rbEditStudent.Size = new System.Drawing.Size(83, 17);
            this.rbEditStudent.TabIndex = 3;
            this.rbEditStudent.TabStop = true;
            this.rbEditStudent.Text = "Edit Student";
            this.rbEditStudent.UseVisualStyleBackColor = true;
            this.rbEditStudent.CheckedChanged += new System.EventHandler(this.rbEditStudent_CheckedChanged);
            // 
            // rbDeleteStudent
            // 
            this.rbDeleteStudent.AutoSize = true;
            this.rbDeleteStudent.Location = new System.Drawing.Point(654, 60);
            this.rbDeleteStudent.Name = "rbDeleteStudent";
            this.rbDeleteStudent.Size = new System.Drawing.Size(96, 17);
            this.rbDeleteStudent.TabIndex = 4;
            this.rbDeleteStudent.TabStop = true;
            this.rbDeleteStudent.Text = "Delete Student";
            this.rbDeleteStudent.UseVisualStyleBackColor = true;
            this.rbDeleteStudent.CheckedChanged += new System.EventHandler(this.rbDeleteStudent_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(522, 329);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(86, 23);
            this.btnSubmit.TabIndex = 22;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // DBSurname
            // 
            this.DBSurname.Location = new System.Drawing.Point(211, 130);
            this.DBSurname.Name = "DBSurname";
            this.DBSurname.Size = new System.Drawing.Size(100, 20);
            this.DBSurname.TabIndex = 13;
            // 
            // DBFirstName
            // 
            this.DBFirstName.Location = new System.Drawing.Point(211, 91);
            this.DBFirstName.Name = "DBFirstName";
            this.DBFirstName.Size = new System.Drawing.Size(100, 20);
            this.DBFirstName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(359, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(359, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(359, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "label10";
            // 
            // DBEmail
            // 
            this.DBEmail.Location = new System.Drawing.Point(211, 168);
            this.DBEmail.Name = "DBEmail";
            this.DBEmail.Size = new System.Drawing.Size(100, 20);
            this.DBEmail.TabIndex = 14;
            // 
            // DBPhone
            // 
            this.DBPhone.Location = new System.Drawing.Point(211, 207);
            this.DBPhone.Name = "DBPhone";
            this.DBPhone.Size = new System.Drawing.Size(100, 20);
            this.DBPhone.TabIndex = 15;
            // 
            // DBAddress1
            // 
            this.DBAddress1.Location = new System.Drawing.Point(211, 240);
            this.DBAddress1.Name = "DBAddress1";
            this.DBAddress1.Size = new System.Drawing.Size(100, 20);
            this.DBAddress1.TabIndex = 16;
            // 
            // DBAddress2
            // 
            this.DBAddress2.Location = new System.Drawing.Point(211, 279);
            this.DBAddress2.Name = "DBAddress2";
            this.DBAddress2.Size = new System.Drawing.Size(100, 20);
            this.DBAddress2.TabIndex = 17;
            // 
            // DBCity
            // 
            this.DBCity.Location = new System.Drawing.Point(497, 90);
            this.DBCity.Name = "DBCity";
            this.DBCity.Size = new System.Drawing.Size(100, 20);
            this.DBCity.TabIndex = 18;
            // 
            // DBCounty
            // 
            this.DBCounty.Location = new System.Drawing.Point(497, 129);
            this.DBCounty.Name = "DBCounty";
            this.DBCounty.Size = new System.Drawing.Size(100, 20);
            this.DBCounty.TabIndex = 19;
            // 
            // DBCourse
            // 
            this.DBCourse.Location = new System.Drawing.Point(497, 210);
            this.DBCourse.Name = "DBCourse";
            this.DBCourse.Size = new System.Drawing.Size(100, 20);
            this.DBCourse.TabIndex = 21;
            // 
            // comboxLevel
            // 
            this.comboxLevel.FormattingEnabled = true;
            this.comboxLevel.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.comboxLevel.Location = new System.Drawing.Point(497, 168);
            this.comboxLevel.Name = "comboxLevel";
            this.comboxLevel.Size = new System.Drawing.Size(100, 21);
            this.comboxLevel.TabIndex = 20;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(44, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLoadStd
            // 
            this.btnLoadStd.Location = new System.Drawing.Point(522, 284);
            this.btnLoadStd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoadStd.Name = "btnLoadStd";
            this.btnLoadStd.Size = new System.Drawing.Size(86, 26);
            this.btnLoadStd.TabIndex = 26;
            this.btnLoadStd.Text = "Load Student";
            this.btnLoadStd.UseVisualStyleBackColor = true;
            this.btnLoadStd.Click += new System.EventHandler(this.btnLoadStd_Click);
            // 
            // txtStudID
            // 
            this.txtStudID.Location = new System.Drawing.Point(211, 59);
            this.txtStudID.Name = "txtStudID";
            this.txtStudID.Size = new System.Drawing.Size(100, 20);
            this.txtStudID.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "label11";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtStudID);
            this.Controls.Add(this.btnLoadStd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.comboxLevel);
            this.Controls.Add(this.DBCourse);
            this.Controls.Add(this.DBCity);
            this.Controls.Add(this.DBCounty);
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
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rbDeleteStudent);
            this.Controls.Add(this.rbEditStudent);
            this.Controls.Add(this.rbAddStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbAddStudent;
        private System.Windows.Forms.RadioButton rbEditStudent;
        private System.Windows.Forms.RadioButton rbDeleteStudent;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLoadStd;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox DBFirstName;
        public System.Windows.Forms.TextBox DBSurname;
        public System.Windows.Forms.TextBox DBEmail;
        public System.Windows.Forms.TextBox DBPhone;
        public System.Windows.Forms.TextBox DBAddress1;
        public System.Windows.Forms.TextBox DBAddress2;
        public System.Windows.Forms.TextBox DBCity;
        public System.Windows.Forms.TextBox DBCounty;
        public System.Windows.Forms.TextBox DBCourse;
        public System.Windows.Forms.ComboBox comboxLevel;
        public System.Windows.Forms.TextBox txtStudID;
    }
}