namespace PresentationLayer
{
    partial class ShowVehicleListForm
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
            this._deleteB = new System.Windows.Forms.Button();
            this._editB = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // _deleteB
            // 
            this._deleteB.Location = new System.Drawing.Point(556, 415);
            this._deleteB.Name = "_deleteB";
            this._deleteB.Size = new System.Drawing.Size(75, 23);
            this._deleteB.TabIndex = 8;
            this._deleteB.Text = "Delete";
            this._deleteB.UseVisualStyleBackColor = true;
            this._deleteB.Click += new System.EventHandler(this.DeleteSelectedVehicles);
            // 
            // _editB
            // 
            this._editB.Location = new System.Drawing.Point(448, 415);
            this._editB.Name = "_editB";
            this._editB.Size = new System.Drawing.Size(75, 23);
            this._editB.TabIndex = 7;
            this._editB.Text = "Edit";
            this._editB.UseVisualStyleBackColor = true;
            this._editB.Click += new System.EventHandler(this.EditSelectedVehicle);
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
            this._vehiclesLV.Location = new System.Drawing.Point(-1, 0);
            this._vehiclesLV.Name = "_vehiclesLV";
            this._vehiclesLV.Size = new System.Drawing.Size(1101, 400);
            this._vehiclesLV.TabIndex = 6;
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
            // ShowVehicleListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 451);
            this.Controls.Add(this._deleteB);
            this.Controls.Add(this._editB);
            this.Controls.Add(this._vehiclesLV);
            this.Name = "ShowVehicleListForm";
            this.Text = "Vehicles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _deleteB;
        private System.Windows.Forms.Button _editB;
        private System.Windows.Forms.ListView _vehiclesLV;
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
    }
}