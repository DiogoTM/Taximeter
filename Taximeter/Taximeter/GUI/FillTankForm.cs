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
    public partial class FillTankForm : Form
    {
        public FillTankForm(Taxist aTaxist)
        {
            InitializeComponent();
            currTaxist = aTaxist;
        }
        Taxist currTaxist;
        decimal fuelPrice;



        private void FillTankForm_Load(object sender, EventArgs e)
        {
            //Randomly defines a price for the fuel
            Random rnd = new Random();
            fuelPrice = (decimal)(rnd.NextDouble() * (0.30) + (1.15));
            
            //Fill labels with the information
            lblBalance.Text = currTaxist.Income.ToString();
            lblPrice.Text = fuelPrice.ToString();
            lblFuelCost.Text = "0.0";
        }

        //Update information with the calculated cost
        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

            if(!string.IsNullOrEmpty(txtAmount.Text))
            {
                decimal cost = fuelPrice * Convert.ToDecimal(txtAmount.Text);
                lblFuelCost.Text = cost.ToString();
            }
           
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Validator.avoidNullInput(txtAmount))
            {
                MessageBox.Show("Missing Information to proceed, please review your input.", "Input error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            currTaxist.fillTank(Convert.ToDouble(txtAmount.Text), fuelPrice);
            UIForm uiForm = new UIForm(currTaxist);
            this.Hide();
            uiForm.Show();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.onlyNumInput(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Exit Message and confirmation
            if (MessageBox.Show(this, "Are you sure you want to close?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
