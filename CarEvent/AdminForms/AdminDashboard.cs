using CarEvent.Database_Helpers;
using CarEvent.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarEvent.AdminForms
{
    public partial class AdminDashboard : Form
    {
        DatabaseHelper databaseHelper;
        public AdminDashboard()
        {
            databaseHelper = new DatabaseHelper();
            InitializeComponent();
        }

        private void eventMngBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ManageEvents());
        }

        private void LoadUserControl(UserControl userControl)
        {
            var panelContainer = this.Controls.Find("panelContainer", true).FirstOrDefault() as Panel;
            if(panelContainer != null)
            {
                panelContainer.Controls.Clear();
                userControl.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(userControl);
            }
        }


        private void userMng_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ManageUsers());
        }

        private void bookinhBng_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ViewBookings());
        }
        private void LoadTables()
        {
            dataGridViewEvents.DataSource = databaseHelper.LoadEventsToTable();
            dataGridViewBookings.DataSource = databaseHelper.LoadBookingsToTable();
            dataGridViewEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBookings.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadTables();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
