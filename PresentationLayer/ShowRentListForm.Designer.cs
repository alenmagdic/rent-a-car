namespace PresentationLayer
{
    partial class ShowRentListForm
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
            this._rentsLV = new System.Windows.Forms.ListView();
            this.reservationId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clientOIB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vehicleBrand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vehicleModelName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vehicleLicensePlate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vehicleId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // _deleteB
            // 
            this._deleteB.Location = new System.Drawing.Point(501, 417);
            this._deleteB.Name = "_deleteB";
            this._deleteB.Size = new System.Drawing.Size(75, 23);
            this._deleteB.TabIndex = 11;
            this._deleteB.Text = "Delete";
            this._deleteB.UseVisualStyleBackColor = true;
            this._deleteB.Click += new System.EventHandler(this.DeleteSelectedRents);
            // 
            // _editB
            // 
            this._editB.Location = new System.Drawing.Point(393, 417);
            this._editB.Name = "_editB";
            this._editB.Size = new System.Drawing.Size(75, 23);
            this._editB.TabIndex = 10;
            this._editB.Text = "Edit";
            this._editB.UseVisualStyleBackColor = true;
            this._editB.Click += new System.EventHandler(this.EditSelectedRent);
            // 
            // _rentsLV
            // 
            this._rentsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.reservationId,
            this.clientName,
            this.clientOIB,
            this.startDate,
            this.endDate,
            this.vehicleBrand,
            this.vehicleModelName,
            this.vehicleLicensePlate,
            this.vehicleId});
            this._rentsLV.Location = new System.Drawing.Point(0, 1);
            this._rentsLV.Name = "_rentsLV";
            this._rentsLV.Size = new System.Drawing.Size(1070, 400);
            this._rentsLV.TabIndex = 9;
            this._rentsLV.UseCompatibleStateImageBehavior = false;
            this._rentsLV.View = System.Windows.Forms.View.Details;
            // 
            // reservationId
            // 
            this.reservationId.Text = "Reservation id";
            this.reservationId.Width = 83;
            // 
            // clientName
            // 
            this.clientName.Text = "Client name";
            this.clientName.Width = 125;
            // 
            // clientOIB
            // 
            this.clientOIB.Text = "Client OIB";
            this.clientOIB.Width = 86;
            // 
            // startDate
            // 
            this.startDate.Text = "Rent start";
            this.startDate.Width = 132;
            // 
            // endDate
            // 
            this.endDate.Text = "Rent end";
            this.endDate.Width = 142;
            // 
            // vehicleBrand
            // 
            this.vehicleBrand.Text = "Vehicle brand";
            this.vehicleBrand.Width = 107;
            // 
            // vehicleModelName
            // 
            this.vehicleModelName.Text = "Vehicle model name";
            this.vehicleModelName.Width = 136;
            // 
            // vehicleLicensePlate
            // 
            this.vehicleLicensePlate.Text = "Vehicle license plate";
            this.vehicleLicensePlate.Width = 132;
            // 
            // vehicleId
            // 
            this.vehicleId.Text = "Vehicle ID";
            this.vehicleId.Width = 123;
            // 
            // ShowRentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 450);
            this.Controls.Add(this._deleteB);
            this.Controls.Add(this._editB);
            this.Controls.Add(this._rentsLV);
            this.Name = "ShowRentListForm";
            this.Text = "Rents";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _deleteB;
        private System.Windows.Forms.Button _editB;
        private System.Windows.Forms.ListView _rentsLV;
        private System.Windows.Forms.ColumnHeader reservationId;
        private System.Windows.Forms.ColumnHeader clientName;
        private System.Windows.Forms.ColumnHeader clientOIB;
        private System.Windows.Forms.ColumnHeader startDate;
        private System.Windows.Forms.ColumnHeader endDate;
        private System.Windows.Forms.ColumnHeader vehicleBrand;
        private System.Windows.Forms.ColumnHeader vehicleModelName;
        private System.Windows.Forms.ColumnHeader vehicleLicensePlate;
        private System.Windows.Forms.ColumnHeader vehicleId;
    }
}