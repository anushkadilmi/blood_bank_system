namespace Blood_Bank
{
    partial class UpdateDonorDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDonorDetails));
            this.btnclose = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.comboblood = new System.Windows.Forms.ComboBox();
            this.txtbxaddress = new System.Windows.Forms.TextBox();
            this.txtbxcity = new System.Windows.Forms.TextBox();
            this.txtbxemail = new System.Windows.Forms.TextBox();
            this.combogender = new System.Windows.Forms.ComboBox();
            this.txtbxmobile = new System.Windows.Forms.TextBox();
            this.dateofbirth = new System.Windows.Forms.DateTimePicker();
            this.txtmthr = new System.Windows.Forms.TextBox();
            this.txtbxfthr = new System.Windows.Forms.TextBox();
            this.txtbxname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxid = new System.Windows.Forms.TextBox();
            this.btnserach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(764, 661);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(141, 49);
            this.btnclose.TabIndex = 50;
            this.btnclose.Text = "      Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Image = ((System.Drawing.Image)(resources.GetObject("btnreset.Image")));
            this.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreset.Location = new System.Drawing.Point(409, 661);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(141, 49);
            this.btnreset.TabIndex = 49;
            this.btnreset.Text = "      Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.Image")));
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.Location = new System.Drawing.Point(83, 661);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(141, 49);
            this.btnupdate.TabIndex = 48;
            this.btnupdate.Text = "      Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // comboblood
            // 
            this.comboblood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboblood.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboblood.FormattingEnabled = true;
            this.comboblood.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O",
            "O-",
            "AB+",
            "AB-"});
            this.comboblood.Location = new System.Drawing.Point(764, 252);
            this.comboblood.Name = "comboblood";
            this.comboblood.Size = new System.Drawing.Size(253, 27);
            this.comboblood.TabIndex = 46;
            // 
            // txtbxaddress
            // 
            this.txtbxaddress.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxaddress.Location = new System.Drawing.Point(764, 401);
            this.txtbxaddress.Multiline = true;
            this.txtbxaddress.Name = "txtbxaddress";
            this.txtbxaddress.Size = new System.Drawing.Size(253, 137);
            this.txtbxaddress.TabIndex = 45;
            // 
            // txtbxcity
            // 
            this.txtbxcity.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxcity.Location = new System.Drawing.Point(764, 331);
            this.txtbxcity.Name = "txtbxcity";
            this.txtbxcity.Size = new System.Drawing.Size(253, 27);
            this.txtbxcity.TabIndex = 44;
            // 
            // txtbxemail
            // 
            this.txtbxemail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxemail.Location = new System.Drawing.Point(764, 188);
            this.txtbxemail.Multiline = true;
            this.txtbxemail.Name = "txtbxemail";
            this.txtbxemail.Size = new System.Drawing.Size(253, 27);
            this.txtbxemail.TabIndex = 43;
            // 
            // combogender
            // 
            this.combogender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combogender.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combogender.FormattingEnabled = true;
            this.combogender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.combogender.Location = new System.Drawing.Point(217, 559);
            this.combogender.Name = "combogender";
            this.combogender.Size = new System.Drawing.Size(253, 27);
            this.combogender.TabIndex = 42;
            // 
            // txtbxmobile
            // 
            this.txtbxmobile.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxmobile.Location = new System.Drawing.Point(217, 496);
            this.txtbxmobile.Name = "txtbxmobile";
            this.txtbxmobile.Size = new System.Drawing.Size(253, 27);
            this.txtbxmobile.TabIndex = 41;
            // 
            // dateofbirth
            // 
            this.dateofbirth.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateofbirth.Location = new System.Drawing.Point(217, 428);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(253, 27);
            this.dateofbirth.TabIndex = 40;
            this.dateofbirth.ValueChanged += new System.EventHandler(this.dateofbirth_ValueChanged);
            // 
            // txtmthr
            // 
            this.txtmthr.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmthr.Location = new System.Drawing.Point(217, 348);
            this.txtmthr.Name = "txtmthr";
            this.txtmthr.Size = new System.Drawing.Size(253, 27);
            this.txtmthr.TabIndex = 39;
            // 
            // txtbxfthr
            // 
            this.txtbxfthr.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxfthr.Location = new System.Drawing.Point(217, 269);
            this.txtbxfthr.Name = "txtbxfthr";
            this.txtbxfthr.Size = new System.Drawing.Size(253, 27);
            this.txtbxfthr.TabIndex = 38;
            // 
            // txtbxname
            // 
            this.txtbxname.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxname.Location = new System.Drawing.Point(217, 188);
            this.txtbxname.Name = "txtbxname";
            this.txtbxname.Size = new System.Drawing.Size(253, 27);
            this.txtbxname.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(592, 401);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 23);
            this.label12.TabIndex = 36;
            this.label12.Text = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(592, 335);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 23);
            this.label11.TabIndex = 35;
            this.label11.Text = "City";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(592, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 23);
            this.label10.TabIndex = 34;
            this.label10.Text = "Blood Group";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(592, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 23);
            this.label9.TabIndex = 33;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 563);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 23);
            this.label8.TabIndex = 32;
            this.label8.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 23);
            this.label7.TabIndex = 31;
            this.label7.Text = "Mobile";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 23);
            this.label6.TabIndex = 30;
            this.label6.Text = "Date Of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Mother Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Father Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 37);
            this.label1.TabIndex = 51;
            this.label1.Text = "UPDATE DONOR DETAILS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = " DonorID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtbxid
            // 
            this.txtbxid.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxid.Location = new System.Drawing.Point(297, 86);
            this.txtbxid.Multiline = true;
            this.txtbxid.Name = "txtbxid";
            this.txtbxid.Size = new System.Drawing.Size(253, 26);
            this.txtbxid.TabIndex = 53;
            this.txtbxid.TextChanged += new System.EventHandler(this.txtbxid_TextChanged);
            // 
            // btnserach
            // 
            this.btnserach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnserach.Image = ((System.Drawing.Image)(resources.GetObject("btnserach.Image")));
            this.btnserach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnserach.Location = new System.Drawing.Point(645, 76);
            this.btnserach.Name = "btnserach";
            this.btnserach.Size = new System.Drawing.Size(141, 41);
            this.btnserach.TabIndex = 54;
            this.btnserach.Text = "      Search";
            this.btnserach.UseVisualStyleBackColor = true;
            this.btnserach.Click += new System.EventHandler(this.btnserach_Click);
            // 
            // UpdateDonorDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1043, 723);
            this.Controls.Add(this.btnserach);
            this.Controls.Add(this.txtbxid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.comboblood);
            this.Controls.Add(this.txtbxaddress);
            this.Controls.Add(this.txtbxcity);
            this.Controls.Add(this.txtbxemail);
            this.Controls.Add(this.combogender);
            this.Controls.Add(this.txtbxmobile);
            this.Controls.Add(this.dateofbirth);
            this.Controls.Add(this.txtmthr);
            this.Controls.Add(this.txtbxfthr);
            this.Controls.Add(this.txtbxname);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateDonorDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateDonorDetails";
            this.Load += new System.EventHandler(this.UpdateDonorDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.ComboBox comboblood;
        private System.Windows.Forms.TextBox txtbxaddress;
        private System.Windows.Forms.TextBox txtbxcity;
        private System.Windows.Forms.TextBox txtbxemail;
        private System.Windows.Forms.ComboBox combogender;
        private System.Windows.Forms.TextBox txtbxmobile;
        private System.Windows.Forms.DateTimePicker dateofbirth;
        private System.Windows.Forms.TextBox txtmthr;
        private System.Windows.Forms.TextBox txtbxfthr;
        private System.Windows.Forms.TextBox txtbxname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxid;
        private System.Windows.Forms.Button btnserach;
    }
}