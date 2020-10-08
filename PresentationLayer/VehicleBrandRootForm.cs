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
    public partial class VehicleBrandRootForm : Form
    {
        public VehicleBrandRootForm()
        {
            InitializeComponent();
        }

        protected virtual void OnApply(object sender, EventArgs e) { }

        protected virtual void OnCancel(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
