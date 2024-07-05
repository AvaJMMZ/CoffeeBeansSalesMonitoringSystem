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
    public partial class frmEditProduct : Form
    {
        private int selectedProductID;
        public event EventHandler StocksUpdated;

        public frmEditProduct(int productID)
        {
            InitializeComponent();
            selectedProductID = productID;
            LoadProductDetails();
        }

        private void labelX_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoadProductDetails()
        {
            try
            {
                using (CRCSMSDataContext db = new CRCSMSDataContext())
                {
                    // Get the selected product from the database
                    tblProduct selectedProduct = db.tblProducts.SingleOrDefault(p => p.productID == selectedProductID);

                    if (selectedProduct != null)
                    {
                        // Display the details in the form controls
                        txtProductName.Text = selectedProduct.productName;
                        txtGram.Text = selectedProduct.gram.ToString();
                        txtPrice.Text = selectedProduct.price.ToString();
                        chbMR.Checked = selectedProduct.mediumRoast ?? false;
                        chbDR.Checked = selectedProduct.darkRoast ?? false;
                        chbWB.Checked = selectedProduct.wholeBeans ?? false;
                        chbCG.Checked = selectedProduct.coarseGround ?? false;
                        chbFG.Checked = selectedProduct.fineGround ?? false;
                    }
                    else
                    {
                        MessageBox.Show("Selected product not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product details: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (CRCSMSDataContext db = new CRCSMSDataContext())
                {
                    // Get the selected product from the database
                    tblProduct selectedProduct = db.tblProducts.SingleOrDefault(p => p.productID == selectedProductID);

                    if (selectedProduct != null)
                    {
                        // Update the details with the values from the form controls
                        selectedProduct.productName = txtProductName.Text;
                        selectedProduct.gram = Convert.ToInt32(txtGram.Text);
                        selectedProduct.price = Convert.ToInt32(txtPrice.Text);
                        selectedProduct.mediumRoast = chbMR.Checked;
                        selectedProduct.darkRoast = chbDR.Checked;
                        selectedProduct.wholeBeans = chbWB.Checked;
                        selectedProduct.coarseGround = chbCG.Checked;
                        selectedProduct.fineGround = chbFG.Checked;

                        // Save changes to the database
                        db.SubmitChanges();

                        MessageBox.Show("Product details updated successfully.");
                        StocksUpdated?.Invoke(this, EventArgs.Empty);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Selected product not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product details: " + ex.Message);
            }
        }
    }
}
