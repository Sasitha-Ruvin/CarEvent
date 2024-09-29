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

namespace CarEvent.ParticipantForms
{
    public partial class UserDashboard : Form
    {
        DatabaseHelper databaseHelper;
        private string LogInUser;
        public UserDashboard(string username)
        {
            this.LogInUser = username;
            databaseHelper = new DatabaseHelper();
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LoadTables()
        {
            dataGridView1.DataSource = databaseHelper.LoadEventsToTable();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            LoadTables();
        }
        private void LoadUserControl(UserControl userControl)
        {
            var panelContainer = this.Controls.Find("panelContainer", true).FirstOrDefault() as Panel;
            if (panelContainer != null)
            {
                panelContainer.Controls.Clear();
                userControl.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(userControl);
            }
        }
        private void userMng_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserBookings(LogInUser));
        }

        private void eventMngBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new BookEvent(LogInUser));  
        }

        private void bookinhBng_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the Event ID of the clicked row
                string eventID = dataGridView1.Rows[e.RowIndex].Cells["EventID"].Value.ToString();

                // Open the EventDetails form, passing the event ID
                EventDetailForm eventDetail = new EventDetailForm(eventID);
                eventDetail.Show();
                LoadTables();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the Event ID of the clicked row
                string eventID = dataGridView1.Rows[e.RowIndex].Cells["EventID"].Value.ToString();

                // Open the EventDetails form, passing the event ID
                EventDetailForm eventDetail = new EventDetailForm(eventID);
                eventDetail.Show();
                LoadTables();
            }

        }
    }
}
