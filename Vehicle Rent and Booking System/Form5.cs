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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            LoadVehiclesToComboBox();

            // Wire up events so calculations update automatically
            pickupdatepicker.ValueChanged += DatePickers_ValueChanged;
            returndatepicker.ValueChanged += DatePickers_ValueChanged;
            vehiclecbox.SelectedIndexChanged += Vehiclecbox_SelectedIndexChanged;

            // Initial calculation on load
            UpdateRentalSummary();
        }

        private void DatePickers_ValueChanged(object sender, EventArgs e)
        {
            UpdateRentalSummary();
        }

        private void Vehiclecbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateRentalSummary();
        }

        private void LoadVehiclesToComboBox()
        {
            try
            {
                var vehicleList = new List<object>();

                using var connection = Database.Database.GetConnection();
                connection.Open();

                using var command = connection.CreateCommand();
                // Only load vehicles that are 'Available'
                command.CommandText = "SELECT PlateNumber, Model FROM Vehicles WHERE Status = 'Available';";

                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int plateNumber = reader.GetInt32(0);
                    string model = reader.GetString(1);

                    vehicleList.Add(new
                    {
                        PlateNumber = plateNumber,
                        Display = $"{plateNumber} - {model}"
                    });
                }

                vehiclecbox.DataSource = vehicleList;
                vehiclecbox.DisplayMember = "Display";
                vehiclecbox.ValueMember = "PlateNumber";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading vehicles: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal GetSelectedVehicleDailyRate()
        {
            if (vehiclecbox.SelectedValue == null) return 0;

            if (int.TryParse(vehiclecbox.SelectedValue.ToString(), out int vehicleNo))
            {
                try
                {
                    using var connection = Database.Database.GetConnection();
                    connection.Open();

                    using var command = connection.CreateCommand();
                    command.CommandText = "SELECT Price FROM Vehicles WHERE PlateNumber = @vehicleNo;";
                    command.Parameters.AddWithValue("@vehicleNo", vehicleNo);

                    object result = command.ExecuteScalar();
                    if (result != null && decimal.TryParse(result.ToString(), out decimal price))
                    {
                        return price;
                    }
                }
                catch (Exception)
                {
                    // Handle or ignore silently during text updates
                }
            }
            return 0;
        }

        private void UpdateRentalSummary()
        {
            // 1. Calculate duration days
            DateTime pickupDateVal = pickupdatepicker.Value.Date;
            DateTime returnDateVal = returndatepicker.Value.Date;
            TimeSpan difference = returnDateVal - pickupDateVal;
            int days = difference.Days;

            if (days < 0) days = 0;
            duration.Text = days.ToString();

            // 2. Get daily rate from vehicles table
            decimal dailyRate = GetSelectedVehicleDailyRate();
            dailyrate.Text = dailyRate.ToString("F2");

            // 3. Display computation string (e.g., "4 x 1500.00")
            computation.Text = $"{days} x {dailyRate:F2}";

            // 4. Calculate total and display
            decimal totalPayment = days * dailyRate;
            total.Text = totalPayment.ToString("F2");
        }

        private void fleetbtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void rentalrecordbtn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void penaltycomputationbtn_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void signbtn_Click_1(object sender, EventArgs e)
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

        private void btn_Click(object sender, EventArgs e)
        {
            if (vehiclecbox.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid vehicle from the dropdown.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string pickupBranch = pickupbranch.Text;
            string pickupDateStr = pickupdatepicker.Value.ToString("yyyy-MM-dd");
            string returnDateStr = returndatepicker.Value.ToString("yyyy-MM-dd");

            if (int.TryParse(vehiclecbox.SelectedValue.ToString(), out int vehicleNo))
            {
                if (!decimal.TryParse(total.Text, out decimal totalPayment) || totalPayment <= 0)
                {
                    MessageBox.Show("Please ensure the rental duration and total payment are valid.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    using var connection = Database.Database.GetConnection();
                    connection.Open();

                    // Use a transaction to ensure both inserting the rental and updating the vehicle status succeed together
                    using var transaction = connection.BeginTransaction();

                    try
                    {
                        // 1. Insert record into Rentals table
                        using var insertCommand = connection.CreateCommand();
                        insertCommand.Transaction = transaction;
                        insertCommand.CommandText = @"
                            INSERT INTO Rentals (vehicle_no, pickupBranch, pickupDate, returnDate, totalPayment) 
                            VALUES (@vehicleNo, @pickupBranch, @pickupDate, @returnDate, @totalPayment);
                        ";

                        insertCommand.Parameters.AddWithValue("@vehicleNo", vehicleNo);
                        insertCommand.Parameters.AddWithValue("@pickupBranch", pickupBranch);
                        insertCommand.Parameters.AddWithValue("@pickupDate", pickupDateStr);
                        insertCommand.Parameters.AddWithValue("@returnDate", returnDateStr);
                        insertCommand.Parameters.AddWithValue("@totalPayment", totalPayment);

                        insertCommand.ExecuteNonQuery();

                        // 2. Update the vehicle's status to 'Rented' so it can't be chosen again
                        using var updateCommand = connection.CreateCommand();
                        updateCommand.Transaction = transaction;
                        updateCommand.CommandText = "UPDATE Vehicles SET Status = 'Rented' WHERE PlateNumber = @vehicleNo;";
                        updateCommand.Parameters.AddWithValue("@vehicleNo", vehicleNo);

                        updateCommand.ExecuteNonQuery();

                        // Commit transaction
                        transaction.Commit();

                        MessageBox.Show($"Rental successfully recorded!\nTotal Payment: ₱{totalPayment:N2}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh the combo box to filter out the newly rented vehicle
                        LoadVehiclesToComboBox();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving rental record: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid vehicle plate number format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void duration_TextChanged(object sender, EventArgs e)
        {
            UpdateRentalSummary();
        }
    }
}