using CarEvent.AdminForms;
using CarEvent.Classes;
using CarEvent.ParticipantForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPass.UseSystemPasswordChar =!checkBoxPass.Checked;
        }

        private void InitiateComboBox()
        {
            comboBoxUser.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUser.Items.Add("Admin");
            comboBoxUser.Items.Add("Participant");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitiateComboBox();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string userType = comboBoxUser.SelectedItem.ToString();
            string username = textBoxUser.Text;
            string password = textBoxPass.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Enter Both Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(userType == "Admin")
                {
                    Admin admin = new Admin();
                    bool isValid = admin.ValidateLogin(username, password);

                    if(isValid)
                    {
                        AdminDashboard adminDashboard = new AdminDashboard();
                        adminDashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials. Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if(userType == "Participant")
                {
                    Participant participant = new Participant();
                    bool isValid = participant.ValidateLogin(username, password);
                    if(isValid)
                    {
                        UserDashboard userDashboard = new UserDashboard(username);
                        userDashboard.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials. Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {

                    MessageBox.Show("Invalid UserType. Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }
    }
}
