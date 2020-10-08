namespace PresentationLayer
{
    public partial class MainWindowForm
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

        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
        protected System.Windows.Forms.TextBox _passwordTB;
        private System.Windows.Forms.Label _passwordLabel;
        protected System.Windows.Forms.TextBox _usernameTB;
        private System.Windows.Forms.Label _usernameLabel;
        private System.Windows.Forms.Button _loginB;
        private System.Windows.Forms.Label _loginStatusLabel;
        private System.Windows.Forms.Button _logoutB;
    }
}