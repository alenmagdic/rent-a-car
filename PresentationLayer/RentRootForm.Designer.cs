namespace PresentationLayer
{
    partial class RentRootForm
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
            this._endDatePicker = new System.Windows.Forms.DateTimePicker();
            this._startDatePicker = new System.Windows.Forms.DateTimePicker();
            this._editReservationB = new System.Windows.Forms.Button();
            this._addReservationB = new System.Windows.Forms.Button();
            this._reservationCB = new System.Windows.Forms.ComboBox();
            this._endDateLabel = new System.Windows.Forms.Label();
            this._startDateLabel = new System.Windows.Forms.Label();
            this._reservationLabel = new System.Windows.Forms.Label();
            this._endDateUnknownCheckBox = new System.Windows.Forms.CheckBox();
            this._applyB = new System.Windows.Forms.Button();
            this._cancelB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _endDatePicker
            // 
            this._endDatePicker.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this._endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._endDatePicker.Location = new System.Drawing.Point(91, 72);
            this._endDatePicker.Name = "_endDatePicker";
            this._endDatePicker.Size = new System.Drawing.Size(298, 20);
            this._endDatePicker.TabIndex = 110;
            // 
            // _startDatePicker
            // 
            this._startDatePicker.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this._startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._startDatePicker.Location = new System.Drawing.Point(91, 46);
            this._startDatePicker.Name = "_startDatePicker";
            this._startDatePicker.Size = new System.Drawing.Size(298, 20);
            this._startDatePicker.TabIndex = 109;
            // 
            // _editReservationB
            // 
            this._editReservationB.Location = new System.Drawing.Point(463, 21);
            this._editReservationB.Name = "_editReservationB";
            this._editReservationB.Size = new System.Drawing.Size(62, 23);
            this._editReservationB.TabIndex = 108;
            this._editReservationB.Text = "Edit";
            this._editReservationB.UseVisualStyleBackColor = true;
            this._editReservationB.Click += new System.EventHandler(this.EditReservation);
            // 
            // _addReservationB
            // 
            this._addReservationB.Location = new System.Drawing.Point(395, 21);
            this._addReservationB.Name = "_addReservationB";
            this._addReservationB.Size = new System.Drawing.Size(62, 23);
            this._addReservationB.TabIndex = 107;
            this._addReservationB.Text = "Add";
            this._addReservationB.UseVisualStyleBackColor = true;
            this._addReservationB.Click += new System.EventHandler(this.AddReservation);
            // 
            // _reservationCB
            // 
            this._reservationCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this._reservationCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this._reservationCB.FormattingEnabled = true;
            this._reservationCB.Location = new System.Drawing.Point(91, 23);
            this._reservationCB.MaxDropDownItems = 100;
            this._reservationCB.Name = "_reservationCB";
            this._reservationCB.Size = new System.Drawing.Size(298, 21);
            this._reservationCB.TabIndex = 106;
            // 
            // _endDateLabel
            // 
            this._endDateLabel.AutoSize = true;
            this._endDateLabel.Location = new System.Drawing.Point(18, 78);
            this._endDateLabel.Name = "_endDateLabel";
            this._endDateLabel.Size = new System.Drawing.Size(53, 13);
            this._endDateLabel.TabIndex = 105;
            this._endDateLabel.Text = "End date:";
            // 
            // _startDateLabel
            // 
            this._startDateLabel.AutoSize = true;
            this._startDateLabel.Location = new System.Drawing.Point(18, 52);
            this._startDateLabel.Name = "_startDateLabel";
            this._startDateLabel.Size = new System.Drawing.Size(56, 13);
            this._startDateLabel.TabIndex = 104;
            this._startDateLabel.Text = "Start date:";
            // 
            // _reservationLabel
            // 
            this._reservationLabel.AutoSize = true;
            this._reservationLabel.Location = new System.Drawing.Point(18, 26);
            this._reservationLabel.Name = "_reservationLabel";
            this._reservationLabel.Size = new System.Drawing.Size(67, 13);
            this._reservationLabel.TabIndex = 103;
            this._reservationLabel.Text = "Reservation:";
            // 
            // _endDateUnknownCheckBox
            // 
            this._endDateUnknownCheckBox.AutoSize = true;
            this._endDateUnknownCheckBox.Location = new System.Drawing.Point(395, 77);
            this._endDateUnknownCheckBox.Name = "_endDateUnknownCheckBox";
            this._endDateUnknownCheckBox.Size = new System.Drawing.Size(133, 17);
            this._endDateUnknownCheckBox.TabIndex = 111;
            this._endDateUnknownCheckBox.Text = "End date yet unknown";
            this._endDateUnknownCheckBox.UseVisualStyleBackColor = true;
            // 
            // _applyB
            // 
            this._applyB.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._applyB.Location = new System.Drawing.Point(149, 117);
            this._applyB.Name = "_applyB";
            this._applyB.Size = new System.Drawing.Size(75, 23);
            this._applyB.TabIndex = 134;
            this._applyB.Text = "Apply";
            this._applyB.UseVisualStyleBackColor = true;
            this._applyB.Click += new System.EventHandler(this.OnApply);
            // 
            // _cancelB
            // 
            this._cancelB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelB.Location = new System.Drawing.Point(246, 117);
            this._cancelB.Name = "_cancelB";
            this._cancelB.Size = new System.Drawing.Size(75, 23);
            this._cancelB.TabIndex = 133;
            this._cancelB.Text = "Cancel";
            this._cancelB.UseVisualStyleBackColor = true;
            this._cancelB.Click += new System.EventHandler(this.OnCancel);
            // 
            // RentRootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 159);
            this.Controls.Add(this._applyB);
            this.Controls.Add(this._cancelB);
            this.Controls.Add(this._endDateUnknownCheckBox);
            this.Controls.Add(this._endDatePicker);
            this.Controls.Add(this._startDatePicker);
            this.Controls.Add(this._editReservationB);
            this.Controls.Add(this._addReservationB);
            this.Controls.Add(this._reservationCB);
            this.Controls.Add(this._endDateLabel);
            this.Controls.Add(this._startDateLabel);
            this.Controls.Add(this._reservationLabel);
            this.Name = "RentRootForm";
            this.Text = "RentRootForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.DateTimePicker _endDatePicker;
        protected System.Windows.Forms.DateTimePicker _startDatePicker;
        private System.Windows.Forms.Button _editReservationB;
        private System.Windows.Forms.Button _addReservationB;
        protected System.Windows.Forms.ComboBox _reservationCB;
        private System.Windows.Forms.Label _endDateLabel;
        private System.Windows.Forms.Label _startDateLabel;
        private System.Windows.Forms.Label _reservationLabel;
        private System.Windows.Forms.Button _applyB;
        private System.Windows.Forms.Button _cancelB;
        protected System.Windows.Forms.CheckBox _endDateUnknownCheckBox;
    }
}