﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvent.Classes
{
    public class Participant:Person
    {
        public string ParticipantID { get; set; }

        private string username { get; set; }

        private string password { get; set; }
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public string _username
        {
            get { return username; }
            set { username = value; }
        }

        public string _password
        {
            get { return password; }
            set { password = value; }
        }
        public Participant() : base("", "", "", 0)
        {
        }


        public Participant(string id, string name, string username, string password, string address, string email, int contact) : base(name, address, email, contact)
        {
            ParticipantID = id;
            _username = username;
            _password = password;
        }

        public override bool ValidateLogin(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Participants WHERE Username COLLATE SQL_Latin1_General_CP1_CS_AS = @Username AND Password COLLATE SQL_Latin1_General_CP1_CS_AS = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            return reader.Read();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
