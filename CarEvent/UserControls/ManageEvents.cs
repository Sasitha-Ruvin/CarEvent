using CarEvent.AdminForms;
using CarEvent.Database_Helpers;
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

namespace CarEvent.UserControls
{
    public partial class ManageEvents : UserControl
    {
        DatabaseHelper dbHelper;
        DataRemoveHelper removeHelper;
        public ManageEvents()
        {


            InitializeComponent();
            dbHelper = new DatabaseHelper();
            removeHelper = new DataRemoveHelper();

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddEvents addEvents = new AddEvents();
            addEvents.ShowDialog();
            dataGridViewEvents.Refresh();
        }
        private void LoadTables()
        {
            dataGridViewEvents.DataSource = dbHelper.LoadEvents();
            dataGridViewEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dataGridViewEvents.Columns["Image"] != null)
            {
                dataGridViewEvents.Columns["Image"].Visible = false;
            }

        }

        private void removeEvent_Click(object sender, EventArgs e)
        {
            string removeId = removeEvent.Text;

            if (removeId == "")
            {
                MessageBox.Show("Enter an ID to Remove. Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!dbHelper.CheckEvent(removeId))
            {
                MessageBox.Show("Invalid ID. Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool isRemoved = removeHelper.RemoveEventFromDB(removeId);
                if (isRemoved)
                {
                    MessageBox.Show("Event Removed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewEvents.DataSource = null;
                    dataGridViewEvents.DataSource = dbHelper.LoadEventsToTable();
                    dataGridViewEvents.Refresh();
                }
                else
                {
                    MessageBox.Show("Failed to Remove Event", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            string eventID = removeEvent.Text;

            if(eventID == "")
            {
                MessageBox.Show("Enter an Event ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateForm updateForm = new UpdateForm(eventID);
            updateForm.Show();
            dataGridViewEvents.Refresh();
        }

        private void ManageEvents_Load(object sender, EventArgs e)
        {
            LoadTables();
        }

        private void dataGridViewEvents_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the Event ID of the clicked row
                string eventID = dataGridViewEvents.Rows[e.RowIndex].Cells["EventID"].Value.ToString();

                // Open the EventDetails form, passing the event ID
                UpdateForm eventDetail = new UpdateForm(eventID);
                eventDetail.Show();
                LoadTables();
                dataGridViewEvents.Refresh();

            }
        }
    }
}
