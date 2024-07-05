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
    public partial class frmExpMonthly : Form
    {
        public frmExpMonthly()
        {
            InitializeComponent();
        }

        private void frmExpMonthly_Load(object sender, EventArgs e)
        {
            this.tblMonthlyExpTableAdapter.Fill(this.cRCSMSDataSet_tblMonthlyExp.tblMonthlyExp);
        }

        private void btnAddMonthly_Click(object sender, EventArgs e)
        {
            frmAddMonthly frmAddMonthlyForm = new frmAddMonthly();
            frmAddMonthlyForm.FormClosed += frmAddMonthlyForm_FormClosed;
            frmAddMonthlyForm.Show();
        }

        private void frmAddMonthlyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.tblMonthlyExpTableAdapter.Fill(this.cRCSMSDataSet_tblMonthlyExp.tblMonthlyExp);
        }

        private void dgvExpMonthly_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is the button column and it is not the header row
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvExpMonthly.Columns["btnDelete"].Index)
            {
                // Get the monthExpID of the selected row
                int monthExpID = Convert.ToInt32(dgvExpMonthly.Rows[e.RowIndex].Cells["monthExpIDDataGridViewTextBoxColumn"].Value);

                // Ask for confirmation before deleting
                DialogResult result = MessageBox.Show("Are you sure you want to delete this monthly expense?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Delete the record from the database
                    using (CRCSMSDataContext db = new CRCSMSDataContext())
                    {
                        // Find the monthly expense record to delete
                        var expenseToDelete = db.tblMonthlyExps.SingleOrDefault(exp => exp.monthExpID == monthExpID);
                        if (expenseToDelete != null)
                        {
                            // Remove the record from the database
                            db.tblMonthlyExps.DeleteOnSubmit(expenseToDelete);
                            db.SubmitChanges();

                            // Remove the row from the DataGridView
                            dgvExpMonthly.Rows.RemoveAt(e.RowIndex);

                            MessageBox.Show("Monthly expense deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Monthly expense not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
