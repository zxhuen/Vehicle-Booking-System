using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using Vehicle_Rent_and_Booking_System.Database;

namespace Vehicle_Rent_and_Booking_System
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            LoadRentalRecords();
        }

        private void LoadRentalRecords()
        {
            try
            {
                using var connection = Database.Database.GetConnection();
                connection.Open();

                string query = @"
            SELECT 
                r.id AS [ID],
                r.vehicle_no AS [Vehicle No],
                v.Model AS [Vehicle Model],
                r.pickupBranch AS [Pickup Branch],
                r.pickupDate AS [Pickup Date],
                r.returnDate AS [Return Date],
                r.totalPayment AS [Total Payment]
            FROM Rentals r
            INNER JOIN Vehicles v ON r.vehicle_no = v.PlateNumber;
        ";

                using var command = connection.CreateCommand();
                command.CommandText = query;

                using var reader = command.ExecuteReader();
                var dataTable = new DataTable();
                dataTable.Load(reader);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rental records: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
     
        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void fleetbtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void rentbtn_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void penaltycomputationbtn_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void signbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to sign out?",
               "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}