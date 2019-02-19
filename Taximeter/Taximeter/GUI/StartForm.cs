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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();      
        }
        //Global variables
        Car startCar;
        List<Trip> startListTrips;
        Taxist startTaxist;

        public void initializeProgram(double startFuel)
        {
            //Create objects
            startCar = new Car(startFuel, 0, 2015, "Honda Civic", "A78 QWE");
            startListTrips = new List<Trip>();
            startTaxist = new Taxist(txtFname.Text,txtLname.Text,startCar, 0, startListTrips);
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Validator.avoidNullInput(txtFname) || Validator.avoidNullInput(txtLname) || Validator.avoidNullInput(txtFuel))
            {
                MessageBox.Show("Missing Information to proceed, please review your input.", "Input error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }                     

            double fuel = Convert.ToDouble(txtFuel.Text);
            initializeProgram(fuel);
            Form newForm = new UIForm(startTaxist);
            this.Hide();
            newForm.Show();
        }

        private void txtFuel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.onlyNumInput(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Exit Message and confirmation
            if (MessageBox.Show(this, "Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
