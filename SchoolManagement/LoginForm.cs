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
using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SchoolManagement
{
    public partial class LoginForm : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\unico\\OneDrive\\Documents\\SchoolManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand command = new SqlCommand();
        SqlDataReader mdr;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            text_password.UseSystemPasswordChar = true;
        }


        // LOGIN to program
        private void button_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text_username.Text) || string.IsNullOrEmpty(text_password.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }

            else
            {
                connection.Open();
                string selectQuery = "SELECT * FROM Login WHERE username = '" + text_username.Text + "' AND password = '" + text_password.Text + "';";
                command = new SqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {


                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    management_page frm2 = new management_page();
                    frm2.ShowDialog();

                }
                else
                {

                    MessageBox.Show("Incorrect Login Information! Try again.");
                }

                connection.Close();
            }
        }


        // LOAD register page
        private void create_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterPage frm3 = new RegisterPage();
            frm3.ShowDialog();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            text_username.Text = "";
            text_password.Text = "";
        }

        private void btn_show_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_show.Checked)
            {
                text_password.UseSystemPasswordChar = false;
            }
            else
            {
                text_password.UseSystemPasswordChar = true;
            }
        }
    }
}
