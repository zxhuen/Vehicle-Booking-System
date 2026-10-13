using Vehicle_Rent_and_Booking_System.Database;

namespace Vehicle_Rent_and_Booking_System
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Database.Database.Initialize();
            Application.Run(new Form1());
        }
    }
}