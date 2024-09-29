using CarEvent.Classes;
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
    public partial class UserBookings : UserControl
    {
        DatabaseHelper dbHelper;
        DataAddHelper dataAddHelper;
        DataRemoveHelper dataRemove;
        private string LogInUser;
        public UserBookings(string username)
        {
            dbHelper = new DatabaseHelper();
            dataAddHelper = new DataAddHelper();
            this.LogInUser = username;
            dataRemove = new DataRemoveHelper();
            InitializeComponent();
        }
       

        private void UserBookings_Load(object sender, EventArgs e)
        {

            Participant participant = dbHelper.Participants.Find(p => p._username == LogInUser);
            if (participant != null)
            {
                List<Bookings> bookedEvents = dbHelper.GetBookings(participant.ParticipantID);
                dataGridViewBookings.DataSource = bookedEvents;
                dataGridViewBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int removeID;
            if (!int.TryParse(removeText.Text, out removeID))
            {
                MessageBox.Show("Invalid Booking ID. Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool isRemoved = dataRemove.RemoveBookingFromDB(removeID);
                if (isRemoved)
                {
                    MessageBox.Show("Booking Cancelled", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewBookings.Refresh();
                }
                else
                {
                    MessageBox.Show("Failed to Remove Booking", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
