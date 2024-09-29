using CarEvent.Classes;
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

namespace CarEvent.UserControls
{
    public partial class BookEvent : UserControl
    {
        DatabaseHelper baseHelper;
        DataAddHelper addHelper;
        private string LogInUser;
        public BookEvent(string username)
        {
            baseHelper = new DatabaseHelper();
            addHelper = new DataAddHelper();
            this.LogInUser = username;
            InitializeComponent();
        }
        private void LoadTables()
        {
            dataGridViewEvents.DataSource = baseHelper.LoadEventsToTable();
            dataGridViewEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BookEvent_Load(object sender, EventArgs e)
        {
            LoadTables();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                object eventID = dataGridViewEvents.Rows[e.RowIndex].Cells["EventID"].Value;

                textBoxID.Text = eventID?.ToString();
            }
        }
        private decimal CalculateCost(string EventID, int Participants)
        {
            decimal cost = 0;

            try
            {
                decimal ticketPrice = baseHelper.GetTicketPrice(EventID);

                cost = ticketPrice * Participants;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to calculate total cost: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return cost;
        }
        private void book_Click(object sender, EventArgs e)
        {
            string eventID = textBoxID.Text;
            int participants;
            if (!int.TryParse(textBoxParticipants.Text, out participants))
            {
                MessageBox.Show("Invalid Participants. Please Enter Numerical Whole Values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Participant participant = baseHelper.Participants.Find(p => p._username == LogInUser);

                if (eventID == "")
                {
                    MessageBox.Show("Enter a Event ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!baseHelper.CheckEvent(eventID))
                {
                    MessageBox.Show("Invalid ID. Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    decimal total = CalculateCost(eventID, participants);

                    Events evt = baseHelper.LoadEvents().Find(ev => ev.EventID == eventID);

                    if (evt != null)
                    {
                        Bookings bookedEvent = new Bookings(eventID, participant.ParticipantID, participants, total);
                        baseHelper.Bookings.Add(bookedEvent);
                        addHelper.AddBookedEventToDatabase(bookedEvent);

                        // Display Event Name, Event Date, and Location in the MessageBox
                        MessageBox.Show($"Thank you for your Booking \n" +
                            $"EventID: {eventID}\n" +
                            $"Event Name: {evt.EventName}\n" +
                            $"Event Date: {evt.EventDate.ToShortDateString()}\n" +
                            $"Location: {evt.Location}\n" +
                            $"No. Of Participants: {participants}\n" +
                            $"Total: {total}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Event not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
