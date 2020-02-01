namespace Assign_2
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
            this.CommunitiesGroupBox = new System.Windows.Forms.GroupBox();
            this.SycamoreRadioButton = new System.Windows.Forms.RadioButton();
            this.DekalbRadioButton = new System.Windows.Forms.RadioButton();
            this.ANRGroupBox = new System.Windows.Forms.GroupBox();
            this.GAddResidentButton = new System.Windows.Forms.Button();
            this.ResidenceCombobox = new System.Windows.Forms.ComboBox();
            this.ResidenceLabel = new System.Windows.Forms.Label();
            this.BithdayLabel = new System.Windows.Forms.Label();
            this.BirthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.OccupationTextbox = new System.Windows.Forms.TextBox();
            this.OccupationLabel = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.OutputTextbox = new System.Windows.Forms.TextBox();
            this.AddPropertyGroupBox = new System.Windows.Forms.GroupBox();
            this.PersonTextbox = new System.Windows.Forms.TextBox();
            this.ResidenceTextbox = new System.Windows.Forms.TextBox();
            this.StreetAddressLabel = new System.Windows.Forms.Label();
            this.StreetAddressTextbox = new System.Windows.Forms.TextBox();
            this.AptNumTextbox = new System.Windows.Forms.TextBox();
            this.PersonOutputLabel = new System.Windows.Forms.Label();
            this.ResidenceOutputLabel = new System.Windows.Forms.Label();
            this.SquareFtLabel = new System.Windows.Forms.Label();
            this.AptLabel = new System.Windows.Forms.Label();
            this.SquareFtUpDown = new System.Windows.Forms.NumericUpDown();
            this.BedroomsLabel = new System.Windows.Forms.Label();
            this.BathsLabel = new System.Windows.Forms.Label();
            this.FloorsLabel = new System.Windows.Forms.Label();
            this.GAddPropertyButton = new System.Windows.Forms.Button();
            this.GarageCheckbox = new System.Windows.Forms.CheckBox();
            this.BedroomsUpDown = new System.Windows.Forms.NumericUpDown();
            this.BathsUpDown = new System.Windows.Forms.NumericUpDown();
            this.FloorsUpDown = new System.Windows.Forms.NumericUpDown();
            this.ForSaleButton = new System.Windows.Forms.Button();
            this.BuyPropertyButton = new System.Windows.Forms.Button();
            this.AddResidentButton = new System.Windows.Forms.Button();
            this.RemoveResidentButton = new System.Windows.Forms.Button();
            this.CommunitiesGroupBox.SuspendLayout();
            this.ANRGroupBox.SuspendLayout();
            this.AddPropertyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SquareFtUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BedroomsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BathsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FloorsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CommunitiesGroupBox
            // 
            this.CommunitiesGroupBox.Controls.Add(this.SycamoreRadioButton);
            this.CommunitiesGroupBox.Controls.Add(this.DekalbRadioButton);
            this.CommunitiesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommunitiesGroupBox.Location = new System.Drawing.Point(12, 12);
            this.CommunitiesGroupBox.Name = "CommunitiesGroupBox";
            this.CommunitiesGroupBox.Size = new System.Drawing.Size(200, 76);
            this.CommunitiesGroupBox.TabIndex = 0;
            this.CommunitiesGroupBox.TabStop = false;
            this.CommunitiesGroupBox.Text = "Communities";
            // 
            // SycamoreRadioButton
            // 
            this.SycamoreRadioButton.AutoSize = true;
            this.SycamoreRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SycamoreRadioButton.Location = new System.Drawing.Point(7, 44);
            this.SycamoreRadioButton.Name = "SycamoreRadioButton";
            this.SycamoreRadioButton.Size = new System.Drawing.Size(94, 22);
            this.SycamoreRadioButton.TabIndex = 1;
            this.SycamoreRadioButton.TabStop = true;
            this.SycamoreRadioButton.Text = "Sycamore";
            this.SycamoreRadioButton.UseVisualStyleBackColor = true;
            // 
            // DekalbRadioButton
            // 
            this.DekalbRadioButton.AutoSize = true;
            this.DekalbRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DekalbRadioButton.Location = new System.Drawing.Point(7, 20);
            this.DekalbRadioButton.Name = "DekalbRadioButton";
            this.DekalbRadioButton.Size = new System.Drawing.Size(72, 22);
            this.DekalbRadioButton.TabIndex = 0;
            this.DekalbRadioButton.TabStop = true;
            this.DekalbRadioButton.Text = "Dekalb";
            this.DekalbRadioButton.UseVisualStyleBackColor = true;
            // 
            // ANRGroupBox
            // 
            this.ANRGroupBox.Controls.Add(this.GAddResidentButton);
            this.ANRGroupBox.Controls.Add(this.ResidenceCombobox);
            this.ANRGroupBox.Controls.Add(this.ResidenceLabel);
            this.ANRGroupBox.Controls.Add(this.BithdayLabel);
            this.ANRGroupBox.Controls.Add(this.BirthdayPicker);
            this.ANRGroupBox.Controls.Add(this.OccupationTextbox);
            this.ANRGroupBox.Controls.Add(this.OccupationLabel);
            this.ANRGroupBox.Controls.Add(this.NameTextbox);
            this.ANRGroupBox.Controls.Add(this.NameLabel);
            this.ANRGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.ANRGroupBox.Location = new System.Drawing.Point(12, 183);
            this.ANRGroupBox.Name = "ANRGroupBox";
            this.ANRGroupBox.Size = new System.Drawing.Size(236, 286);
            this.ANRGroupBox.TabIndex = 1;
            this.ANRGroupBox.TabStop = false;
            this.ANRGroupBox.Text = "Add New Resident";
            // 
            // GAddResidentButton
            // 
            this.GAddResidentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.GAddResidentButton.Location = new System.Drawing.Point(155, 248);
            this.GAddResidentButton.Name = "GAddResidentButton";
            this.GAddResidentButton.Size = new System.Drawing.Size(75, 32);
            this.GAddResidentButton.TabIndex = 8;
            this.GAddResidentButton.Text = "Add";
            this.GAddResidentButton.UseVisualStyleBackColor = true;
            // 
            // ResidenceCombobox
            // 
            this.ResidenceCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ResidenceCombobox.FormattingEnabled = true;
            this.ResidenceCombobox.Location = new System.Drawing.Point(9, 208);
            this.ResidenceCombobox.Name = "ResidenceCombobox";
            this.ResidenceCombobox.Size = new System.Drawing.Size(221, 26);
            this.ResidenceCombobox.TabIndex = 7;
            // 
            // ResidenceLabel
            // 
            this.ResidenceLabel.AutoSize = true;
            this.ResidenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ResidenceLabel.Location = new System.Drawing.Point(6, 186);
            this.ResidenceLabel.Name = "ResidenceLabel";
            this.ResidenceLabel.Size = new System.Drawing.Size(78, 18);
            this.ResidenceLabel.TabIndex = 6;
            this.ResidenceLabel.Text = "Residence";
            // 
            // BithdayLabel
            // 
            this.BithdayLabel.AutoSize = true;
            this.BithdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BithdayLabel.Location = new System.Drawing.Point(6, 133);
            this.BithdayLabel.Name = "BithdayLabel";
            this.BithdayLabel.Size = new System.Drawing.Size(61, 18);
            this.BithdayLabel.TabIndex = 5;
            this.BithdayLabel.Text = "Birthday";
            // 
            // BirthdayPicker
            // 
            this.BirthdayPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BirthdayPicker.Location = new System.Drawing.Point(7, 154);
            this.BirthdayPicker.Name = "BirthdayPicker";
            this.BirthdayPicker.Size = new System.Drawing.Size(223, 21);
            this.BirthdayPicker.TabIndex = 4;
            // 
            // OccupationTextbox
            // 
            this.OccupationTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.OccupationTextbox.Location = new System.Drawing.Point(7, 101);
            this.OccupationTextbox.Name = "OccupationTextbox";
            this.OccupationTextbox.Size = new System.Drawing.Size(223, 24);
            this.OccupationTextbox.TabIndex = 3;
            // 
            // OccupationLabel
            // 
            this.OccupationLabel.AutoSize = true;
            this.OccupationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.OccupationLabel.Location = new System.Drawing.Point(6, 79);
            this.OccupationLabel.Name = "OccupationLabel";
            this.OccupationLabel.Size = new System.Drawing.Size(84, 18);
            this.OccupationLabel.TabIndex = 2;
            this.OccupationLabel.Text = "Occupation";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NameTextbox.Location = new System.Drawing.Point(7, 47);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(223, 24);
            this.NameTextbox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NameLabel.Location = new System.Drawing.Point(6, 25);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(48, 18);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.OutputLabel.Location = new System.Drawing.Point(12, 472);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(72, 24);
            this.OutputLabel.TabIndex = 2;
            this.OutputLabel.Text = "Output";
            // 
            // OutputTextbox
            // 
            this.OutputTextbox.Location = new System.Drawing.Point(12, 499);
            this.OutputTextbox.Multiline = true;
            this.OutputTextbox.Name = "OutputTextbox";
            this.OutputTextbox.Size = new System.Drawing.Size(935, 120);
            this.OutputTextbox.TabIndex = 3;
            // 
            // AddPropertyGroupBox
            // 
            this.AddPropertyGroupBox.Controls.Add(this.FloorsUpDown);
            this.AddPropertyGroupBox.Controls.Add(this.BathsUpDown);
            this.AddPropertyGroupBox.Controls.Add(this.BedroomsUpDown);
            this.AddPropertyGroupBox.Controls.Add(this.GarageCheckbox);
            this.AddPropertyGroupBox.Controls.Add(this.GAddPropertyButton);
            this.AddPropertyGroupBox.Controls.Add(this.FloorsLabel);
            this.AddPropertyGroupBox.Controls.Add(this.BathsLabel);
            this.AddPropertyGroupBox.Controls.Add(this.BedroomsLabel);
            this.AddPropertyGroupBox.Controls.Add(this.SquareFtUpDown);
            this.AddPropertyGroupBox.Controls.Add(this.AptLabel);
            this.AddPropertyGroupBox.Controls.Add(this.SquareFtLabel);
            this.AddPropertyGroupBox.Controls.Add(this.AptNumTextbox);
            this.AddPropertyGroupBox.Controls.Add(this.StreetAddressTextbox);
            this.AddPropertyGroupBox.Controls.Add(this.StreetAddressLabel);
            this.AddPropertyGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.AddPropertyGroupBox.Location = new System.Drawing.Point(254, 183);
            this.AddPropertyGroupBox.Name = "AddPropertyGroupBox";
            this.AddPropertyGroupBox.Size = new System.Drawing.Size(231, 286);
            this.AddPropertyGroupBox.TabIndex = 4;
            this.AddPropertyGroupBox.TabStop = false;
            this.AddPropertyGroupBox.Text = "Add Property";
            // 
            // PersonTextbox
            // 
            this.PersonTextbox.Location = new System.Drawing.Point(492, 32);
            this.PersonTextbox.Multiline = true;
            this.PersonTextbox.Name = "PersonTextbox";
            this.PersonTextbox.Size = new System.Drawing.Size(221, 461);
            this.PersonTextbox.TabIndex = 5;
            // 
            // ResidenceTextbox
            // 
            this.ResidenceTextbox.Location = new System.Drawing.Point(719, 32);
            this.ResidenceTextbox.Multiline = true;
            this.ResidenceTextbox.Name = "ResidenceTextbox";
            this.ResidenceTextbox.Size = new System.Drawing.Size(228, 461);
            this.ResidenceTextbox.TabIndex = 6;
            // 
            // StreetAddressLabel
            // 
            this.StreetAddressLabel.AutoSize = true;
            this.StreetAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.StreetAddressLabel.Location = new System.Drawing.Point(6, 25);
            this.StreetAddressLabel.Name = "StreetAddressLabel";
            this.StreetAddressLabel.Size = new System.Drawing.Size(105, 18);
            this.StreetAddressLabel.TabIndex = 7;
            this.StreetAddressLabel.Text = "Street Address";
            // 
            // StreetAddressTextbox
            // 
            this.StreetAddressTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.StreetAddressTextbox.Location = new System.Drawing.Point(6, 47);
            this.StreetAddressTextbox.Name = "StreetAddressTextbox";
            this.StreetAddressTextbox.Size = new System.Drawing.Size(156, 24);
            this.StreetAddressTextbox.TabIndex = 8;
            // 
            // AptNumTextbox
            // 
            this.AptNumTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.AptNumTextbox.Location = new System.Drawing.Point(168, 47);
            this.AptNumTextbox.Name = "AptNumTextbox";
            this.AptNumTextbox.Size = new System.Drawing.Size(45, 24);
            this.AptNumTextbox.TabIndex = 9;
            // 
            // PersonOutputLabel
            // 
            this.PersonOutputLabel.AutoSize = true;
            this.PersonOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.PersonOutputLabel.Location = new System.Drawing.Point(488, 5);
            this.PersonOutputLabel.Name = "PersonOutputLabel";
            this.PersonOutputLabel.Size = new System.Drawing.Size(76, 24);
            this.PersonOutputLabel.TabIndex = 7;
            this.PersonOutputLabel.Text = "Person";
            // 
            // ResidenceOutputLabel
            // 
            this.ResidenceOutputLabel.AutoSize = true;
            this.ResidenceOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Bold);
            this.ResidenceOutputLabel.Location = new System.Drawing.Point(715, 7);
            this.ResidenceOutputLabel.Name = "ResidenceOutputLabel";
            this.ResidenceOutputLabel.Size = new System.Drawing.Size(232, 22);
            this.ResidenceOutputLabel.TabIndex = 8;
            this.ResidenceOutputLabel.Text = "Residence (*==For Sale)";
            // 
            // SquareFtLabel
            // 
            this.SquareFtLabel.AutoSize = true;
            this.SquareFtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.SquareFtLabel.Location = new System.Drawing.Point(6, 79);
            this.SquareFtLabel.Name = "SquareFtLabel";
            this.SquareFtLabel.Size = new System.Drawing.Size(114, 18);
            this.SquareFtLabel.TabIndex = 10;
            this.SquareFtLabel.Text = "Square Footage";
            // 
            // AptLabel
            // 
            this.AptLabel.AutoSize = true;
            this.AptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.AptLabel.Location = new System.Drawing.Point(165, 26);
            this.AptLabel.Name = "AptLabel";
            this.AptLabel.Size = new System.Drawing.Size(45, 18);
            this.AptLabel.TabIndex = 11;
            this.AptLabel.Text = "Apt. #";
            // 
            // SquareFtUpDown
            // 
            this.SquareFtUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.SquareFtUpDown.Location = new System.Drawing.Point(6, 102);
            this.SquareFtUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.SquareFtUpDown.Name = "SquareFtUpDown";
            this.SquareFtUpDown.Size = new System.Drawing.Size(76, 24);
            this.SquareFtUpDown.TabIndex = 12;
            this.SquareFtUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // BedroomsLabel
            // 
            this.BedroomsLabel.AutoSize = true;
            this.BedroomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BedroomsLabel.Location = new System.Drawing.Point(6, 133);
            this.BedroomsLabel.Name = "BedroomsLabel";
            this.BedroomsLabel.Size = new System.Drawing.Size(78, 18);
            this.BedroomsLabel.TabIndex = 13;
            this.BedroomsLabel.Text = "Bedrooms";
            // 
            // BathsLabel
            // 
            this.BathsLabel.AutoSize = true;
            this.BathsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BathsLabel.Location = new System.Drawing.Point(90, 133);
            this.BathsLabel.Name = "BathsLabel";
            this.BathsLabel.Size = new System.Drawing.Size(46, 18);
            this.BathsLabel.TabIndex = 14;
            this.BathsLabel.Text = "Baths";
            // 
            // FloorsLabel
            // 
            this.FloorsLabel.AutoSize = true;
            this.FloorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.FloorsLabel.Location = new System.Drawing.Point(142, 133);
            this.FloorsLabel.Name = "FloorsLabel";
            this.FloorsLabel.Size = new System.Drawing.Size(51, 18);
            this.FloorsLabel.TabIndex = 15;
            this.FloorsLabel.Text = "Floors";
            // 
            // GAddPropertyButton
            // 
            this.GAddPropertyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.GAddPropertyButton.Location = new System.Drawing.Point(150, 248);
            this.GAddPropertyButton.Name = "GAddPropertyButton";
            this.GAddPropertyButton.Size = new System.Drawing.Size(75, 32);
            this.GAddPropertyButton.TabIndex = 9;
            this.GAddPropertyButton.Text = "Add";
            this.GAddPropertyButton.UseVisualStyleBackColor = true;
            // 
            // GarageCheckbox
            // 
            this.GarageCheckbox.AutoSize = true;
            this.GarageCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.GarageCheckbox.Location = new System.Drawing.Point(18, 208);
            this.GarageCheckbox.Name = "GarageCheckbox";
            this.GarageCheckbox.Size = new System.Drawing.Size(84, 22);
            this.GarageCheckbox.TabIndex = 16;
            this.GarageCheckbox.Text = "Garage?";
            this.GarageCheckbox.UseVisualStyleBackColor = true;
            // 
            // BedroomsUpDown
            // 
            this.BedroomsUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BedroomsUpDown.Location = new System.Drawing.Point(9, 154);
            this.BedroomsUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.BedroomsUpDown.Name = "BedroomsUpDown";
            this.BedroomsUpDown.Size = new System.Drawing.Size(42, 24);
            this.BedroomsUpDown.TabIndex = 17;
            this.BedroomsUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BathsUpDown
            // 
            this.BathsUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BathsUpDown.Location = new System.Drawing.Point(94, 155);
            this.BathsUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.BathsUpDown.Name = "BathsUpDown";
            this.BathsUpDown.Size = new System.Drawing.Size(42, 24);
            this.BathsUpDown.TabIndex = 18;
            this.BathsUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FloorsUpDown
            // 
            this.FloorsUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.FloorsUpDown.Location = new System.Drawing.Point(145, 155);
            this.FloorsUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FloorsUpDown.Name = "FloorsUpDown";
            this.FloorsUpDown.Size = new System.Drawing.Size(42, 24);
            this.FloorsUpDown.TabIndex = 19;
            this.FloorsUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ForSaleButton
            // 
            this.ForSaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForSaleButton.Location = new System.Drawing.Point(332, 32);
            this.ForSaleButton.Name = "ForSaleButton";
            this.ForSaleButton.Size = new System.Drawing.Size(154, 30);
            this.ForSaleButton.TabIndex = 9;
            this.ForSaleButton.Text = "Toggle For-Sale";
            this.ForSaleButton.UseVisualStyleBackColor = true;
            // 
            // BuyPropertyButton
            // 
            this.BuyPropertyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyPropertyButton.Location = new System.Drawing.Point(332, 68);
            this.BuyPropertyButton.Name = "BuyPropertyButton";
            this.BuyPropertyButton.Size = new System.Drawing.Size(154, 30);
            this.BuyPropertyButton.TabIndex = 10;
            this.BuyPropertyButton.Text = "Buy Property";
            this.BuyPropertyButton.UseVisualStyleBackColor = true;
            // 
            // AddResidentButton
            // 
            this.AddResidentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddResidentButton.Location = new System.Drawing.Point(332, 104);
            this.AddResidentButton.Name = "AddResidentButton";
            this.AddResidentButton.Size = new System.Drawing.Size(154, 30);
            this.AddResidentButton.TabIndex = 11;
            this.AddResidentButton.Text = "Add Resident";
            this.AddResidentButton.UseVisualStyleBackColor = true;
            // 
            // RemoveResidentButton
            // 
            this.RemoveResidentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveResidentButton.Location = new System.Drawing.Point(332, 140);
            this.RemoveResidentButton.Name = "RemoveResidentButton";
            this.RemoveResidentButton.Size = new System.Drawing.Size(154, 30);
            this.RemoveResidentButton.TabIndex = 12;
            this.RemoveResidentButton.Text = "Remove Resident";
            this.RemoveResidentButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 631);
            this.Controls.Add(this.RemoveResidentButton);
            this.Controls.Add(this.AddResidentButton);
            this.Controls.Add(this.BuyPropertyButton);
            this.Controls.Add(this.ForSaleButton);
            this.Controls.Add(this.ResidenceOutputLabel);
            this.Controls.Add(this.PersonOutputLabel);
            this.Controls.Add(this.ResidenceTextbox);
            this.Controls.Add(this.PersonTextbox);
            this.Controls.Add(this.AddPropertyGroupBox);
            this.Controls.Add(this.OutputTextbox);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.ANRGroupBox);
            this.Controls.Add(this.CommunitiesGroupBox);
            this.Name = "Form1";
            this.Text = "Real Estate Management Application";
            this.CommunitiesGroupBox.ResumeLayout(false);
            this.CommunitiesGroupBox.PerformLayout();
            this.ANRGroupBox.ResumeLayout(false);
            this.ANRGroupBox.PerformLayout();
            this.AddPropertyGroupBox.ResumeLayout(false);
            this.AddPropertyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SquareFtUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BedroomsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BathsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FloorsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CommunitiesGroupBox;
        private System.Windows.Forms.RadioButton SycamoreRadioButton;
        private System.Windows.Forms.RadioButton DekalbRadioButton;
        private System.Windows.Forms.GroupBox ANRGroupBox;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.TextBox OutputTextbox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.GroupBox AddPropertyGroupBox;
        private System.Windows.Forms.Button GAddResidentButton;
        private System.Windows.Forms.ComboBox ResidenceCombobox;
        private System.Windows.Forms.Label ResidenceLabel;
        private System.Windows.Forms.Label BithdayLabel;
        private System.Windows.Forms.DateTimePicker BirthdayPicker;
        private System.Windows.Forms.TextBox OccupationTextbox;
        private System.Windows.Forms.Label OccupationLabel;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox PersonTextbox;
        private System.Windows.Forms.TextBox ResidenceTextbox;
        private System.Windows.Forms.TextBox AptNumTextbox;
        private System.Windows.Forms.TextBox StreetAddressTextbox;
        private System.Windows.Forms.Label StreetAddressLabel;
        private System.Windows.Forms.Label PersonOutputLabel;
        private System.Windows.Forms.Label ResidenceOutputLabel;
        private System.Windows.Forms.NumericUpDown FloorsUpDown;
        private System.Windows.Forms.NumericUpDown BathsUpDown;
        private System.Windows.Forms.NumericUpDown BedroomsUpDown;
        private System.Windows.Forms.CheckBox GarageCheckbox;
        private System.Windows.Forms.Button GAddPropertyButton;
        private System.Windows.Forms.Label FloorsLabel;
        private System.Windows.Forms.Label BathsLabel;
        private System.Windows.Forms.Label BedroomsLabel;
        private System.Windows.Forms.NumericUpDown SquareFtUpDown;
        private System.Windows.Forms.Label AptLabel;
        private System.Windows.Forms.Label SquareFtLabel;
        private System.Windows.Forms.Button ForSaleButton;
        private System.Windows.Forms.Button BuyPropertyButton;
        private System.Windows.Forms.Button AddResidentButton;
        private System.Windows.Forms.Button RemoveResidentButton;
    }
}

