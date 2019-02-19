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
    public partial class PickupForm : Form
    {
        public PickupForm(Taxist aTaxist)
        {
            InitializeComponent();
            currTaxist = aTaxist;
        }
        Taxist currTaxist;


        private void PickupForm_Load(object sender, EventArgs e)
        {
            //Fill comboboxes with only possible options
            for (int i = 0; i <=60; i++)
            {
                cboSMin.Items.Add(i);
                cboEMin.Items.Add(i);
            }
            for (int i = 0; i < 24; i++)
            {
                cboSHour.Items.Add(i);
                cboEHour.Items.Add(i);
            }

            //Select current time in the comboboxes
            DateTime now = DateTime.Now;
            cboSHour.Text = now.TimeOfDay.Hours.ToString();
            cboSMin.Text = now.TimeOfDay.Minutes.ToString();
            cboEHour.Text = now.TimeOfDay.Hours.ToString();
            cboEMin.Text = now.TimeOfDay.Minutes.ToString();          
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Validator.avoidNullInput(txtSpeed))
            {
                MessageBox.Show("Missing Information to proceed, please review your input.", "Input error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TimeSpan startTime = new TimeSpan(Convert.ToInt16(cboSHour.Text), Convert.ToInt16(cboSMin.Text),0);
            TimeSpan endTime = new TimeSpan(Convert.ToInt16(cboEHour.Text), Convert.ToInt16(cboEMin.Text),0);
            currTaxist.newTrip(startTime, endTime, Convert.ToDouble(txtSpeed.Text));
            UIForm uiForm = new UIForm(currTaxist);
            this.Hide();
            uiForm.Show();
            
            
        }

        private void txtSpeed_KeyPress(object sender, KeyPressEventArgs e)
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
