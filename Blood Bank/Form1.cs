using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnHideShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           if (btnHideShow.Text == "Show")
            {
                btnHideShow.Text = "Hide";
                txtpswrd.PasswordChar = '\0';
            }
            else
            {
                btnHideShow.Text = "Show";
                txtpswrd.PasswordChar = '*';
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                btnlogin.Enabled = true;
            }
            else { btnlogin.Enabled = false; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnlogin.Enabled = false;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "donate" && txtpswrd.Text == "abc")
            {
                Dashbord db = new Dashbord();
                db.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter valid Username OR Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
