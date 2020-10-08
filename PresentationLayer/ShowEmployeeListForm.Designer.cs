namespace PresentationLayer
{
    partial class ShowEmployeeListForm
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
            this._employeesLV = new System.Windows.Forms.ListView();
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oib = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employeeType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // _deleteB
            // 
            this._deleteB.Location = new System.Drawing.Point(272, 416);
            this._deleteB.Name = "_deleteB";
            this._deleteB.Size = new System.Drawing.Size(75, 23);
            this._deleteB.TabIndex = 5;
            this._deleteB.Text = "Delete";
            this._deleteB.UseVisualStyleBackColor = true;
            this._deleteB.Click += new System.EventHandler(this.DeleteSelectedEmployees);
            // 
            // _editB
            // 
            this._editB.Location = new System.Drawing.Point(164, 416);
            this._editB.Name = "_editB";
            this._editB.Size = new System.Drawing.Size(75, 23);
            this._editB.TabIndex = 4;
            this._editB.Text = "Edit";
            this._editB.UseVisualStyleBackColor = true;
            this._editB.Click += new System.EventHandler(this.EditSelectedEmployee);
            // 
            // _employeesLV
            // 
            this._employeesLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstName,
            this.lastName,
            this.oib,
            this.username,
            this.employeeType});
            this._employeesLV.Location = new System.Drawing.Point(-1, 0);
            this._employeesLV.Name = "_employeesLV";
            this._employeesLV.Size = new System.Drawing.Size(531, 400);
            this._employeesLV.TabIndex = 3;
            this._employeesLV.UseCompatibleStateImageBehavior = false;
            this._employeesLV.View = System.Windows.Forms.View.Details;
            // 
            // firstName
            // 
            this.firstName.Text = "First name";
            this.firstName.Width = 94;
            // 
            // lastName
            // 
            this.lastName.Text = "Last name";
            this.lastName.Width = 108;
            // 
            // oib
            // 
            this.oib.Text = "OIB";
            this.oib.Width = 100;
            // 
            // username
            // 
            this.username.Text = "Username";
            this.username.Width = 113;
            // 
            // employeeType
            // 
            this.employeeType.Text = "Employee type";
            this.employeeType.Width = 112;
            // 
            // ShowEmployeeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 451);
            this.Controls.Add(this._deleteB);
            this.Controls.Add(this._editB);
            this.Controls.Add(this._employeesLV);
            this.Name = "ShowEmployeeListForm";
            this.Text = "Employees";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _deleteB;
        private System.Windows.Forms.Button _editB;
        private System.Windows.Forms.ListView _employeesLV;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader oib;
        private System.Windows.Forms.ColumnHeader username;
        private System.Windows.Forms.ColumnHeader employeeType;
    }
}