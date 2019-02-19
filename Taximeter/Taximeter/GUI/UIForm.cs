using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taximeter.BUS;

namespace Taximeter.GUI
{
    public partial class UIForm : Form
    {
        public UIForm(Taxist aTaxist)
        {
            InitializeComponent();
            startTaxist = aTaxist;
        }
        Taxist startTaxist;             
                   

        private void UIForm_Load(object sender, EventArgs e)
        {
            lblGas.Text = startTaxist.Car.Fuel.ToString();
            lblIncome.Text = startTaxist.Income.ToString();
            lblMileage.Text = startTaxist.Car.Mileage.ToString();
            lblTrip.Text = startTaxist.Trips.Count.ToString();
            lblInfo.Text = "Taxist: " + startTaxist.Fname + " " + startTaxist.Lname + "\nCar: " + startTaxist.Car.Type + " " + startTaxist.Car.Year + " - " + startTaxist.Car.Plate;   
        }

        private void btnPickUp_Click(object sender, EventArgs e)
        {

            
            PickupForm newPForm = new PickupForm(startTaxist);
            newPForm.Show();
        }

        private void btnFillUp_Click(object sender, EventArgs e)
        {
            FillTankForm newFForm = new FillTankForm(startTaxist);
            newFForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Exit Message and confirmation
            if (MessageBox.Show(this, "Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
