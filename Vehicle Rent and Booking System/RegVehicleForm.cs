using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Rent_and_Booking_System
{
    public partial class RegVehicleForm : Form
    {
        private bool isEditMode = false;

        // 1. Default constructor for Registering a NEW vehicle
        public RegVehicleForm()
        {
            InitializeComponent();
            isEditMode = false;
        }

        // 2. Overloaded constructor for EDITING an existing vehicle
        public RegVehicleForm(string model, int plateNumber, string type, int seats, double price, double mileage, string status)
        {
            InitializeComponent();
            isEditMode = true;

            // Pre-fill the fields with the selected vehicle's data
            txtVehicleModel.Text = model;
            txtPlateNumber.Text = plateNumber.ToString();
            txtPlateNumber.Enabled = false; // Plate number is primary key, so lock it to prevent accidental changes
            cmbVehicleType.Text = type;
            txtSeats.Text = seats.ToString();
            txtDailyRate.Text = price.ToString();
            txtMileage.Text = mileage.ToString();
            cmbStatus.Text = status;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string vehicle_model = txtVehicleModel.Text.Trim();
                double price = Convert.ToDouble(txtDailyRate.Text);
                int plate_number = Convert.ToInt32(txtPlateNumber.Text);
                double current_mileage = Convert.ToDouble(txtMileage.Text);
                string vehicle_type = cmbVehicleType.Text;
                string status = cmbStatus.Text;
                int seat = Convert.ToInt32(txtSeats.Text);

                if (string.IsNullOrEmpty(vehicle_model) || string.IsNullOrEmpty(vehicle_type) || string.IsNullOrEmpty(status))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var connection = Database.Database.GetConnection();
                connection.Open();

                using var command = connection.CreateCommand();

                if (isEditMode)
                {
                    // Run UPDATE query if we are editing
                    command.CommandText = """
                        UPDATE Vehicles 
                        SET Model = @Model, Type = @Type, Seats = @Seats, Price = @Price, Mileage = @Mileage, Status = @Status 
                        WHERE PlateNumber = @PlateNumber;
                    """;
                }
                else
                {
                    // Run INSERT query if we are registering new
                    command.CommandText = """
                        INSERT INTO Vehicles (PlateNumber, Model, Type, Seats, Price, Mileage, Status)
                        VALUES (@PlateNumber, @Model, @Type, @Seats, @Price, @Mileage, @Status);
                    """;
                }

                command.Parameters.AddWithValue("@PlateNumber", plate_number);
                command.Parameters.AddWithValue("@Model", vehicle_model);
                command.Parameters.AddWithValue("@Type", vehicle_type);
                command.Parameters.AddWithValue("@Seats", seat);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Mileage", current_mileage);
                command.Parameters.AddWithValue("@Status", status);

                command.ExecuteNonQuery();

                string successMsg = isEditMode ? "Vehicle updated successfully!" : "Vehicle saved successfully!";
                MessageBox.Show(successMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for Price, Plate Number, Mileage, and Seats.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Microsoft.Data.Sqlite.SqliteException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtVehicleModel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}