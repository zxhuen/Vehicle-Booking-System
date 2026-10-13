using Microsoft.VisualBasic.ApplicationServices;

namespace Vehicle_Rent_and_Booking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            password_textbox.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = user_id_textbox.Text;
            string password = password_textbox.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(
                    "Please Enter Both user ID and Password.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            using var connection = Database.Database.GetConnection();
            connection.Open();

            using var command = connection.CreateCommand();

            command.CommandText = """
            SELECT UserId
            FROM Users
            WHERE UserId = $userId
            AND Password = $password;
            """;

            command.Parameters.AddWithValue("$userId", id);
            command.Parameters.AddWithValue("$password", password);

            var result = command.ExecuteScalar();


            if (result != null)
            {
                MessageBox.Show("Logged in");

                Form2 form2 = new Form2();
                form2.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong credentials");
            }
        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
