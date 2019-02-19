using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taximeter.BUS
{
    public class Car
    {
        private double fuel;
        private double mileage;
        private int year;
        private string type;
        private string plate;

        public Car(double fuel, double mileage, int year, string type, string plate)
        {
            this.fuel = fuel;
            this.mileage = mileage;
            this.year = year;
            this.type = type;
            this.plate = plate;
        }

        public Car()
        {
            this.fuel = 0;
            this.mileage = 0;
            this.year = DateTime.Now.Year;
            this.type = "";
            this.plate = "";
        }

        public double Fuel { get => fuel; set => fuel = value; }
        public double Mileage { get => mileage; set => mileage = value; }
        public int Year { get => year; set => year = value; }
        public string Type { get => type; set => type = value; }
        public string Plate { get => plate; set => plate = value; }

  
    }
}
