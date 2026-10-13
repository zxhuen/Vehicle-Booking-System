using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace Vehicle_Rent_and_Booking_System.Database
{
    internal class Database
    {
        private const string ConnectionString = "Data Source=vehicle_rental.db";

        public static SqliteConnection GetConnection()
        {
            return new SqliteConnection(ConnectionString);
        }

        public static void Initialize()
        {
            using var connection = GetConnection();
            connection.Open();

            // Enable foreign key support in SQLite
            using var pragmaCmd = connection.CreateCommand();
            pragmaCmd.CommandText = "PRAGMA foreign_keys = ON;";
            pragmaCmd.ExecuteNonQuery();

            using var command = connection.CreateCommand();

            command.CommandText = """
            CREATE TABLE IF NOT EXISTS Users (
                UserId TEXT PRIMARY KEY,
                Password TEXT NOT NULL
            );

            INSERT OR IGNORE INTO Users (UserId, Password)
            VALUES ('123', 'admin');

            CREATE TABLE IF NOT EXISTS Vehicles (
                PlateNumber INTEGER PRIMARY KEY,
                Model TEXT NOT NULL,
                Type TEXT NOT NULL,
                Seats INTEGER NOT NULL,
                Price REAL NOT NULL,
                Mileage REAL NOT NULL DEFAULT 0.0,
                Status TEXT NOT NULL DEFAULT 'Available'
            );

            CREATE TABLE IF NOT EXISTS Rentals (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                vehicle_no INTEGER NOT NULL,
                pickupBranch TEXT NOT NULL,
                pickupDate TEXT NOT NULL,
                returnDate TEXT NOT NULL,
                totalPayment REAL NOT NULL,
                FOREIGN KEY (vehicle_no) REFERENCES Vehicles(PlateNumber)
            );

            -- Wipe all rental records and make all vehicles available on every app startup
            DELETE FROM Rentals;
            UPDATE Vehicles SET Status = 'Available';
            """;
            command.ExecuteNonQuery();

            try
            {
                command.CommandText = "ALTER TABLE Vehicles ADD COLUMN Mileage REAL NOT NULL DEFAULT 0.0;";
                command.ExecuteNonQuery();
            }
            catch (Microsoft.Data.Sqlite.SqliteException)
            {
            }

            try
            {
                command.CommandText = "ALTER TABLE Rentals ADD COLUMN totalPayment REAL NOT NULL DEFAULT 0.0;";
                command.ExecuteNonQuery();
            }
            catch (Microsoft.Data.Sqlite.SqliteException)
            {
            }

            command.CommandText = """
            INSERT OR IGNORE INTO Vehicles (PlateNumber, Model, Type, Seats, Price, Mileage, Status) VALUES
            (1001, 'Toyota Vios', 'Sedan', 5, 1500.00, 15000.5, 'Available'),
            (1002, 'Honda Civic', 'Sedan', 5, 2200.00, 8500.0, 'Available'),
            (1003, 'Toyota Innova', 'MPV', 7, 2800.00, 24300.2, 'Available'),
            (1004, 'Ford Everest', 'SUV', 7, 3500.00, 12000.0, 'Available'),
            (1005, 'Nissan Urvan', 'Van', 15, 4500.00, 45000.8, 'Available');
            """;
            command.ExecuteNonQuery();
        }
    }
}