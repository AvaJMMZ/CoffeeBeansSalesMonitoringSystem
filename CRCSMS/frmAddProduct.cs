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
    public partial class frmAddProduct : Form
    {
        public event EventHandler ProductAdded;

        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void labelX_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                using (CRCSMSDataContext db = new CRCSMSDataContext())
                {
                    tblProduct newProduct = new tblProduct();

                    newProduct.productName = txtProductName.Text;
                    newProduct.gram = Convert.ToInt32(txtGram.Text);
                    newProduct.price = Convert.ToInt32(txtPrice.Text);
                    newProduct.stocks = 0;
                    newProduct.mediumRoast = chbMR.Checked;
                    newProduct.darkRoast = chbDR.Checked;
                    newProduct.wholeBeans = chbWB.Checked;
                    newProduct.coarseGround = chbCG.Checked;
                    newProduct.fineGround = chbFG.Checked;

                    db.tblProducts.InsertOnSubmit(newProduct);
                    db.SubmitChanges();
                    MessageBox.Show("Product added successfully.");
                }

                OnProductAdded();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message);
            }
        }

        private void OnProductAdded()
        {
            ProductAdded?.Invoke(this, EventArgs.Empty);
        }
    }
}
