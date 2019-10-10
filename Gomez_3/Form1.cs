// Programmer: Bethy Gomez
// Project: Gomez_3
// Date Due: 04/02/2018
// Description: Assignment #3; Form for taking an order

using System;
using System.IO;
using System.Windows.Forms;

namespace Gomez_3
{
    public partial class Form1 : Form
    {
        // Declare constant variables
        private const decimal homeDeliveryPrice = 7.50m;
        private const decimal pickUpPrice = 0m;
        private const decimal singlePrice = 9.95m;
        private const decimal halfDozenPrice = 35.95m;
        private const decimal dozenPrice = 65.95m;
        private const decimal extrasPrice = 9.50m;
        private const decimal messagePrice = 2.50m;
        private const decimal TAX_RATE = 0.07m;

        // Declare variables
        private string deliveryType = "";  // Variable for delivery type
        private string bundleSize = "";    // Variable for Balloon bundle size

        // Declare variables for calculating order totals
        private decimal deliveryPrice;   // Extra variable to make it easier in UpdateTotals section
        private decimal bundlePrice;     // Extra variable to make it easier in UpdateTotals section
        private decimal messageSubtotal; // Extra variable to make it easier in UpdateTotals section
        private decimal extrasSubtotal;  // Extra variable to make it easier in UpdateTotals section
        private int extrasCount = 0;     // Variable to count how many extras are selected; used in UpdateTotals and Summary
        private decimal subtotalPrice;
        private decimal salesTaxPrice;
        private decimal orderTotalPrice;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add current date as default
            deliveryDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");       

            // Add items to combo box
            titleComboBox.Items.Add("Dr.");
            titleComboBox.Items.Add("Mr.");
            titleComboBox.Items.Add("Mrs.");
            titleComboBox.Items.Add("Ms.");
            titleComboBox.Items.Add("Rev.");

            // Set default options
            pickUpRadioButton.Checked = true;
            singleRadioButton.Checked = true;

            // Call custom method to populate list box with extras
            PopulateListBox();

            // Set defaults for occasion combo box
            occasionComboBox.Sorted = true;
            occasionComboBox.SelectedItem = "Birthday";

            // Set selection mode for list box
            extrasListBox.SelectionMode = SelectionMode.MultiSimple;
            extrasListBox.Sorted = true;

            // To apply variables when form loads
            homeDeliveryPriceLabel.Text = homeDeliveryPrice.ToString("c");
            singlePriceLabel.Text = singlePrice.ToString("c");
            halfDozenPriceLabel.Text = halfDozenPrice.ToString("c");
            dozenPriceLabel.Text = dozenPrice.ToString("c");
            extrasPriceLabel.Text = extrasPrice.ToString("c") + " Each";
            messagePriceLabel.Text = messagePrice.ToString("c");
        }

        private void displaySummaryButton_Click(object sender, EventArgs e)
        {
            // To display each extra chosen on a new line in the summary message box
            string extrasList = "";

            for (int counter = 0; counter < extrasListBox.Items.Count; counter++)
            {
                if (extrasListBox.GetSelected(counter))
                {
                    extrasList += extrasListBox.Items[counter] + "\n";
                    extrasCount++;
                    UpdateTotals(); // Updates the extra price for the order total
                }
            }
            
            // To check that first and last name were entered before displaying summary
            if (firstNameTextBox.Text == "" || lastNameTextBox.Text == "")
            {
                MessageBox.Show("Customer Name is incomplete.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                extrasCount = 0;
                extrasListBox.ClearSelected(); // Allows the decrease in total seem more logical
                UpdateTotals();
                // This is odd since it makes the order totals decrease
                // But it does show the correct amounts in the order summary
                // I wasn't able to make the extras price show up in real time, only after clicking the display summary button
            }
            else
            {
                // To check if phone number is complete
                if (phoneMaskedTextBox.MaskCompleted)
                {
                    // Display a message box with a summary of all information provided on the form
                    MessageBox.Show("Bonnie's Balloons Order Summary\n" +
                        "\nCustomer Name: " + titleComboBox.Text + " " + firstNameTextBox.Text + " " + lastNameTextBox.Text +
                        "\nCustomer Address: " + streetTextBox.Text + " " + cityTextBox.Text + " " + stateMaskedTextBox.Text +
                        " " + zipMaskedTextBox.Text +
                        "\nCustomer Phone: " + phoneMaskedTextBox.Text +
                        "\nDelivery Date: " + deliveryDateMaskedTextBox.Text +
                        "\nDelivery Type: " + deliveryType +
                        "\nBundle Size: " + bundleSize +
                        "\nOccasion: " + occasionComboBox.Text +
                        "\nExtras: " + "\n" + extrasList +
                        "Message: " + messageTextBox.Text +
                        "\nSubtotal: " + subtotalPrice.ToString("c") +
                        "\nSales Tax: " + salesTaxPrice.ToString("c") +
                        "\nOrder Total: " + orderTotalPrice.ToString("c"),
                        "Order Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm(); // Custom method to reset form after displaying order summary
                }
                else
                {
                    // Error message for missing phone number
                    MessageBox.Show("Phone number is incomplete", "Missing Information", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    extrasCount = 0;
                    extrasListBox.ClearSelected(); // Allows the decrease in total seem more logical
                    UpdateTotals();
                    // This is odd since it makes the order totals decrease
                    // But it does show the correct amounts in the order summary
                    // I wasn't able to make the extras price show up in real time, only after clicking the button
                }
            }
        }

        private void exitProgramButton_Click(object sender, EventArgs e)
        {
            // To add a confirmation box before quitting the application
            // Declare variable to hold user selection in dialog box
            DialogResult selection;
            selection = MessageBox.Show("Are you sure you wish to quit?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Take action based on user selection in dialog box
            if (selection == DialogResult.Yes)
            {
                // To close the form
                this.Close();
            }
        }

        private void messageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (messageCheckBox.Checked)
            {
                // Enables message box if check box is checked
                messageTextBox.Enabled = true;
                messagePriceLabel.Enabled = true;
            }
            else
            {
                // To disable and clear message box if check box is unchecked
                messageTextBox.Enabled = false;
                messagePriceLabel.Enabled = false;
                messageTextBox.Text = "";
            }
            UpdateTotals(); // Custom method to update totals

        }

        // Custom method for populating the list box and combo box in the form
        private void PopulateListBox() // Custom method to populate listbox and combobox
        {
            try
            {
                // To populate the extras list box
                StreamReader inputFile;
                extrasListBox.Items.Clear();
                inputFile = File.OpenText("Extras.txt");
                while (!inputFile.EndOfStream)
                {
                    extrasListBox.Items.Add(inputFile.ReadLine());
                }
                inputFile.Close();

                // To populate the occasion combo box
                StreamReader inputText;
                occasionComboBox.Items.Clear();
                inputText = File.OpenText("Occasions.txt");
                while (!inputText.EndOfStream)
                {
                    occasionComboBox.Items.Add(inputText.ReadLine());
                }
                inputText.Close();

            }
            catch (Exception ex)
            {
                // Default error message in case list box can't be populated
                MessageBox.Show(ex.Message);
            }
           
        }

        private void homeDeliveryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // To store delivery type in a variable to show in summary message mox
            if (homeDeliveryRadioButton.Checked)
            {
                deliveryType = homeDeliveryRadioButton.Text;
            }
            else
            {
                deliveryType = pickUpRadioButton.Text;
            }
            UpdateTotals();
        }

        private void singleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // To store bundle size in a variable to show in summary message box
            if (singleRadioButton.Checked)
            {
                bundleSize = singleRadioButton.Text;
            }
            else if (halfDozenRadioButton.Checked)
            {
                bundleSize = halfDozenRadioButton.Text;
            }
            else
            {
                bundleSize = dozenRadioButton.Text;
            }
            UpdateTotals();
        }

        private void UpdateTotals() // Custom method for updating totals
        {
            // Stores delivery price in a variable to be used in calculating subtotal
            if (homeDeliveryRadioButton.Checked)
            {
                deliveryPrice = homeDeliveryPrice;
            }
            else
            {
                deliveryPrice = pickUpPrice;
            }
            // Stores bundle price in a variable to be used in calculating subtotal
            if (singleRadioButton.Checked)
            {
                bundlePrice = singlePrice;
            }
            else if (halfDozenRadioButton.Checked)
            {
                bundlePrice = halfDozenPrice;
            }
            else
            {
                bundlePrice = dozenPrice;
            }
            // Stores message price in a variable to be used in calculating subtotal
            if (messageCheckBox.Checked)
            {
                messageSubtotal = messagePrice;              
            }
            else
            {
                messageSubtotal = 0;
            }

            // Formulas for calculating totals
            extrasSubtotal = extrasCount * extrasPrice;
            subtotalPrice = deliveryPrice + bundlePrice + messageSubtotal + extrasSubtotal;  // To calculate subtotal
            salesTaxPrice = subtotalPrice * TAX_RATE;                                        // To calculate sales tax
            orderTotalPrice = subtotalPrice + salesTaxPrice;                                 // To calculate order total
            
            // To display totals in labels on the form
            subtotalPriceLabel.Text = subtotalPrice.ToString("c");
            salesTaxPriceLabel.Text = salesTaxPrice.ToString("c");
            orderTotalPriceLabel.Text = orderTotalPrice.ToString("c");
        }

        private void ResetForm() // Custom method to clear/reset the form
        {
            titleComboBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            streetTextBox.Text = "";
            cityTextBox.Text = "";
            stateMaskedTextBox.Text = "";
            zipMaskedTextBox.Text = "";
            phoneMaskedTextBox.Text = "";
            deliveryDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
            pickUpRadioButton.Checked = true;
            singleRadioButton.Checked = true;
            occasionComboBox.SelectedItem = "Birthday";
            extrasListBox.ClearSelected();
            extrasSubtotal = 0;
            extrasCount = 0;
            messageCheckBox.Checked = false;
            UpdateTotals(); // To reset the order totals to the default settings

            // To send focus back to the first control on the form
            titleComboBox.Focus();
        }

        private void clearFormButton_Click(object sender, EventArgs e)
        {
            ResetForm(); // Custom method to clear the form
        }

        private void extrasListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // I tried deleting this but all I ended up doing was making another event handler.
        }

        private void extrasListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // See comment above.
        }

        private void stateMaskedTextBox_Leave(object sender, EventArgs e)
        {
            // Forces upper case letters in statemaskedtextbox
            stateMaskedTextBox.Text = stateMaskedTextBox.Text.ToUpper();
        }
    }
}