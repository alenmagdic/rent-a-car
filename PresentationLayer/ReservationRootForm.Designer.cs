namespace PresentationLayer
{
    partial class ReservationRootForm
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
            this._editClientB = new System.Windows.Forms.Button();
            this._addClientB = new System.Windows.Forms.Button();
            this._clientCB = new System.Windows.Forms.ComboBox();
            this._endDateLabel = new System.Windows.Forms.Label();
            this._startDateLabel = new System.Windows.Forms.Label();
            this._clientLabel = new System.Windows.Forms.Label();
            this._cancelB = new System.Windows.Forms.Button();
            this._startDatePicker = new System.Windows.Forms.DateTimePicker();
            this._endDatePicker = new System.Windows.Forms.DateTimePicker();
            this._vehiclesLV = new System.Windows.Forms.ListView();
            this.brand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modelName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trunkCapacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numOfSeats = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.engineType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.power = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.transmissionType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.height = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.width = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vehicleID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.licensePlate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._availableVehiclesLabel = new System.Windows.Forms.Label();
            this._vehiclesFilterLabel = new System.Windows.Forms.Label();
            this._minPowerNB = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this._powerLabel = new System.Windows.Forms.Label();
            this._maxPowerNB = new System.Windows.Forms.NumericUpDown();
            this._brandCB = new System.Windows.Forms.ComboBox();
            this._brandLabel = new System.Windows.Forms.Label();
            this._categoryCB = new System.Windows.Forms.ComboBox();
            this._categoryLabel = new System.Windows.Forms.Label();
            this._engineTypesCB = new System.Windows.Forms.ComboBox();
            this._engineTypeLabel = new System.Windows.Forms.Label();
            this._transTypeCB = new System.Windows.Forms.ComboBox();
            this._transmissionTypeLabel = new System.Windows.Forms.Label();
            this._maxTrunkCapacityNB = new System.Windows.Forms.NumericUpDown();
            this._minTrunkCapacityNB = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this._trunkCapacityLabel = new System.Windows.Forms.Label();
            this._maxNumOfSeatsNB = new System.Windows.Forms.NumericUpDown();
            this._minNumOfSeatsNB = new System.Windows.Forms.NumericUpDown();
            this._numOfSeatsLabel = new System.Windows.Forms.Label();
            this._maxLengthNB = new System.Windows.Forms.NumericUpDown();
            this._minLengthNB = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this._lengthLabel = new System.Windows.Forms.Label();
            this._resetFilterB = new System.Windows.Forms.Button();
            this._reloadB = new System.Windows.Forms.Button();
            this._applyB = new System.Windows.Forms.Button();
            this._reservationDurationLabel = new System.Windows.Forms.Label();
            this._reservationDurationValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._minPowerNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._maxPowerNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._maxTrunkCapacityNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._minTrunkCapacityNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._maxNumOfSeatsNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._minNumOfSeatsNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._maxLengthNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._minLengthNB)).BeginInit();
            this.SuspendLayout();
            // 
            // _editClientB
            // 
            this._editClientB.Location = new System.Drawing.Point(451, 21);
            this._editClientB.Name = "_editClientB";
            this._editClientB.Size = new System.Drawing.Size(62, 23);
            this._editClientB.TabIndex = 100;
            this._editClientB.Text = "Edit";
            this._editClientB.UseVisualStyleBackColor = true;
            this._editClientB.Click += new System.EventHandler(this.EditClient);
            // 
            // _addClientB
            // 
            this._addClientB.Location = new System.Drawing.Point(383, 21);
            this._addClientB.Name = "_addClientB";
            this._addClientB.Size = new System.Drawing.Size(62, 23);
            this._addClientB.TabIndex = 99;
            this._addClientB.Text = "Add";
            this._addClientB.UseVisualStyleBackColor = true;
            this._addClientB.Click += new System.EventHandler(this.AddClient);
            // 
            // _clientCB
            // 
            this._clientCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this._clientCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this._clientCB.FormattingEnabled = true;
            this._clientCB.Location = new System.Drawing.Point(79, 23);
            this._clientCB.MaxDropDownItems = 100;
            this._clientCB.Name = "_clientCB";
            this._clientCB.Size = new System.Drawing.Size(298, 21);
            this._clientCB.TabIndex = 76;
            // 
            // _endDateLabel
            // 
            this._endDateLabel.AutoSize = true;
            this._endDateLabel.Location = new System.Drawing.Point(20, 78);
            this._endDateLabel.Name = "_endDateLabel";
            this._endDateLabel.Size = new System.Drawing.Size(53, 13);
            this._endDateLabel.TabIndex = 71;
            this._endDateLabel.Text = "End date:";
            // 
            // _startDateLabel
            // 
            this._startDateLabel.AutoSize = true;
            this._startDateLabel.Location = new System.Drawing.Point(20, 52);
            this._startDateLabel.Name = "_startDateLabel";
            this._startDateLabel.Size = new System.Drawing.Size(56, 13);
            this._startDateLabel.TabIndex = 69;
            this._startDateLabel.Text = "Start date:";
            // 
            // _clientLabel
            // 
            this._clientLabel.AutoSize = true;
            this._clientLabel.Location = new System.Drawing.Point(20, 26);
            this._clientLabel.Name = "_clientLabel";
            this._clientLabel.Size = new System.Drawing.Size(36, 13);
            this._clientLabel.TabIndex = 68;
            this._clientLabel.Text = "Client:";
            // 
            // _cancelB
            // 
            this._cancelB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelB.Location = new System.Drawing.Point(554, 681);
            this._cancelB.Name = "_cancelB";
            this._cancelB.Size = new System.Drawing.Size(75, 23);
            this._cancelB.TabIndex = 67;
            this._cancelB.Text = "Cancel";
            this._cancelB.UseVisualStyleBackColor = true;
            this._cancelB.Click += new System.EventHandler(this.OnCancel);
            // 
            // _startDatePicker
            // 
            this._startDatePicker.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this._startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._startDatePicker.Location = new System.Drawing.Point(79, 46);
            this._startDatePicker.Name = "_startDatePicker";
            this._startDatePicker.Size = new System.Drawing.Size(298, 20);
            this._startDatePicker.TabIndex = 101;
            this._startDatePicker.ValueChanged += new System.EventHandler(this.UpdateDuration);
            // 
            // _endDatePicker
            // 
            this._endDatePicker.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this._endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._endDatePicker.Location = new System.Drawing.Point(79, 72);
            this._endDatePicker.Name = "_endDatePicker";
            this._endDatePicker.Size = new System.Drawing.Size(298, 20);
            this._endDatePicker.TabIndex = 102;
            this._endDatePicker.ValueChanged += new System.EventHandler(this.UpdateDuration);
            // 
            // _vehiclesLV
            // 
            this._vehiclesLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.brand,
            this.modelName,
            this.category,
            this.trunkCapacity,
            this.numOfSeats,
            this.engineType,
            this.power,
            this.transmissionType,
            this.length,
            this.height,
            this.width,
            this.vehicleID,
            this.licensePlate});
            this._vehiclesLV.Location = new System.Drawing.Point(-2, 139);
            this._vehiclesLV.Name = "_vehiclesLV";
            this._vehiclesLV.Size = new System.Drawing.Size(1102, 253);
            this._vehiclesLV.TabIndex = 103;
            this._vehiclesLV.UseCompatibleStateImageBehavior = false;
            this._vehiclesLV.View = System.Windows.Forms.View.Details;
            // 
            // brand
            // 
            this.brand.Text = "Brand";
            this.brand.Width = 83;
            // 
            // modelName
            // 
            this.modelName.Text = "Model";
            this.modelName.Width = 80;
            // 
            // category
            // 
            this.category.Text = "Category";
            this.category.Width = 79;
            // 
            // trunkCapacity
            // 
            this.trunkCapacity.Text = "Trunk capacity (liters)";
            this.trunkCapacity.Width = 115;
            // 
            // numOfSeats
            // 
            this.numOfSeats.Text = "Seats";
            this.numOfSeats.Width = 45;
            // 
            // engineType
            // 
            this.engineType.Text = "Engine type";
            this.engineType.Width = 75;
            // 
            // power
            // 
            this.power.Text = "Power (kW)";
            this.power.Width = 71;
            // 
            // transmissionType
            // 
            this.transmissionType.Text = "Transmission type";
            this.transmissionType.Width = 98;
            // 
            // length
            // 
            this.length.Text = "Length (mm)";
            this.length.Width = 76;
            // 
            // height
            // 
            this.height.Text = "Height (mm)";
            this.height.Width = 70;
            // 
            // width
            // 
            this.width.Text = "Width (mm)";
            this.width.Width = 68;
            // 
            // vehicleID
            // 
            this.vehicleID.Text = "Vehicle ID";
            this.vehicleID.Width = 131;
            // 
            // licensePlate
            // 
            this.licensePlate.Text = "License plate";
            this.licensePlate.Width = 106;
            // 
            // _availableVehiclesLabel
            // 
            this._availableVehiclesLabel.AutoSize = true;
            this._availableVehiclesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._availableVehiclesLabel.Location = new System.Drawing.Point(20, 116);
            this._availableVehiclesLabel.Name = "_availableVehiclesLabel";
            this._availableVehiclesLabel.Size = new System.Drawing.Size(431, 20);
            this._availableVehiclesLabel.TabIndex = 104;
            this._availableVehiclesLabel.Text = "Vehicles available at selected time and meeting filter criteria:";
            // 
            // _vehiclesFilterLabel
            // 
            this._vehiclesFilterLabel.AutoSize = true;
            this._vehiclesFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._vehiclesFilterLabel.Location = new System.Drawing.Point(20, 412);
            this._vehiclesFilterLabel.Name = "_vehiclesFilterLabel";
            this._vehiclesFilterLabel.Size = new System.Drawing.Size(107, 20);
            this._vehiclesFilterLabel.TabIndex = 105;
            this._vehiclesFilterLabel.Text = "Vehicles filter:";
            // 
            // _minPowerNB
            // 
            this._minPowerNB.Location = new System.Drawing.Point(156, 554);
            this._minPowerNB.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._minPowerNB.Name = "_minPowerNB";
            this._minPowerNB.Size = new System.Drawing.Size(80, 20);
            this._minPowerNB.TabIndex = 108;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 556);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 107;
            this.label3.Text = "kW";
            // 
            // _powerLabel
            // 
            this._powerLabel.AutoSize = true;
            this._powerLabel.Location = new System.Drawing.Point(21, 556);
            this._powerLabel.Name = "_powerLabel";
            this._powerLabel.Size = new System.Drawing.Size(83, 13);
            this._powerLabel.TabIndex = 106;
            this._powerLabel.Text = "Min/max power:";
            // 
            // _maxPowerNB
            // 
            this._maxPowerNB.Location = new System.Drawing.Point(252, 554);
            this._maxPowerNB.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._maxPowerNB.Name = "_maxPowerNB";
            this._maxPowerNB.Size = new System.Drawing.Size(80, 20);
            this._maxPowerNB.TabIndex = 109;
            // 
            // _brandCB
            // 
            this._brandCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this._brandCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this._brandCB.FormattingEnabled = true;
            this._brandCB.Location = new System.Drawing.Point(116, 446);
            this._brandCB.MaxDropDownItems = 100;
            this._brandCB.Name = "_brandCB";
            this._brandCB.Size = new System.Drawing.Size(176, 21);
            this._brandCB.TabIndex = 111;
            // 
            // _brandLabel
            // 
            this._brandLabel.AutoSize = true;
            this._brandLabel.Location = new System.Drawing.Point(20, 449);
            this._brandLabel.Name = "_brandLabel";
            this._brandLabel.Size = new System.Drawing.Size(41, 13);
            this._brandLabel.TabIndex = 110;
            this._brandLabel.Text = "Brand: ";
            // 
            // _categoryCB
            // 
            this._categoryCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this._categoryCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this._categoryCB.FormattingEnabled = true;
            this._categoryCB.Location = new System.Drawing.Point(116, 473);
            this._categoryCB.MaxDropDownItems = 100;
            this._categoryCB.Name = "_categoryCB";
            this._categoryCB.Size = new System.Drawing.Size(176, 21);
            this._categoryCB.TabIndex = 113;
            // 
            // _categoryLabel
            // 
            this._categoryLabel.AutoSize = true;
            this._categoryLabel.Location = new System.Drawing.Point(20, 476);
            this._categoryLabel.Name = "_categoryLabel";
            this._categoryLabel.Size = new System.Drawing.Size(52, 13);
            this._categoryLabel.TabIndex = 112;
            this._categoryLabel.Text = "Category:";
            // 
            // _engineTypesCB
            // 
            this._engineTypesCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this._engineTypesCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this._engineTypesCB.FormattingEnabled = true;
            this._engineTypesCB.Location = new System.Drawing.Point(116, 500);
            this._engineTypesCB.MaxDropDownItems = 100;
            this._engineTypesCB.Name = "_engineTypesCB";
            this._engineTypesCB.Size = new System.Drawing.Size(176, 21);
            this._engineTypesCB.TabIndex = 115;
            // 
            // _engineTypeLabel
            // 
            this._engineTypeLabel.AutoSize = true;
            this._engineTypeLabel.Location = new System.Drawing.Point(20, 503);
            this._engineTypeLabel.Name = "_engineTypeLabel";
            this._engineTypeLabel.Size = new System.Drawing.Size(66, 13);
            this._engineTypeLabel.TabIndex = 114;
            this._engineTypeLabel.Text = "Engine type:";
            // 
            // _transTypeCB
            // 
            this._transTypeCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this._transTypeCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this._transTypeCB.FormattingEnabled = true;
            this._transTypeCB.Location = new System.Drawing.Point(116, 527);
            this._transTypeCB.MaxDropDownItems = 100;
            this._transTypeCB.Name = "_transTypeCB";
            this._transTypeCB.Size = new System.Drawing.Size(176, 21);
            this._transTypeCB.TabIndex = 117;
            // 
            // _transmissionTypeLabel
            // 
            this._transmissionTypeLabel.AutoSize = true;
            this._transmissionTypeLabel.Location = new System.Drawing.Point(20, 530);
            this._transmissionTypeLabel.Name = "_transmissionTypeLabel";
            this._transmissionTypeLabel.Size = new System.Drawing.Size(94, 13);
            this._transmissionTypeLabel.TabIndex = 116;
            this._transmissionTypeLabel.Text = "Transmission type:";
            // 
            // _maxTrunkCapacityNB
            // 
            this._maxTrunkCapacityNB.Location = new System.Drawing.Point(252, 580);
            this._maxTrunkCapacityNB.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._maxTrunkCapacityNB.Name = "_maxTrunkCapacityNB";
            this._maxTrunkCapacityNB.Size = new System.Drawing.Size(80, 20);
            this._maxTrunkCapacityNB.TabIndex = 121;
            // 
            // _minTrunkCapacityNB
            // 
            this._minTrunkCapacityNB.Location = new System.Drawing.Point(156, 580);
            this._minTrunkCapacityNB.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._minTrunkCapacityNB.Name = "_minTrunkCapacityNB";
            this._minTrunkCapacityNB.Size = new System.Drawing.Size(80, 20);
            this._minTrunkCapacityNB.TabIndex = 120;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 582);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 119;
            this.label8.Text = "liters";
            // 
            // _trunkCapacityLabel
            // 
            this._trunkCapacityLabel.AutoSize = true;
            this._trunkCapacityLabel.Location = new System.Drawing.Point(21, 582);
            this._trunkCapacityLabel.Name = "_trunkCapacityLabel";
            this._trunkCapacityLabel.Size = new System.Drawing.Size(121, 13);
            this._trunkCapacityLabel.TabIndex = 118;
            this._trunkCapacityLabel.Text = "Min/max trunk capacity:";
            // 
            // _maxNumOfSeatsNB
            // 
            this._maxNumOfSeatsNB.Location = new System.Drawing.Point(252, 606);
            this._maxNumOfSeatsNB.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._maxNumOfSeatsNB.Name = "_maxNumOfSeatsNB";
            this._maxNumOfSeatsNB.Size = new System.Drawing.Size(80, 20);
            this._maxNumOfSeatsNB.TabIndex = 125;
            // 
            // _minNumOfSeatsNB
            // 
            this._minNumOfSeatsNB.Location = new System.Drawing.Point(156, 606);
            this._minNumOfSeatsNB.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._minNumOfSeatsNB.Name = "_minNumOfSeatsNB";
            this._minNumOfSeatsNB.Size = new System.Drawing.Size(80, 20);
            this._minNumOfSeatsNB.TabIndex = 124;
            // 
            // _numOfSeatsLabel
            // 
            this._numOfSeatsLabel.AutoSize = true;
            this._numOfSeatsLabel.Location = new System.Drawing.Point(21, 608);
            this._numOfSeatsLabel.Name = "_numOfSeatsLabel";
            this._numOfSeatsLabel.Size = new System.Drawing.Size(129, 13);
            this._numOfSeatsLabel.TabIndex = 122;
            this._numOfSeatsLabel.Text = "Min/max number of seats:";
            // 
            // _maxLengthNB
            // 
            this._maxLengthNB.Location = new System.Drawing.Point(252, 632);
            this._maxLengthNB.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._maxLengthNB.Name = "_maxLengthNB";
            this._maxLengthNB.Size = new System.Drawing.Size(80, 20);
            this._maxLengthNB.TabIndex = 129;
            // 
            // _minLengthNB
            // 
            this._minLengthNB.Location = new System.Drawing.Point(156, 632);
            this._minLengthNB.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._minLengthNB.Name = "_minLengthNB";
            this._minLengthNB.Size = new System.Drawing.Size(80, 20);
            this._minLengthNB.TabIndex = 128;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(338, 634);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 127;
            this.label12.Text = "mm";
            // 
            // _lengthLabel
            // 
            this._lengthLabel.AutoSize = true;
            this._lengthLabel.Location = new System.Drawing.Point(21, 634);
            this._lengthLabel.Name = "_lengthLabel";
            this._lengthLabel.Size = new System.Drawing.Size(83, 13);
            this._lengthLabel.TabIndex = 126;
            this._lengthLabel.Text = "Min/max length:";
            // 
            // _resetFilterB
            // 
            this._resetFilterB.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._resetFilterB.Location = new System.Drawing.Point(23, 661);
            this._resetFilterB.Name = "_resetFilterB";
            this._resetFilterB.Size = new System.Drawing.Size(75, 23);
            this._resetFilterB.TabIndex = 130;
            this._resetFilterB.Text = "Reset filter";
            this._resetFilterB.UseVisualStyleBackColor = true;
            this._resetFilterB.Click += new System.EventHandler(this.ResetFilter);
            // 
            // _reloadB
            // 
            this._reloadB.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._reloadB.Location = new System.Drawing.Point(457, 116);
            this._reloadB.Name = "_reloadB";
            this._reloadB.Size = new System.Drawing.Size(75, 23);
            this._reloadB.TabIndex = 131;
            this._reloadB.Text = "Reload";
            this._reloadB.UseVisualStyleBackColor = true;
            this._reloadB.Click += new System.EventHandler(this.ReloadVehiclesList);
            // 
            // _applyB
            // 
            this._applyB.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._applyB.Location = new System.Drawing.Point(457, 681);
            this._applyB.Name = "_applyB";
            this._applyB.Size = new System.Drawing.Size(75, 23);
            this._applyB.TabIndex = 132;
            this._applyB.Text = "Apply";
            this._applyB.UseVisualStyleBackColor = true;
            this._applyB.Click += new System.EventHandler(this.OnApply);
            // 
            // _reservationDurationLabel
            // 
            this._reservationDurationLabel.AutoSize = true;
            this._reservationDurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._reservationDurationLabel.Location = new System.Drawing.Point(400, 70);
            this._reservationDurationLabel.Name = "_reservationDurationLabel";
            this._reservationDurationLabel.Size = new System.Drawing.Size(187, 24);
            this._reservationDurationLabel.TabIndex = 133;
            this._reservationDurationLabel.Text = "Reservation duration:";
            // 
            // _reservationDurationValueLabel
            // 
            this._reservationDurationValueLabel.AutoSize = true;
            this._reservationDurationValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._reservationDurationValueLabel.Location = new System.Drawing.Point(584, 70);
            this._reservationDurationValueLabel.Name = "_reservationDurationValueLabel";
            this._reservationDurationValueLabel.Size = new System.Drawing.Size(64, 24);
            this._reservationDurationValueLabel.TabIndex = 134;
            this._reservationDurationValueLabel.Text = "0 days";
            // 
            // ReservationRootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 726);
            this.Controls.Add(this._reservationDurationValueLabel);
            this.Controls.Add(this._reservationDurationLabel);
            this.Controls.Add(this._applyB);
            this.Controls.Add(this._reloadB);
            this.Controls.Add(this._resetFilterB);
            this.Controls.Add(this._maxLengthNB);
            this.Controls.Add(this._minLengthNB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this._lengthLabel);
            this.Controls.Add(this._maxNumOfSeatsNB);
            this.Controls.Add(this._minNumOfSeatsNB);
            this.Controls.Add(this._numOfSeatsLabel);
            this.Controls.Add(this._maxTrunkCapacityNB);
            this.Controls.Add(this._minTrunkCapacityNB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this._trunkCapacityLabel);
            this.Controls.Add(this._transTypeCB);
            this.Controls.Add(this._transmissionTypeLabel);
            this.Controls.Add(this._engineTypesCB);
            this.Controls.Add(this._engineTypeLabel);
            this.Controls.Add(this._categoryCB);
            this.Controls.Add(this._categoryLabel);
            this.Controls.Add(this._brandCB);
            this.Controls.Add(this._brandLabel);
            this.Controls.Add(this._maxPowerNB);
            this.Controls.Add(this._minPowerNB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._powerLabel);
            this.Controls.Add(this._vehiclesFilterLabel);
            this.Controls.Add(this._availableVehiclesLabel);
            this.Controls.Add(this._vehiclesLV);
            this.Controls.Add(this._endDatePicker);
            this.Controls.Add(this._startDatePicker);
            this.Controls.Add(this._editClientB);
            this.Controls.Add(this._addClientB);
            this.Controls.Add(this._clientCB);
            this.Controls.Add(this._endDateLabel);
            this.Controls.Add(this._startDateLabel);
            this.Controls.Add(this._clientLabel);
            this.Controls.Add(this._cancelB);
            this.Name = "ReservationRootForm";
            this.Text = "ReservationRootForm";
            ((System.ComponentModel.ISupportInitialize)(this._minPowerNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._maxPowerNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._maxTrunkCapacityNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._minTrunkCapacityNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._maxNumOfSeatsNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._minNumOfSeatsNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._maxLengthNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._minLengthNB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _editClientB;
        private System.Windows.Forms.Button _addClientB;
        protected System.Windows.Forms.ComboBox _clientCB;
        private System.Windows.Forms.Label _endDateLabel;
        private System.Windows.Forms.Label _startDateLabel;
        private System.Windows.Forms.Label _clientLabel;
        private System.Windows.Forms.Button _cancelB;
        private System.Windows.Forms.ColumnHeader brand;
        private System.Windows.Forms.ColumnHeader modelName;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader trunkCapacity;
        private System.Windows.Forms.ColumnHeader numOfSeats;
        private System.Windows.Forms.ColumnHeader engineType;
        private System.Windows.Forms.ColumnHeader power;
        private System.Windows.Forms.ColumnHeader transmissionType;
        private System.Windows.Forms.ColumnHeader length;
        private System.Windows.Forms.ColumnHeader height;
        private System.Windows.Forms.ColumnHeader width;
        private System.Windows.Forms.ColumnHeader vehicleID;
        private System.Windows.Forms.ColumnHeader licensePlate;
        private System.Windows.Forms.Label _availableVehiclesLabel;
        private System.Windows.Forms.Label _vehiclesFilterLabel;
        protected System.Windows.Forms.NumericUpDown _minPowerNB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label _powerLabel;
        protected System.Windows.Forms.NumericUpDown _maxPowerNB;
        protected System.Windows.Forms.ComboBox _brandCB;
        private System.Windows.Forms.Label _brandLabel;
        protected System.Windows.Forms.ComboBox _categoryCB;
        private System.Windows.Forms.Label _categoryLabel;
        protected System.Windows.Forms.ComboBox _engineTypesCB;
        private System.Windows.Forms.Label _engineTypeLabel;
        protected System.Windows.Forms.ComboBox _transTypeCB;
        private System.Windows.Forms.Label _transmissionTypeLabel;
        protected System.Windows.Forms.NumericUpDown _maxTrunkCapacityNB;
        protected System.Windows.Forms.NumericUpDown _minTrunkCapacityNB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label _trunkCapacityLabel;
        protected System.Windows.Forms.NumericUpDown _maxNumOfSeatsNB;
        protected System.Windows.Forms.NumericUpDown _minNumOfSeatsNB;
        private System.Windows.Forms.Label _numOfSeatsLabel;
        protected System.Windows.Forms.NumericUpDown _maxLengthNB;
        protected System.Windows.Forms.NumericUpDown _minLengthNB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label _lengthLabel;
        protected System.Windows.Forms.DateTimePicker _startDatePicker;
        protected System.Windows.Forms.DateTimePicker _endDatePicker;
        private System.Windows.Forms.Button _resetFilterB;
        private System.Windows.Forms.Button _reloadB;
        private System.Windows.Forms.Button _applyB;
        protected System.Windows.Forms.ListView _vehiclesLV;
        private System.Windows.Forms.Label _reservationDurationLabel;
        private System.Windows.Forms.Label _reservationDurationValueLabel;
    }
}