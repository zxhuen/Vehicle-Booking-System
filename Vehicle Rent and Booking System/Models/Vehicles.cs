using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rent_and_Booking_System.Models
{
    internal class Vehicles
    {
        public string Model { get; set; }
        public int PlateNumber { get; set; }
        public string Type { get; set; }
        public int Seats { get; set; }
        public double Price { get; set; }
        public string Status { get; set; }

        public double DailyRate { get; set; }
        public double Mileage { get; set; }

        public Vehicles()
        {
        }

        public Vehicles(string model, int plateNumber, string type, int seats, double price, string status, double mileage, double dailyRate)
        {
            Model = model;
            PlateNumber = plateNumber;
            Type = type;
            Seats = seats;
            Price = price;
            Status = status;
            Mileage = mileage;
            DailyRate = dailyRate;
        }
    }
}
