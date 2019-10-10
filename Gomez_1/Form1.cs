// Programmer: Bethy Gomez
// Project: Gomez_1
// Date: 02/07/2018
// Description: Form for calculating a customer's motel charges

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomez_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Close form (terminate the program) when Exit button is clicked
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Perfrom calculations and display results
        private void totalButton_Click(object sender, EventArgs e)
        {
            // Use try-catch to handle any data entry exceptions
            try
            {
                // Declare local constants
                const decimal TAX_RATE = 0.07m;

                // Declare variables for additional charges to prevent use of unassigned local variables in if statements
                decimal minibarCharges = 0m;     // Charges of using minibar
                decimal telephoneCharges = 0m;   // Charges of using the telephone
                decimal miscCharges = 0m;        // Other charges associated with stay


                // Declare local variables
                int daysStayed;             // Number of nights the guest stayed
                decimal nightlyrate;        // Rate of room per night
                decimal roomCharges;        // Total charges for the room (nights stayed times nightly rate)
                decimal additionalCharges;  // Total charges for minibar, telephone and misc
                decimal subtotalCharge;     // Total charges for room and additional charges
                decimal tax;                // Tax on subtotal charges
                decimal totalCharges;       // Total charge for order including tax

                // Get variables from text boxes and assign to variables
                daysStayed = int.Parse(daysStayedTextBox.Text);
                nightlyrate = decimal.Parse(nightlyRateTextBox.Text);

                // The following lines are to prevent an exception when attempting to convert a null value to numeric
                if (minibarTextBox.Text != "")
                    minibarCharges = decimal.Parse(minibarTextBox.Text);
                if (telephoneTextBox.Text != "")
                    telephoneCharges = decimal.Parse(telephoneTextBox.Text);
                if (miscTextBox.Text != "")
                    miscCharges = decimal.Parse(miscTextBox.Text);

                // Calculate and display room charges
                roomCharges = daysStayed * nightlyrate;
                roomChargesLabel.Text = roomCharges.ToString("c");

                // Calculate and display additional charges
                additionalCharges = minibarCharges + telephoneCharges + miscCharges;
                additionalChargesLabel.Text = additionalCharges.ToString("c");

                // Calculate and display subtotal
                subtotalCharge = roomCharges + additionalCharges;
                subtotalLabel.Text = subtotalCharge.ToString("c");

                // Calculate and display the sales tax
                tax = subtotalCharge * TAX_RATE;
                taxLabel.Text = tax.ToString("c");

                // Calculate and display the total charges
                totalCharges = subtotalCharge + tax;
                totalChargesLabel.Text = totalCharges.ToString("c");

                // Set focus to clear button when the total button is clicked
                clearButton.Focus();



            }
            catch (Exception ex)
            {
                // Display the default error message
                MessageBox.Show(ex.Message);
            }
        }
        // Clear all input and output controls
        private void clearButton_Click(object sender, EventArgs e)
        {
            dateTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            roomNumberTextBox.Text = "";
            daysStayedTextBox.Text = "";
            nightlyRateTextBox.Text = "";
            minibarTextBox.Text = "";
            telephoneTextBox.Text = "";
            miscTextBox.Text = "";
            roomChargesLabel.Text = "";
            additionalChargesLabel.Text = "";
            subtotalLabel.Text = "";
            taxLabel.Text = "";
            totalChargesLabel.Text = "";

            // Set focus to first input control on form
            dateTextBox.Focus();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            // Display a message that gives basic instructions about the program
            MessageBox.Show("To use this program enter the date the customer is checking out, along with their first name, last name and room number. Enter the number of days they stayed and the nightly rate along with any additional charges and click the total button. Once finished click the clear button to enter a new customer's information and the exit button when finsihed.");
        }
    }
}
