namespace WindowsFormsApp3
{
    partial class AddAdminForm
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
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.lblAddAdminName = new System.Windows.Forms.Label();
            this.lblAddAdminPass = new System.Windows.Forms.Label();
            this.txtAddAdminPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.Location = new System.Drawing.Point(306, 219);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAddAdmin.TabIndex = 0;
            this.btnAddAdmin.Text = "Add Admin";
            this.btnAddAdmin.UseVisualStyleBackColor = true;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // txtAdminName
            // 
            this.txtAdminName.Location = new System.Drawing.Point(295, 88);
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.Size = new System.Drawing.Size(100, 20);
            this.txtAdminName.TabIndex = 1;
            // 
            // lblAddAdminName
            // 
            this.lblAddAdminName.AutoSize = true;
            this.lblAddAdminName.Location = new System.Drawing.Point(170, 91);
            this.lblAddAdminName.Name = "lblAddAdminName";
            this.lblAddAdminName.Size = new System.Drawing.Size(89, 13);
            this.lblAddAdminName.TabIndex = 2;
            this.lblAddAdminName.Text = "Add Admin Name";
            // 
            // lblAddAdminPass
            // 
            this.lblAddAdminPass.AutoSize = true;
            this.lblAddAdminPass.Location = new System.Drawing.Point(170, 136);
            this.lblAddAdminPass.Name = "lblAddAdminPass";
            this.lblAddAdminPass.Size = new System.Drawing.Size(84, 13);
            this.lblAddAdminPass.TabIndex = 4;
            this.lblAddAdminPass.Text = "Add Admin Pass";
            this.lblAddAdminPass.UseMnemonic = false;
            // 
            // txtAddAdminPass
            // 
            this.txtAddAdminPass.Location = new System.Drawing.Point(295, 133);
            this.txtAddAdminPass.Name = "txtAddAdminPass";
            this.txtAddAdminPass.Size = new System.Drawing.Size(100, 20);
            this.txtAddAdminPass.TabIndex = 3;
            // 
            // AddAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAddAdminPass);
            this.Controls.Add(this.txtAddAdminPass);
            this.Controls.Add(this.lblAddAdminName);
            this.Controls.Add(this.txtAdminName);
            this.Controls.Add(this.btnAddAdmin);
            this.Name = "AddAdminForm";
            this.Text = "AddAdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.TextBox txtAdminName;
        private System.Windows.Forms.Label lblAddAdminName;
        private System.Windows.Forms.Label lblAddAdminPass;
        private System.Windows.Forms.TextBox txtAddAdminPass;
    }
}