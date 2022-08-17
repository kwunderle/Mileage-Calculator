using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcValidation___Katharine_Wunderle
{
    //Author: Katharine Wunderle
    //ID: 623748
    //Date: 02/27/2021
    //Goal: Calculate gas cost and mpg
    public partial class CalcValidation : Form
    {
        public CalcValidation()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //declare input variables
                decimal beginOdo;
                decimal endOdo;
                decimal gallons;
                decimal gasCost;
                //declare output variables
                decimal totalCost;
                decimal totalMiles;
                decimal mpg;

                //INPUT
                //Get beginning mileage
                beginOdo = decimal.Parse(BeginOdoInput.Text);
                //Get ending mileage
                endOdo = decimal.Parse(endOdoInput.Text);
                //Get amount of gas needed
                gallons = decimal.Parse(gallonInput.Text);
                //Get gas price
                gasCost = decimal.Parse(gasPriceInput.Text);

                //PROCESSING
                //Calculate total cost of fill-up
                totalCost = gallons * gasCost;

                //Calculate miles between stop 1 and 2
                totalMiles = endOdo - beginOdo;

                //Calculate MPG
                mpg = totalMiles / gallons;

                //OUTPUT
                //Display total cost of fill-up
                totalOutput.Text = totalCost.ToString("c");

                //Display miles between stop 1 and 2
                milesOutput.Text = totalMiles.ToString() + " miles";

                //Display mpg
                mpgOutput.Text = mpg.ToString() + " mpg";
            }
            catch
            {
                //Display an error message
                MessageBox.Show("Invalid data was entered.");
                return;
            }
        }
    }
}
