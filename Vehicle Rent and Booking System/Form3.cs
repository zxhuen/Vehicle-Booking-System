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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            LoadVehiclesToGrid();
        }

        private void LoadVehiclesToGrid()
        {
            dataGridView1.Rows.Clear();

            using var connection = Database.Database.GetConnection();
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = "SELECT Model, PlateNumber, Type, Seats, Price, Mileage, Status FROM Vehicles;";

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(
                    reader.GetString(0),                  // Model
                    reader.GetInt32(1),                   // Plate Number
                    reader.GetString(2),                  // Type
                    reader.GetInt32(3),                   // Seats
                    reader.GetDouble(4).ToString("F2"),   // Price/Day formatted
                    reader.GetDouble(5).ToString(),       // Status
                    reader.GetString(6)                     //Mileage
                );
            }
        }


        private void Form3_Load(object sender, EventArgs e)
        {

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

        private void rentbtn_Click_1(object sender, EventArgs e)
        {

        }

        private void fleetbtn_Click(object sender, EventArgs e)
        {

        }

        private void regVehiclebtn_Click(object sender, EventArgs e)
        {
            RegVehicleForm regVehicleForm = new RegVehicleForm();
            regVehicleForm.Show();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 && dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please highlight/select a vehicle row to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                if (row.IsNewRow) return;

                string model = row.Cells[0].Value?.ToString() ?? "";
                if (!int.TryParse(row.Cells[1].Value?.ToString(), out int plateNumber)) return;
                string type = row.Cells[2].Value?.ToString() ?? "";
                if (!int.TryParse(row.Cells[3].Value?.ToString(), out int seats)) seats = 5;
                if (!double.TryParse(row.Cells[4].Value?.ToString(), out double price)) price = 0;
                if (!double.TryParse(row.Cells[5].Value?.ToString(), out double mileage)) mileage = 0;
                string status = row.Cells[6].Value?.ToString() ?? "Available";

                // Open the RegVehicleForm in edit mode
                using (var editForm = new RegVehicleForm(model, plateNumber, type, seats, price, mileage, status))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        // Refresh the grid automatically after saving changes
                        LoadVehiclesToGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening edit form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 && dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please highlight/select a vehicle row to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                if (row.IsNewRow) return;

                if (!int.TryParse(row.Cells[1].Value?.ToString(), out int plateNumber))
                {
                    MessageBox.Show("Could not read the Plate Number for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult confirmResult = MessageBox.Show(
                    $"Are you sure you want to delete vehicle with Plate Number: {plateNumber}?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmResult == DialogResult.Yes)
                {
                    using var connection = Database.Database.GetConnection();
                    connection.Open();

                    using var command = connection.CreateCommand();
                    command.CommandText = "DELETE FROM Vehicles WHERE PlateNumber = @plateNumber;";
                    command.Parameters.AddWithValue("@plateNumber", plateNumber);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Vehicle deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadVehiclesToGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting vehicle: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}