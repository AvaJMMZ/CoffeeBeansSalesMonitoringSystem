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
    public partial class frmAddOrder : Form
    {
        public event EventHandler OrderAdded;

        public frmAddOrder()
        {
            InitializeComponent();
        }

        private void labelX_Click(object sender, EventArgs e)
        {
            RestoreAllStocksInCart();
            this.Hide();
        }

        private void RestoreAllStocksInCart()
        {
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                int productID = Convert.ToInt32(row.Cells["productID"].Value);
                int quantity = Convert.ToInt32(row.Cells["quantity"].Value);
                RestoreStocksInDatabase(productID, quantity);
            }
        }

        private void frmAddOrder_Load(object sender, EventArgs e)
        {
            this.tblProductsTableAdapter.Fill(this.cRCSMSDataSet_dgvProductList.tblProducts);
            DisplayProductInformation();
        }

        private void DisplayProductInformation()
        {
            conAllProducts.Controls.Clear();

            foreach (DataGridViewRow row in dgvProductList.Rows)
            {
                int productID = Convert.ToInt32(row.Cells["productIDDataGridViewTextBoxColumn"].Value);
                string productName = row.Cells["productNameDataGridViewTextBoxColumn"].Value.ToString();
                int gram = Convert.ToInt32(row.Cells["gramDataGridViewTextBoxColumn"].Value);
                int price = Convert.ToInt32(row.Cells["priceDataGridViewTextBoxColumn"].Value);
                int stocks = Convert.ToInt32(row.Cells["stocksDataGridViewTextBoxColumn"].Value);

                bool mediumRoast = Convert.ToBoolean(row.Cells["mediumRoastDataGridViewCheckBoxColumn"].Value);
                bool darkRoast = Convert.ToBoolean(row.Cells["darkRoastDataGridViewCheckBoxColumn"].Value);
                bool wholeBeans = Convert.ToBoolean(row.Cells["wholeBeansDataGridViewCheckBoxColumn"].Value);
                bool coarseGround = Convert.ToBoolean(row.Cells["coarseGroundDataGridViewCheckBoxColumn"].Value);
                bool fineGround = Convert.ToBoolean(row.Cells["fineGroundDataGridViewCheckBoxColumn"].Value);

                Label labelProductName = new Label();
                labelProductName.Text = $"{productName}";
                labelProductName.AutoSize = false;
                labelProductName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelProductName.ForeColor = System.Drawing.Color.Maroon;
                labelProductName.Location = new System.Drawing.Point(13, 10);
                labelProductName.Size = new System.Drawing.Size(300, 22);
                labelProductName.TabIndex = 6;

                Label labelProductID = new Label();
                labelProductID.Text = $"ID: {productID}";
                labelProductID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
                labelProductID.ForeColor = System.Drawing.Color.Maroon;
                labelProductID.Location = new System.Drawing.Point(27, 43);
                labelProductID.Size = new System.Drawing.Size(300, 19);
                labelProductID.TabIndex = 7;

                Label labelGram = new Label();
                labelGram.Text = $"Gram: {gram}g";
                labelGram.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
                labelGram.ForeColor = System.Drawing.Color.Maroon;
                labelGram.Location = new System.Drawing.Point(27, 75);
                labelGram.Size = new System.Drawing.Size(300, 19);
                labelGram.TabIndex = 9;

                Label labelPrice = new Label();
                labelPrice.Text = $"Price: ₱{price}";
                labelPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
                labelPrice.ForeColor = System.Drawing.Color.Maroon;
                labelPrice.Location = new System.Drawing.Point(27, 106);
                labelPrice.Size = new System.Drawing.Size(300, 19);
                labelPrice.TabIndex = 8;

                Label labelStocks = new Label();
                labelStocks.Name = $"labelStocks{productID}";
                labelStocks.Text = $"Stocks: {stocks} remaining";
                labelStocks.Font = new System.Drawing.Font("Arial", 8F);
                labelStocks.ForeColor = System.Drawing.Color.Maroon;
                labelStocks.Location = new System.Drawing.Point(27, 137);
                labelStocks.Size = new System.Drawing.Size(300, 19);
                labelStocks.TabIndex = 8;

                Panel conProduct = new Panel();
                conProduct.Controls.AddRange(new Control[] { labelProductID, labelProductName, labelGram, labelPrice, labelStocks});
                conProduct.Click += (sender, e) => conProduct_Click(sender, e, productID, productName, gram, price, stocks, mediumRoast, darkRoast, wholeBeans, coarseGround, fineGround);
                conProduct.BackColor = System.Drawing.Color.SandyBrown;
                conProduct.Location = new System.Drawing.Point(10, 10);
                conProduct.Margin = new System.Windows.Forms.Padding(10);
                conProduct.Size = new System.Drawing.Size(276, 154);
                conProduct.TabIndex = 0;
                conProduct.Cursor = Cursors.Hand;
                conProduct.MouseEnter += (sender, e) => conProduct_MouseEnter(sender, e, conProduct);
                conProduct.MouseLeave += (sender, e) => conProduct_MouseLeave(sender, e, conProduct);


                conAllProducts.Controls.Add(conProduct);
            }
        }

        private void conProduct_Click(object sender, EventArgs e, int productID, string productName, int gram, int price, int stocks, bool mediumRoast, bool darkRoast, bool wholeBeans, bool coarseGround, bool fineGround)
        {
            // Check if stocks are 0 and disable click event handler
            if (stocks == 0)
            {
                MessageBox.Show($"Product '{productName}' is out of stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmMoreDetails moreDetailsForm = new frmMoreDetails(this, productID, productName, gram, price, stocks, mediumRoast, darkRoast, wholeBeans, coarseGround, fineGround);
                moreDetailsForm.ShowDialog();
            }
        }

        private void conProduct_MouseEnter(object sender, EventArgs e, Panel conProduct)
        {
            conProduct.BackColor = System.Drawing.Color.Orange;
        }

        private void conProduct_MouseLeave(object sender, EventArgs e, Panel conProduct)
        {
            conProduct.BackColor = System.Drawing.Color.SandyBrown;
        }

        public void AddProductToOrder(int productID, string roastType, string groundType, int quantity, decimal productTotalPayment)
        {
            dgvCart.Rows.Add(productID, roastType, groundType, quantity, productTotalPayment);

            UpdateStocksInDatabase(productID, quantity);

            RefreshDataGridView();

            RefreshProductList();

            MessageBox.Show("Product added to the order!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RefreshProductList()
        {
            this.tblProductsTableAdapter.Fill(this.cRCSMSDataSet_dgvProductList.tblProducts);

            foreach (DataGridViewRow row in dgvProductList.Rows)
            {
                int productID = Convert.ToInt32(row.Cells["productIDDataGridViewTextBoxColumn"].Value);
                int stocks = Convert.ToInt32(row.Cells["stocksDataGridViewTextBoxColumn"].Value);

                // Find the labelStocks control for the current productID
                Label labelStocks = conAllProducts.Controls.Find($"labelStocks{productID}", true).FirstOrDefault() as Label;

                if (labelStocks != null)
                {
                    // Update the label text with the new stocks value
                    labelStocks.Text = $"Stocks: {stocks} remaining";
                }
            }
        }

        private void UpdateStocksInDatabase(int productID, int quantity)
        {
            using (CRCSMSDataContext db = new CRCSMSDataContext())
            {
                var product = db.tblProducts.FirstOrDefault(p => p.productID == productID);
                if (product != null)
                {
                    product.stocks -= quantity;
                    db.SubmitChanges();
                }
            }
        }

        private void RefreshDataGridView()
        {
            dgvCart.Refresh();
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is the "Delete" button column
            if (e.ColumnIndex == dgvCart.Columns["delete"].Index && e.RowIndex >= 0)
            {
                // Get the productID from the clicked row
                int productIDToDelete = Convert.ToInt32(dgvCart.Rows[e.RowIndex].Cells["productID"].Value);

                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Perform the deletion
                    DeleteProductFromOrder(productIDToDelete);
                }
            }
        }

        private void DeleteProductFromOrder(int productID)
        {
            // Find the row with the specified productID
            DataGridViewRow rowToDelete = null;
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (Convert.ToInt32(row.Cells["productID"].Value) == productID)
                {
                    rowToDelete = row;
                    break;
                }
            }

            // Delete the row if found
            if (rowToDelete != null)
            {
                // Retrieve the quantity of the product being deleted
                int quantityToDelete = Convert.ToInt32(rowToDelete.Cells["quantity"].Value);

                RestoreStocksInDatabase(productID, quantityToDelete);

                // Remove the row from the cart
                dgvCart.Rows.Remove(rowToDelete);

                // Refresh the DataGridView
                RefreshDataGridView();

                RefreshProductList();

                MessageBox.Show("Product deleted from the order!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Product not found in the order!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RestoreStocksInDatabase(int productID, int quantity)
        {
            using (CRCSMSDataContext db = new CRCSMSDataContext())
            {
                var product = db.tblProducts.FirstOrDefault(p => p.productID == productID);
                if (product != null)
                {
                    product.stocks += quantity;
                    db.SubmitChanges();
                }
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a name before submitting.");
                return;
            }

            using (CRCSMSDataContext db = new CRCSMSDataContext())
            {
                tblOrder newOrder = new tblOrder
                {
                    name = txtName.Text,
                    dateOrdered = DateTime.Now,
                    orderTotalPayment = CalculateTotalPayment()
                };

                db.tblOrders.InsertOnSubmit(newOrder);
                db.SubmitChanges();

                int orderID = newOrder.orderID;

                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    int productID = Convert.ToInt32(row.Cells["productID"].Value);
                    string roastType = row.Cells["roastType"].Value.ToString();
                    string groundType = row.Cells["groundType"].Value.ToString();
                    int quantity = Convert.ToInt32(row.Cells["quantity"].Value);
                    int productTotalPayment = Convert.ToInt32(row.Cells["productTotalPayment"].Value);

                    tblOrderDetail orderDetail = new tblOrderDetail
                    {
                        orderID = orderID,
                        productID = productID,
                        roastType = roastType,
                        groundType = groundType,
                        quantity = quantity,
                        productTotalPayment = productTotalPayment
                    };

                    db.tblOrderDetails.InsertOnSubmit(orderDetail);
                    db.SubmitChanges();
                }

                MessageBox.Show("Order added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OrderAdded?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
        }

        private int CalculateTotalPayment()
        {
            int totalPayment = 0;

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                totalPayment += Convert.ToInt32(row.Cells["productTotalPayment"].Value);
            }

            return totalPayment;
        }
    }
}
