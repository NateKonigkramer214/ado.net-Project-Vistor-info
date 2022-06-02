using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charlie
{
    public partial class MeetingAim : Form
    {
        public MeetingAim()
        {
            InitializeComponent();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            if (meeting_radio.Checked)
            {
                Form1.Self.meetaim_btn.Text = meeting_radio.Text;
            }
            else if (salesapp_radio.Checked)
            {
                Form1.Self.meetaim_btn.Text = salesapp_radio.Text;
            }
            else if (sitevisit_radio.Checked)
            {
                Form1.Self.meetaim_btn.Text = sitevisit_radio.Text;
            }
            else if (studentint_radio.Checked)
            {
                Form1.Self.meetaim_btn.Text = studentint_radio.Text;
            }
            this.Close();


         }

            private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
