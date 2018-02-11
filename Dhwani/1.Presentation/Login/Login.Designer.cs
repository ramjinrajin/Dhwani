namespace Dhwani
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labFname = new System.Windows.Forms.Label();
            this.labLname = new System.Windows.Forms.Label();
            this.labemail = new System.Windows.Forms.Label();
            this.labDateofBirth = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDateofBirth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtpincode = new System.Windows.Forms.TextBox();
            this.buttenregister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // labFname
            // 
            this.labFname.AutoSize = true;
            this.labFname.Location = new System.Drawing.Point(50, 37);
            this.labFname.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labFname.Name = "labFname";
            this.labFname.Size = new System.Drawing.Size(57, 13);
            this.labFname.TabIndex = 2;
            this.labFname.Text = "First Name";
            // 
            // labLname
            // 
            this.labLname.AutoSize = true;
            this.labLname.Location = new System.Drawing.Point(50, 76);
            this.labLname.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labLname.Name = "labLname";
            this.labLname.Size = new System.Drawing.Size(53, 13);
            this.labLname.TabIndex = 3;
            this.labLname.Text = "Lastname";
            // 
            // labemail
            // 
            this.labemail.AutoSize = true;
            this.labemail.Location = new System.Drawing.Point(50, 114);
            this.labemail.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labemail.Name = "labemail";
            this.labemail.Size = new System.Drawing.Size(32, 13);
            this.labemail.TabIndex = 4;
            this.labemail.Text = "Email";
            // 
            // labDateofBirth
            // 
            this.labDateofBirth.AutoSize = true;
            this.labDateofBirth.Location = new System.Drawing.Point(50, 159);
            this.labDateofBirth.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labDateofBirth.Name = "labDateofBirth";
            this.labDateofBirth.Size = new System.Drawing.Size(60, 13);
            this.labDateofBirth.TabIndex = 5;
            this.labDateofBirth.Text = "DateofBirth";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(130, 37);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(1);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(145, 20);
            this.txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(130, 76);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(1);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(145, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(130, 114);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(1);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(145, 20);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtDateofBirth
            // 
            this.txtDateofBirth.Location = new System.Drawing.Point(130, 156);
            this.txtDateofBirth.Margin = new System.Windows.Forms.Padding(1);
            this.txtDateofBirth.Name = "txtDateofBirth";
            this.txtDateofBirth.Size = new System.Drawing.Size(145, 20);
            this.txtDateofBirth.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mobile No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Address";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 273);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pin code";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(130, 196);
            this.txtMobileNo.Margin = new System.Windows.Forms.Padding(1);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(145, 20);
            this.txtMobileNo.TabIndex = 13;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(130, 233);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(1);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(145, 20);
            this.txtAddress.TabIndex = 14;
            // 
            // txtpincode
            // 
            this.txtpincode.Location = new System.Drawing.Point(130, 273);
            this.txtpincode.Margin = new System.Windows.Forms.Padding(1);
            this.txtpincode.Name = "txtpincode";
            this.txtpincode.Size = new System.Drawing.Size(145, 20);
            this.txtpincode.TabIndex = 15;
            // 
            // buttenregister
            // 
            this.buttenregister.Location = new System.Drawing.Point(149, 308);
            this.buttenregister.Name = "buttenregister";
            this.buttenregister.Size = new System.Drawing.Size(75, 23);
            this.buttenregister.TabIndex = 16;
            this.buttenregister.Text = "Register";
            this.buttenregister.UseVisualStyleBackColor = true;
            this.buttenregister.Click += new System.EventHandler(this.buttenregister_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 352);
            this.Controls.Add(this.buttenregister);
            this.Controls.Add(this.txtpincode);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDateofBirth);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.labDateofBirth);
            this.Controls.Add(this.labemail);
            this.Controls.Add(this.labLname);
            this.Controls.Add(this.labFname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label labFname;
        private System.Windows.Forms.Label labLname;
        private System.Windows.Forms.Label labemail;
        private System.Windows.Forms.Label labDateofBirth;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDateofBirth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtpincode;
        private System.Windows.Forms.Button buttenregister;
    }
}

