using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taximeter.BUS
{
    public class Trip
    {
        private int id;
        private TimeSpan startTime, endTime;
        private double startSpeed;
        private decimal cost;


        public Trip(int id, TimeSpan startTime, TimeSpan endTime, double startSpeed)
        {
            this.id = id;
            this.startTime = startTime;
            this.endTime = endTime;
            this.startSpeed = startSpeed;
            this.cost = calcCost();
        }
        public Trip()
        {
            this.id = 0;
            this.startTime = new TimeSpan(9,0,0);
            this.endTime = new TimeSpan(15,0,0);
            this.startSpeed = 0;
            this.cost = 0;
        }

        public int Id { get => id; set => id = value; }
        public TimeSpan StartTime { get => startTime; set => startTime = value; }
        public TimeSpan EndTime { get => endTime; set => endTime = value; }
        public double StartSpeed { get => startSpeed; set => startSpeed = value; }
        public decimal Cost { get => cost; set => cost = value; }

        //Method to calculate the trip cost
        public decimal calcCost()
        {
            double tripTime = (EndTime - StartTime).TotalHours;
            TimeSpan time1 = new TimeSpan(0, 0, 0), time2 = new TimeSpan(8,0,0), time3 = new TimeSpan(14,0,0);
            decimal cost = 0;
            
            //Check if the trip will take more than 12 hours
            if (tripTime > 12 )
            {
                MessageBox.Show("A single trip cannot take more than 12 hours, please inform the passenger.","Not possible to continue.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return -1;
            }
            //Check if the input was correct, if the time is set in the future returns an error message.
            else if (tripTime < 0)
            {
                MessageBox.Show("A trip cannot start in the future and end in the past! Please review information.", "Not possible to continue.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return -1;
            }


            //The method used to obtain the cost is by dividing the trip in partial times, since the cost changes according to the time of the day
            double partial1 = time2.TotalHours - StartTime.TotalHours;
            double partial2 = time3.TotalHours - StartTime.TotalHours;
            double partial3 = EndTime.TotalHours - time1.TotalHours;
            double partial4 = EndTime.TotalHours - time2.TotalHours;
            double partial5 = EndTime.TotalHours - time3.TotalHours;

            //If the partial time calculated is higher than the maximum possible, or negative,  it is discarded from the equation (= 0)
            if(partial1>8 || partial1 < 0)
            {
                partial1 = 0;
            }
            if(partial2>6 || partial2 < 0)
            {
                partial2 = 0;
            }
            if(partial3>6 || partial3 < 0)
            {
                partial3 = 0; 
            }
            if (partial4>6 || partial4 < 0)
            {
                partial4 = 0; 
            }
            if (partial5 >10 || partial5 < 0)
            {
                partial5 = 0;
            }                                      
    
            //Formula to calculate the cost according to the prices 
            cost = (decimal)(partial1* 30 + partial2 * 20 + partial3 * 30 + partial4 * 20 + partial5 * 25);
            return cost;                                
        }
    }
}
