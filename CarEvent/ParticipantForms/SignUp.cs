using CarEvent.Database_Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarEvent.ParticipantForms
{
    public partial class SignUp : Form
    {
        DatabaseHelper databaseHelper;
        DataAddHelper dataAddHelper;
        public SignUp()
        {
            databaseHelper = new DatabaseHelper();
            dataAddHelper = new DataAddHelper();
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void signUpbtn_Click(object sender, EventArgs e)
        {
            string ID = databaseHelper.GenerateCustomerID();
            string name = textBoxName.Text;
            string username = textBoxUsername.Text;
            string password = textBoxPass.Text;
            string email = textBoxEmail.Text;
            string address = textBoxAddress.Text;
            int contact;
            if (!int.TryParse(textBoxContact.Text, out contact))
            {
                MessageBox.Show("Invalid Contact. Please Enter Numerical Values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (name == "" || username == "" || password == "" || email == "" || address == "")
            {
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool success = dataAddHelper.AddUser(ID, name, username, password, email, address, contact);
                if (success)
                {
                    MessageBox.Show("Registration Successful. Please use the Username and Password to Login", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Occured. Registration Failed. Please try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
