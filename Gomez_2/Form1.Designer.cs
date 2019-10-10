namespace Gomez_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.langPictureBox = new System.Windows.Forms.PictureBox();
            this.termInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.springRadioButton = new System.Windows.Forms.RadioButton();
            this.fallRadioButton = new System.Windows.Forms.RadioButton();
            this.studentInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.outOfStateRadioButton = new System.Windows.Forms.RadioButton();
            this.inStateRadioButton = new System.Windows.Forms.RadioButton();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.studentIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.courseOrderInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.spanishPriceLabel = new System.Windows.Forms.Label();
            this.russianPriceLabel = new System.Windows.Forms.Label();
            this.italianPriceLabel = new System.Windows.Forms.Label();
            this.germanPriceLabel = new System.Windows.Forms.Label();
            this.frenchPriceLabel = new System.Windows.Forms.Label();
            this.spanishCheckBox = new System.Windows.Forms.CheckBox();
            this.russianCheckBox = new System.Windows.Forms.CheckBox();
            this.italianCheckBox = new System.Windows.Forms.CheckBox();
            this.germanCheckBox = new System.Windows.Forms.CheckBox();
            this.frenchCheckBox = new System.Windows.Forms.CheckBox();
            this.paymentInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.expDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cardNumberTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.visaRadioButton = new System.Windows.Forms.RadioButton();
            this.masterCardRadioButton = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.coursesLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.saveToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.clearToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.exitToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.langPictureBox)).BeginInit();
            this.termInfoGroupBox.SuspendLayout();
            this.studentInfoGroupBox.SuspendLayout();
            this.courseOrderInfoGroupBox.SuspendLayout();
            this.paymentInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // langPictureBox
            // 
            this.langPictureBox.Image = global::Gomez_2.Properties.Resources.langpic;
            this.langPictureBox.Location = new System.Drawing.Point(12, 12);
            this.langPictureBox.Name = "langPictureBox";
            this.langPictureBox.Size = new System.Drawing.Size(340, 100);
            this.langPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.langPictureBox.TabIndex = 0;
            this.langPictureBox.TabStop = false;
            // 
            // termInfoGroupBox
            // 
            this.termInfoGroupBox.Controls.Add(this.yearComboBox);
            this.termInfoGroupBox.Controls.Add(this.springRadioButton);
            this.termInfoGroupBox.Controls.Add(this.fallRadioButton);
            this.termInfoGroupBox.Location = new System.Drawing.Point(12, 118);
            this.termInfoGroupBox.Name = "termInfoGroupBox";
            this.termInfoGroupBox.Size = new System.Drawing.Size(340, 54);
            this.termInfoGroupBox.TabIndex = 0;
            this.termInfoGroupBox.TabStop = false;
            this.termInfoGroupBox.Text = "Term Information";
            // 
            // yearComboBox
            // 
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(196, 15);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(121, 21);
            this.yearComboBox.TabIndex = 2;
            // 
            // springRadioButton
            // 
            this.springRadioButton.AutoSize = true;
            this.springRadioButton.Location = new System.Drawing.Point(112, 19);
            this.springRadioButton.Name = "springRadioButton";
            this.springRadioButton.Size = new System.Drawing.Size(55, 17);
            this.springRadioButton.TabIndex = 1;
            this.springRadioButton.Text = "Spring";
            this.springRadioButton.UseVisualStyleBackColor = true;
            this.springRadioButton.CheckedChanged += new System.EventHandler(this.springRadioButton_CheckedChanged);
            // 
            // fallRadioButton
            // 
            this.fallRadioButton.AutoSize = true;
            this.fallRadioButton.Checked = true;
            this.fallRadioButton.Location = new System.Drawing.Point(37, 19);
            this.fallRadioButton.Name = "fallRadioButton";
            this.fallRadioButton.Size = new System.Drawing.Size(41, 17);
            this.fallRadioButton.TabIndex = 0;
            this.fallRadioButton.TabStop = true;
            this.fallRadioButton.Text = "Fall";
            this.fallRadioButton.UseVisualStyleBackColor = true;
            this.fallRadioButton.CheckedChanged += new System.EventHandler(this.fallRadioButton_CheckedChanged);
            // 
            // studentInfoGroupBox
            // 
            this.studentInfoGroupBox.Controls.Add(this.label5);
            this.studentInfoGroupBox.Controls.Add(this.outOfStateRadioButton);
            this.studentInfoGroupBox.Controls.Add(this.inStateRadioButton);
            this.studentInfoGroupBox.Controls.Add(this.emailTextBox);
            this.studentInfoGroupBox.Controls.Add(this.lastNameTextBox);
            this.studentInfoGroupBox.Controls.Add(this.firstNameTextBox);
            this.studentInfoGroupBox.Controls.Add(this.studentIDMaskedTextBox);
            this.studentInfoGroupBox.Controls.Add(this.label4);
            this.studentInfoGroupBox.Controls.Add(this.label3);
            this.studentInfoGroupBox.Controls.Add(this.label2);
            this.studentInfoGroupBox.Controls.Add(this.label1);
            this.studentInfoGroupBox.Location = new System.Drawing.Point(12, 178);
            this.studentInfoGroupBox.Name = "studentInfoGroupBox";
            this.studentInfoGroupBox.Size = new System.Drawing.Size(340, 139);
            this.studentInfoGroupBox.TabIndex = 1;
            this.studentInfoGroupBox.TabStop = false;
            this.studentInfoGroupBox.Text = "Student Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Residence:";
            // 
            // outOfStateRadioButton
            // 
            this.outOfStateRadioButton.AutoSize = true;
            this.outOfStateRadioButton.Location = new System.Drawing.Point(196, 114);
            this.outOfStateRadioButton.Name = "outOfStateRadioButton";
            this.outOfStateRadioButton.Size = new System.Drawing.Size(84, 17);
            this.outOfStateRadioButton.TabIndex = 10;
            this.outOfStateRadioButton.Text = "Out-Of-State";
            this.outOfStateRadioButton.UseVisualStyleBackColor = true;
            this.outOfStateRadioButton.CheckedChanged += new System.EventHandler(this.outOfStateRadioButton_CheckedChanged);
            // 
            // inStateRadioButton
            // 
            this.inStateRadioButton.AutoSize = true;
            this.inStateRadioButton.Checked = true;
            this.inStateRadioButton.Location = new System.Drawing.Point(112, 116);
            this.inStateRadioButton.Name = "inStateRadioButton";
            this.inStateRadioButton.Size = new System.Drawing.Size(62, 17);
            this.inStateRadioButton.TabIndex = 9;
            this.inStateRadioButton.TabStop = true;
            this.inStateRadioButton.Text = "In-State";
            this.inStateRadioButton.UseVisualStyleBackColor = true;
            this.inStateRadioButton.CheckedChanged += new System.EventHandler(this.inStateRadioButton_CheckedChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(112, 87);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(146, 20);
            this.emailTextBox.TabIndex = 7;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(112, 61);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(112, 36);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // studentIDMaskedTextBox
            // 
            this.studentIDMaskedTextBox.Location = new System.Drawing.Point(112, 13);
            this.studentIDMaskedTextBox.Mask = "000-00-0000";
            this.studentIDMaskedTextBox.Name = "studentIDMaskedTextBox";
            this.studentIDMaskedTextBox.Size = new System.Drawing.Size(67, 20);
            this.studentIDMaskedTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // courseOrderInfoGroupBox
            // 
            this.courseOrderInfoGroupBox.Controls.Add(this.spanishPriceLabel);
            this.courseOrderInfoGroupBox.Controls.Add(this.russianPriceLabel);
            this.courseOrderInfoGroupBox.Controls.Add(this.italianPriceLabel);
            this.courseOrderInfoGroupBox.Controls.Add(this.germanPriceLabel);
            this.courseOrderInfoGroupBox.Controls.Add(this.frenchPriceLabel);
            this.courseOrderInfoGroupBox.Controls.Add(this.spanishCheckBox);
            this.courseOrderInfoGroupBox.Controls.Add(this.russianCheckBox);
            this.courseOrderInfoGroupBox.Controls.Add(this.italianCheckBox);
            this.courseOrderInfoGroupBox.Controls.Add(this.germanCheckBox);
            this.courseOrderInfoGroupBox.Controls.Add(this.frenchCheckBox);
            this.courseOrderInfoGroupBox.Location = new System.Drawing.Point(12, 323);
            this.courseOrderInfoGroupBox.Name = "courseOrderInfoGroupBox";
            this.courseOrderInfoGroupBox.Size = new System.Drawing.Size(340, 144);
            this.courseOrderInfoGroupBox.TabIndex = 2;
            this.courseOrderInfoGroupBox.TabStop = false;
            this.courseOrderInfoGroupBox.Text = "Course Order Information";
            // 
            // spanishPriceLabel
            // 
            this.spanishPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spanishPriceLabel.Location = new System.Drawing.Point(161, 113);
            this.spanishPriceLabel.Name = "spanishPriceLabel";
            this.spanishPriceLabel.Size = new System.Drawing.Size(71, 20);
            this.spanishPriceLabel.TabIndex = 9;
            this.spanishPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // russianPriceLabel
            // 
            this.russianPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.russianPriceLabel.Location = new System.Drawing.Point(161, 89);
            this.russianPriceLabel.Name = "russianPriceLabel";
            this.russianPriceLabel.Size = new System.Drawing.Size(71, 20);
            this.russianPriceLabel.TabIndex = 7;
            this.russianPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // italianPriceLabel
            // 
            this.italianPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.italianPriceLabel.Location = new System.Drawing.Point(161, 65);
            this.italianPriceLabel.Name = "italianPriceLabel";
            this.italianPriceLabel.Size = new System.Drawing.Size(71, 20);
            this.italianPriceLabel.TabIndex = 5;
            this.italianPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // germanPriceLabel
            // 
            this.germanPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.germanPriceLabel.Location = new System.Drawing.Point(161, 41);
            this.germanPriceLabel.Name = "germanPriceLabel";
            this.germanPriceLabel.Size = new System.Drawing.Size(71, 20);
            this.germanPriceLabel.TabIndex = 3;
            this.germanPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frenchPriceLabel
            // 
            this.frenchPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frenchPriceLabel.Location = new System.Drawing.Point(161, 17);
            this.frenchPriceLabel.Name = "frenchPriceLabel";
            this.frenchPriceLabel.Size = new System.Drawing.Size(71, 20);
            this.frenchPriceLabel.TabIndex = 1;
            this.frenchPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spanishCheckBox
            // 
            this.spanishCheckBox.AutoSize = true;
            this.spanishCheckBox.Location = new System.Drawing.Point(22, 116);
            this.spanishCheckBox.Name = "spanishCheckBox";
            this.spanishCheckBox.Size = new System.Drawing.Size(114, 17);
            this.spanishCheckBox.TabIndex = 8;
            this.spanishCheckBox.Text = "Beginning Spanish";
            this.spanishCheckBox.UseVisualStyleBackColor = true;
            this.spanishCheckBox.CheckedChanged += new System.EventHandler(this.frenchCheckBox_CheckedChanged);
            // 
            // russianCheckBox
            // 
            this.russianCheckBox.AutoSize = true;
            this.russianCheckBox.Location = new System.Drawing.Point(22, 92);
            this.russianCheckBox.Name = "russianCheckBox";
            this.russianCheckBox.Size = new System.Drawing.Size(114, 17);
            this.russianCheckBox.TabIndex = 6;
            this.russianCheckBox.Text = "Beginning Russian";
            this.russianCheckBox.UseVisualStyleBackColor = true;
            this.russianCheckBox.CheckedChanged += new System.EventHandler(this.frenchCheckBox_CheckedChanged);
            // 
            // italianCheckBox
            // 
            this.italianCheckBox.AutoSize = true;
            this.italianCheckBox.Location = new System.Drawing.Point(22, 68);
            this.italianCheckBox.Name = "italianCheckBox";
            this.italianCheckBox.Size = new System.Drawing.Size(104, 17);
            this.italianCheckBox.TabIndex = 4;
            this.italianCheckBox.Text = "Beginning Italian";
            this.italianCheckBox.UseVisualStyleBackColor = true;
            this.italianCheckBox.CheckedChanged += new System.EventHandler(this.frenchCheckBox_CheckedChanged);
            // 
            // germanCheckBox
            // 
            this.germanCheckBox.AutoSize = true;
            this.germanCheckBox.Location = new System.Drawing.Point(22, 44);
            this.germanCheckBox.Name = "germanCheckBox";
            this.germanCheckBox.Size = new System.Drawing.Size(113, 17);
            this.germanCheckBox.TabIndex = 2;
            this.germanCheckBox.Text = "Beginning German";
            this.germanCheckBox.UseVisualStyleBackColor = true;
            this.germanCheckBox.CheckedChanged += new System.EventHandler(this.frenchCheckBox_CheckedChanged);
            // 
            // frenchCheckBox
            // 
            this.frenchCheckBox.AutoSize = true;
            this.frenchCheckBox.Location = new System.Drawing.Point(22, 20);
            this.frenchCheckBox.Name = "frenchCheckBox";
            this.frenchCheckBox.Size = new System.Drawing.Size(109, 17);
            this.frenchCheckBox.TabIndex = 0;
            this.frenchCheckBox.Text = "Beginning French";
            this.frenchCheckBox.UseVisualStyleBackColor = true;
            this.frenchCheckBox.CheckedChanged += new System.EventHandler(this.frenchCheckBox_CheckedChanged);
            // 
            // paymentInfoGroupBox
            // 
            this.paymentInfoGroupBox.Controls.Add(this.label6);
            this.paymentInfoGroupBox.Controls.Add(this.expDateMaskedTextBox);
            this.paymentInfoGroupBox.Controls.Add(this.cardNumberTextBox);
            this.paymentInfoGroupBox.Controls.Add(this.label12);
            this.paymentInfoGroupBox.Controls.Add(this.label11);
            this.paymentInfoGroupBox.Controls.Add(this.visaRadioButton);
            this.paymentInfoGroupBox.Controls.Add(this.masterCardRadioButton);
            this.paymentInfoGroupBox.Location = new System.Drawing.Point(12, 473);
            this.paymentInfoGroupBox.Name = "paymentInfoGroupBox";
            this.paymentInfoGroupBox.Size = new System.Drawing.Size(340, 96);
            this.paymentInfoGroupBox.TabIndex = 4;
            this.paymentInfoGroupBox.TabStop = false;
            this.paymentInfoGroupBox.Text = "Payment Information";
            // 
            // expDateMaskedTextBox
            // 
            this.expDateMaskedTextBox.Location = new System.Drawing.Point(137, 68);
            this.expDateMaskedTextBox.Mask = "00/00/0000";
            this.expDateMaskedTextBox.Name = "expDateMaskedTextBox";
            this.expDateMaskedTextBox.Size = new System.Drawing.Size(68, 20);
            this.expDateMaskedTextBox.TabIndex = 5;
            this.expDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // cardNumberTextBox
            // 
            this.cardNumberTextBox.Location = new System.Drawing.Point(137, 42);
            this.cardNumberTextBox.MaxLength = 16;
            this.cardNumberTextBox.Name = "cardNumberTextBox";
            this.cardNumberTextBox.Size = new System.Drawing.Size(121, 20);
            this.cardNumberTextBox.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Expiration Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Card Number:";
            // 
            // visaRadioButton
            // 
            this.visaRadioButton.AutoSize = true;
            this.visaRadioButton.Location = new System.Drawing.Point(242, 19);
            this.visaRadioButton.Name = "visaRadioButton";
            this.visaRadioButton.Size = new System.Drawing.Size(45, 17);
            this.visaRadioButton.TabIndex = 1;
            this.visaRadioButton.Text = "Visa";
            this.visaRadioButton.UseVisualStyleBackColor = true;
            this.visaRadioButton.CheckedChanged += new System.EventHandler(this.visaRadioButton_CheckedChanged);
            // 
            // masterCardRadioButton
            // 
            this.masterCardRadioButton.AutoSize = true;
            this.masterCardRadioButton.Checked = true;
            this.masterCardRadioButton.Location = new System.Drawing.Point(137, 19);
            this.masterCardRadioButton.Name = "masterCardRadioButton";
            this.masterCardRadioButton.Size = new System.Drawing.Size(79, 17);
            this.masterCardRadioButton.TabIndex = 0;
            this.masterCardRadioButton.TabStop = true;
            this.masterCardRadioButton.Text = "MasterCard";
            this.masterCardRadioButton.UseVisualStyleBackColor = true;
            this.masterCardRadioButton.CheckedChanged += new System.EventHandler(this.masterCardRadioButton_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(64, 582);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Total Number of Courses:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(125, 611);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Total Price:";
            // 
            // coursesLabel
            // 
            this.coursesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coursesLabel.Location = new System.Drawing.Point(208, 572);
            this.coursesLabel.Name = "coursesLabel";
            this.coursesLabel.Size = new System.Drawing.Size(62, 23);
            this.coursesLabel.TabIndex = 6;
            this.coursesLabel.Text = "X";
            this.coursesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceLabel.Location = new System.Drawing.Point(208, 601);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(62, 23);
            this.totalPriceLabel.TabIndex = 8;
            this.totalPriceLabel.Text = "$X.XX";
            this.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(34, 642);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "&Save";
            this.saveToolTip.SetToolTip(this.saveButton, "Save new order information");
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(142, 642);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "&Clear";
            this.saveToolTip.SetToolTip(this.clearButton, "Clear all information");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(254, 642);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "E&xit";
            this.exitToolTip.SetToolTip(this.exitButton, "Exit the program");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Credit Card Type:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 677);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.coursesLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.paymentInfoGroupBox);
            this.Controls.Add(this.courseOrderInfoGroupBox);
            this.Controls.Add(this.studentInfoGroupBox);
            this.Controls.Add(this.termInfoGroupBox);
            this.Controls.Add(this.langPictureBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Language Arts Institute";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.langPictureBox)).EndInit();
            this.termInfoGroupBox.ResumeLayout(false);
            this.termInfoGroupBox.PerformLayout();
            this.studentInfoGroupBox.ResumeLayout(false);
            this.studentInfoGroupBox.PerformLayout();
            this.courseOrderInfoGroupBox.ResumeLayout(false);
            this.courseOrderInfoGroupBox.PerformLayout();
            this.paymentInfoGroupBox.ResumeLayout(false);
            this.paymentInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox langPictureBox;
        private System.Windows.Forms.GroupBox termInfoGroupBox;
        private System.Windows.Forms.GroupBox studentInfoGroupBox;
        private System.Windows.Forms.GroupBox courseOrderInfoGroupBox;
        private System.Windows.Forms.GroupBox paymentInfoGroupBox;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.RadioButton springRadioButton;
        private System.Windows.Forms.RadioButton fallRadioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton outOfStateRadioButton;
        private System.Windows.Forms.RadioButton inStateRadioButton;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.MaskedTextBox studentIDMaskedTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label spanishPriceLabel;
        private System.Windows.Forms.Label russianPriceLabel;
        private System.Windows.Forms.Label italianPriceLabel;
        private System.Windows.Forms.Label germanPriceLabel;
        private System.Windows.Forms.Label frenchPriceLabel;
        private System.Windows.Forms.CheckBox spanishCheckBox;
        private System.Windows.Forms.CheckBox russianCheckBox;
        private System.Windows.Forms.CheckBox italianCheckBox;
        private System.Windows.Forms.CheckBox germanCheckBox;
        private System.Windows.Forms.CheckBox frenchCheckBox;
        private System.Windows.Forms.MaskedTextBox expDateMaskedTextBox;
        private System.Windows.Forms.TextBox cardNumberTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton visaRadioButton;
        private System.Windows.Forms.RadioButton masterCardRadioButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label coursesLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolTip saveToolTip;
        private System.Windows.Forms.ToolTip exitToolTip;
        private System.Windows.Forms.ToolTip clearToolTip;
        private System.Windows.Forms.Label label6;
    }
}

