using System;
using System.Windows.Forms;
using TournamentTracker;
using TournamentTracker.Interfaces;

namespace TournamentTrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                TournamentTracker.Models.PrizeModel model = new TournamentTracker.Models.PrizeModel(
                    placeNumberValue.Text,
                    placeNameValue.Text,
                    prizeAmountValue.Text,
                    prizePercentageValue.Text
                );

                GlobalConfig.Connections.CreatePrize(model);

                MessageBox.Show("Prize Saved Successfully!");

                // Resetting the form values.
                placeNameValue.Text = "";
                placeNumberValue.Text = "";
                prizeAmountValue.Text = "0";
                prizePercentageValue.Text = "0";

            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        /// <summary>
        /// Validation Function for Form.
        /// </summary>
        /// <returns>boolean if the form is valid or not.</returns>
        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;

            if (!int.TryParse(placeNumberValue.Text, out placeNumber))
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if (placeNameValue.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            int prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = int.TryParse(prizePercentageValue.Text, out prizePercentage);

            if (!prizeAmountValid || !prizePercentageValid)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }


            return output;
        }

    }
}
