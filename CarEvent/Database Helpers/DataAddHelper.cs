﻿using CarEvent.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarEvent.Database_Helpers
{
    public class DataAddHelper
    {
        //Connection String
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public bool AddUser(string ID, string name, string username, string password, string email, string address, int contact)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Participants (ParticipantID, Username, Password, Name, Address, Email, Contact)" +
                        "VALUES (@ID, @Username, @Password, @Name, @Address, @Email, @Contact)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", ID);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@Contact", contact);

                        if (databaseHelper.CheckUsernameExistance(username))
                        {
                            MessageBox.Show("Username is already taken. Please Choose another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        else
                        {
                            int result = command.ExecuteNonQuery();
                            return result > 0;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool AddEvent(string ID, string Name, string location, DateTime date, string description, byte[] image, decimal ticket)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Event(EventID, EventName, Description, EventDate, Location, Image, TicketPrice)" +
                        "VALUES (@ID, @Name, @Desc, @Date, @Location, @Image, @Ticket)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", ID);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@Desc", description);
                        command.Parameters.AddWithValue("@Location", location);
                        command.Parameters.AddWithValue("@Date", date);
                        command.Parameters.AddWithValue("@Image", image);
                        command.Parameters.AddWithValue("@Ticket", ticket);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Method to update event details in the database
        public bool UpdateEvent(string eventID, string eventName, string location, DateTime eventDate, string description, byte[] eventImage, decimal ticket)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Event SET EventName = @EventName, Location = @Location, EventDate = @EventDate, Description = @Description, Image = @Image, TicketPrice = @Ticket WHERE EventID = @EventID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EventID", eventID);
                        command.Parameters.AddWithValue("@EventName", eventName);
                        command.Parameters.AddWithValue("@Location", location);
                        command.Parameters.AddWithValue("@EventDate", eventDate);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@Image", eventImage);
                        command.Parameters.AddWithValue("@Ticket", ticket);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update event: " + ex.Message, "Update Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool AddBookedEventToDatabase(Bookings bookings)
        {
            string query = "INSERT INTO Bookings (EventID, ParticipantID, Participants, Total)" +
                           "VALUES (@EventID, @ParticipantID, @NoOfParticipants, @Total)";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        // Set the parameters from the BookedEvent object
                        command.Parameters.AddWithValue("@EventID", bookings.EventID); // Assuming EventID is an Event object
                        command.Parameters.AddWithValue("@ParticipantID", bookings.ParticipantID);
                        command.Parameters.AddWithValue("@NoOfParticipants", bookings.NoOfParticipants);
                        command.Parameters.AddWithValue("@Total", bookings.Total);

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
