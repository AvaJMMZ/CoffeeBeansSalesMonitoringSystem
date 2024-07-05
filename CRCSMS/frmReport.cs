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
    public partial class frmReport : Form
    {
        frmReportSales salesReportForm;

        public frmReport()
        {
            InitializeComponent();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            if (salesReportForm == null)
            {
                salesReportForm = new frmReportSales();
                salesReportForm.FormClosed += ProductsForm_FormClosed;
                salesReportForm.MdiParent = this;
                salesReportForm.Dock = DockStyle.Fill;
                salesReportForm.Show();
            }
            else
            {
                salesReportForm.Activate();
            }
        }

        private void ProductsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            salesReportForm = null;
        }
    }
}
