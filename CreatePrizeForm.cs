using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequester callingForm;
        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
        }

        private void LastNameTextValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrizePercentageValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm()) 
            {
                PrizeModel model = new PrizeModel(
                    PlaceNameValue.Text,
                    PlaceNumberValue.Text,
                    PrizeAmoutValue.Text,
                    PrizePercentageValue.Text
                    );


                GlobalConfig.Connection.CreatePrize( model );

                callingForm.PrizeComplete(model);

                this.Close();

                //PlaceNameValue.Text = "";
                //PlaceNumberValue.Text = "";
                //PrizeAmoutValue.Text = "0";
                //PrizePercentageValue.Text = "0";


            }

            else
            {
                MessageBox.Show("This form has a Invalid Information");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(PlaceNumberValue.Text, out placeNumber);

            if (placeNumberValidNumber == false) 
            {
                output = false;
            }

            if (placeNumber < 1) { output = false; }

            if (PlaceNameValue.Text.Length == 0) { output = false; }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool PrizeAmountValid = decimal.TryParse(PrizeAmoutValue.Text, out prizeAmount);
            bool PrizePercentageValid = double.TryParse(PrizePercentageValue.Text, out prizePercentage);

            if (PrizeAmountValid == false || PrizePercentageValid == false) 
            {

            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }
            if (prizeAmount < 0 || prizePercentage > 100)
            {
                output = false;
            }




            return output;
        }
    }
}
