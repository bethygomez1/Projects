// Programmer: Bethy Gomez
// Project: Gomez_4
// Date Due: 04/23/2018
// Description: RegistrationForm; Assignment #4; Form for taking registration order

using System;
using System.Windows.Forms;
using System.IO;

namespace Gomez_4
{
    public partial class RegistrationForm : Form
    {
        // Declare class constant variables
        private const decimal LIVEACTION_PRICE = 79.95m;
        private const decimal ANIMATION_PRICE = 99.95m;
        private const int MAX_CLASSES = 4;

        // Declare variables
        private decimal pricePerClass;
        private int classesCount = 0;
        private string paymentType = "";
        private string receiptRequest = "";
        private string classesList = "";
        private decimal totalPrice;


        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // To set the current date as default
            dateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");

            // Set default radio buttons
            liveActionRadioButton.Checked = true;
            cashRadioButton.Checked = true;

            // To add items to the combo box
            registrantStatusComboBox.Items.Add("Actor");
            registrantStatusComboBox.Items.Add("Director");
            registrantStatusComboBox.Items.Add("Animator");
            registrantStatusComboBox.Items.Add("Cinematographer");
            registrantStatusComboBox.Items.Add("Drama Teacher");
            registrantStatusComboBox.Items.Add("Light Technician");
            registrantStatusComboBox.Items.Add("Sound Technician");

            // Custom method to populate list box
            PopulateList();

            // Set selection mode for list box
            classesListBox.SelectionMode = SelectionMode.MultiSimple;
            classesListBox.Sorted = true; // To sort the list box

            // To show the max number of classes in a label using a constant
            maxClassesLabel.Text = "Max of " + MAX_CLASSES + " classes";

            receiptRequest = "No"; // To set the receipt request default

            UpdateTotals(); // To update totals when form loads
        }

        // Custom method to populate the list box with appropriate classes
        private void PopulateList()
        {
            try
            {
                // To populate list box is live action radio button is selected
                if (liveActionRadioButton.Checked)
                {
                    StreamReader inputFile;
                    classesListBox.Items.Clear();
                    inputFile = File.OpenText("LiveActionClasses.txt");
                    while (!inputFile.EndOfStream)
                    {
                        classesListBox.Items.Add(inputFile.ReadLine());
                    }
                    inputFile.Close();
                }
                // To populate list box if animation radio button is selected
                if (animationRadioButton.Checked)
                {
                    StreamReader inputText;
                    classesListBox.Items.Clear();
                    inputText = File.OpenText("AnimationClasses.txt");
                    while (!inputText.EndOfStream)
                    {
                        classesListBox.Items.Add(inputText.ReadLine());
                    }
                    inputText.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Custom method to update totals on the form
        private void UpdateTotals()
        {
            // To apply correct prices if live action radio button is selected
            if (liveActionRadioButton.Checked)
            {
                pricePerClassLabel.Text = LIVEACTION_PRICE.ToString("c");
                pricePerClass = LIVEACTION_PRICE;
            }
            else
            {
                // To apply correct prices if animation radio button is selected
                pricePerClassLabel.Text = ANIMATION_PRICE.ToString("c");
                pricePerClass = ANIMATION_PRICE;
            }

            // All of this code leads to the correct amounts in the summary message box but 
            // I couldn't get it to update in real time when the classes are selected

            // To update the classes selected label
            classesSelectedLabel.Text = classesCount.ToString("");

            // To increment class counter when list box items are selected
            for (int counter = 0; counter < classesListBox.Items.Count; counter++)
            {
                if (classesListBox.GetSelected(counter))
                {
                    classesList += classesListBox.Items[counter] + "\n";
                    classesCount++;
                    classesSelectedLabel.Text = classesCount.ToString("");
                }
            }
            // To calculate total order price
            totalPrice = classesCount * pricePerClass;
            // To display total order cost
            totalOrderCostLabel.Text = totalPrice.ToString("c");


        }

        // Custom method to reset the form
        private void ResetForm()
        {
            // To clear/reset all controls on the form
            dateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            dateOfBirthMaskedTextBox.Text = "";
            registrantStatusComboBox.Text = "";
            liveActionRadioButton.Checked = true;
            classesListBox.ClearSelected();
            classesCount = 0;
            cashRadioButton.Checked = true;
            receiptRequestCheckBox.Checked = false;
            PopulateList();
            UpdateTotals();

            // Send focus to first control
            dateMaskedTextBox.Focus();
        }

        private void liveActionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Event handler used in case radio button is changed to populate list box with correct classes
            PopulateList();

            // To update the price per class label depending on class type selected
            UpdateTotals();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // To display error message if first or last name is not entered
            if (firstNameTextBox.Text == "" || lastNameTextBox.Text == "")
            {
                MessageBox.Show("Customer Name is incomplete.", "Missing Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            // To display error message if email is not entered
            else if (emailTextBox.Text == "")
            {
                MessageBox.Show("Customer Email is required", "Missing Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            // To dsiplay an error message if no classes are selected
            else if (classesListBox.SelectedIndex == -1)
            {
                MessageBox.Show("At least 1 class is required", "Missing Information", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // To display an error message if more than the max number of classes are selected
            else if (classesListBox.SelectedIndices.Count > 4)
            {
                MessageBox.Show("A maximum of " + MAX_CLASSES.ToString("") + " classes can be selected", 
                    "Invalid Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Determine if date of birth is entered before displaying summary
                if (dateOfBirthMaskedTextBox.MaskCompleted)
                {

                        UpdateTotals(); // To make sure that the message box displays the correct totals

                        // To display a summary of information on the form
                        MessageBox.Show("Hopkins Film School Registration Information\n" +
                            "\nRegistration Date: " + dateMaskedTextBox.Text +
                            "\nRegistrant Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text +
                            "\nEmail Address: " + emailTextBox.Text +
                            "\nDate of Birth: " + dateOfBirthMaskedTextBox.Text +
                            "\nRegistrant Status: " + registrantStatusComboBox.Text +
                            "\nClasses Selected:\n" + classesList +
                            "Number of Classes Selected: " + classesCount +
                            "\nPrice Per Class: " + pricePerClass +
                            "\nTotal Order Price: " + totalPrice.ToString("c") +
                            "\nPayment Method: " + paymentType +
                            "\nEmail Receipt Requested: " + receiptRequest,
                            " Registration Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Try-catch to save information to external data file
                        try
                        {
                            StreamWriter outputFile; // StreamWriter object for use in writing file
                            outputFile = File.AppendText("RegistrationData.txt"); // To specify the file
                                                                                  // Write all data to file
                            outputFile.WriteLine("Date: " + dateMaskedTextBox.Text);
                            outputFile.WriteLine("Registrant Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text);
                            outputFile.WriteLine("Email Address: " + emailTextBox.Text);
                            outputFile.WriteLine("Date of Birth: " + dateOfBirthMaskedTextBox.Text);
                            outputFile.WriteLine("Registrant Status: " + registrantStatusComboBox.Text);
                            outputFile.WriteLine("Classes Selected:");
                            for (int count = 0; count < classesListBox.Items.Count; count++)
                            {
                                if (classesListBox.GetSelected(count))
                                {
                                    // To display list box items on a separate line
                                    outputFile.WriteLine(classesListBox.Items[count]);
                                }
                            }
                            outputFile.WriteLine("Number of Classes Selected: " + classesCount);
                            outputFile.WriteLine("Price Per Class: " + pricePerClass);
                            outputFile.WriteLine("Total Order Price: " + totalPrice.ToString("c"));
                            outputFile.WriteLine("Payment Method: " + paymentType);
                            outputFile.WriteLine("Email Receipt Requested: " + receiptRequest);
                            outputFile.WriteLine(); // Blank line to seperate properties
                            outputFile.Close(); // Close output file after writing data
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        ResetForm(); // To reset the form after summary is displayed
                }
                // To display error message if date of birth is not entered
                else
                {
                    MessageBox.Show("Date of Birth is incomplete", "Missing Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To reset the form with custom method
            ResetForm();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To add a confirmation box before quitting the application
            // Declare variable to hold user selection in dialog box
            DialogResult selection;
            selection = MessageBox.Show("Are you sure you wish to exit the program?", 
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Take action based on user selection in dialog box
            if (selection == DialogResult.Yes)
            {
                // To close the program
                this.Close();
            }
        }

        // To determine the payment method when saving information
        private void cashRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (cashRadioButton.Checked)
            {
                // To specify cash as payment method
                paymentType = cashRadioButton.Text;
            }
            else
            {
                // To specify check as the payment method
                paymentType = checkRadioButton.Text;
            }
        }

        // To determine if email receipt is requested
        private void receiptRequestCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (receiptRequestCheckBox.Checked)
            {
                receiptRequest = "Yes";
            }
            else
            {
                receiptRequest = "No";
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of the AboutForm form class
            AboutForm myAboutForm = new AboutForm();

            // Display AboutForm instance as a model form
            myAboutForm.ShowDialog();
        }
    }
}
