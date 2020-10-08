namespace PresentationLayer
{
    partial class ClientRootForm
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
            this._clientTypeCB = new System.Windows.Forms.ComboBox();
            this._phoneNumberTB = new System.Windows.Forms.TextBox();
            this._phoneNumberLabel = new System.Windows.Forms.Label();
            this._emailTB = new System.Windows.Forms.TextBox();
            this._emailLabel = new System.Windows.Forms.Label();
            this._clientTypeLabel = new System.Windows.Forms.Label();
            this._oibTB = new System.Windows.Forms.TextBox();
            this._oibLabel = new System.Windows.Forms.Label();
            this._nameTB = new System.Windows.Forms.TextBox();
            this._nameLabel = new System.Windows.Forms.Label();
            this._cancelB = new System.Windows.Forms.Button();
            this._applyB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _clientTypeCB
            // 
            this._clientTypeCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this._clientTypeCB.FormattingEnabled = true;
            this._clientTypeCB.Location = new System.Drawing.Point(116, 74);
            this._clientTypeCB.Name = "_clientTypeCB";
            this._clientTypeCB.Size = new System.Drawing.Size(143, 21);
            this._clientTypeCB.TabIndex = 34;
            // 
            // _phoneNumberTB
            // 
            this._phoneNumberTB.Location = new System.Drawing.Point(116, 127);
            this._phoneNumberTB.Name = "_phoneNumberTB";
            this._phoneNumberTB.Size = new System.Drawing.Size(143, 20);
            this._phoneNumberTB.TabIndex = 33;
            // 
            // _phoneNumberLabel
            // 
            this._phoneNumberLabel.AutoSize = true;
            this._phoneNumberLabel.Location = new System.Drawing.Point(17, 130);
            this._phoneNumberLabel.Name = "_phoneNumberLabel";
            this._phoneNumberLabel.Size = new System.Drawing.Size(79, 13);
            this._phoneNumberLabel.TabIndex = 32;
            this._phoneNumberLabel.Text = "Phone number:";
            // 
            // _emailTB
            // 
            this._emailTB.Location = new System.Drawing.Point(116, 101);
            this._emailTB.Name = "_emailTB";
            this._emailTB.Size = new System.Drawing.Size(143, 20);
            this._emailTB.TabIndex = 31;
            // 
            // _emailLabel
            // 
            this._emailLabel.AutoSize = true;
            this._emailLabel.Location = new System.Drawing.Point(17, 104);
            this._emailLabel.Name = "_emailLabel";
            this._emailLabel.Size = new System.Drawing.Size(35, 13);
            this._emailLabel.TabIndex = 30;
            this._emailLabel.Text = "Email:";
            // 
            // _clientTypeLabel
            // 
            this._clientTypeLabel.AutoSize = true;
            this._clientTypeLabel.Location = new System.Drawing.Point(17, 77);
            this._clientTypeLabel.Name = "_clientTypeLabel";
            this._clientTypeLabel.Size = new System.Drawing.Size(62, 13);
            this._clientTypeLabel.TabIndex = 29;
            this._clientTypeLabel.Text = "Client type: ";
            // 
            // _oibTB
            // 
            this._oibTB.Location = new System.Drawing.Point(116, 48);
            this._oibTB.Name = "_oibTB";
            this._oibTB.Size = new System.Drawing.Size(143, 20);
            this._oibTB.TabIndex = 28;
            // 
            // _oibLabel
            // 
            this._oibLabel.AutoSize = true;
            this._oibLabel.Location = new System.Drawing.Point(17, 51);
            this._oibLabel.Name = "_oibLabel";
            this._oibLabel.Size = new System.Drawing.Size(31, 13);
            this._oibLabel.TabIndex = 27;
            this._oibLabel.Text = "OIB: ";
            // 
            // _nameTB
            // 
            this._nameTB.Location = new System.Drawing.Point(116, 21);
            this._nameTB.Name = "_nameTB";
            this._nameTB.Size = new System.Drawing.Size(143, 20);
            this._nameTB.TabIndex = 24;
            // 
            // _nameLabel
            // 
            this._nameLabel.AutoSize = true;
            this._nameLabel.Location = new System.Drawing.Point(17, 24);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(38, 13);
            this._nameLabel.TabIndex = 23;
            this._nameLabel.Text = "Name:";
            // 
            // _cancelB
            // 
            this._cancelB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelB.Location = new System.Drawing.Point(143, 166);
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
            this._applyB.Location = new System.Drawing.Point(48, 166);
            this._applyB.Name = "_applyB";
            this._applyB.Size = new System.Drawing.Size(75, 23);
            this._applyB.TabIndex = 21;
            this._applyB.Text = "Apply";
            this._applyB.UseVisualStyleBackColor = true;
            this._applyB.Click += new System.EventHandler(this.OnApply);
            // 
            // ClientRootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 210);
            this.Controls.Add(this._clientTypeCB);
            this.Controls.Add(this._phoneNumberTB);
            this.Controls.Add(this._phoneNumberLabel);
            this.Controls.Add(this._emailTB);
            this.Controls.Add(this._emailLabel);
            this.Controls.Add(this._clientTypeLabel);
            this.Controls.Add(this._oibTB);
            this.Controls.Add(this._oibLabel);
            this.Controls.Add(this._nameTB);
            this.Controls.Add(this._nameLabel);
            this.Controls.Add(this._cancelB);
            this.Controls.Add(this._applyB);
            this.Name = "ClientRootForm";
            this.Text = "ClientRootForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.ComboBox _clientTypeCB;
        protected System.Windows.Forms.TextBox _phoneNumberTB;
        private System.Windows.Forms.Label _phoneNumberLabel;
        protected System.Windows.Forms.TextBox _emailTB;
        private System.Windows.Forms.Label _emailLabel;
        private System.Windows.Forms.Label _clientTypeLabel;
        protected System.Windows.Forms.TextBox _oibTB;
        private System.Windows.Forms.Label _oibLabel;
        protected System.Windows.Forms.TextBox _nameTB;
        private System.Windows.Forms.Label _nameLabel;
        private System.Windows.Forms.Button _cancelB;
        private System.Windows.Forms.Button _applyB;
    }
}