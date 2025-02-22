﻿using CarEvent.Database_Helpers;
using CarEvent.UserControls;
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

namespace CarEvent.AdminForms
{
    public partial class AddEvents : Form
    {
        DataAddHelper addHelper;
        DatabaseHelper databaseHelper;
        public AddEvents()
        {
            InitializeComponent();
            databaseHelper = new DatabaseHelper();
            addHelper = new DataAddHelper();
            InitateDateTime();
        }

        private void InitateDateTime()
        {
            eventDate.Format = DateTimePickerFormat.Short;
            eventDate.MinDate = DateTime.Today;
        }

        private byte[] eventImage;

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ValidateInputs()
        {
            string ID = textBoxID.Text;
            string name = textBoxName.Text;
            string location = textBoxLocation.Text;
            string description = descBox.Text;
            DateTime date = eventDate.Value;
            string ticketPriceText = textBoxTicketPrice.Text;

            if (ID == "" || name == "" || description == "" || location == "")
            {
                MessageBox.Show("Please Fill all the Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (databaseHelper.CheckEvent(ID))
            {
                MessageBox.Show("ID Exists Already. Please Enter Different ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!decimal.TryParse(ticketPriceText, out decimal ticketPrice))
            {
                MessageBox.Show("Please enter a valid ticket price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (eventImage == null)
            {
                MessageBox.Show("Please upload an event image.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void addEventBtn_Click(object sender, EventArgs e)
        {
            string ID = textBoxID.Text;
            string name = textBoxName.Text;
            string location = textBoxLocation.Text;
            string description = descBox.Text;
            DateTime date = eventDate.Value;

            if (ValidateInputs())
            {
                decimal ticketPrice = decimal.Parse(textBoxTicketPrice.Text);
                bool success = addHelper.AddEvent(ID, name, location, date, description, eventImage, ticketPrice);
                if (success)
                {
                    MessageBox.Show("Event added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ManageEvents manageEvents = new ManageEvents();
                    manageEvents.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to add event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void uploadIMG_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Images Files| *.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    eventImage = File.ReadAllBytes(openFileDialog.FileName);
                }
            }
        }
    }
}
