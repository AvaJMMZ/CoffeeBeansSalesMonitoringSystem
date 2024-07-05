using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRCSMS
{
    public partial class frmReportSales : Form
    {
        public frmReportSales()
        {
            InitializeComponent();
        }

        private void frmReportSales_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
