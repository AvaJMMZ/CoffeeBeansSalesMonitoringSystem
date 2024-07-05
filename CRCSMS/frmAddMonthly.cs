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
    public partial class frmAddMonthly : Form
    {
        public frmAddMonthly()
        {
            InitializeComponent();
        }
        private void labelX_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAddMonthly_Click(object sender, EventArgs e)
        {
            string monthName = txtMonthExp.Text;
            string monthlyBudget = numMonthBud.Value.ToString();

            tblMonthlyExp newMonthlyExp = new tblMonthlyExp
            {
                monthExpName = monthName,
                monthlyBudget = monthlyBudget
            };

            using (CRCSMSDataContext db = new CRCSMSDataContext())
            {
                db.tblMonthlyExps.InsertOnSubmit(newMonthlyExp);
                db.SubmitChanges();
            }

            MessageBox.Show("Monthly expense added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtMonthExp.Text = "";
            numMonthBud.Text = "";
            this.Close();
        }
    }
}
