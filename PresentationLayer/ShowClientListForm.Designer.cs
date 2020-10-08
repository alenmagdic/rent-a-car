namespace PresentationLayer
{
    partial class ShowClientListForm
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
            this._clientsLV = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oib = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clientType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // _deleteB
            // 
            this._deleteB.Location = new System.Drawing.Point(331, 415);
            this._deleteB.Name = "_deleteB";
            this._deleteB.Size = new System.Drawing.Size(75, 23);
            this._deleteB.TabIndex = 8;
            this._deleteB.Text = "Delete";
            this._deleteB.UseVisualStyleBackColor = true;
            this._deleteB.Click += new System.EventHandler(this.DeleteSelectedClients);
            // 
            // _editB
            // 
            this._editB.Location = new System.Drawing.Point(223, 415);
            this._editB.Name = "_editB";
            this._editB.Size = new System.Drawing.Size(75, 23);
            this._editB.TabIndex = 7;
            this._editB.Text = "Edit";
            this._editB.UseVisualStyleBackColor = true;
            this._editB.Click += new System.EventHandler(this.EditSelectedClient);
            // 
            // _clientsLV
            // 
            this._clientsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.email,
            this.oib,
            this.phoneNumber,
            this.clientType});
            this._clientsLV.Location = new System.Drawing.Point(0, -1);
            this._clientsLV.Name = "_clientsLV";
            this._clientsLV.Size = new System.Drawing.Size(632, 400);
            this._clientsLV.TabIndex = 6;
            this._clientsLV.UseCompatibleStateImageBehavior = false;
            this._clientsLV.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 132;
            // 
            // oib
            // 
            this.oib.Text = "OIB";
            this.oib.Width = 100;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 161;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Text = "Phone number";
            this.phoneNumber.Width = 123;
            // 
            // clientType
            // 
            this.clientType.Text = "Client type";
            this.clientType.Width = 112;
            // 
            // ShowClientListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 451);
            this.Controls.Add(this._deleteB);
            this.Controls.Add(this._editB);
            this.Controls.Add(this._clientsLV);
            this.Name = "ShowClientListForm";
            this.Text = "Clients";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _deleteB;
        private System.Windows.Forms.Button _editB;
        private System.Windows.Forms.ListView _clientsLV;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader oib;
        private System.Windows.Forms.ColumnHeader phoneNumber;
        private System.Windows.Forms.ColumnHeader clientType;
    }
}