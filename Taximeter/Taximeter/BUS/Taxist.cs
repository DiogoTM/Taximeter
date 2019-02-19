using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Taximeter.BUS
{
    public class Taxist :Person
    {
        private Car car;
        private decimal income;
        private List<Trip> trips;

        public Taxist(string fname, string lname, Car car, decimal income, List<Trip> trips)
        {
            this.Fname = fname;
            this.Lname = lname;
            this.car = car;
            this.income = income;
            this.trips = trips;
        }

        public decimal Income { get => income; set => income = value; }
        internal Car Car { get => car; set => car = value; }
        internal List<Trip> Trips { get => trips; set => trips = value; }

        //Method to fill Tank
        public void fillTank(double amount, decimal currCost)
        {
            decimal totalCost = currCost * (decimal)amount;
            if (totalCost <= Income)
            {
                Income -= totalCost;
                Car.Fuel += amount;
                MessageBox.Show("Car refueled succesfully!", "Refuel Success", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Not enough funds!", "Error processing payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }       
        }

        //Method to add New Trip (New Passenger)
        //Passenger information is not needed
        public void newTrip(TimeSpan sTime, TimeSpan eTime,double sSpeed)
        {
            Trip aTrip = new Trip(Trips.Count() + 1, sTime, eTime, sSpeed);
            if (aTrip.calcCost() == -1)
            {
                return;
            }
            Trips.Add(aTrip);
            Income += aTrip.Cost;
            calcFuel(aTrip);
            calcMileage(aTrip);
            MessageBox.Show("New trip on going, passenger accepted!", " Successful Operation!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);         
        }
        
        //Method to calculate fuel given a trip 
        public void calcFuel(Trip aTrip)
        {
            double tripTime = (aTrip.EndTime - aTrip.StartTime).TotalHours;
            Car.Fuel = Car.Fuel - (tripTime * Math.Abs(Math.Tan(aTrip.StartSpeed * tripTime)) + Math.Abs(Math.Cos(aTrip.StartSpeed)));
            if (Car.Fuel < 0)
            {
                MessageBox.Show("You will run out of Gas during this trip, a service fee will be discount for the on-site refuelling.", " Gas Alert!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Income -= 100;
            }
        }

        //Method to Calculate Mileage after new trip
        public void calcMileage(Trip aTrip)
        {
            double tripTime = (aTrip.EndTime - aTrip.StartTime).TotalHours;           
            Car.Mileage = Car.Mileage + Math.Pow(aTrip.StartSpeed, (2 * tripTime)) - aTrip.StartSpeed * tripTime;
        }


    }
}
