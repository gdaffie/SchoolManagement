using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class RegisterPage : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\unico\\OneDrive\\Documents\\SchoolManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand command = new SqlCommand();
        SqlDataReader mdr;
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {
            text_password.UseSystemPasswordChar = true;
            text_confirm_password.UseSystemPasswordChar = true;
        }

        // REGISTER new account
        private void btn_register_Click(object sender, EventArgs e)
        {
            connection.Open();

            if (string.IsNullOrEmpty(text_username.Text) || string.IsNullOrEmpty(text_password.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
                connection.Close();
            }

            else if (text_password.Text != text_confirm_password.Text)
            {
                MessageBox.Show("Please enter matching passwords!");
                text_username.Text = " ";
                text_password.Text = " ";
                text_confirm_password.Text = " ";
                connection.Close();
            }

            else
            {

                string selectQuery = "SELECT * FROM Login WHERE username = @username";

                command = new SqlCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@username", text_username.Text);
                command.Parameters.AddWithValue("@password", text_password.Text);
                mdr = command.ExecuteReader();

                if (mdr.Read())
                {
                    MessageBox.Show("Username not available!");

                    connection.Close();
                }
                else
                {
                    try
                    {
                        mdr.Close();
                        SqlCommand cmd = new SqlCommand("INSERT INTO Login values (@username,@password) ", connection);



                        cmd.Parameters.AddWithValue("@username", text_username.Text);
                        cmd.Parameters.AddWithValue("@password", text_password.Text);
                        cmd.ExecuteNonQuery();


                        MessageBox.Show("Account Successfully Created!");








                    }
                    catch (Exception ex)
                    {
                        // Show any error message.
                        MessageBox.Show(ex.Message);
                    }

                    connection.Close();
                }

            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            text_username.Text = string.Empty;
            text_password.Text = string.Empty;
            text_confirm_password.Text = string.Empty;
        }

        private void back_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm frm3 = new LoginForm();
            frm3.ShowDialog();
        }

        private void show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_show.Checked)
            {
                text_password.UseSystemPasswordChar = false;
                text_confirm_password.UseSystemPasswordChar = false;
            }
            else
            {
                text_password.UseSystemPasswordChar = true;
                text_confirm_password.UseSystemPasswordChar = true;
            }
        }
    }
}
