using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace CRCSMS
{
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            frmAddOrder frmAddOrderForm = new frmAddOrder();
            frmAddOrderForm.OrderAdded += FrmAddOrderForm_OrderAdded;
            frmAddOrderForm.Show();
        }

        private void FrmAddOrderForm_OrderAdded(object sender, EventArgs e)
        {
            this.tblOrderDetailsTableAdapter.Fill(this.cRCSMSDataSet_tblOrderDetails.tblOrderDetails);
            this.tblOrdersTableAdapter.Fill(this.cRCSMSDataSet_tblOrders.tblOrders);
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRCSMSDataSet_tblOrderDetails.tblOrderDetails' table. You can move, or remove it, as needed.
            this.tblOrderDetailsTableAdapter.Fill(this.cRCSMSDataSet_tblOrderDetails.tblOrderDetails);
            this.tblOrdersTableAdapter.Fill(this.cRCSMSDataSet_tblOrders.tblOrders);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.tblOrdersTableAdapter.Fill(this.cRCSMSDataSet_tblOrders.tblOrders);
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = this.cRCSMSDataSet_tblOrders.tblOrders;

            this.tblOrderDetailsTableAdapter.Fill(this.cRCSMSDataSet_tblOrderDetails.tblOrderDetails);
            dgvtblDetails.DataSource = null;
            dgvtblDetails.DataSource = this.cRCSMSDataSet_tblOrderDetails.tblOrderDetails;

            MessageBox.Show("Refresh done.");
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvProducts.Columns["btnViewDetails"].Index)
            {
                int orderID = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["orderIDDataGridViewTextBoxColumn"].Value);

   
                var orderDetails = cRCSMSDataSet_tblOrderDetails.tblOrderDetails.AsEnumerable()
                                    .Where(row => row.Field<int>("orderID") == orderID)
                                    .CopyToDataTable();

                var moreDetails = cRCSMSDataSet_tblOrderDetails.tblOrderDetails.AsEnumerable()
                                    .Where(row => row.Field<int>("orderID") == orderID)
                                    .CopyToDataTable();

                StringBuilder details = new StringBuilder();
                foreach (DataRow row in orderDetails.Rows)
                {
                    details.AppendLine($"Order Detail ID: {row["orderDetailID"]}");
                    details.AppendLine($"Product ID: {row["productID"]}");
                    details.AppendLine($"Roast Type: {row["roastType"]}");
                    details.AppendLine($"Ground Type: {row["groundType"]}");
                    details.AppendLine($"Quantity: {row["quantity"]}");
                    details.AppendLine($"Product Total Payment: {row["productTotalPayment"]}");
                    details.AppendLine();
                }
                lblOrderDetails.Text = details.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string password = PromptForPassword();

            if (password == "admin123")
            {
                if (dgvProducts.SelectedRows.Count > 0)
                {
                    int orderID = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["orderIDDataGridViewTextBoxColumn"].Value);

                    var orderDetailsToDelete = cRCSMSDataSet_tblOrderDetails.tblOrderDetails.AsEnumerable()
                        .Where(row => row.Field<int>("orderID") == orderID).ToList();

                    foreach (var detail in orderDetailsToDelete)
                    {
                        detail.Delete();
                    }

                    tblOrderDetailsTableAdapter.Update(cRCSMSDataSet_tblOrderDetails.tblOrderDetails);

                    var orderToDelete = cRCSMSDataSet_tblOrders.tblOrders.FindByorderID(orderID);
                    if (orderToDelete != null)
                    {
                        orderToDelete.Delete();
                    }

                    tblOrdersTableAdapter.Update(cRCSMSDataSet_tblOrders.tblOrders);

                    this.tblOrdersTableAdapter.Fill(this.cRCSMSDataSet_tblOrders.tblOrders);
                    dgvProducts.DataSource = null;
                    dgvProducts.DataSource = this.cRCSMSDataSet_tblOrders.tblOrders;

                    this.tblOrderDetailsTableAdapter.Fill(this.cRCSMSDataSet_tblOrderDetails.tblOrderDetails);
                    dgvtblDetails.DataSource = null;
                    dgvtblDetails.DataSource = this.cRCSMSDataSet_tblOrderDetails.tblOrderDetails;

                    MessageBox.Show("Order deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Please select an order to delete.");
                }
            }
            else if (password != "")
            {
                MessageBox.Show("Incorrect password. Deletion cancelled.");
            }
        }

        private string PromptForPassword()
        {
            using (var form = new MaterialForm())
            {
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(form);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

                var passwordTextBox = new MaterialSingleLineTextField();
                var okButton = new MaterialRaisedButton();

                form.Text = "Enter Password";
                form.Size = new Size(300, 200);
                form.StartPosition = FormStartPosition.CenterScreen;
                form.FormBorderStyle = FormBorderStyle.None;

                passwordTextBox.PasswordChar = '*';
                passwordTextBox.Hint = "Password";
                passwordTextBox.Location = new Point(50, 80);
                passwordTextBox.Width = 200;

                okButton.Text = "OK";
                okButton.Width = 100;
                okButton.Height = 30;
                okButton.Location = new Point(100, 130);

                // Event handler for OK button click event
                okButton.Click += (sender, e) => form.DialogResult = DialogResult.OK;

                form.Controls.Add(passwordTextBox);
                form.Controls.Add(okButton);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    return passwordTextBox.Text;
                }
                else
                {
                    return null;
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtpFrom.Value.Date;
            DateTime toDate = dtpTo.Value.Date.AddDays(1).AddSeconds(-1); // Add one day and subtract one second to include the entire last day

            // Filter orders between fromDate and toDate
            var filteredOrders = cRCSMSDataSet_tblOrders.tblOrders
                .Where(order => order.dateOrdered >= fromDate && order.dateOrdered <= toDate)
                .ToList();

            // Update DataGridView with filtered orders
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = filteredOrders;
        }
    }
}
