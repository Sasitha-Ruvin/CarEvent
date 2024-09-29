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
    public partial class ViewBookings : UserControl
    {
        DatabaseHelper databaseHelper;
        public ViewBookings()
        {
            databaseHelper = new DatabaseHelper();
            InitializeComponent();
        }

        private void LoadTables()
        {
            dataGridView1.DataSource = databaseHelper.LoadBookingsToTable();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ViewBookings_Load(object sender, EventArgs e)
        {
            LoadTables();
        }
    }
}
