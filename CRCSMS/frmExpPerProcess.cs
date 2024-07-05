using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CRCSMS
{
    public partial class frmExpPerProcess : Form
    {
        public frmExpPerProcess()
        {
            InitializeComponent();
        }

        private void frmExpPerProcess_Load(object sender, EventArgs e) 
        {
            // TODO: This line of code loads data into the 'cRCSMSDataSet_tblExpProcess.tblExpProcess' table. You can move, or remove it, as needed.
            this.tblExpProcessTableAdapter.Fill(this.cRCSMSDataSet_tblExpProcess.tblExpProcess);
        }

        private void FrmAddProcessForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.tblExpProcessTableAdapter.Fill(this.cRCSMSDataSet_tblExpProcess.tblExpProcess);
        }

        private void btnAddProcess_Click(object sender, EventArgs e)
        {
            frmAddProcess frmAddProcessForm = new frmAddProcess();
            frmAddProcessForm.FormClosed += FrmAddProcessForm_FormClosed;
            frmAddProcessForm.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.tblExpProcessTableAdapter.Fill(this.cRCSMSDataSet_tblExpProcess.tblExpProcess);
        }

        private void dgvProcessExp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvProcessExp.Columns["btnViewDetails"].Index)
            {
                int processID = Convert.ToInt32(dgvProcessExp.Rows[e.RowIndex].Cells["processIDDataGridViewTextBoxColumn"].Value);

                using (CRCSMSDataContext db = new CRCSMSDataContext())
                {
                    var processExpDetails = db.tblExpProcesses.FirstOrDefault(p => p.processID == processID);
                    if (processExpDetails != null)
                    {
                        using (frmProcessExpDetails detailsForm = new frmProcessExpDetails())
                        {
                            detailsForm.DisplayProcessExpDetails(processExpDetails);
                            detailsForm.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Process expense details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtpFrom.Value.Date;
            DateTime toDate = dtpTo.Value.Date.AddDays(1); // Add 1 day to include the entire end day

            using (CRCSMSDataContext db = new CRCSMSDataContext())
            {
                var filteredExpenses = db.tblExpProcesses
                    .AsEnumerable() // Switch to LINQ to Objects
                    .Where(expense =>
                    {
                        DateTime dateProcess;
                        return DateTime.TryParseExact(expense.dateProcess, "dd/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateProcess)
                            && dateProcess >= fromDate && dateProcess < toDate;
                    })
                    .ToList();

                // Bind the filtered data to the DataGridView
                dgvProcessExp.DataSource = filteredExpenses;
            }
        }
    }
}
