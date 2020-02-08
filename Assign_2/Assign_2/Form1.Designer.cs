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
            this.AttachedCheckbox = new System.Windows.Forms.CheckBox();
            this.FloorsUpDown = new System.Windows.Forms.NumericUpDown();
            this.BathsUpDown = new System.Windows.Forms.NumericUpDown();
            this.BedroomsUpDown = new System.Windows.Forms.NumericUpDown();
            this.GarageCheckbox = new System.Windows.Forms.CheckBox();
            this.GAddPropertyButton = new System.Windows.Forms.Button();
            this.FloorsLabel = new System.Windows.Forms.Label();
            this.BathsLabel = new System.Windows.Forms.Label();
            this.BedroomsLabel = new System.Windows.Forms.Label();
            this.SquareFtUpDown = new System.Windows.Forms.NumericUpDown();
            this.AptLabel = new System.Windows.Forms.Label();
            this.SquareFtLabel = new System.Windows.Forms.Label();
            this.AptNumTextbox = new System.Windows.Forms.TextBox();
            this.StreetAddressTextbox = new System.Windows.Forms.TextBox();
            this.StreetAddressLabel = new System.Windows.Forms.Label();
            this.PersonOutputLabel = new System.Windows.Forms.Label();
            this.ResidenceOutputLabel = new System.Windows.Forms.Label();
            this.ForSaleButton = new System.Windows.Forms.Button();
            this.BuyPropertyButton = new System.Windows.Forms.Button();
            this.AddResidentButton = new System.Windows.Forms.Button();
            this.RemoveResidentButton = new System.Windows.Forms.Button();
            this.PersonListbox = new System.Windows.Forms.ListBox();
            this.ResidenceListbox = new System.Windows.Forms.ListBox();
            this.CommunitiesGroupBox.SuspendLayout();
            this.ANRGroupBox.SuspendLayout();
            this.AddPropertyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FloorsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BathsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BedroomsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SquareFtUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CommunitiesGroupBox
            // 
            this.CommunitiesGroupBox.Controls.Add(this.SycamoreRadioButton);
            this.CommunitiesGroupBox.Controls.Add(this.DekalbRadioButton);
            this.CommunitiesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommunitiesGroupBox.Location = new System.Drawing.Point(24, 23);
            this.CommunitiesGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.CommunitiesGroupBox.Name = "CommunitiesGroupBox";
            this.CommunitiesGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.CommunitiesGroupBox.Size = new System.Drawing.Size(400, 146);
            this.CommunitiesGroupBox.TabIndex = 0;
            this.CommunitiesGroupBox.TabStop = false;
            this.CommunitiesGroupBox.Text = "Communities";
            // 
            // SycamoreRadioButton
            // 
            this.SycamoreRadioButton.AutoSize = true;
            this.SycamoreRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SycamoreRadioButton.Location = new System.Drawing.Point(14, 85);
            this.SycamoreRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.SycamoreRadioButton.Name = "SycamoreRadioButton";
            this.SycamoreRadioButton.Size = new System.Drawing.Size(178, 40);
            this.SycamoreRadioButton.TabIndex = 1;
            this.SycamoreRadioButton.Text = "Sycamore";
            this.SycamoreRadioButton.UseVisualStyleBackColor = true;
            this.SycamoreRadioButton.Click += new System.EventHandler(this.SycamoreRadioButton_Click);
            // 
            // DekalbRadioButton
            // 
            this.DekalbRadioButton.AutoSize = true;
            this.DekalbRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DekalbRadioButton.Location = new System.Drawing.Point(14, 38);
            this.DekalbRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.DekalbRadioButton.Name = "DekalbRadioButton";
            this.DekalbRadioButton.Size = new System.Drawing.Size(138, 40);
            this.DekalbRadioButton.TabIndex = 0;
            this.DekalbRadioButton.Text = "Dekalb";
            this.DekalbRadioButton.UseVisualStyleBackColor = true;
            this.DekalbRadioButton.Click += new System.EventHandler(this.DekalbRadioButton_Click);
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
            this.ANRGroupBox.Location = new System.Drawing.Point(24, 352);
            this.ANRGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.ANRGroupBox.Name = "ANRGroupBox";
            this.ANRGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.ANRGroupBox.Size = new System.Drawing.Size(472, 550);
            this.ANRGroupBox.TabIndex = 1;
            this.ANRGroupBox.TabStop = false;
            this.ANRGroupBox.Text = "Add New Resident";
            // 
            // GAddResidentButton
            // 
            this.GAddResidentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.GAddResidentButton.Location = new System.Drawing.Point(310, 477);
            this.GAddResidentButton.Margin = new System.Windows.Forms.Padding(6);
            this.GAddResidentButton.Name = "GAddResidentButton";
            this.GAddResidentButton.Size = new System.Drawing.Size(150, 62);
            this.GAddResidentButton.TabIndex = 8;
            this.GAddResidentButton.Text = "Add";
            this.GAddResidentButton.UseVisualStyleBackColor = true;
            this.GAddResidentButton.Click += new System.EventHandler(this.AddNewResidentButton_Clicked);
            // 
            // ResidenceCombobox
            // 
            this.ResidenceCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ResidenceCombobox.FormattingEnabled = true;
            this.ResidenceCombobox.Location = new System.Drawing.Point(18, 400);
            this.ResidenceCombobox.Margin = new System.Windows.Forms.Padding(6);
            this.ResidenceCombobox.Name = "ResidenceCombobox";
            this.ResidenceCombobox.Size = new System.Drawing.Size(438, 41);
            this.ResidenceCombobox.TabIndex = 7;
            this.ResidenceCombobox.DropDown += new System.EventHandler(this.Dropdown_Preview);
            // 
            // ResidenceLabel
            // 
            this.ResidenceLabel.AutoSize = true;
            this.ResidenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ResidenceLabel.Location = new System.Drawing.Point(12, 358);
            this.ResidenceLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ResidenceLabel.Name = "ResidenceLabel";
            this.ResidenceLabel.Size = new System.Drawing.Size(156, 36);
            this.ResidenceLabel.TabIndex = 6;
            this.ResidenceLabel.Text = "Residence";
            // 
            // BithdayLabel
            // 
            this.BithdayLabel.AutoSize = true;
            this.BithdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BithdayLabel.Location = new System.Drawing.Point(12, 256);
            this.BithdayLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.BithdayLabel.Name = "BithdayLabel";
            this.BithdayLabel.Size = new System.Drawing.Size(125, 36);
            this.BithdayLabel.TabIndex = 5;
            this.BithdayLabel.Text = "Birthday";
            // 
            // BirthdayPicker
            // 
            this.BirthdayPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BirthdayPicker.Location = new System.Drawing.Point(14, 296);
            this.BirthdayPicker.Margin = new System.Windows.Forms.Padding(6);
            this.BirthdayPicker.Name = "BirthdayPicker";
            this.BirthdayPicker.Size = new System.Drawing.Size(442, 35);
            this.BirthdayPicker.TabIndex = 4;
            // 
            // OccupationTextbox
            // 
            this.OccupationTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.OccupationTextbox.Location = new System.Drawing.Point(14, 194);
            this.OccupationTextbox.Margin = new System.Windows.Forms.Padding(6);
            this.OccupationTextbox.Name = "OccupationTextbox";
            this.OccupationTextbox.Size = new System.Drawing.Size(442, 41);
            this.OccupationTextbox.TabIndex = 3;
            // 
            // OccupationLabel
            // 
            this.OccupationLabel.AutoSize = true;
            this.OccupationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.OccupationLabel.Location = new System.Drawing.Point(12, 152);
            this.OccupationLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.OccupationLabel.Name = "OccupationLabel";
            this.OccupationLabel.Size = new System.Drawing.Size(166, 36);
            this.OccupationLabel.TabIndex = 2;
            this.OccupationLabel.Text = "Occupation";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NameTextbox.Location = new System.Drawing.Point(14, 90);
            this.NameTextbox.Margin = new System.Windows.Forms.Padding(6);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(442, 41);
            this.NameTextbox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NameLabel.Location = new System.Drawing.Point(12, 48);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(92, 36);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.OutputLabel.Location = new System.Drawing.Point(24, 908);
            this.OutputLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(141, 44);
            this.OutputLabel.TabIndex = 2;
            this.OutputLabel.Text = "Output";
            // 
            // OutputTextbox
            // 
            this.OutputTextbox.Location = new System.Drawing.Point(24, 960);
            this.OutputTextbox.Margin = new System.Windows.Forms.Padding(6);
            this.OutputTextbox.Multiline = true;
            this.OutputTextbox.Name = "OutputTextbox";
            this.OutputTextbox.Size = new System.Drawing.Size(1972, 227);
            this.OutputTextbox.TabIndex = 3;
            // 
            // AddPropertyGroupBox
            // 
            this.AddPropertyGroupBox.Controls.Add(this.AttachedCheckbox);
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
            this.AddPropertyGroupBox.Location = new System.Drawing.Point(508, 352);
            this.AddPropertyGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.AddPropertyGroupBox.Name = "AddPropertyGroupBox";
            this.AddPropertyGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.AddPropertyGroupBox.Size = new System.Drawing.Size(462, 550);
            this.AddPropertyGroupBox.TabIndex = 4;
            this.AddPropertyGroupBox.TabStop = false;
            this.AddPropertyGroupBox.Text = "Add Property";
            // 
            // AttachedCheckbox
            // 
            this.AttachedCheckbox.AutoSize = true;
            this.AttachedCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.AttachedCheckbox.Location = new System.Drawing.Point(206, 400);
            this.AttachedCheckbox.Margin = new System.Windows.Forms.Padding(6);
            this.AttachedCheckbox.Name = "AttachedCheckbox";
            this.AttachedCheckbox.Size = new System.Drawing.Size(182, 40);
            this.AttachedCheckbox.TabIndex = 20;
            this.AttachedCheckbox.Text = "Attached?";
            this.AttachedCheckbox.UseVisualStyleBackColor = true;
            this.AttachedCheckbox.Visible = false;
            // 
            // FloorsUpDown
            // 
            this.FloorsUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.FloorsUpDown.Location = new System.Drawing.Point(290, 298);
            this.FloorsUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.FloorsUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FloorsUpDown.Name = "FloorsUpDown";
            this.FloorsUpDown.Size = new System.Drawing.Size(84, 41);
            this.FloorsUpDown.TabIndex = 19;
            this.FloorsUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BathsUpDown
            // 
            this.BathsUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BathsUpDown.Location = new System.Drawing.Point(188, 298);
            this.BathsUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.BathsUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.BathsUpDown.Name = "BathsUpDown";
            this.BathsUpDown.Size = new System.Drawing.Size(84, 41);
            this.BathsUpDown.TabIndex = 18;
            this.BathsUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BedroomsUpDown
            // 
            this.BedroomsUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BedroomsUpDown.Location = new System.Drawing.Point(18, 296);
            this.BedroomsUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.BedroomsUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.BedroomsUpDown.Name = "BedroomsUpDown";
            this.BedroomsUpDown.Size = new System.Drawing.Size(84, 41);
            this.BedroomsUpDown.TabIndex = 17;
            this.BedroomsUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GarageCheckbox
            // 
            this.GarageCheckbox.AutoSize = true;
            this.GarageCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.GarageCheckbox.Location = new System.Drawing.Point(36, 400);
            this.GarageCheckbox.Margin = new System.Windows.Forms.Padding(6);
            this.GarageCheckbox.Name = "GarageCheckbox";
            this.GarageCheckbox.Size = new System.Drawing.Size(162, 40);
            this.GarageCheckbox.TabIndex = 16;
            this.GarageCheckbox.Text = "Garage?";
            this.GarageCheckbox.UseVisualStyleBackColor = true;
            this.GarageCheckbox.Click += new System.EventHandler(this.GarageCheckbox_Click);
            // 
            // GAddPropertyButton
            // 
            this.GAddPropertyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.GAddPropertyButton.Location = new System.Drawing.Point(300, 477);
            this.GAddPropertyButton.Margin = new System.Windows.Forms.Padding(6);
            this.GAddPropertyButton.Name = "GAddPropertyButton";
            this.GAddPropertyButton.Size = new System.Drawing.Size(150, 62);
            this.GAddPropertyButton.TabIndex = 9;
            this.GAddPropertyButton.Text = "Add";
            this.GAddPropertyButton.UseVisualStyleBackColor = true;
            this.GAddPropertyButton.Click += new System.EventHandler(this.GAddPropertyButton_Click);
            // 
            // FloorsLabel
            // 
            this.FloorsLabel.AutoSize = true;
            this.FloorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.FloorsLabel.Location = new System.Drawing.Point(284, 256);
            this.FloorsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FloorsLabel.Name = "FloorsLabel";
            this.FloorsLabel.Size = new System.Drawing.Size(99, 36);
            this.FloorsLabel.TabIndex = 15;
            this.FloorsLabel.Text = "Floors";
            // 
            // BathsLabel
            // 
            this.BathsLabel.AutoSize = true;
            this.BathsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BathsLabel.Location = new System.Drawing.Point(180, 256);
            this.BathsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.BathsLabel.Name = "BathsLabel";
            this.BathsLabel.Size = new System.Drawing.Size(91, 36);
            this.BathsLabel.TabIndex = 14;
            this.BathsLabel.Text = "Baths";
            // 
            // BedroomsLabel
            // 
            this.BedroomsLabel.AutoSize = true;
            this.BedroomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BedroomsLabel.Location = new System.Drawing.Point(12, 256);
            this.BedroomsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.BedroomsLabel.Name = "BedroomsLabel";
            this.BedroomsLabel.Size = new System.Drawing.Size(150, 36);
            this.BedroomsLabel.TabIndex = 13;
            this.BedroomsLabel.Text = "Bedrooms";
            // 
            // SquareFtUpDown
            // 
            this.SquareFtUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.SquareFtUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.SquareFtUpDown.Location = new System.Drawing.Point(12, 196);
            this.SquareFtUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.SquareFtUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SquareFtUpDown.Name = "SquareFtUpDown";
            this.SquareFtUpDown.Size = new System.Drawing.Size(152, 41);
            this.SquareFtUpDown.TabIndex = 12;
            this.SquareFtUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // AptLabel
            // 
            this.AptLabel.AutoSize = true;
            this.AptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.AptLabel.Location = new System.Drawing.Point(330, 50);
            this.AptLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AptLabel.Name = "AptLabel";
            this.AptLabel.Size = new System.Drawing.Size(94, 36);
            this.AptLabel.TabIndex = 11;
            this.AptLabel.Text = "Apt. #";
            // 
            // SquareFtLabel
            // 
            this.SquareFtLabel.AutoSize = true;
            this.SquareFtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.SquareFtLabel.Location = new System.Drawing.Point(12, 152);
            this.SquareFtLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SquareFtLabel.Name = "SquareFtLabel";
            this.SquareFtLabel.Size = new System.Drawing.Size(228, 36);
            this.SquareFtLabel.TabIndex = 10;
            this.SquareFtLabel.Text = "Square Footage";
            // 
            // AptNumTextbox
            // 
            this.AptNumTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.AptNumTextbox.Location = new System.Drawing.Point(336, 90);
            this.AptNumTextbox.Margin = new System.Windows.Forms.Padding(6);
            this.AptNumTextbox.Name = "AptNumTextbox";
            this.AptNumTextbox.Size = new System.Drawing.Size(86, 41);
            this.AptNumTextbox.TabIndex = 9;
            this.AptNumTextbox.TextChanged += new System.EventHandler(this.AptNumTextbox_TextChanged);
            // 
            // StreetAddressTextbox
            // 
            this.StreetAddressTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.StreetAddressTextbox.Location = new System.Drawing.Point(12, 90);
            this.StreetAddressTextbox.Margin = new System.Windows.Forms.Padding(6);
            this.StreetAddressTextbox.Name = "StreetAddressTextbox";
            this.StreetAddressTextbox.Size = new System.Drawing.Size(308, 41);
            this.StreetAddressTextbox.TabIndex = 8;
            // 
            // StreetAddressLabel
            // 
            this.StreetAddressLabel.AutoSize = true;
            this.StreetAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.StreetAddressLabel.Location = new System.Drawing.Point(12, 48);
            this.StreetAddressLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.StreetAddressLabel.Name = "StreetAddressLabel";
            this.StreetAddressLabel.Size = new System.Drawing.Size(212, 36);
            this.StreetAddressLabel.TabIndex = 7;
            this.StreetAddressLabel.Text = "Street Address";
            // 
            // PersonOutputLabel
            // 
            this.PersonOutputLabel.AutoSize = true;
            this.PersonOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.PersonOutputLabel.Location = new System.Drawing.Point(976, 10);
            this.PersonOutputLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PersonOutputLabel.Name = "PersonOutputLabel";
            this.PersonOutputLabel.Size = new System.Drawing.Size(146, 44);
            this.PersonOutputLabel.TabIndex = 7;
            this.PersonOutputLabel.Text = "Person";
            // 
            // ResidenceOutputLabel
            // 
            this.ResidenceOutputLabel.AutoSize = true;
            this.ResidenceOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Bold);
            this.ResidenceOutputLabel.Location = new System.Drawing.Point(1430, 13);
            this.ResidenceOutputLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ResidenceOutputLabel.Name = "ResidenceOutputLabel";
            this.ResidenceOutputLabel.Size = new System.Drawing.Size(436, 40);
            this.ResidenceOutputLabel.TabIndex = 8;
            this.ResidenceOutputLabel.Text = "Residence (*==For Sale)";
            // 
            // ForSaleButton
            // 
            this.ForSaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForSaleButton.Location = new System.Drawing.Point(664, 62);
            this.ForSaleButton.Margin = new System.Windows.Forms.Padding(6);
            this.ForSaleButton.Name = "ForSaleButton";
            this.ForSaleButton.Size = new System.Drawing.Size(308, 58);
            this.ForSaleButton.TabIndex = 9;
            this.ForSaleButton.Text = "Toggle For-Sale";
            this.ForSaleButton.UseVisualStyleBackColor = true;
            this.ForSaleButton.Click += new System.EventHandler(this.ForSaleButton_Click);
            // 
            // BuyPropertyButton
            // 
            this.BuyPropertyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyPropertyButton.Location = new System.Drawing.Point(664, 131);
            this.BuyPropertyButton.Margin = new System.Windows.Forms.Padding(6);
            this.BuyPropertyButton.Name = "BuyPropertyButton";
            this.BuyPropertyButton.Size = new System.Drawing.Size(308, 58);
            this.BuyPropertyButton.TabIndex = 10;
            this.BuyPropertyButton.Text = "Buy Property";
            this.BuyPropertyButton.UseVisualStyleBackColor = true;
            this.BuyPropertyButton.Click += new System.EventHandler(this.BuyPropertyButton_Click);
            // 
            // AddResidentButton
            // 
            this.AddResidentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddResidentButton.Location = new System.Drawing.Point(664, 200);
            this.AddResidentButton.Margin = new System.Windows.Forms.Padding(6);
            this.AddResidentButton.Name = "AddResidentButton";
            this.AddResidentButton.Size = new System.Drawing.Size(308, 58);
            this.AddResidentButton.TabIndex = 11;
            this.AddResidentButton.Text = "Add Resident";
            this.AddResidentButton.UseVisualStyleBackColor = true;
            // 
            // RemoveResidentButton
            // 
            this.RemoveResidentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveResidentButton.Location = new System.Drawing.Point(664, 269);
            this.RemoveResidentButton.Margin = new System.Windows.Forms.Padding(6);
            this.RemoveResidentButton.Name = "RemoveResidentButton";
            this.RemoveResidentButton.Size = new System.Drawing.Size(308, 58);
            this.RemoveResidentButton.TabIndex = 12;
            this.RemoveResidentButton.Text = "Remove Resident";
            this.RemoveResidentButton.UseVisualStyleBackColor = true;
            // 
            // PersonListbox
            // 
            this.PersonListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonListbox.FormattingEnabled = true;
            this.PersonListbox.ItemHeight = 29;
            this.PersonListbox.Location = new System.Drawing.Point(984, 62);
            this.PersonListbox.Margin = new System.Windows.Forms.Padding(6);
            this.PersonListbox.Name = "PersonListbox";
            this.PersonListbox.Size = new System.Drawing.Size(438, 816);
            this.PersonListbox.TabIndex = 13;
            this.PersonListbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PersonListbox_MouseClick);
            // 
            // ResidenceListbox
            // 
            this.ResidenceListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResidenceListbox.FormattingEnabled = true;
            this.ResidenceListbox.ItemHeight = 29;
            this.ResidenceListbox.Location = new System.Drawing.Point(1438, 62);
            this.ResidenceListbox.Margin = new System.Windows.Forms.Padding(6);
            this.ResidenceListbox.Name = "ResidenceListbox";
            this.ResidenceListbox.Size = new System.Drawing.Size(558, 816);
            this.ResidenceListbox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2024, 1213);
            this.Controls.Add(this.ResidenceListbox);
            this.Controls.Add(this.PersonListbox);
            this.Controls.Add(this.RemoveResidentButton);
            this.Controls.Add(this.AddResidentButton);
            this.Controls.Add(this.BuyPropertyButton);
            this.Controls.Add(this.ForSaleButton);
            this.Controls.Add(this.ResidenceOutputLabel);
            this.Controls.Add(this.PersonOutputLabel);
            this.Controls.Add(this.AddPropertyGroupBox);
            this.Controls.Add(this.OutputTextbox);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.ANRGroupBox);
            this.Controls.Add(this.CommunitiesGroupBox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Real Estate Management Application";
            this.CommunitiesGroupBox.ResumeLayout(false);
            this.CommunitiesGroupBox.PerformLayout();
            this.ANRGroupBox.ResumeLayout(false);
            this.ANRGroupBox.PerformLayout();
            this.AddPropertyGroupBox.ResumeLayout(false);
            this.AddPropertyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FloorsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BathsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BedroomsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SquareFtUpDown)).EndInit();
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
        private System.Windows.Forms.ListBox PersonListbox;
        private System.Windows.Forms.ListBox ResidenceListbox;
        private System.Windows.Forms.CheckBox AttachedCheckbox;
    }
}

