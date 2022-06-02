namespace Charlie
{
    partial class Form1
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
            this.VisitorDetails_GB = new System.Windows.Forms.GroupBox();
            this.VisitorLable = new System.Windows.Forms.Label();
            this.TB_Visitor_ID = new System.Windows.Forms.TextBox();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.mobile_tb = new System.Windows.Forms.TextBox();
            this.surname_tb = new System.Windows.Forms.TextBox();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.Visitor_email = new System.Windows.Forms.Label();
            this.Visitor_mobile = new System.Windows.Forms.Label();
            this.Visitor_surname = new System.Windows.Forms.Label();
            this.Visitor_name = new System.Windows.Forms.Label();
            this.MeetingDetails_GB = new System.Windows.Forms.GroupBox();
            this.label_colon = new System.Windows.Forms.Label();
            this.nu_min = new System.Windows.Forms.NumericUpDown();
            this.nu_hour = new System.Windows.Forms.NumericUpDown();
            this.meetwith = new System.Windows.Forms.ComboBox();
            this.meetaim_btn = new System.Windows.Forms.Button();
            this.metting_aim = new System.Windows.Forms.Label();
            this.meetingdate = new System.Windows.Forms.DateTimePicker();
            this.meeting_with = new System.Windows.Forms.Label();
            this.time_meeting = new System.Windows.Forms.Label();
            this.date_meeting = new System.Windows.Forms.Label();
            this.signIn_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.information_lb = new System.Windows.Forms.ListBox();
            this.InsertDataSQL = new System.Windows.Forms.Button();
            this.UpdateData = new System.Windows.Forms.Button();
            this.DeleteData = new System.Windows.Forms.Button();
            this.Staff_ID_LABLE = new System.Windows.Forms.Label();
            this.TB_Staff_ID = new System.Windows.Forms.TextBox();
            this.STAFF_ID_GB = new System.Windows.Forms.GroupBox();
            this.VisitorDetails_GB.SuspendLayout();
            this.MeetingDetails_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_hour)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.STAFF_ID_GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // VisitorDetails_GB
            // 
            this.VisitorDetails_GB.BackColor = System.Drawing.Color.White;
            this.VisitorDetails_GB.Controls.Add(this.VisitorLable);
            this.VisitorDetails_GB.Controls.Add(this.TB_Visitor_ID);
            this.VisitorDetails_GB.Controls.Add(this.email_tb);
            this.VisitorDetails_GB.Controls.Add(this.mobile_tb);
            this.VisitorDetails_GB.Controls.Add(this.surname_tb);
            this.VisitorDetails_GB.Controls.Add(this.name_tb);
            this.VisitorDetails_GB.Controls.Add(this.Visitor_email);
            this.VisitorDetails_GB.Controls.Add(this.Visitor_mobile);
            this.VisitorDetails_GB.Controls.Add(this.Visitor_surname);
            this.VisitorDetails_GB.Controls.Add(this.Visitor_name);
            this.VisitorDetails_GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisitorDetails_GB.Location = new System.Drawing.Point(22, 109);
            this.VisitorDetails_GB.Name = "VisitorDetails_GB";
            this.VisitorDetails_GB.Size = new System.Drawing.Size(261, 312);
            this.VisitorDetails_GB.TabIndex = 1;
            this.VisitorDetails_GB.TabStop = false;
            this.VisitorDetails_GB.Text = "Visitor Details";
            // 
            // VisitorLable
            // 
            this.VisitorLable.AutoSize = true;
            this.VisitorLable.Location = new System.Drawing.Point(23, 30);
            this.VisitorLable.Name = "VisitorLable";
            this.VisitorLable.Size = new System.Drawing.Size(52, 13);
            this.VisitorLable.TabIndex = 7;
            this.VisitorLable.Text = "Visitor_ID";
            // 
            // TB_Visitor_ID
            // 
            this.TB_Visitor_ID.Enabled = false;
            this.TB_Visitor_ID.Location = new System.Drawing.Point(26, 46);
            this.TB_Visitor_ID.Name = "TB_Visitor_ID";
            this.TB_Visitor_ID.Size = new System.Drawing.Size(206, 20);
            this.TB_Visitor_ID.TabIndex = 6;
            // 
            // email_tb
            // 
            this.email_tb.Location = new System.Drawing.Point(26, 259);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(206, 20);
            this.email_tb.TabIndex = 5;
            // 
            // mobile_tb
            // 
            this.mobile_tb.Location = new System.Drawing.Point(26, 194);
            this.mobile_tb.Name = "mobile_tb";
            this.mobile_tb.Size = new System.Drawing.Size(206, 20);
            this.mobile_tb.TabIndex = 5;
            this.mobile_tb.TextChanged += new System.EventHandler(this.mobile_tb_TextChanged);
            this.mobile_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mobile_tb_kp);
            // 
            // surname_tb
            // 
            this.surname_tb.Location = new System.Drawing.Point(26, 139);
            this.surname_tb.Name = "surname_tb";
            this.surname_tb.Size = new System.Drawing.Size(206, 20);
            this.surname_tb.TabIndex = 4;
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(26, 89);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(206, 20);
            this.name_tb.TabIndex = 2;
            // 
            // Visitor_email
            // 
            this.Visitor_email.AutoSize = true;
            this.Visitor_email.Location = new System.Drawing.Point(26, 230);
            this.Visitor_email.Name = "Visitor_email";
            this.Visitor_email.Size = new System.Drawing.Size(32, 13);
            this.Visitor_email.TabIndex = 3;
            this.Visitor_email.Text = "Email";
            // 
            // Visitor_mobile
            // 
            this.Visitor_mobile.AutoSize = true;
            this.Visitor_mobile.Location = new System.Drawing.Point(26, 167);
            this.Visitor_mobile.Name = "Visitor_mobile";
            this.Visitor_mobile.Size = new System.Drawing.Size(38, 13);
            this.Visitor_mobile.TabIndex = 2;
            this.Visitor_mobile.Text = "Mobile";
            this.Visitor_mobile.Click += new System.EventHandler(this.Visitor_mobile_Click);
            // 
            // Visitor_surname
            // 
            this.Visitor_surname.AutoSize = true;
            this.Visitor_surname.Location = new System.Drawing.Point(23, 112);
            this.Visitor_surname.Name = "Visitor_surname";
            this.Visitor_surname.Size = new System.Drawing.Size(49, 13);
            this.Visitor_surname.TabIndex = 1;
            this.Visitor_surname.Text = "Surname";
            // 
            // Visitor_name
            // 
            this.Visitor_name.AutoSize = true;
            this.Visitor_name.Location = new System.Drawing.Point(23, 69);
            this.Visitor_name.Name = "Visitor_name";
            this.Visitor_name.Size = new System.Drawing.Size(35, 13);
            this.Visitor_name.TabIndex = 0;
            this.Visitor_name.Text = "Name";
            // 
            // MeetingDetails_GB
            // 
            this.MeetingDetails_GB.Controls.Add(this.label_colon);
            this.MeetingDetails_GB.Controls.Add(this.nu_min);
            this.MeetingDetails_GB.Controls.Add(this.nu_hour);
            this.MeetingDetails_GB.Controls.Add(this.meetwith);
            this.MeetingDetails_GB.Controls.Add(this.meetaim_btn);
            this.MeetingDetails_GB.Controls.Add(this.metting_aim);
            this.MeetingDetails_GB.Controls.Add(this.meetingdate);
            this.MeetingDetails_GB.Controls.Add(this.meeting_with);
            this.MeetingDetails_GB.Controls.Add(this.time_meeting);
            this.MeetingDetails_GB.Controls.Add(this.date_meeting);
            this.MeetingDetails_GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingDetails_GB.Location = new System.Drawing.Point(301, 109);
            this.MeetingDetails_GB.Name = "MeetingDetails_GB";
            this.MeetingDetails_GB.Size = new System.Drawing.Size(259, 312);
            this.MeetingDetails_GB.TabIndex = 2;
            this.MeetingDetails_GB.TabStop = false;
            this.MeetingDetails_GB.Text = "Meeting Details";
            // 
            // label_colon
            // 
            this.label_colon.AutoSize = true;
            this.label_colon.Location = new System.Drawing.Point(129, 139);
            this.label_colon.Name = "label_colon";
            this.label_colon.Size = new System.Drawing.Size(10, 13);
            this.label_colon.TabIndex = 10;
            this.label_colon.Text = ":";
            this.label_colon.Click += new System.EventHandler(this.label_colon_Click);
            // 
            // nu_min
            // 
            this.nu_min.Location = new System.Drawing.Point(145, 137);
            this.nu_min.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nu_min.Name = "nu_min";
            this.nu_min.Size = new System.Drawing.Size(95, 20);
            this.nu_min.TabIndex = 9;
            this.nu_min.ValueChanged += new System.EventHandler(this.nu_min_ValueChanged);
            // 
            // nu_hour
            // 
            this.nu_hour.Location = new System.Drawing.Point(27, 137);
            this.nu_hour.Name = "nu_hour";
            this.nu_hour.Size = new System.Drawing.Size(99, 20);
            this.nu_hour.TabIndex = 8;
            // 
            // meetwith
            // 
            this.meetwith.FormattingEnabled = true;
            this.meetwith.Location = new System.Drawing.Point(27, 193);
            this.meetwith.Name = "meetwith";
            this.meetwith.Size = new System.Drawing.Size(200, 21);
            this.meetwith.TabIndex = 7;
            this.meetwith.SelectedIndexChanged += new System.EventHandler(this.meetwith_SelectedIndexChanged);
            this.meetwith.SelectedValueChanged += new System.EventHandler(this.Staff_ID_Function);
            // 
            // meetaim_btn
            // 
            this.meetaim_btn.Location = new System.Drawing.Point(19, 259);
            this.meetaim_btn.Name = "meetaim_btn";
            this.meetaim_btn.Size = new System.Drawing.Size(208, 23);
            this.meetaim_btn.TabIndex = 6;
            this.meetaim_btn.Text = "Meeting Aim";
            this.meetaim_btn.UseVisualStyleBackColor = true;
            this.meetaim_btn.Click += new System.EventHandler(this.meetaim_btn_Click);
            // 
            // metting_aim
            // 
            this.metting_aim.AutoSize = true;
            this.metting_aim.Location = new System.Drawing.Point(24, 230);
            this.metting_aim.Name = "metting_aim";
            this.metting_aim.Size = new System.Drawing.Size(65, 13);
            this.metting_aim.TabIndex = 5;
            this.metting_aim.Text = "Meeting Aim";
            // 
            // meetingdate
            // 
            this.meetingdate.Location = new System.Drawing.Point(27, 69);
            this.meetingdate.Name = "meetingdate";
            this.meetingdate.Size = new System.Drawing.Size(200, 20);
            this.meetingdate.TabIndex = 4;
            // 
            // meeting_with
            // 
            this.meeting_with.AutoSize = true;
            this.meeting_with.Location = new System.Drawing.Point(24, 167);
            this.meeting_with.Name = "meeting_with";
            this.meeting_with.Size = new System.Drawing.Size(70, 13);
            this.meeting_with.TabIndex = 3;
            this.meeting_with.Text = "Meeting With";
            // 
            // time_meeting
            // 
            this.time_meeting.AutoSize = true;
            this.time_meeting.Location = new System.Drawing.Point(24, 101);
            this.time_meeting.Name = "time_meeting";
            this.time_meeting.Size = new System.Drawing.Size(30, 13);
            this.time_meeting.TabIndex = 2;
            this.time_meeting.Text = "Time";
            // 
            // date_meeting
            // 
            this.date_meeting.AutoSize = true;
            this.date_meeting.Location = new System.Drawing.Point(24, 44);
            this.date_meeting.Name = "date_meeting";
            this.date_meeting.Size = new System.Drawing.Size(30, 13);
            this.date_meeting.TabIndex = 1;
            this.date_meeting.Text = "Date";
            // 
            // signIn_btn
            // 
            this.signIn_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.signIn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signIn_btn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(198)))), ((int)(((byte)(63)))));
            this.signIn_btn.Location = new System.Drawing.Point(22, 427);
            this.signIn_btn.Name = "signIn_btn";
            this.signIn_btn.Size = new System.Drawing.Size(128, 43);
            this.signIn_btn.TabIndex = 3;
            this.signIn_btn.Text = "Sign In";
            this.signIn_btn.UseVisualStyleBackColor = false;
            this.signIn_btn.Click += new System.EventHandler(this.signIn_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.information_lb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(581, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 387);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visitors on-site";
            // 
            // information_lb
            // 
            this.information_lb.FormattingEnabled = true;
            this.information_lb.Location = new System.Drawing.Point(6, 19);
            this.information_lb.Name = "information_lb";
            this.information_lb.Size = new System.Drawing.Size(307, 355);
            this.information_lb.TabIndex = 0;
            this.information_lb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LB_inforamtion_MouseClick);
            this.information_lb.SelectedIndexChanged += new System.EventHandler(this.information_lb_SelectedIndexChanged);
            // 
            // InsertDataSQL
            // 
            this.InsertDataSQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.InsertDataSQL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsertDataSQL.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertDataSQL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(198)))), ((int)(((byte)(63)))));
            this.InsertDataSQL.Location = new System.Drawing.Point(156, 427);
            this.InsertDataSQL.Name = "InsertDataSQL";
            this.InsertDataSQL.Size = new System.Drawing.Size(127, 43);
            this.InsertDataSQL.TabIndex = 5;
            this.InsertDataSQL.Text = "Insert";
            this.InsertDataSQL.UseVisualStyleBackColor = false;
            this.InsertDataSQL.Click += new System.EventHandler(this.InsertDataSQL_Click);
            // 
            // UpdateData
            // 
            this.UpdateData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.UpdateData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateData.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(198)))), ((int)(((byte)(63)))));
            this.UpdateData.Location = new System.Drawing.Point(301, 427);
            this.UpdateData.Name = "UpdateData";
            this.UpdateData.Size = new System.Drawing.Size(126, 43);
            this.UpdateData.TabIndex = 6;
            this.UpdateData.Text = "Update";
            this.UpdateData.UseVisualStyleBackColor = false;
            this.UpdateData.Click += new System.EventHandler(this.UpdateData_Click);
            // 
            // DeleteData
            // 
            this.DeleteData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.DeleteData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteData.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(198)))), ((int)(((byte)(63)))));
            this.DeleteData.Location = new System.Drawing.Point(433, 427);
            this.DeleteData.Name = "DeleteData";
            this.DeleteData.Size = new System.Drawing.Size(127, 43);
            this.DeleteData.TabIndex = 7;
            this.DeleteData.Text = "Delete";
            this.DeleteData.UseVisualStyleBackColor = false;
            this.DeleteData.Click += new System.EventHandler(this.DeleteData_Click);
            // 
            // Staff_ID_LABLE
            // 
            this.Staff_ID_LABLE.AutoSize = true;
            this.Staff_ID_LABLE.Location = new System.Drawing.Point(6, 20);
            this.Staff_ID_LABLE.Name = "Staff_ID_LABLE";
            this.Staff_ID_LABLE.Size = new System.Drawing.Size(49, 13);
            this.Staff_ID_LABLE.TabIndex = 8;
            this.Staff_ID_LABLE.Text = "Staff_ID:";
            // 
            // TB_Staff_ID
            // 
            this.TB_Staff_ID.Enabled = false;
            this.TB_Staff_ID.Location = new System.Drawing.Point(61, 17);
            this.TB_Staff_ID.Name = "TB_Staff_ID";
            this.TB_Staff_ID.Size = new System.Drawing.Size(206, 20);
            this.TB_Staff_ID.TabIndex = 9;
            this.TB_Staff_ID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // STAFF_ID_GB
            // 
            this.STAFF_ID_GB.Controls.Add(this.TB_Staff_ID);
            this.STAFF_ID_GB.Controls.Add(this.Staff_ID_LABLE);
            this.STAFF_ID_GB.Location = new System.Drawing.Point(587, 427);
            this.STAFF_ID_GB.Name = "STAFF_ID_GB";
            this.STAFF_ID_GB.Size = new System.Drawing.Size(284, 43);
            this.STAFF_ID_GB.TabIndex = 10;
            this.STAFF_ID_GB.TabStop = false;
            this.STAFF_ID_GB.Text = "Staff Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Charlie.Properties.Resources.Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(906, 482);
            this.Controls.Add(this.DeleteData);
            this.Controls.Add(this.STAFF_ID_GB);
            this.Controls.Add(this.UpdateData);
            this.Controls.Add(this.InsertDataSQL);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.signIn_btn);
            this.Controls.Add(this.MeetingDetails_GB);
            this.Controls.Add(this.VisitorDetails_GB);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Visitor Registration";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.VisitorDetails_GB.ResumeLayout(false);
            this.VisitorDetails_GB.PerformLayout();
            this.MeetingDetails_GB.ResumeLayout(false);
            this.MeetingDetails_GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_hour)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.STAFF_ID_GB.ResumeLayout(false);
            this.STAFF_ID_GB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox VisitorDetails_GB;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.TextBox mobile_tb;
        private System.Windows.Forms.TextBox surname_tb;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label Visitor_email;
        private System.Windows.Forms.Label Visitor_mobile;
        private System.Windows.Forms.Label Visitor_surname;
        private System.Windows.Forms.Label Visitor_name;
        private System.Windows.Forms.GroupBox MeetingDetails_GB;
        private System.Windows.Forms.NumericUpDown nu_min;
        private System.Windows.Forms.NumericUpDown nu_hour;
        private System.Windows.Forms.ComboBox meetwith;
        private System.Windows.Forms.Label metting_aim;
        private System.Windows.Forms.Label meeting_with;
        private System.Windows.Forms.Label time_meeting;
        private System.Windows.Forms.Label date_meeting;
        private System.Windows.Forms.Button signIn_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox information_lb;
        private System.Windows.Forms.Label label_colon;
        public System.Windows.Forms.Button meetaim_btn;
        public System.Windows.Forms.DateTimePicker meetingdate;
        private System.Windows.Forms.Button InsertDataSQL;
        private System.Windows.Forms.Button UpdateData;
        private System.Windows.Forms.Button DeleteData;
        private System.Windows.Forms.Label Staff_ID_LABLE;
        private System.Windows.Forms.TextBox TB_Staff_ID;
        private System.Windows.Forms.GroupBox STAFF_ID_GB;
        private System.Windows.Forms.Label VisitorLable;
        private System.Windows.Forms.TextBox TB_Visitor_ID;
    }
}

