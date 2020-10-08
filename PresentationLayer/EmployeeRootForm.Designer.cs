namespace PresentationLayer
{
    partial class EmployeeRootForm
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
            this.components = new System.ComponentModel.Container();
            this._cancelB = new System.Windows.Forms.Button();
            this._applyB = new System.Windows.Forms.Button();
            this._firstNameTB = new System.Windows.Forms.TextBox();
            this._firstNameLabel = new System.Windows.Forms.Label();
            this._lastNameTB = new System.Windows.Forms.TextBox();
            this._lastNameLabel = new System.Windows.Forms.Label();
            this._oibTB = new System.Windows.Forms.TextBox();
            this._oibLabel = new System.Windows.Forms.Label();
            this._employeeTypeLabel = new System.Windows.Forms.Label();
            this._usernameTB = new System.Windows.Forms.TextBox();
            this._usernameLabel = new System.Windows.Forms.Label();
            this._passwordTB = new System.Windows.Forms.TextBox();
            this._passwordLabel = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this._employeeTypeCB = new System.Windows.Forms.ComboBox();
            this.employeeTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._repeatPassTB = new System.Windows.Forms.TextBox();
            this._repeatPasswordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _cancelB
            // 
            this._cancelB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelB.Location = new System.Drawing.Point(152, 236);
            this._cancelB.Name = "_cancelB";
            this._cancelB.Size = new System.Drawing.Size(75, 23);
            this._cancelB.TabIndex = 5;
            this._cancelB.Text = "Cancel";
            this._cancelB.UseVisualStyleBackColor = true;
            this._cancelB.Click += new System.EventHandler(this.OnCancel);
            // 
            // _applyB
            // 
            this._applyB.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._applyB.Location = new System.Drawing.Point(57, 236);
            this._applyB.Name = "_applyB";
            this._applyB.Size = new System.Drawing.Size(75, 23);
            this._applyB.TabIndex = 4;
            this._applyB.Text = "Apply";
            this._applyB.UseVisualStyleBackColor = true;
            this._applyB.Click += new System.EventHandler(this.OnApply);
            // 
            // _firstNameTB
            // 
            this._firstNameTB.Location = new System.Drawing.Point(128, 30);
            this._firstNameTB.Name = "_firstNameTB";
            this._firstNameTB.Size = new System.Drawing.Size(143, 20);
            this._firstNameTB.TabIndex = 7;
            // 
            // _firstNameLabel
            // 
            this._firstNameLabel.AutoSize = true;
            this._firstNameLabel.Location = new System.Drawing.Point(29, 33);
            this._firstNameLabel.Name = "_firstNameLabel";
            this._firstNameLabel.Size = new System.Drawing.Size(61, 13);
            this._firstNameLabel.TabIndex = 6;
            this._firstNameLabel.Text = "First name: ";
            // 
            // _lastNameTB
            // 
            this._lastNameTB.Location = new System.Drawing.Point(128, 56);
            this._lastNameTB.Name = "_lastNameTB";
            this._lastNameTB.Size = new System.Drawing.Size(143, 20);
            this._lastNameTB.TabIndex = 9;
            // 
            // _lastNameLabel
            // 
            this._lastNameLabel.AutoSize = true;
            this._lastNameLabel.Location = new System.Drawing.Point(29, 59);
            this._lastNameLabel.Name = "_lastNameLabel";
            this._lastNameLabel.Size = new System.Drawing.Size(62, 13);
            this._lastNameLabel.TabIndex = 8;
            this._lastNameLabel.Text = "Last name: ";
            // 
            // _oibTB
            // 
            this._oibTB.Location = new System.Drawing.Point(128, 82);
            this._oibTB.Name = "_oibTB";
            this._oibTB.Size = new System.Drawing.Size(143, 20);
            this._oibTB.TabIndex = 11;
            // 
            // _oibLabel
            // 
            this._oibLabel.AutoSize = true;
            this._oibLabel.Location = new System.Drawing.Point(29, 85);
            this._oibLabel.Name = "_oibLabel";
            this._oibLabel.Size = new System.Drawing.Size(31, 13);
            this._oibLabel.TabIndex = 10;
            this._oibLabel.Text = "OIB: ";
            // 
            // _employeeTypeLabel
            // 
            this._employeeTypeLabel.AutoSize = true;
            this._employeeTypeLabel.Location = new System.Drawing.Point(29, 111);
            this._employeeTypeLabel.Name = "_employeeTypeLabel";
            this._employeeTypeLabel.Size = new System.Drawing.Size(82, 13);
            this._employeeTypeLabel.TabIndex = 12;
            this._employeeTypeLabel.Text = "Employee type: ";
            // 
            // _usernameTB
            // 
            this._usernameTB.Location = new System.Drawing.Point(128, 134);
            this._usernameTB.Name = "_usernameTB";
            this._usernameTB.Size = new System.Drawing.Size(143, 20);
            this._usernameTB.TabIndex = 15;
            // 
            // _usernameLabel
            // 
            this._usernameLabel.AutoSize = true;
            this._usernameLabel.Location = new System.Drawing.Point(29, 137);
            this._usernameLabel.Name = "_usernameLabel";
            this._usernameLabel.Size = new System.Drawing.Size(58, 13);
            this._usernameLabel.TabIndex = 14;
            this._usernameLabel.Text = "Username:";
            // 
            // _passwordTB
            // 
            this._passwordTB.Location = new System.Drawing.Point(128, 160);
            this._passwordTB.Name = "_passwordTB";
            this._passwordTB.Size = new System.Drawing.Size(143, 20);
            this._passwordTB.TabIndex = 17;
            // 
            // _passwordLabel
            // 
            this._passwordLabel.AutoSize = true;
            this._passwordLabel.Location = new System.Drawing.Point(29, 163);
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.Size = new System.Drawing.Size(56, 13);
            this._passwordLabel.TabIndex = 16;
            this._passwordLabel.Text = "Password:";
            // 
            // _employeeTypeCB
            // 
            this._employeeTypeCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this._employeeTypeCB.FormattingEnabled = true;
            this._employeeTypeCB.Location = new System.Drawing.Point(128, 108);
            this._employeeTypeCB.Name = "_employeeTypeCB";
            this._employeeTypeCB.Size = new System.Drawing.Size(143, 21);
            this._employeeTypeCB.TabIndex = 18;
            // 
            // _repeatPassTB
            // 
            this._repeatPassTB.Location = new System.Drawing.Point(128, 190);
            this._repeatPassTB.Name = "_repeatPassTB";
            this._repeatPassTB.Size = new System.Drawing.Size(143, 20);
            this._repeatPassTB.TabIndex = 20;
            // 
            // _repeatPasswordLabel
            // 
            this._repeatPasswordLabel.AutoSize = true;
            this._repeatPasswordLabel.Location = new System.Drawing.Point(29, 193);
            this._repeatPasswordLabel.Name = "_repeatPasswordLabel";
            this._repeatPasswordLabel.Size = new System.Drawing.Size(93, 13);
            this._repeatPasswordLabel.TabIndex = 19;
            this._repeatPasswordLabel.Text = "Repeat password:";
            // 
            // EmployeeRootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 285);
            this.Controls.Add(this._repeatPassTB);
            this.Controls.Add(this._repeatPasswordLabel);
            this.Controls.Add(this._employeeTypeCB);
            this.Controls.Add(this._passwordTB);
            this.Controls.Add(this._passwordLabel);
            this.Controls.Add(this._usernameTB);
            this.Controls.Add(this._usernameLabel);
            this.Controls.Add(this._employeeTypeLabel);
            this.Controls.Add(this._oibTB);
            this.Controls.Add(this._oibLabel);
            this.Controls.Add(this._lastNameTB);
            this.Controls.Add(this._lastNameLabel);
            this.Controls.Add(this._firstNameTB);
            this.Controls.Add(this._firstNameLabel);
            this.Controls.Add(this._cancelB);
            this.Controls.Add(this._applyB);
            this.Name = "EmployeeRootForm";
            this.Text = "EmployeeRootForm";
            ((System.ComponentModel.ISupportInitialize)(this.employeeTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _cancelB;
        private System.Windows.Forms.Button _applyB;
        protected System.Windows.Forms.TextBox _firstNameTB;
        private System.Windows.Forms.Label _firstNameLabel;
        protected System.Windows.Forms.TextBox _lastNameTB;
        private System.Windows.Forms.Label _lastNameLabel;
        protected System.Windows.Forms.TextBox _oibTB;
        private System.Windows.Forms.Label _oibLabel;
        private System.Windows.Forms.Label _employeeTypeLabel;
        protected System.Windows.Forms.TextBox _usernameTB;
        private System.Windows.Forms.Label _usernameLabel;
        protected System.Windows.Forms.TextBox _passwordTB;
        private System.Windows.Forms.Label _passwordLabel;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        protected System.Windows.Forms.ComboBox _employeeTypeCB;
        protected System.Windows.Forms.TextBox _repeatPassTB;
        private System.Windows.Forms.Label _repeatPasswordLabel;
        private System.Windows.Forms.BindingSource employeeTypesBindingSource;
    }
}