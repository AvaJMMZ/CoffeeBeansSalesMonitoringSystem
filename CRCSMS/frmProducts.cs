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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void RefreshDataGridView()
        {
            this.tblProductsTableAdapter.Fill(this.cRCSMSDataSet_tblProducts.tblProducts);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddProduct addProductForm = new frmAddProduct();
            addProductForm.ProductAdded += FrmAddProduct_ProductAdded;
            addProductForm.Show();
        }

        private void FrmAddProduct_ProductAdded(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProducts.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                int selectedProductID = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["productIDDataGridViewTextBoxColumn"].Value);

                frmEditProduct editProductForm = new frmEditProduct(selectedProductID);
                editProductForm.StocksUpdated += AddStocksForm_StocksUpdated;
                editProductForm.Show();
            }
            else if (e.ColumnIndex == dgvProducts.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                string selectedProductName = dgvProducts.Rows[e.RowIndex].Cells["productNameDataGridViewTextBoxColumn"].Value.ToString();

                DialogResult result = MessageBox.Show($"Are you sure you want to delete '{selectedProductName}'?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int selectedProductID = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["productIDDataGridViewTextBoxColumn"].Value);

                    DeleteProduct(selectedProductID);
                }
            }
        }

        private void DeleteProduct(int productID)
        {
            try
            {
                using (CRCSMSDataContext db = new CRCSMSDataContext())
                {
                    tblProduct selectedProduct = db.tblProducts.SingleOrDefault(p => p.productID == productID);

                    if (selectedProduct != null)
                    {
                        db.tblProducts.DeleteOnSubmit(selectedProduct);
                        db.SubmitChanges();
                        RefreshDataGridView();
                        MessageBox.Show("Product deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Selected product not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void btnAddStocks_Click(object sender, EventArgs e)
        {
            string password = PromptForPassword();

            if (password == "admin123")
            {
                frmAddStocks addStocksForm = new frmAddStocks();
                addStocksForm.StocksUpdated += AddStocksForm_StocksUpdated;
                addStocksForm.Show();
            }
            else if (password != "")
            {
                MessageBox.Show("Incorrect password. Access denied.");
            }
        }

        private void AddStocksForm_StocksUpdated(object sender, EventArgs e)
        {
            RefreshDataGridView();
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
    }
}
