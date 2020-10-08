using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    partial class VehicleBrandRootForm
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
            this._brandNameLabel = new System.Windows.Forms.Label();
            this._brandNameTB = new System.Windows.Forms.TextBox();
            this._applyB = new System.Windows.Forms.Button();
            this._cancelB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _brandNameLabel
            // 
            this._brandNameLabel.AutoSize = true;
            this._brandNameLabel.Location = new System.Drawing.Point(27, 27);
            this._brandNameLabel.Name = "_brandNameLabel";
            this._brandNameLabel.Size = new System.Drawing.Size(70, 13);
            this._brandNameLabel.TabIndex = 0;
            this._brandNameLabel.Text = "Brand name: ";
            // 
            // _brandNameTB
            // 
            this._brandNameTB.Location = new System.Drawing.Point(103, 24);
            this._brandNameTB.Name = "_brandNameTB";
            this._brandNameTB.Size = new System.Drawing.Size(143, 20);
            this._brandNameTB.TabIndex = 1;
            // 
            // _applyB
            // 
            this._applyB.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._applyB.Location = new System.Drawing.Point(41, 62);
            this._applyB.Name = "_applyB";
            this._applyB.Size = new System.Drawing.Size(75, 23);
            this._applyB.TabIndex = 2;
            this._applyB.Text = "Apply";
            this._applyB.UseVisualStyleBackColor = true;
            this._applyB.Click += new System.EventHandler(this.OnApply);
            // 
            // _cancelB
            // 
            this._cancelB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelB.Location = new System.Drawing.Point(136, 62);
            this._cancelB.Name = "_cancelB";
            this._cancelB.Size = new System.Drawing.Size(75, 23);
            this._cancelB.TabIndex = 3;
            this._cancelB.Text = "Cancel";
            this._cancelB.UseVisualStyleBackColor = true;
            this._cancelB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnCancel);
            // 
            // VehicleBrandRootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 129);
            this.Controls.Add(this._cancelB);
            this.Controls.Add(this._applyB);
            this.Controls.Add(this._brandNameTB);
            this.Controls.Add(this._brandNameLabel);
            this.Name = "VehicleBrandRootForm";
            this.ShowIcon = false;
            this.Text = "Vehicle brand";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _brandNameLabel;
        protected System.Windows.Forms.TextBox _brandNameTB;
        private System.Windows.Forms.Button _applyB;
        private System.Windows.Forms.Button _cancelB;
    }
}