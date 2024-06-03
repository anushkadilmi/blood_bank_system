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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Runtime.Remoting.Contexts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Reflection;

namespace Blood_Bank
{
    public partial class AddNewDonar : Form
    {
        private static int visitCounter = 0;
        public AddNewDonar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtbxid.Text != "" && txtbxname.Text != "" && txtbxfthr.Text != "" && txtmthr.Text != "" && txtbxmobile.Text != "" && combogender.Text != "" && txtbxemail.Text != "" && comboblood.Text != "" && txtbxcity.Text != "" && txtbxaddress.Text != "")
            {
                //create a connection with MS SQL Server
                string cs = "Data Source=LAPTOP-UL0VVV27;Initial Catalog=BloodBank;Integrated Security=True;";
                SqlConnection con = new SqlConnection(cs);
                con.Open();

                //sql command
                string sql = "INSERT INTO tbladddonor (did,name,fname,mname,dob,mobile,gender,email,bloodgroup,city,daddress) VALUES(@did,@name,@fname ,@mname ,@dob ,@mobile ,@gender,@email,@bloodgroup,@city,@daddress)";

                // Validate email address
                if (!IsValidEmail(txtbxemail.Text))
                {
                    MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate mobile number
                if (!IsValidMobileNumber(txtbxmobile.Text))
                {
                    MessageBox.Show("Please enter a valid mobile number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@did", this.txtbxid.Text);
                com.Parameters.AddWithValue("@name", this.txtbxname.Text);
                com.Parameters.AddWithValue("@fname", this.txtbxfthr.Text);
                com.Parameters.AddWithValue("@mname", this.txtmthr.Text);
                com.Parameters.AddWithValue("@dob", (Convert.ToDateTime(dateofbirth.Text)));
                com.Parameters.AddWithValue("@mobile", this.txtbxmobile.Text);
                com.Parameters.AddWithValue("@gender", this.combogender.Text);
                com.Parameters.AddWithValue("@email", this.txtbxemail.Text);
                com.Parameters.AddWithValue("@bloodgroup", this.comboblood.Text);
                com.Parameters.AddWithValue("@city", this.txtbxcity.Text);
                com.Parameters.AddWithValue("@daddress", this.txtbxaddress.Text);



                //Execute Query
                int ret = com.ExecuteNonQuery();
                MessageBox.Show("No of records added: " + ret, "Information",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                //Disconnect from server
                con.Close();
            }
            
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
       






        private void btnreset_Click(object sender, EventArgs e)
        {
            txtbxid.Clear();
           txtbxname.Clear();
            txtbxfthr.Clear();
            txtmthr.Clear();
            dateofbirth.ResetText();
            txtbxmobile.Clear();
            combogender.ResetText();
            txtbxemail.Clear();
            combogender.ResetText();
            txtbxcity.Clear();
            txtbxaddress.Clear();
        
    }

        private void AddNewDonar_Load(object sender, EventArgs e)
        {
            visitCounter++; //increase each time a form is loaded
            txtbxid.Text = visitCounter.ToString("000"); // format the counter
        }
    }
}

