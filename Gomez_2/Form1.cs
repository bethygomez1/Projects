//Programmer: Bethy Gomez
// Project: Gomez_2
// Date Due: 02/23/2018
// Description: Individual Assignment #2; Form for signing up students for language courses

using System;
using System.Windows.Forms;

namespace Gomez_2
{
    public partial class Form1 : Form
    {
        // Declare class level variable
        private int totalCourses;                    // Total courses selected
        private decimal studentPrice;                // Determines if its an in state or out of state student
        private decimal totalPrice;                  // Total price of the order
        private const decimal INSTATE_PRICE = 49m;   // Instate price
        private const decimal OUTSTATE_PRICE = 99m;  // Out of state price
        private object fallSpringTerm;               // Variable to declare the term
        private object residenceStatus;              // Variable to declare residence status
        private object cardType;                     // Variable to declare card type
        public Form1()
        {
            InitializeComponent();

            // To declare the instate price per course
            // Did this for so the form starts this way since in state is the default
            // Show the in state price in the price labels
            frenchPriceLabel.Text = INSTATE_PRICE.ToString("c");
            germanPriceLabel.Text = INSTATE_PRICE.ToString("c");
            italianPriceLabel.Text = INSTATE_PRICE.ToString("c");
            russianPriceLabel.Text = INSTATE_PRICE.ToString("c");
            spanishPriceLabel.Text = INSTATE_PRICE.ToString("c");

            // Display the in state price when in state radio button is checked
            if (inStateRadioButton.Checked)
            {
                studentPrice = INSTATE_PRICE;
            }

            // Allows the new order information message box to read the default fall term
            if (fallRadioButton.Checked)
            {
                fallSpringTerm = fallRadioButton.Text;
            }

            // Allows the new order information message box to read the default instate residence status
            if (inStateRadioButton.Checked)
            {
                residenceStatus = inStateRadioButton.Text;
            }

            // Allows the new order information message box to read the default mastercard card type
            if (masterCardRadioButton.Checked)
            {
                cardType = masterCardRadioButton.Text;
            }

            // Display the total courses (0) and price (0) when form starts
            coursesLabel.Text = totalCourses.ToString();
            totalPriceLabel.Text = totalPrice.ToString("c");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // To add items to combobox
            yearComboBox.Items.Add("2018");
            yearComboBox.Items.Add("2019");
            yearComboBox.Items.Add("2020");
            yearComboBox.Items.Add("2021");
            yearComboBox.Items.Add("2022");
            yearComboBox.Items.Add("2023");
        }

        private void outOfStateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Declare out of state price per course
            // Show the out of state price in the price labels
            frenchPriceLabel.Text = OUTSTATE_PRICE.ToString("c");
            germanPriceLabel.Text = OUTSTATE_PRICE.ToString("c");
            italianPriceLabel.Text = OUTSTATE_PRICE.ToString("c");
            russianPriceLabel.Text = OUTSTATE_PRICE.ToString("c");
            spanishPriceLabel.Text = OUTSTATE_PRICE.ToString("c");

            // Show the out of state price when out of state radio button is checked
            if (outOfStateRadioButton.Checked)
            {
                studentPrice = OUTSTATE_PRICE;
                residenceStatus = outOfStateRadioButton.Text;
            }
        }

        private void inStateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // To display the instate price when in state radio button is checked
            // I tried to work this into the original code in the load form section
            // but if i toggled between instate and outofstate the prices wouldn't go back
            frenchPriceLabel.Text = INSTATE_PRICE.ToString("c");
            germanPriceLabel.Text = INSTATE_PRICE.ToString("c");
            italianPriceLabel.Text = INSTATE_PRICE.ToString("c");
            russianPriceLabel.Text = INSTATE_PRICE.ToString("c");
            spanishPriceLabel.Text = INSTATE_PRICE.ToString("c");

            if (inStateRadioButton.Checked)
            {
                studentPrice = INSTATE_PRICE;
                residenceStatus = inStateRadioButton.Text;
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Display a messgae box with a summary of the information user inputs into the form
            if (totalCourses >=1 && totalCourses <4)
            {
                // To make sure that the total price in message box accurately reflects the residence radio button checked
                totalPrice = totalCourses * studentPrice;

                MessageBox.Show("Registration Term:" + " " + fallSpringTerm + " " + yearComboBox.Text +
                    Environment.NewLine + "Student ID:" + " " + studentIDMaskedTextBox.Text +
                    Environment.NewLine + "Student Name:" + " " + firstNameTextBox.Text + " " + 
                    lastNameTextBox.Text + 
                    Environment.NewLine + "Email Address:" + " " + emailTextBox.Text + 
                    Environment.NewLine + "Residence Status:" + " " + residenceStatus +
                    Environment.NewLine + "Total Courses Purchased:" + " " + coursesLabel.Text +
                    Environment.NewLine + "Price Per Course:" + " " + studentPrice.ToString("c") +
                    Environment.NewLine + "Total Order Price:" + " " + totalPrice.ToString("c") +
                    Environment.NewLine + "Credit Card Type:" + " " + cardType +
                    Environment.NewLine + "Card Number:" + " " + cardNumberTextBox.Text +
                    Environment.NewLine + "Card Expiration Date:" + " " + expDateMaskedTextBox.Text,
                    "New Order Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Display a message box for invalid data (not enough or too many check boxes are checked)
            else
            {
                MessageBox.Show("A course order must contain at least one course but no more than three courses.",
                    "Invalid Data", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear all controls on the form
            fallRadioButton.Checked = true;
            yearComboBox.SelectedIndex = -1;
            studentIDMaskedTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            inStateRadioButton.Checked = true;
            frenchCheckBox.Checked = false;
            germanCheckBox.Checked = false;
            italianCheckBox.Checked = false;
            russianCheckBox.Checked = false;
            spanishCheckBox.Checked = false;
            masterCardRadioButton.Checked = true;
            cardNumberTextBox.Text = "";
            expDateMaskedTextBox.Text = "";
            coursesLabel.Text = "0";
            totalPriceLabel.Text = "$0.00";
            
            // Set focus to the first control
            // I wasn't sure if this should be StudentID but the radiobutton is technically the first control
            fallRadioButton.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // To add a confirmation box before quitting the application
            // Declare variable to hold user selection in dialog box
            DialogResult selection;
            selection = MessageBox.Show("Are you sure you wish to quit?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Tale action based on user selection in dialog box
            if (selection == DialogResult.Yes)
            {
                // To close the form
                this.Close();
            }

        }

        private void frenchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            totalCourses = 0;

            // Increment counter for each box selected
            if (frenchCheckBox.Checked)
            {
                totalCourses += 1;
            }
            if (germanCheckBox.Checked)
            {
                totalCourses += 1;
            }
            if (italianCheckBox.Checked)
            {
                totalCourses += 1;
            }
            if (russianCheckBox.Checked)
            {
                totalCourses += 1;
            }
            if (spanishCheckBox.Checked)
            {
                totalCourses += 1;
            }

            // Update the display of number of courses selected
            coursesLabel.Text = totalCourses.ToString();
            
            // Update the display of total price of the order
            totalPrice = totalCourses * studentPrice;
            totalPriceLabel.Text = totalPrice.ToString("c");
        }

        private void springRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Allows the new order info message box to read the term
            if (springRadioButton.Checked)
            {
                fallSpringTerm = springRadioButton.Text;
            }
        }

        private void fallRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Allows the new order info message box to read the term if toggled back to the default
            if (fallRadioButton.Checked)
            {
                fallSpringTerm = fallRadioButton.Text;
            }
        }

        private void masterCardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Allows the new order info message box to read the card type if toggled back to the default
            if (masterCardRadioButton.Checked)
            {
                cardType = masterCardRadioButton.Text;
            }
        }

        private void visaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Allows the new order info message box to read the card type
            if (visaRadioButton.Checked)
            {
                cardType = visaRadioButton.Text;
            }
        }
    }
}
