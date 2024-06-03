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

namespace Blood_Bank
{
    public partial class DeleteDonor : Form
    {
        public DeleteDonor()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
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

            if (dr.Read())
            {
                //Bind data with controls
                /*Bind with textbox
               this.txtbxid.Text = dr.GetValue(0).ToString();*/
                this.txtbxname.Text = dr.GetValue(1).ToString();
                this.txtbxfthr.Text = dr.GetValue(2).ToString();
                this.txtmthr.Text = dr.GetValue(3).ToString();
                //this.dateofbirth.Text = dr.GetValue(3).ToString();
                this.txtbxmobile.Text = dr.GetValue(4).ToString();
                this.combogender.Text = dr.GetValue(5).ToString();
                this.txtbxemail.Text = dr.GetValue(6).ToString();
                this.comboblood.Text = dr.GetValue(7).ToString();
                this.txtbxcity.Text = dr.GetValue(8).ToString();
                this.txtbxaddress.Text = dr.GetValue(9).ToString();
            }
            else
            {
                MessageBox.Show("No records found.", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Disconnect from server
            con.Close();
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

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            //creat a connection with MS SQL Server
            string cs = "Data Source=LAPTOP-UL0VVV27;Initial Catalog=BloodBank;Integrated Security=True;";
            SqlConnection con = new SqlConnection(cs);
            con.Open();


            //sql command
            string sql = "DELETE FROM tbladddonor WHERE did =@did ";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@did", this.txtbxid.Text);


            //execute query function
            string mret = MessageBox.Show("Are you  sure you want to delete this record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Information).ToString();
            if (mret == "Yes")
            {



                //execute query function
                int ret = com.ExecuteNonQuery();
                MessageBox.Show("No of records deleted " + ret, "information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }
            //disconect from server
            con.Close();
        }

        private void DeleteDonor_Load(object sender, EventArgs e)
        {

        }
    }
}
