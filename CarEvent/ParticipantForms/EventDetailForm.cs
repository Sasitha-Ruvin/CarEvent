using CarEvent.Classes;
using CarEvent.Database_Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarEvent.ParticipantForms
{
    public partial class EventDetailForm : Form
    {
        DatabaseHelper databaseHelper;
        private string eventID;
        private byte[] eventImage;
        public EventDetailForm(string selectedEvent)
        {
            InitializeComponent();
            EnableEditing(false);
            databaseHelper = new DatabaseHelper();
            eventID = selectedEvent;
            LoadDetails();
        }

        private void EnableEditing(bool enable)
        {
            textBoxName.ReadOnly = !enable;
            textBoxLocation.ReadOnly = !enable;
            descBox.ReadOnly = !enable;
            eventDate.Enabled = enable;
       
        }
        private void LoadDetails()
        {
            Events evt = databaseHelper.Event.Find(e => e.EventID == eventID);
            if (evt != null)
            {
                textBoxID.Text = evt.EventID;
                textBoxName.Text = evt.EventName;
                textBoxLocation.Text = evt.Location;
                eventDate.Value = evt.EventDate;
                descBox.Text = evt.Description;

                if (evt.Image != null)
                {
                    eventImage = evt.Image;
                    using (MemoryStream ms = new MemoryStream(eventImage))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
            }
            EnableEditing(false);


        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
