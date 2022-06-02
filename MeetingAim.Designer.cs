namespace Charlie
{
    partial class MeetingAim
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
            this.meeting_radio = new System.Windows.Forms.RadioButton();
            this.salesapp_radio = new System.Windows.Forms.RadioButton();
            this.sitevisit_radio = new System.Windows.Forms.RadioButton();
            this.studentint_radio = new System.Windows.Forms.RadioButton();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please specify the nature of the meeting";
            // 
            // meeting_radio
            // 
            this.meeting_radio.AutoSize = true;
            this.meeting_radio.Location = new System.Drawing.Point(15, 62);
            this.meeting_radio.Name = "meeting_radio";
            this.meeting_radio.Size = new System.Drawing.Size(63, 17);
            this.meeting_radio.TabIndex = 2;
            this.meeting_radio.TabStop = true;
            this.meeting_radio.Text = "Meeting";
            this.meeting_radio.UseVisualStyleBackColor = true;
            // 
            // salesapp_radio
            // 
            this.salesapp_radio.AutoSize = true;
            this.salesapp_radio.Location = new System.Drawing.Point(126, 62);
            this.salesapp_radio.Name = "salesapp_radio";
            this.salesapp_radio.Size = new System.Drawing.Size(108, 17);
            this.salesapp_radio.TabIndex = 4;
            this.salesapp_radio.TabStop = true;
            this.salesapp_radio.Text = "Sale Appointment";
            this.salesapp_radio.UseVisualStyleBackColor = true;
            // 
            // sitevisit_radio
            // 
            this.sitevisit_radio.AutoSize = true;
            this.sitevisit_radio.Location = new System.Drawing.Point(15, 109);
            this.sitevisit_radio.Name = "sitevisit_radio";
            this.sitevisit_radio.Size = new System.Drawing.Size(65, 17);
            this.sitevisit_radio.TabIndex = 5;
            this.sitevisit_radio.TabStop = true;
            this.sitevisit_radio.Text = "Site Visit";
            this.sitevisit_radio.UseVisualStyleBackColor = true;
            // 
            // studentint_radio
            // 
            this.studentint_radio.AutoSize = true;
            this.studentint_radio.Location = new System.Drawing.Point(126, 109);
            this.studentint_radio.Name = "studentint_radio";
            this.studentint_radio.Size = new System.Drawing.Size(108, 17);
            this.studentint_radio.TabIndex = 6;
            this.studentint_radio.TabStop = true;
            this.studentint_radio.Text = "Student Interview";
            this.studentint_radio.UseVisualStyleBackColor = true;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(43, 142);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 7;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(145, 142);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 23);
            this.ok_btn.TabIndex = 8;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // MeetingAim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 177);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.studentint_radio);
            this.Controls.Add(this.sitevisit_radio);
            this.Controls.Add(this.salesapp_radio);
            this.Controls.Add(this.meeting_radio);
            this.Controls.Add(this.label1);
            this.Name = "MeetingAim";
            this.Text = "MeetingAim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton meeting_radio;
        private System.Windows.Forms.RadioButton salesapp_radio;
        private System.Windows.Forms.RadioButton sitevisit_radio;
        private System.Windows.Forms.RadioButton studentint_radio;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button ok_btn;
    }
}