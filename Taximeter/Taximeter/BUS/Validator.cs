using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taximeter.BUS
{
    class Validator
    {
        //Validator function to allow only number input and one decimal point
        public static void onlyNumInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        //Function to avoid null inputs
        public static bool avoidNullInput(TextBox aTextbox)
        {
            if (string.IsNullOrEmpty(aTextbox.Text))
            {
                return true;
            }
            return false;
        }
     
    }
}
