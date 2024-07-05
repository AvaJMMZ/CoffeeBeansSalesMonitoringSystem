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
    public partial class frmMoreDetails : Form
    {
        private int productID;
        private string productName;
        private int gram;
        private int price;
        private bool mediumRoast;
        private bool darkRoast;
        private bool wholeBeans;
        private bool coarseGround;
        private bool fineGround;

        private frmAddOrder addOrderForm;

        private int stocks;

        public frmMoreDetails(frmAddOrder addOrderForm, int productID, string productName, int gram, int price, int stocks, bool mediumRoast, bool darkRoast, bool wholeBeans, bool coarseGround, bool fineGround)
        {
            InitializeComponent();

            // Assign values to class-level variables
            this.productID = productID;
            this.productName = productName;
            this.gram = gram;
            this.price = price;
            this.mediumRoast = mediumRoast;
            this.darkRoast = darkRoast;
            this.wholeBeans = wholeBeans;
            this.coarseGround = coarseGround;
            this.fineGround = fineGround;
            this.stocks = stocks;

            this.addOrderForm = addOrderForm;

            rbMR.Enabled = mediumRoast;
            rbMR.ForeColor = mediumRoast ? System.Drawing.Color.Black : System.Drawing.Color.Gray;

            rbDR.Enabled = darkRoast;
            rbDR.ForeColor = darkRoast ? System.Drawing.Color.Black : System.Drawing.Color.Gray;

            rbWB.Enabled = wholeBeans;
            rbWB.ForeColor = wholeBeans ? System.Drawing.Color.Black : System.Drawing.Color.Gray;

            rbCG.Enabled = coarseGround;
            rbCG.ForeColor = coarseGround ? System.Drawing.Color.Black : System.Drawing.Color.Gray;

            rbFG.Enabled = fineGround;
            rbFG.ForeColor = fineGround ? System.Drawing.Color.Black : System.Drawing.Color.Gray;

            labelID.Text = $"{productID}";
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if (updownQuantity.Value <= 0)
            {
                MessageBox.Show("Please enter a quantity greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Do not proceed if quantity is 0 or less
            }

            if ((int)updownQuantity.Value > stocks)
            {
                MessageBox.Show($"The selected quantity exceeds the available stocks ({stocks}).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Do not proceed if quantity exceeds stocks
            }

            if (!rbMR.Checked && !rbDR.Checked)
            {
                MessageBox.Show("Please select a roast type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Do not proceed if no roast type is selected
            }

            if (!rbFG.Checked && !rbCG.Checked && !rbWB.Checked)
            {
                MessageBox.Show("Please select a ground type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Do not proceed if no ground type is selected
            }

            string groundType = GetSelectedGroundType();
            string roastType = GetSelectedRoastType();

            int quantity = (int)updownQuantity.Value;
            decimal productTotalPayment = quantity * price;

            addOrderForm.AddProductToOrder(productID, roastType, groundType, quantity, productTotalPayment);
            this.Close();
        }


        private string GetSelectedGroundType()
        {
            if (rbFG.Checked)
                return "Fine Ground";
            else if (rbCG.Checked)
                return "Coarse Ground";
            else if (rbWB.Checked)
                return "Whole Beans";
            else
                return string.Empty;
        }

        private string GetSelectedRoastType()
        {
            if (rbMR.Checked)
                return "Medium Roast";
            else if (rbDR.Checked)
                return "Dark Roast";
            else
                return string.Empty;
        }
    }
}
