using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_Rent_and_Booking_System.Models;

namespace Vehicle_Rent_and_Booking_System
{
    public partial class Form2 : Form
    {
        private int totalVehicles = 0;
        private int availableVehicles = 0;
        private int rentedVehicles = 0;

        private List<Vehicles> vehicleList = new List<Vehicles>();
        public Form2()
        {
            InitializeComponent();
            load_vehicles_from_db();
        }

        public void load_vehicles_from_db()
        {
            totalVehicles = 0;
            availableVehicles = 0;
            rentedVehicles = 0;

            using var connection = Database.Database.GetConnection();
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = "SELECT PlateNumber, Model, Type, Seats, Price, Status FROM Vehicles;";

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var vehicle = new Vehicles
                {
                    PlateNumber = reader.GetInt32(0),
                    Model = reader.GetString(1),
                    Type = reader.GetString(2),
                    Seats = reader.GetInt32(3),
                    Price = reader.GetDouble(4),
                    Status = reader.GetString(5)
                };

                vehicleList.Add(vehicle);


                if (string.Equals(vehicle.Status, "Available", StringComparison.OrdinalIgnoreCase))
                {
                    availableVehicles++;
                }
                else if (string.Equals(vehicle.Status, "Rented", StringComparison.OrdinalIgnoreCase))
                {
                    rentedVehicles++;
                }
            }

            totalVehicles = vehicleList.Count;


            textBoxTotalVehicles.Text = totalVehicles.ToString();
            textBoxAvailability.Text = availableVehicles.ToString();
            textBoxRented.Text = rentedVehicles.ToString();
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


        private void fleetbtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void rentalrecordbtn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
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

        private void fleetbtn_Click_1(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void rentalrecordbtn_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void rentbtn_Click_1(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void penaltycomputationbtn_Click_1(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {

        }
    }
}


