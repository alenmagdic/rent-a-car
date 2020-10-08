using System.Windows.Forms;

namespace PresentationLayer
{
    partial class ShowVehicleBrandsListForm
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
            this._brandsLV = new System.Windows.Forms.ListView();
            this.brandName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._editB = new System.Windows.Forms.Button();
            this._deleteB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _brandsLV
            // 
            this._brandsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.brandName});
            this._brandsLV.Location = new System.Drawing.Point(0, 0);
            this._brandsLV.Name = "_brandsLV";
            this._brandsLV.Size = new System.Drawing.Size(291, 400);
            this._brandsLV.TabIndex = 0;
            this._brandsLV.UseCompatibleStateImageBehavior = false;
            this._brandsLV.View = System.Windows.Forms.View.Details;
            // 
            // brandName
            // 
            this.brandName.Text = "Brand name";
            this.brandName.Width = 284;
            // 
            // _editB
            // 
            this._editB.Location = new System.Drawing.Point(50, 416);
            this._editB.Name = "_editB";
            this._editB.Size = new System.Drawing.Size(75, 23);
            this._editB.TabIndex = 1;
            this._editB.Text = "Edit";
            this._editB.UseVisualStyleBackColor = true;
            this._editB.Click += new System.EventHandler(this.EditSelectedBrand);
            // 
            // _deleteB
            // 
            this._deleteB.Location = new System.Drawing.Point(158, 416);
            this._deleteB.Name = "_deleteB";
            this._deleteB.Size = new System.Drawing.Size(75, 23);
            this._deleteB.TabIndex = 2;
            this._deleteB.Text = "Delete";
            this._deleteB.UseVisualStyleBackColor = true;
            this._deleteB.Click += new System.EventHandler(this.DeleteSelectedBrand);
            // 
            // ShowVehicleBrandsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 451);
            this.Controls.Add(this._deleteB);
            this.Controls.Add(this._editB);
            this.Controls.Add(this._brandsLV);
            this.Name = "ShowVehicleBrandsListForm";
            this.Text = "Vehicle brands";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView _brandsLV;
        private System.Windows.Forms.Button _editB;
        private System.Windows.Forms.Button _deleteB;
        private ColumnHeader brandName;
    }
}