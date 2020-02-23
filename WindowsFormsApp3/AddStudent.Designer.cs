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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLoadStd = new System.Windows.Forms.Button();
            this.txtStudID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnViewDB = new System.Windows.Forms.Button();
            this.comboCounty = new System.Windows.Forms.ComboBox();
            this.comboCourse = new System.Windows.Forms.ComboBox();
            this.rdoBtnPost = new System.Windows.Forms.RadioButton();
            this.rdoBtnUnder = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // rbAddStudent
            // 
            this.rbAddStudent.AutoSize = true;
            this.rbAddStudent.Location = new System.Drawing.Point(25, 22);
            this.rbAddStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbAddStudent.Name = "rbAddStudent";
            this.rbAddStudent.Size = new System.Drawing.Size(107, 21);
            this.rbAddStudent.TabIndex = 2;
            this.rbAddStudent.TabStop = true;
            this.rbAddStudent.Text = "Add Student";
            this.rbAddStudent.UseVisualStyleBackColor = true;
            this.rbAddStudent.CheckedChanged += new System.EventHandler(this.rbAddStudent_CheckedChanged);
            // 
            // rbEditStudent
            // 
            this.rbEditStudent.AutoSize = true;
            this.rbEditStudent.Location = new System.Drawing.Point(25, 50);
            this.rbEditStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbEditStudent.Name = "rbEditStudent";
            this.rbEditStudent.Size = new System.Drawing.Size(106, 21);
            this.rbEditStudent.TabIndex = 3;
            this.rbEditStudent.TabStop = true;
            this.rbEditStudent.Text = "Edit Student";
            this.rbEditStudent.UseVisualStyleBackColor = true;
            this.rbEditStudent.CheckedChanged += new System.EventHandler(this.rbEditStudent_CheckedChanged);
            // 
            // rbDeleteStudent
            // 
            this.rbDeleteStudent.AutoSize = true;
            this.rbDeleteStudent.Location = new System.Drawing.Point(25, 79);
            this.rbDeleteStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDeleteStudent.Name = "rbDeleteStudent";
            this.rbDeleteStudent.Size = new System.Drawing.Size(123, 21);
            this.rbDeleteStudent.TabIndex = 4;
            this.rbDeleteStudent.TabStop = true;
            this.rbDeleteStudent.Text = "Delete Student";
            this.rbDeleteStudent.UseVisualStyleBackColor = true;
            this.rbDeleteStudent.CheckedChanged += new System.EventHandler(this.rbDeleteStudent_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(681, 346);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(115, 28);
            this.btnSubmit.TabIndex = 23;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // DBSurname
            // 
            this.DBSurname.Location = new System.Drawing.Point(281, 160);
            this.DBSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DBSurname.Name = "DBSurname";
            this.DBSurname.Size = new System.Drawing.Size(132, 22);
            this.DBSurname.TabIndex = 13;
            // 
            // DBFirstName
            // 
            this.DBFirstName.Location = new System.Drawing.Point(281, 112);
            this.DBFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DBFirstName.Name = "DBFirstName";
            this.DBFirstName.Size = new System.Drawing.Size(132, 22);
            this.DBFirstName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 304);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 352);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(479, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(479, 167);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(479, 219);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(479, 276);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "label10";
            // 
            // DBEmail
            // 
            this.DBEmail.Location = new System.Drawing.Point(281, 207);
            this.DBEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DBEmail.Name = "DBEmail";
            this.DBEmail.Size = new System.Drawing.Size(132, 22);
            this.DBEmail.TabIndex = 14;
            // 
            // DBPhone
            // 
            this.DBPhone.Location = new System.Drawing.Point(281, 255);
            this.DBPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DBPhone.Name = "DBPhone";
            this.DBPhone.Size = new System.Drawing.Size(132, 22);
            this.DBPhone.TabIndex = 15;
            // 
            // DBAddress1
            // 
            this.DBAddress1.Location = new System.Drawing.Point(281, 295);
            this.DBAddress1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DBAddress1.Name = "DBAddress1";
            this.DBAddress1.Size = new System.Drawing.Size(132, 22);
            this.DBAddress1.TabIndex = 16;
            // 
            // DBAddress2
            // 
            this.DBAddress2.Location = new System.Drawing.Point(281, 343);
            this.DBAddress2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DBAddress2.Name = "DBAddress2";
            this.DBAddress2.Size = new System.Drawing.Size(132, 22);
            this.DBAddress2.TabIndex = 17;
            // 
            // DBCity
            // 
            this.DBCity.Location = new System.Drawing.Point(663, 111);
            this.DBCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DBCity.Name = "DBCity";
            this.DBCity.Size = new System.Drawing.Size(132, 22);
            this.DBCity.TabIndex = 18;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(59, 17);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLoadStd
            // 
            this.btnLoadStd.Location = new System.Drawing.Point(681, 308);
            this.btnLoadStd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadStd.Name = "btnLoadStd";
            this.btnLoadStd.Size = new System.Drawing.Size(115, 32);
            this.btnLoadStd.TabIndex = 22;
            this.btnLoadStd.Text = "Load Student";
            this.btnLoadStd.UseVisualStyleBackColor = true;
            this.btnLoadStd.Click += new System.EventHandler(this.btnLoadStd_Click);
            // 
            // txtStudID
            // 
            this.txtStudID.Location = new System.Drawing.Point(281, 73);
            this.txtStudID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStudID.Name = "txtStudID";
            this.txtStudID.Size = new System.Drawing.Size(132, 22);
            this.txtStudID.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(97, 73);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "label11";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 400);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(899, 143);
            this.dataGridView1.TabIndex = 29;
            // 
            // btnViewDB
            // 
            this.btnViewDB.Location = new System.Drawing.Point(924, 441);
            this.btnViewDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewDB.Name = "btnViewDB";
            this.btnViewDB.Size = new System.Drawing.Size(127, 59);
            this.btnViewDB.TabIndex = 24;
            this.btnViewDB.Text = "View/Refresh Database";
            this.btnViewDB.UseVisualStyleBackColor = true;
            this.btnViewDB.Click += new System.EventHandler(this.btnViewDB_Click);
            // 
            // comboCounty
            // 
            this.comboCounty.FormattingEnabled = true;
            this.comboCounty.Items.AddRange(new object[] {
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
            this.comboCounty.Location = new System.Drawing.Point(663, 159);
            this.comboCounty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboCounty.Name = "comboCounty";
            this.comboCounty.Size = new System.Drawing.Size(132, 24);
            this.comboCounty.TabIndex = 19;
            // 
            // comboCourse
            // 
            this.comboCourse.FormattingEnabled = true;
            this.comboCourse.Items.AddRange(new object[] {
            "Computing",
            "Science",
            "Accounting",
            "French",
            "The_Physics_of_Star_Trek"});
            this.comboCourse.Location = new System.Drawing.Point(663, 272);
            this.comboCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboCourse.Name = "comboCourse";
            this.comboCourse.Size = new System.Drawing.Size(132, 24);
            this.comboCourse.TabIndex = 21;
            // 
            // rdoBtnPost
            // 
            this.rdoBtnPost.AutoSize = true;
            this.rdoBtnPost.Location = new System.Drawing.Point(20, 16);
            this.rdoBtnPost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoBtnPost.Name = "rdoBtnPost";
            this.rdoBtnPost.Size = new System.Drawing.Size(89, 21);
            this.rdoBtnPost.TabIndex = 33;
            this.rdoBtnPost.TabStop = true;
            this.rdoBtnPost.Text = "PostGrad";
            this.rdoBtnPost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rdoBtnPost.UseVisualStyleBackColor = true;
            // 
            // rdoBtnUnder
            // 
            this.rdoBtnUnder.AutoSize = true;
            this.rdoBtnUnder.Location = new System.Drawing.Point(20, 39);
            this.rdoBtnUnder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoBtnUnder.Name = "rdoBtnUnder";
            this.rdoBtnUnder.Size = new System.Drawing.Size(100, 21);
            this.rdoBtnUnder.TabIndex = 34;
            this.rdoBtnUnder.TabStop = true;
            this.rdoBtnUnder.Text = "UnderGrad";
            this.rdoBtnUnder.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDeleteStudent);
            this.groupBox1.Controls.Add(this.rbAddStudent);
            this.groupBox1.Controls.Add(this.rbEditStudent);
            this.groupBox1.Location = new System.Drawing.Point(885, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(177, 119);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoBtnPost);
            this.groupBox3.Controls.Add(this.rdoBtnUnder);
            this.groupBox3.Location = new System.Drawing.Point(663, 192);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(133, 73);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboCourse);
            this.Controls.Add(this.comboCounty);
            this.Controls.Add(this.btnViewDB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtStudID);
            this.Controls.Add(this.btnLoadStd);
            this.Controls.Add(this.btnBack);
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
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        public System.Windows.Forms.TextBox txtStudID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnViewDB;
        public System.Windows.Forms.ComboBox comboCounty;
        public System.Windows.Forms.ComboBox comboCourse;
        private System.Windows.Forms.RadioButton rdoBtnPost;
        private System.Windows.Forms.RadioButton rdoBtnUnder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}