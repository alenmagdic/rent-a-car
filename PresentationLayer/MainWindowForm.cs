using BaseLib;
using Controllers;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class MainWindowForm : Form, IMainView
    {
        public string Username => _usernameTB.Text;
        public string Password => _passwordTB.Text;
        private MainFormController _mainController;

        public MainWindowForm(MainFormController mainController)
        {
            _mainController = mainController;
            InitializeComponent();
        }

        private MenuStrip _menu;

        private void InitializeComponent()
        {
            this._menu = new System.Windows.Forms.MenuStrip();
            this._employeeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleBrandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBrandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBrandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._passwordTB = new System.Windows.Forms.TextBox();
            this._passwordLabel = new System.Windows.Forms.Label();
            this._usernameTB = new System.Windows.Forms.TextBox();
            this._usernameLabel = new System.Windows.Forms.Label();
            this._loginB = new System.Windows.Forms.Button();
            this._loginStatusLabel = new System.Windows.Forms.Label();
            this._logoutB = new System.Windows.Forms.Button();
            this._menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _menu
            // 
            this._menu.Enabled = false;
            this._menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._employeeMenuItem,
            this.reservationToolStripMenuItem,
            this.rentToolStripMenuItem,
            this.vehicleBrandToolStripMenuItem,
            this.vehicleToolStripMenuItem,
            this.clientToolStripMenuItem});
            this._menu.Location = new System.Drawing.Point(0, 0);
            this._menu.Name = "_menu";
            this._menu.Size = new System.Drawing.Size(556, 24);
            this._menu.TabIndex = 0;
            this._menu.Text = "menuStrip1";
            // 
            // _employeeMenuItem
            // 
            this._employeeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewEmployeesToolStripMenuItem,
            this.addEmployeeToolStripMenuItem});
            this._employeeMenuItem.Name = "_employeeMenuItem";
            this._employeeMenuItem.Size = new System.Drawing.Size(71, 20);
            this._employeeMenuItem.Text = "Employee";
            // 
            // viewEmployeesToolStripMenuItem
            // 
            this.viewEmployeesToolStripMenuItem.Name = "viewEmployeesToolStripMenuItem";
            this.viewEmployeesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewEmployeesToolStripMenuItem.Text = "View Employees";
            this.viewEmployeesToolStripMenuItem.Click += new System.EventHandler(this.ViewEmployees);
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.AddEmployee);
            // 
            // reservationToolStripMenuItem
            // 
            this.reservationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewReservationsToolStripMenuItem,
            this.newReservationToolStripMenuItem});
            this.reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            this.reservationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.reservationToolStripMenuItem.Text = "Reservation";
            // 
            // viewReservationsToolStripMenuItem
            // 
            this.viewReservationsToolStripMenuItem.Name = "viewReservationsToolStripMenuItem";
            this.viewReservationsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.viewReservationsToolStripMenuItem.Text = "View Reservations";
            this.viewReservationsToolStripMenuItem.Click += new System.EventHandler(this.ViewReservations);
            // 
            // newReservationToolStripMenuItem
            // 
            this.newReservationToolStripMenuItem.Name = "newReservationToolStripMenuItem";
            this.newReservationToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.newReservationToolStripMenuItem.Text = "New Reservation";
            this.newReservationToolStripMenuItem.Click += new System.EventHandler(this.AddReservation);
            // 
            // rentToolStripMenuItem
            // 
            this.rentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewRentsToolStripMenuItem,
            this.newRentToolStripMenuItem});
            this.rentToolStripMenuItem.Name = "rentToolStripMenuItem";
            this.rentToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.rentToolStripMenuItem.Text = "Rent";
            // 
            // viewRentsToolStripMenuItem
            // 
            this.viewRentsToolStripMenuItem.Name = "viewRentsToolStripMenuItem";
            this.viewRentsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.viewRentsToolStripMenuItem.Text = "View Rents";
            this.viewRentsToolStripMenuItem.Click += new System.EventHandler(this.ViewRents);
            // 
            // newRentToolStripMenuItem
            // 
            this.newRentToolStripMenuItem.Name = "newRentToolStripMenuItem";
            this.newRentToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.newRentToolStripMenuItem.Text = "New Rent";
            this.newRentToolStripMenuItem.Click += new System.EventHandler(this.AddRent);
            // 
            // vehicleBrandToolStripMenuItem
            // 
            this.vehicleBrandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewBrandsToolStripMenuItem,
            this.addBrandToolStripMenuItem});
            this.vehicleBrandToolStripMenuItem.Name = "vehicleBrandToolStripMenuItem";
            this.vehicleBrandToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.vehicleBrandToolStripMenuItem.Text = "Vehicle Brand";
            // 
            // viewBrandsToolStripMenuItem
            // 
            this.viewBrandsToolStripMenuItem.Name = "viewBrandsToolStripMenuItem";
            this.viewBrandsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.viewBrandsToolStripMenuItem.Text = "View Brands";
            this.viewBrandsToolStripMenuItem.Click += new System.EventHandler(this.ViewVehicleBrands);
            // 
            // addBrandToolStripMenuItem
            // 
            this.addBrandToolStripMenuItem.Name = "addBrandToolStripMenuItem";
            this.addBrandToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.addBrandToolStripMenuItem.Text = "Add Brand";
            this.addBrandToolStripMenuItem.Click += new System.EventHandler(this.AddVehicleBrand);
            // 
            // vehicleToolStripMenuItem
            // 
            this.vehicleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewVehiclesToolStripMenuItem,
            this.addVehicleToolStripMenuItem});
            this.vehicleToolStripMenuItem.Name = "vehicleToolStripMenuItem";
            this.vehicleToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vehicleToolStripMenuItem.Text = "Vehicle";
            // 
            // viewVehiclesToolStripMenuItem
            // 
            this.viewVehiclesToolStripMenuItem.Name = "viewVehiclesToolStripMenuItem";
            this.viewVehiclesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.viewVehiclesToolStripMenuItem.Text = "View Vehicles";
            this.viewVehiclesToolStripMenuItem.Click += new System.EventHandler(this.ViewVehicles);
            // 
            // addVehicleToolStripMenuItem
            // 
            this.addVehicleToolStripMenuItem.Name = "addVehicleToolStripMenuItem";
            this.addVehicleToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.addVehicleToolStripMenuItem.Text = "Add Vehicle";
            this.addVehicleToolStripMenuItem.Click += new System.EventHandler(this.AddVehicle);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewClientsToolStripMenuItem,
            this.addClientToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // viewClientsToolStripMenuItem
            // 
            this.viewClientsToolStripMenuItem.Name = "viewClientsToolStripMenuItem";
            this.viewClientsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.viewClientsToolStripMenuItem.Text = "View clients";
            this.viewClientsToolStripMenuItem.Click += new System.EventHandler(this.ViewClients);
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.addClientToolStripMenuItem.Text = "Add client";
            this.addClientToolStripMenuItem.Click += new System.EventHandler(this.AddClient);
            // 
            // _passwordTB
            // 
            this._passwordTB.Location = new System.Drawing.Point(254, 175);
            this._passwordTB.Name = "_passwordTB";
            this._passwordTB.Size = new System.Drawing.Size(143, 20);
            this._passwordTB.TabIndex = 13;
            // 
            // _passwordLabel
            // 
            this._passwordLabel.AutoSize = true;
            this._passwordLabel.Location = new System.Drawing.Point(150, 178);
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.Size = new System.Drawing.Size(56, 13);
            this._passwordLabel.TabIndex = 12;
            this._passwordLabel.Text = "Password:";
            // 
            // _usernameTB
            // 
            this._usernameTB.Location = new System.Drawing.Point(254, 149);
            this._usernameTB.Name = "_usernameTB";
            this._usernameTB.Size = new System.Drawing.Size(143, 20);
            this._usernameTB.TabIndex = 11;
            // 
            // _usernameLabel
            // 
            this._usernameLabel.AutoSize = true;
            this._usernameLabel.Location = new System.Drawing.Point(150, 152);
            this._usernameLabel.Name = "_usernameLabel";
            this._usernameLabel.Size = new System.Drawing.Size(108, 13);
            this._usernameLabel.TabIndex = 10;
            this._usernameLabel.Text = "Employee username: ";
            // 
            // _loginB
            // 
            this._loginB.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._loginB.Location = new System.Drawing.Point(228, 213);
            this._loginB.Name = "_loginB";
            this._loginB.Size = new System.Drawing.Size(75, 23);
            this._loginB.TabIndex = 14;
            this._loginB.Text = "Log in";
            this._loginB.UseVisualStyleBackColor = true;
            this._loginB.Click += new System.EventHandler(this.LogIn);
            // 
            // _loginStatusLabel
            // 
            this._loginStatusLabel.AutoSize = true;
            this._loginStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._loginStatusLabel.Location = new System.Drawing.Point(150, 91);
            this._loginStatusLabel.Name = "_loginStatusLabel";
            this._loginStatusLabel.Size = new System.Drawing.Size(297, 13);
            this._loginStatusLabel.TabIndex = 15;
            this._loginStatusLabel.Text = "You are not logged in. Log in using the form below.";
            // 
            // _logoutB
            // 
            this._logoutB.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._logoutB.Location = new System.Drawing.Point(153, 107);
            this._logoutB.Name = "_logoutB";
            this._logoutB.Size = new System.Drawing.Size(75, 23);
            this._logoutB.TabIndex = 16;
            this._logoutB.Text = "Log out";
            this._logoutB.UseVisualStyleBackColor = true;
            this._logoutB.Visible = false;
            this._logoutB.Click += new System.EventHandler(this.LogOut);
            // 
            // MainWindowForm
            // 
            this.ClientSize = new System.Drawing.Size(556, 377);
            this.Controls.Add(this._logoutB);
            this.Controls.Add(this._loginStatusLabel);
            this.Controls.Add(this._loginB);
            this.Controls.Add(this._passwordTB);
            this.Controls.Add(this._passwordLabel);
            this.Controls.Add(this._usernameTB);
            this.Controls.Add(this._usernameLabel);
            this.Controls.Add(this._menu);
            this.MainMenuStrip = this._menu;
            this.Name = "MainWindowForm";
            this.Text = "Rent a car";
            this._menu.ResumeLayout(false);
            this._menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ToolStripMenuItem _employeeMenuItem;
        private ToolStripMenuItem viewEmployeesToolStripMenuItem;
        private ToolStripMenuItem addEmployeeToolStripMenuItem;
        private ToolStripMenuItem reservationToolStripMenuItem;
        private ToolStripMenuItem rentToolStripMenuItem;
        private ToolStripMenuItem vehicleBrandToolStripMenuItem;
        private ToolStripMenuItem vehicleToolStripMenuItem;

        private ToolStripMenuItem viewReservationsToolStripMenuItem;
        private ToolStripMenuItem newReservationToolStripMenuItem;
        private ToolStripMenuItem viewRentsToolStripMenuItem;
        private ToolStripMenuItem newRentToolStripMenuItem;
        private ToolStripMenuItem viewBrandsToolStripMenuItem;
        private ToolStripMenuItem addBrandToolStripMenuItem;
        private ToolStripMenuItem viewVehiclesToolStripMenuItem;
        private ToolStripMenuItem addVehicleToolStripMenuItem;



        private void ViewEmployees(object sender, EventArgs e)
        {
            _mainController.ShowEmployeeListView();
        }

        private void AddEmployee(object sender, EventArgs e)
        {
            _mainController.ShowAddEmployee();
        }

        private void ViewVehicleBrands(object sender, EventArgs e)
        {
            _mainController.ShowBrandsListView();
        }

        private void AddVehicleBrand(object sender, EventArgs e)
        {
            _mainController.ShowAddVehicleBrand();
        }

        private void AddVehicle(object sender, EventArgs e)
        {
            _mainController.ShowAddVehicle();
        }

        private void ViewVehicles(object sender, EventArgs e)
        {
            _mainController.ShowVehicleListView();
        }

        private void ViewClients(object sender, EventArgs e)
        {
            _mainController.ShowClientListView();
        }

        private void AddClient(object sender, EventArgs e)
        {
            _mainController.ShowAddClient();
        }

        private void AddReservation(object sender, EventArgs e)
        {
            _mainController.ShowAddReservation();
        }

        private void ViewReservations(object sender, EventArgs e)
        {
            _mainController.ShowReservationListView();
        }

        private void ViewRents(object sender, EventArgs e)
        {
            _mainController.ShowRentListView();
        }

        private void AddRent(object sender, EventArgs e)
        {
            _mainController.ShowAddRent();
        }

        private void LogIn(object sender, EventArgs e)
        {
            _mainController.LogIn(this);
        }

        private void LogOut(object sender, EventArgs e)
        {
            _mainController.LogOut(this);
        }

        public void UpdateView()
        {
            if(_mainController.CurrentEmployee!=null)
            {
                SetLoggedInState();
            } else
            {
                SetLoggedOutState();
            }
        }

        private void SetLoggedOutState()
        {
            _loginStatusLabel.Text = "You are not logged in. Log in using the form below.";
            _logoutB.Visible = false;
            _usernameTB.Visible = true;
            _passwordTB.Visible = true;
            _loginB.Visible = true;
            _usernameLabel.Visible = true;
            _passwordLabel.Visible = true;
            _menu.Enabled = false;
        }

        private void SetLoggedInState()
        {
            _loginStatusLabel.Text = "You are logged in as: "+_mainController.CurrentEmployee.Username;
            _logoutB.Visible = true;
            _usernameTB.Text = "";
            _passwordTB.Text = "";
            _usernameTB.Visible = false;
            _passwordTB.Visible = false;
            _loginB.Visible = false;
            _usernameLabel.Visible = false;
            _passwordLabel.Visible = false;

            _menu.Enabled = true;
            if(_mainController.CurrentEmployee.EmployeeType.Equals(EmployeeTypes.STANDARD_EMPLOYEE))
            {
                _employeeMenuItem.Enabled = false;
            } else
            {
                _employeeMenuItem.Enabled = true;
            }
        }
    }
}
