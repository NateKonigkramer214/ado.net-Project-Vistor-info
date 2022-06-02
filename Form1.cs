using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Charlie
{
    public partial class Form1 : Form
    {
     
        //Connection string to database.
        string connString = @"Data Source=DESKTOP-EJAM62L;
                            Initial Catalog=VisitorInfo;
                            Integrated Security=True;
                            Connect Timeout=30;Encrypt=False;
                            TrustServerCertificate=False;
                            ApplicationIntent=ReadWrite;
                            MultiSubnetFailover=False";

        int Visitor_ID = 0;

        public static Form1 Self;
        MeetingAim aim = new MeetingAim();

        public void Clear_Fields() // Function to clear all fields as well as ListBox
        {
            name_tb.Clear();
            surname_tb.Clear();
            email_tb.Clear();
            mobile_tb.Clear();
            nu_hour.ResetText();
            nu_min.ResetText();
            meetwith.ResetText();
            meetaim_btn.Text = "Meeting Aim";
            name_tb.Focus();
            TB_Staff_ID.Clear();
            TB_Visitor_ID.Clear();
            information_lb.Items.Clear();
        }

        public Form1()
        {
            InitializeComponent();
            Self = this;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            ListBox_Data_Load(); // Calling function to load data in the ListBox from Student_Info Table
            Staff_Data_Load(); // Calling function to load data in the ComboBox from Course_Details Table
        }

        public void ListBox_Data_Load()
        {
            Clear_Fields(); // Calling  Clear_Field function

            // Creating instance of SqlConnection
            SqlConnection conn = new SqlConnection(connString);

            //Set the sql command (statment)
            string sql_Query = "select Visitor.Visitor_ID, Visitor.FirstName, Visitor.Surname, Visitor.Mobile, Staff.Meeting_with , Visitor.Meeting_aim From Visitor, Staff Where Visitor.Staff_ID = Staff.Staff_ID";

            // Creating instance of SqlCommand  and set the connection and query to instance of SqlCommand
            SqlCommand cmd = new SqlCommand(sql_Query, conn);
            cmd.Parameters.Clear();
            conn.Open();

            //Create the instance of the sqldatareader
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //populate data in Listbox from Reader
                information_lb.Items.Add(( reader["Visitor_ID"] + " " + reader["FirstName"] + " " + reader["Surname"] + " " + reader["Mobile"] + " " + reader["Meeting_aim"] + " " + reader["Meeting_with"] ));
            }

            //Close the data reader
            reader.Close();

            //Connection close
            conn.Close();
        }

        public void Staff_Data_Load()
        {
            // Creating instance of SqlConnection
            SqlConnection conn = new SqlConnection(connString);
            // set the sql command ( Statement )
            string sql_Query2 = "Select Staff_ID,Meeting_with From Staff";
            // Creating instance of SqlCommand  and set the connection and query to instance of SqlCommand
            SqlCommand cmd2 = new SqlCommand(sql_Query2, conn);
            //Open connection
            conn.Open();
            // Creating instance of SqlDataReader
            SqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                //populate data in ComboBox from Reader
                meetwith.Items.Add(reader["Meeting_with"]);
            }
            //Close Database reader
            reader.Close();
            //Close connection
            conn.Close();
        }

        //Insert data to form

        private void InsertDataSQL_Click(object sender, EventArgs e)
        {

            int hr = Convert.ToInt32(nu_hour.Value);
            int mins = Convert.ToInt32(nu_min.Value);
            DateTime dt = DateTime.Today.AddHours(hr).AddMinutes(mins);
            string meetingtime = (dt.ToString("hh:mm"));

            meetingdate.Format = DateTimePickerFormat.Custom;
            meetingdate.CustomFormat = "yyyy-MM-dd";

           
            SqlConnection conn = new SqlConnection(connString);

            
            string sql_Query3 = "Insert into Visitor(FirstName, Surname, Mobile, Email, Meeting_date, Meeting_aim, Meeting_time, Staff_ID) values ('" + name_tb.Text + "','" + surname_tb.Text + "','" + mobile_tb.Text + "','" + email_tb.Text + "','" + meetingdate.Text + "','" + meetaim_btn.Text + "','" + meetingtime + "','" + TB_Staff_ID.Text + "')";

            
            SqlCommand cmd4 = new SqlCommand(sql_Query3, conn);

            //Open connection
            conn.Open();

            cmd4.ExecuteNonQuery();

            MessageBox.Show("Record Saved/Inseted"); 
            //Close connection
            conn.Close();

            
            ListBox_Data_Load();

        }

        private void LB_inforamtion_MouseClick(object sender, MouseEventArgs e)
        {
            int hr = Convert.ToInt32(nu_hour.Value);
            int mins = Convert.ToInt32(nu_min.Value);
            DateTime dt = DateTime.Today.AddHours(hr).AddMinutes(mins);
            string meetingtime = (dt.ToString("hh:mm"));

            meetingdate.Format = DateTimePickerFormat.Custom;
            meetingdate.CustomFormat = "yyyy-MM-dd";

            var selectedValue = information_lb.SelectedItem;
            if (selectedValue != null)
            {
                MessageBox.Show(selectedValue.ToString());
            }
            string VisitorData = information_lb.SelectedItem.ToString();
            string[] Field_Data = VisitorData.Split(' ');
            Visitor_ID = int.Parse(Field_Data[0]);

            // Creating instance of SqlConnection
            SqlConnection conn = new SqlConnection(connString);

            // set the sql command ( Statement )
            string sql_Query = "select Visitor.Visitor_ID, Visitor.FirstName, Visitor.Surname, Visitor.Mobile, Visitor.Email, Visitor.Meeting_date, Visitor.Meeting_aim, Visitor.Meeting_time, Staff.Meeting_with , Staff.Staff_ID From Visitor, Staff Where Visitor.Staff_ID = Staff.Staff_ID AND Visitor_ID = " + Visitor_ID;

            SqlCommand cmd = new SqlCommand(sql_Query, conn);

            //Open connection
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                
                TB_Visitor_ID.Text = reader["Visitor_ID"].ToString();
                name_tb.Text = reader["FirstName"].ToString();
                surname_tb.Text = reader["Surname"].ToString();
                mobile_tb.Text = reader["Mobile"].ToString();
                email_tb.Text = reader["Email"].ToString();
                meetingdate.Text = reader["Meeting_date"].ToString();
                metting_aim.Text = reader["Meeting_aim"].ToString();
                meetingtime = reader["Meeting_time"].ToString();
                meeting_with.Text = reader["Meeting_with"].ToString();
                TB_Staff_ID.Text = reader["Staff_ID"].ToString();
            }

            //Close Database reader
            reader.Close();

            //Close connection
            conn.Close();

        }
        private void DeleteData_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(connString);

            string sql_Query = "Delete from Visitor where Visitor_ID = " + TB_Visitor_ID.Text;
       
            SqlCommand cmd5 = new SqlCommand(sql_Query, conn);

            conn.Open();

            cmd5.ExecuteNonQuery();

            MessageBox.Show("Record Deleted"); 
            
            conn.Close();

            ListBox_Data_Load(); 
        }
        private void UpdateData_Click(object sender, EventArgs e)
        {

            int hr = Convert.ToInt32(nu_hour.Value);
            int mins = Convert.ToInt32(nu_min.Value);
            DateTime dt = DateTime.Today.AddHours(hr).AddMinutes(mins);
            string meetingtime = (dt.ToString("hh:mm"));

            SqlConnection conn = new SqlConnection(connString);

            
            string sql_Query4 = "Update Visitor set FirstName = '" + name_tb.Text + "', Surname = '" + surname_tb.Text + "', Mobile ='" + mobile_tb.Text + "', Email ='" + email_tb.Text + "', Meeting_date ='" + meetingdate.Text + "', Meeting_time = '" + meetingtime + "', Staff_ID =" + TB_Staff_ID.Text  + "Where Visitor_ID =" + TB_Visitor_ID.Text;

            MessageBox.Show(sql_Query4);
           
            SqlCommand cmd5 = new SqlCommand(sql_Query4, conn);

            
            conn.Open();

            cmd5.ExecuteNonQuery();

            MessageBox.Show("Record Updated"); 
            
            conn.Close();

            ListBox_Data_Load(); 

        }

        private void meetaim_btn_Click(object sender, EventArgs e)
        {

            MeetingAim aim = new MeetingAim();
            aim.Show();
        }

        private void label_colon_Click(object sender, EventArgs e)
        {

        }

        private void signIn_btn_Click(object sender, EventArgs e)
        {

            //Varibles

            string fname = name_tb.Text;
            string lname = surname_tb.Text;
            decimal hour = nu_hour.Value;
            decimal min = nu_min.Value;
            string timeHour = hour.ToString();
            string timeMin = min.ToString();
            string with = meetwith.Text;
            string aim = meetaim_btn.Text;


            //validation of mobilenumber

            if (mobile_tb.TextLength == 10)
            {
                MessageBox.Show("Contact number is validated");

            }
            else
            {
                MessageBox.Show("Contact number must contain 10 charecters");
                mobile_tb.Focus();
            }


            // mandatory fields 

            if (name_tb.Text == "")
            {
                name_tb.Focus();
                MessageBox.Show("Please fill in the maditory fields");

            }
            else if (surname_tb.Text == "")
            {
                surname_tb.Focus();
                MessageBox.Show("Please fill in the maditory fields");
            }
            else if (mobile_tb.Text.Length < 10)
            {
                MessageBox.Show("Please fill in the manditory fields.");
                mobile_tb.Focus();
            }
            else if (mobile_tb.Text.Length > 10)
            {
                MessageBox.Show("Please fill in the manditory fields.");
                mobile_tb.Focus();
            }
            else if (email_tb.Text == "")
            {
                email_tb.Focus();
                MessageBox.Show("Please fill in the maditory fields");

            }
            else if (meetingdate.Text == " ")
            {
                meetingdate.Focus();
                MessageBox.Show("Please fill in the maditory fields");
            }
            else if (nu_hour.Value == 0)
            {
                nu_hour.Focus();
                MessageBox.Show("Please fill in the maditory fields");
            }
            else if (nu_min.Text == "")
            {
                nu_min.Focus();
                MessageBox.Show("Please fill in the maditory fields");
            }
            else if (meetwith.Text == "")
            {
                meeting_with.Focus();
                MessageBox.Show("Please fill in the maditory field meeting with.");
            }

            // print meetinginfo to listbox 

            else
            {
                int hr = Convert.ToInt32(nu_hour.Value);
                int mins = Convert.ToInt32(nu_min.Value);
                DateTime dt = DateTime.Today.AddHours(hr).AddMinutes(mins);
                string meetingtime = (dt.ToString("hh:mm tt"));

                information_lb.Items.Add($"Meeting of: {fname} {lname}"); // text box
                information_lb.Items.Add($"Meeting at: {meetingtime}"); // numricupdown
                information_lb.Items.Add("Meeting with: " + with); // combobox
                information_lb.Items.Add("Meeting Aim: " + aim); // button 
                information_lb.Items.Add("----------------------------------------------------------");

                clear(); //clear method
            }


            // validation of mobilenumber 

            //if (mobile_tb.TextLength == 10)
            //{
            //    MessageBox.Show("Contact number is validated");

            //}
            //else
            //{
            //    MessageBox.Show("Contact number must contain 10 charecters");
            //}



        }
        void clear()
        {
            name_tb.Clear();
            surname_tb.Clear();
            email_tb.Clear();
            mobile_tb.Clear();
            nu_hour.ResetText();
            nu_min.ResetText();
            meetwith.ResetText();
            meetaim_btn.Text = "Meeting Aim";
            name_tb.Focus();
        }
        private void meetwith_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void mobile_tb_kp(object sender, KeyPressEventArgs e)
        {
            // so you cant enter letter in mobile number field  

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error moblie number must only contain numbers. No Letters!");

            }
        }

        private void mobile_tb_TextChanged(object sender, EventArgs e)
        {
            // change text color to red if u havent enterd 10 char's and black when you have 

            if (mobile_tb.TextLength == 10)
            {
                mobile_tb.ForeColor = Color.Black;
            }
            else
            {
                mobile_tb.ForeColor = Color.Red;
            }
        }

        private void nu_min_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Staff_ID_Function(object sender, EventArgs e)
        {
            // Creating instance of SqlConnection
            SqlConnection conn = new SqlConnection(connString);

            // set the sql command ( Statement )
            string Staff_ID_Query = "Select Staff_ID from Staff where Meeting_with ='" + meetwith.SelectedItem.ToString() + "'";

            // Creating instance of SqlCommand  and set the connection and query to instance of SqlCommand
            SqlCommand cmd3 = new SqlCommand(Staff_ID_Query, conn);

            //Open connection
            conn.Open();

            // Creating instance of SqlDataReader
            SqlDataReader reader = cmd3.ExecuteReader();
            while (reader.Read())
            {
                //populate data in TextBox from Reader
                TB_Staff_ID.Text = reader["Staff_ID"].ToString();
            }

            //Close connection
            conn.Close();

        }

        private void Visitor_mobile_Click(object sender, EventArgs e)
        {

        }

        private void information_lb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
