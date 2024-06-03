using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Blood_Bank
{
    public partial class UpdateDonorDetails : Form
    {
        DataSet ds;
        int i = 0;

        public UpdateDonorDetails()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                /*String sql = "UPDATE DonorDetails SET name='" + txtName.Text + "',fname='" + txtFather.Text + "',mname='" + txtMother.Text + "',dob='" + dateTimePicker1.Text + "',mobile='" + txtMobile.Text + "'," +
                    "" + "gender='" + txtGender.Text + "',email='" + txtEmail.Text + "',bloodgroup='" + txtBloodGroup.Text + "'," +
                    "city='" + txtCity.Text + "',daddress='" + txtAddress.Text + "' WHERE did = @did";*/

                string cs = "Data Source=LAPTOP-UL0VVV27;Initial Catalog=BloodBank;Integrated Security=True;";
                SqlConnection con = new SqlConnection(cs);
                con.Open();

                string sql = "UPDATE tbladddonor SET name=@name,fname=@fname,mname=@mname,dob=@dob,mobile=@mobile,gender=@gender,email=@email,bloodgroup=@blood,city=@city,daddress=@address WHERE did=@did";
                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@did", this.txtbxid.Text);
                com.Parameters.AddWithValue("@name", this.txtbxname.Text);
                com.Parameters.AddWithValue("@fname", this.txtbxfthr.Text);
                com.Parameters.AddWithValue("@mname", this.txtmthr.Text);
                com.Parameters.AddWithValue("@dob", this.dateofbirth.Text);
                com.Parameters.AddWithValue("@mobile", this.txtbxmobile.Text);
                com.Parameters.AddWithValue("@gender", this.combogender.Text);
                com.Parameters.AddWithValue("@email", this.txtbxemail.Text);
                com.Parameters.AddWithValue("@blood", this.comboblood.Text);
                com.Parameters.AddWithValue("@city", this.txtbxcity.Text);
                com.Parameters.AddWithValue("@address", this.txtbxaddress.Text);

                int ret = com.ExecuteNonQuery();
                MessageBox.Show("No of records added: " + ret, "Information",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                con.Close();
            }
        }
        private void UpdateDonorDetails_Load(object sender, EventArgs e)
        {

        }

        private void button1(object sender, EventArgs e)
        {
        }

        private void dateofbirth_ValueChanged(object sender, EventArgs e)
        {
            /*//create a connection with MS SQL Server
          string cs = "Data Source=DESKTOP-59LVIGS\\SQLEXPRESS;Initial Catalog=Blood_Bank1;Integrated Security=True";
          SqlConnection conn = new SqlConnection(cs);
          conn.Open();


          //sql command
          string sql = "SELECT dob FROM Table_12 WHERE dob=@date";
          SqlCommand com = new SqlCommand(sql, conn);
          com.Parameters.AddWithValue("@date", this.dateTimePicker1.Text);

          //access data
          SqlDataReader dr = com.ExecuteReader();
          dr.Read();

          //Bind with textbox
          this.dateTimePicker1.Text = dr.GetValue(0).ToString();


          //Disconnect from server
          conn.Close();*/
        }

        private void txtbxid_TextChanged(object sender, EventArgs e)
        {
            if (txtbxid.Text == "")
            {
                txtbxname.Clear();
                txtbxfthr.Clear();
                txtmthr.Clear();
                dateofbirth.ResetText();
                txtbxmobile.Clear();
                combogender.ResetText();
                txtbxemail.Clear();
                comboblood.ResetText();
                txtbxcity.Clear();
                txtbxaddress.Clear();
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtbxid.Clear();
        }

        private void btnserach_Click(object sender, EventArgs e)
        {
            //Create a connection with MS SQL Server
            string cs = "Data Source=LAPTOP-UL0VVV27;Initial Catalog=BloodBank;Integrated Security=True;";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //Create a command
            string sql = "SELECT did,name,fname,mname,mobile,gender,email,bloodgroup,city,daddress FROM tbladddonor WHERE did=@did";
            

            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@did", this.txtbxid.Text);
            com.Parameters.AddWithValue("@dob", this.dateofbirth.Text);
            com.Parameters.AddWithValue("@gender", this.combogender.Text);
            com.Parameters.AddWithValue("@bloodgroup", this.comboblood.Text);



            //Access data
            SqlDataReader dr = com.ExecuteReader();
            dr.Read();

            //Bind data with controls
            /*Bind with textbox
           this.textBox2.Text = dr.GetValue(0).ToString();*/
            this.txtbxname.Text = dr.GetValue(1).ToString();
            this.txtbxfthr.Text = dr.GetValue(2).ToString();
            this.txtmthr.Text = dr.GetValue(3).ToString();
            //this.dateTimePicker1.Text = dr.GetValue(3).ToString();
            this.txtbxmobile.Text = dr.GetValue(4).ToString();
            this.combogender.Text = dr.GetValue(5).ToString();
            this.txtbxemail.Text = dr.GetValue(6).ToString();
            this.comboblood.Text = dr.GetValue(7).ToString();
            this.txtbxcity.Text = dr.GetValue(8).ToString();
            this.txtbxaddress.Text = dr.GetValue(9).ToString();
            //Disconnect from server
            con.Close();

            

        }
        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtbxname.Text) ||
                string.IsNullOrWhiteSpace(txtbxfthr.Text) ||
                string.IsNullOrWhiteSpace(txtmthr.Text) ||
                string.IsNullOrWhiteSpace(txtbxmobile.Text) ||
                string.IsNullOrWhiteSpace(combogender.Text) ||
                string.IsNullOrWhiteSpace(txtbxemail.Text) ||
                string.IsNullOrWhiteSpace(comboblood.Text) ||
                string.IsNullOrWhiteSpace(txtbxcity.Text) ||
                string.IsNullOrWhiteSpace(txtbxaddress.Text))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidEmail(txtbxemail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidMobileNumber(txtbxmobile.Text))
            {
                MessageBox.Show("Please enter a valid mobile number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidMobileNumber(string number)
        {
            return number.Length == 10 && number.All(char.IsDigit);
        }
    }
}

    
