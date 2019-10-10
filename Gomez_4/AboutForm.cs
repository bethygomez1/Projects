// Programmer: Bethy Gomez
// Project: Gomez_4
// Date Due: 04/23/2018
// Description: AboutForm; Assignment #4; To display an instance of a class

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomez_4
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Close form; returning program execution control to RegistrationForm
            this.Close();
        }
    }
}
