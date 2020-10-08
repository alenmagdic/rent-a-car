namespace PresentationLayer
{
    partial class VehicleRootForm
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
            this._powerLabel = new System.Windows.Forms.Label();
            this._engineTypeLabel = new System.Windows.Forms.Label();
            this._numberOfSeatsLabel = new System.Windows.Forms.Label();
            this._trunkCapacityLabel = new System.Windows.Forms.Label();
            this._categoryLabel = new System.Windows.Forms.Label();
            this._modelNameTB = new System.Windows.Forms.TextBox();
            this._modelNameLabel = new System.Windows.Forms.Label();
            this._brandLabel = new System.Windows.Forms.Label();
            this._cancelB = new System.Windows.Forms.Button();
            this._applyB = new System.Windows.Forms.Button();
            this._brandCB = new System.Windows.Forms.ComboBox();
            this._categoryCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._engineTypesCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this._transTypeCB = new System.Windows.Forms.ComboBox();
            this._transTypeLabel = new System.Windows.Forms.Label();
            this._lengthLabel = new System.Windows.Forms.Label();
            this._heightLabel = new System.Windows.Forms.Label();
            this._widthLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._licensePlateTB = new System.Windows.Forms.TextBox();
            this._licensePlateLabel = new System.Windows.Forms.Label();
            this._vehicleIdTB = new System.Windows.Forms.TextBox();
            this._vehicleIdLabel = new System.Windows.Forms.Label();
            this._lengthNB = new System.Windows.Forms.NumericUpDown();
            this._heightNB = new System.Windows.Forms.NumericUpDown();
            this._widthNB = new System.Windows.Forms.NumericUpDown();
            this._powerNB = new System.Windows.Forms.NumericUpDown();
            this._trunkCapacityNB = new System.Windows.Forms.NumericUpDown();
            this._numOfSeatsNB = new System.Windows.Forms.NumericUpDown();
            this._addBrandB = new System.Windows.Forms.Button();
            this._editBrandB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._lengthNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._heightNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._widthNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._powerNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._trunkCapacityNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numOfSeatsNB)).BeginInit();
            this.SuspendLayout();
            // 
            // _powerLabel
            // 
            this._powerLabel.AutoSize = true;
            this._powerLabel.Location = new System.Drawing.Point(27, 188);
            this._powerLabel.Name = "_powerLabel";
            this._powerLabel.Size = new System.Drawing.Size(40, 13);
            this._powerLabel.TabIndex = 35;
            this._powerLabel.Text = "Power:";
            // 
            // _engineTypeLabel
            // 
            this._engineTypeLabel.AutoSize = true;
            this._engineTypeLabel.Location = new System.Drawing.Point(27, 158);
            this._engineTypeLabel.Name = "_engineTypeLabel";
            this._engineTypeLabel.Size = new System.Drawing.Size(66, 13);
            this._engineTypeLabel.TabIndex = 32;
            this._engineTypeLabel.Text = "Engine type:";
            // 
            // _numberOfSeatsLabel
            // 
            this._numberOfSeatsLabel.AutoSize = true;
            this._numberOfSeatsLabel.Location = new System.Drawing.Point(27, 132);
            this._numberOfSeatsLabel.Name = "_numberOfSeatsLabel";
            this._numberOfSeatsLabel.Size = new System.Drawing.Size(87, 13);
            this._numberOfSeatsLabel.TabIndex = 30;
            this._numberOfSeatsLabel.Text = "Number of seats:";
            // 
            // _trunkCapacityLabel
            // 
            this._trunkCapacityLabel.AutoSize = true;
            this._trunkCapacityLabel.Location = new System.Drawing.Point(27, 106);
            this._trunkCapacityLabel.Name = "_trunkCapacityLabel";
            this._trunkCapacityLabel.Size = new System.Drawing.Size(81, 13);
            this._trunkCapacityLabel.TabIndex = 29;
            this._trunkCapacityLabel.Text = "Trunk capacity:";
            // 
            // _categoryLabel
            // 
            this._categoryLabel.AutoSize = true;
            this._categoryLabel.Location = new System.Drawing.Point(27, 80);
            this._categoryLabel.Name = "_categoryLabel";
            this._categoryLabel.Size = new System.Drawing.Size(52, 13);
            this._categoryLabel.TabIndex = 27;
            this._categoryLabel.Text = "Category:";
            // 
            // _modelNameTB
            // 
            this._modelNameTB.Location = new System.Drawing.Point(126, 51);
            this._modelNameTB.Name = "_modelNameTB";
            this._modelNameTB.Size = new System.Drawing.Size(143, 20);
            this._modelNameTB.TabIndex = 26;
            // 
            // _modelNameLabel
            // 
            this._modelNameLabel.AutoSize = true;
            this._modelNameLabel.Location = new System.Drawing.Point(27, 54);
            this._modelNameLabel.Name = "_modelNameLabel";
            this._modelNameLabel.Size = new System.Drawing.Size(68, 13);
            this._modelNameLabel.TabIndex = 25;
            this._modelNameLabel.Text = "Model name:";
            // 
            // _brandLabel
            // 
            this._brandLabel.AutoSize = true;
            this._brandLabel.Location = new System.Drawing.Point(27, 28);
            this._brandLabel.Name = "_brandLabel";
            this._brandLabel.Size = new System.Drawing.Size(41, 13);
            this._brandLabel.TabIndex = 23;
            this._brandLabel.Text = "Brand: ";
            // 
            // _cancelB
            // 
            this._cancelB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelB.Location = new System.Drawing.Point(147, 377);
            this._cancelB.Name = "_cancelB";
            this._cancelB.Size = new System.Drawing.Size(75, 23);
            this._cancelB.TabIndex = 22;
            this._cancelB.Text = "Cancel";
            this._cancelB.UseVisualStyleBackColor = true;
            this._cancelB.Click += new System.EventHandler(this.OnCancel);
            // 
            // _applyB
            // 
            this._applyB.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._applyB.Location = new System.Drawing.Point(52, 377);
            this._applyB.Name = "_applyB";
            this._applyB.Size = new System.Drawing.Size(75, 23);
            this._applyB.TabIndex = 21;
            this._applyB.Text = "Apply";
            this._applyB.UseVisualStyleBackColor = true;
            this._applyB.Click += new System.EventHandler(this.OnApply);
            // 
            // _brandCB
            // 
            this._brandCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this._brandCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this._brandCB.FormattingEnabled = true;
            this._brandCB.Location = new System.Drawing.Point(126, 25);
            this._brandCB.MaxDropDownItems = 100;
            this._brandCB.Name = "_brandCB";
            this._brandCB.Size = new System.Drawing.Size(143, 21);
            this._brandCB.TabIndex = 37;
            // 
            // _categoryCB
            // 
            this._categoryCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this._categoryCB.FormattingEnabled = true;
            this._categoryCB.Location = new System.Drawing.Point(126, 77);
            this._categoryCB.MaxDropDownItems = 20;
            this._categoryCB.Name = "_categoryCB";
            this._categoryCB.Size = new System.Drawing.Size(143, 21);
            this._categoryCB.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "liters";
            // 
            // _engineTypesCB
            // 
            this._engineTypesCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this._engineTypesCB.FormattingEnabled = true;
            this._engineTypesCB.Location = new System.Drawing.Point(126, 155);
            this._engineTypesCB.Name = "_engineTypesCB";
            this._engineTypesCB.Size = new System.Drawing.Size(143, 21);
            this._engineTypesCB.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "kW";
            // 
            // _transTypeCB
            // 
            this._transTypeCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this._transTypeCB.FormattingEnabled = true;
            this._transTypeCB.Location = new System.Drawing.Point(126, 211);
            this._transTypeCB.Name = "_transTypeCB";
            this._transTypeCB.Size = new System.Drawing.Size(143, 21);
            this._transTypeCB.TabIndex = 43;
            // 
            // _transTypeLabel
            // 
            this._transTypeLabel.AutoSize = true;
            this._transTypeLabel.Location = new System.Drawing.Point(27, 214);
            this._transTypeLabel.Name = "_transTypeLabel";
            this._transTypeLabel.Size = new System.Drawing.Size(94, 13);
            this._transTypeLabel.TabIndex = 42;
            this._transTypeLabel.Text = "Transmission type:";
            // 
            // _lengthLabel
            // 
            this._lengthLabel.AutoSize = true;
            this._lengthLabel.Location = new System.Drawing.Point(27, 241);
            this._lengthLabel.Name = "_lengthLabel";
            this._lengthLabel.Size = new System.Drawing.Size(43, 13);
            this._lengthLabel.TabIndex = 44;
            this._lengthLabel.Text = "Length:";
            // 
            // _heightLabel
            // 
            this._heightLabel.AutoSize = true;
            this._heightLabel.Location = new System.Drawing.Point(27, 267);
            this._heightLabel.Name = "_heightLabel";
            this._heightLabel.Size = new System.Drawing.Size(41, 13);
            this._heightLabel.TabIndex = 46;
            this._heightLabel.Text = "Height:";
            // 
            // _widthLabel
            // 
            this._widthLabel.AutoSize = true;
            this._widthLabel.Location = new System.Drawing.Point(27, 293);
            this._widthLabel.Name = "_widthLabel";
            this._widthLabel.Size = new System.Drawing.Size(38, 13);
            this._widthLabel.TabIndex = 48;
            this._widthLabel.Text = "Width:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "mm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "mm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "mm";
            // 
            // _licensePlateTB
            // 
            this._licensePlateTB.Location = new System.Drawing.Point(126, 342);
            this._licensePlateTB.Name = "_licensePlateTB";
            this._licensePlateTB.Size = new System.Drawing.Size(143, 20);
            this._licensePlateTB.TabIndex = 56;
            // 
            // _licensePlateLabel
            // 
            this._licensePlateLabel.AutoSize = true;
            this._licensePlateLabel.Location = new System.Drawing.Point(27, 345);
            this._licensePlateLabel.Name = "_licensePlateLabel";
            this._licensePlateLabel.Size = new System.Drawing.Size(73, 13);
            this._licensePlateLabel.TabIndex = 55;
            this._licensePlateLabel.Text = "License plate:";
            // 
            // _vehicleIdTB
            // 
            this._vehicleIdTB.Location = new System.Drawing.Point(126, 316);
            this._vehicleIdTB.Name = "_vehicleIdTB";
            this._vehicleIdTB.Size = new System.Drawing.Size(143, 20);
            this._vehicleIdTB.TabIndex = 54;
            // 
            // _vehicleIdLabel
            // 
            this._vehicleIdLabel.AutoSize = true;
            this._vehicleIdLabel.Location = new System.Drawing.Point(27, 319);
            this._vehicleIdLabel.Name = "_vehicleIdLabel";
            this._vehicleIdLabel.Size = new System.Drawing.Size(59, 13);
            this._vehicleIdLabel.TabIndex = 53;
            this._vehicleIdLabel.Text = "Vehicle ID:";
            // 
            // _lengthNB
            // 
            this._lengthNB.Location = new System.Drawing.Point(126, 241);
            this._lengthNB.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this._lengthNB.Name = "_lengthNB";
            this._lengthNB.Size = new System.Drawing.Size(143, 20);
            this._lengthNB.TabIndex = 58;
            // 
            // _heightNB
            // 
            this._heightNB.Location = new System.Drawing.Point(126, 265);
            this._heightNB.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this._heightNB.Name = "_heightNB";
            this._heightNB.Size = new System.Drawing.Size(143, 20);
            this._heightNB.TabIndex = 59;
            // 
            // _widthNB
            // 
            this._widthNB.Location = new System.Drawing.Point(126, 291);
            this._widthNB.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this._widthNB.Name = "_widthNB";
            this._widthNB.Size = new System.Drawing.Size(143, 20);
            this._widthNB.TabIndex = 60;
            // 
            // _powerNB
            // 
            this._powerNB.Location = new System.Drawing.Point(126, 186);
            this._powerNB.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._powerNB.Name = "_powerNB";
            this._powerNB.Size = new System.Drawing.Size(143, 20);
            this._powerNB.TabIndex = 61;
            // 
            // _trunkCapacityNB
            // 
            this._trunkCapacityNB.Location = new System.Drawing.Point(126, 104);
            this._trunkCapacityNB.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._trunkCapacityNB.Name = "_trunkCapacityNB";
            this._trunkCapacityNB.Size = new System.Drawing.Size(143, 20);
            this._trunkCapacityNB.TabIndex = 62;
            // 
            // _numOfSeatsNB
            // 
            this._numOfSeatsNB.Location = new System.Drawing.Point(126, 130);
            this._numOfSeatsNB.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this._numOfSeatsNB.Name = "_numOfSeatsNB";
            this._numOfSeatsNB.Size = new System.Drawing.Size(143, 20);
            this._numOfSeatsNB.TabIndex = 63;
            // 
            // _addBrandB
            // 
            this._addBrandB.Location = new System.Drawing.Point(278, 23);
            this._addBrandB.Name = "_addBrandB";
            this._addBrandB.Size = new System.Drawing.Size(62, 23);
            this._addBrandB.TabIndex = 64;
            this._addBrandB.Text = "Add";
            this._addBrandB.UseVisualStyleBackColor = true;
            this._addBrandB.Click += new System.EventHandler(this.AddBrand);
            // 
            // _editBrandB
            // 
            this._editBrandB.Location = new System.Drawing.Point(346, 23);
            this._editBrandB.Name = "_editBrandB";
            this._editBrandB.Size = new System.Drawing.Size(62, 23);
            this._editBrandB.TabIndex = 65;
            this._editBrandB.Text = "Edit";
            this._editBrandB.UseVisualStyleBackColor = true;
            this._editBrandB.Click += new System.EventHandler(this.EditBrand);
            // 
            // VehicleRootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 427);
            this.Controls.Add(this._editBrandB);
            this.Controls.Add(this._addBrandB);
            this.Controls.Add(this._numOfSeatsNB);
            this.Controls.Add(this._trunkCapacityNB);
            this.Controls.Add(this._powerNB);
            this.Controls.Add(this._widthNB);
            this.Controls.Add(this._heightNB);
            this.Controls.Add(this._lengthNB);
            this.Controls.Add(this._licensePlateTB);
            this.Controls.Add(this._licensePlateLabel);
            this.Controls.Add(this._vehicleIdTB);
            this.Controls.Add(this._vehicleIdLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._widthLabel);
            this.Controls.Add(this._heightLabel);
            this.Controls.Add(this._lengthLabel);
            this.Controls.Add(this._transTypeCB);
            this.Controls.Add(this._transTypeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._engineTypesCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._categoryCB);
            this.Controls.Add(this._brandCB);
            this.Controls.Add(this._powerLabel);
            this.Controls.Add(this._engineTypeLabel);
            this.Controls.Add(this._numberOfSeatsLabel);
            this.Controls.Add(this._trunkCapacityLabel);
            this.Controls.Add(this._categoryLabel);
            this.Controls.Add(this._modelNameTB);
            this.Controls.Add(this._modelNameLabel);
            this.Controls.Add(this._brandLabel);
            this.Controls.Add(this._cancelB);
            this.Controls.Add(this._applyB);
            this.Name = "VehicleRootForm";
            this.Text = "VehicleRootForm";
            ((System.ComponentModel.ISupportInitialize)(this._lengthNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._heightNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._widthNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._powerNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._trunkCapacityNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numOfSeatsNB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label _powerLabel;
        private System.Windows.Forms.Label _engineTypeLabel;
        private System.Windows.Forms.Label _numberOfSeatsLabel;
        private System.Windows.Forms.Label _trunkCapacityLabel;
        private System.Windows.Forms.Label _categoryLabel;
        protected System.Windows.Forms.TextBox _modelNameTB;
        private System.Windows.Forms.Label _modelNameLabel;
        private System.Windows.Forms.Label _brandLabel;
        private System.Windows.Forms.Button _cancelB;
        private System.Windows.Forms.Button _applyB;
        protected System.Windows.Forms.ComboBox _brandCB;
        protected System.Windows.Forms.ComboBox _categoryCB;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ComboBox _engineTypesCB;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.ComboBox _transTypeCB;
        private System.Windows.Forms.Label _transTypeLabel;
        private System.Windows.Forms.Label _lengthLabel;
        private System.Windows.Forms.Label _heightLabel;
        private System.Windows.Forms.Label _widthLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        protected System.Windows.Forms.TextBox _licensePlateTB;
        private System.Windows.Forms.Label _licensePlateLabel;
        protected System.Windows.Forms.TextBox _vehicleIdTB;
        private System.Windows.Forms.Label _vehicleIdLabel;
        protected System.Windows.Forms.NumericUpDown _lengthNB;
        protected System.Windows.Forms.NumericUpDown _heightNB;
        protected System.Windows.Forms.NumericUpDown _widthNB;
        protected System.Windows.Forms.NumericUpDown _powerNB;
        protected System.Windows.Forms.NumericUpDown _trunkCapacityNB;
        protected System.Windows.Forms.NumericUpDown _numOfSeatsNB;
        private System.Windows.Forms.Button _addBrandB;
        private System.Windows.Forms.Button _editBrandB;
    }
}