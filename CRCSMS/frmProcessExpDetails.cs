using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace CRCSMS
{
    public partial class frmProcessExpDetails : Form
    {
        private tblExpProcess displayedProcessExp;

        public frmProcessExpDetails()
        {
            InitializeComponent();
        }

        public void DisplayProcessExpDetails(tblExpProcess processExp)
        {
            if (processExp != null)
            {
                displayedProcessExp = processExp;

                // Display all the details in the appropriate labels
                labelcoffeeBean.Text = processExp.coffeeBean ?? "None";
                labelpriceCB.Text = processExp.priceCB?.ToString() ?? "None";
                labeltotalexpCD.Text = processExp.totalexpCD?.ToString() ?? "None";
                labelworker.Text = processExp.worker ?? "None";
                labelsalary.Text = processExp.salary?.ToString() ?? "None";
                labeltotalSalary.Text = processExp.totalSalary?.ToString() ?? "None";
                labelsticker.Text = processExp.sticker ?? "None";
                labelpriceSt.Text = processExp.priceSt?.ToString() ?? "None";
                labeltotalexpSt.Text = processExp.totalexpSt?.ToString() ?? "None";
                labelgasTank.Text = processExp.gasTank ?? "None";
                labelpriceGS.Text = processExp.priceGS?.ToString() ?? "None";
                labeltotalexpGS.Text = processExp.totalexpGS?.ToString() ?? "None";
                labelaPU.Text = processExp.aPU?.ToString() ?? "None";
                labelaPP.Text = processExp.aPP?.ToString() ?? "None";
                labelaTotal.Text = processExp.aTotal?.ToString() ?? "None";
                labelbPU.Text = processExp.bPU?.ToString() ?? "None";
                labelbPP.Text = processExp.bPP?.ToString() ?? "None";
                labelbTotal.Text = processExp.bTotal?.ToString() ?? "None";
                labelcPU.Text = processExp.cPU?.ToString() ?? "None";
                labelcPP.Text = processExp.cPP?.ToString() ?? "None";
                labelcTotal.Text = processExp.cTotal?.ToString() ?? "None";
                labeltotalexpProcess.Text = processExp.totalexpProcess?.ToString() ?? "None";
            }
            else
            {
                MessageBox.Show("Process expense details object is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Create an instance of PrintDocument.
            PrintDocument pd = new PrintDocument();

            // Add PrintPage event handler.
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);

            // Create an instance of PrintPreviewDialog.
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();

            // Set the PrintDocument property of PrintPreviewDialog to the PrintDocument instance.
            printPreviewDialog.Document = pd;

            // Show the preview dialog.
            printPreviewDialog.ShowDialog();
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12);
            Brush brush = Brushes.Black;

            float yPos = 10;
            float leftMargin = e.MarginBounds.Left;

            string businessName = "CLINTON’S ROBUSTA COFFEE";
            string businessAddress = "123 Main Street, City, State ZIP";
            string businessContact = "Phone: (123) 456-7890";
            string receiptInfo = $"Process ID: {displayedProcessExp.processID.ToString()}   Date: {displayedProcessExp.dateProcess.ToString()}";

            e.Graphics.DrawString(businessName, new Font(font, FontStyle.Bold), brush, leftMargin, yPos);
            yPos += font.GetHeight();
            e.Graphics.DrawString(businessAddress, font, brush, leftMargin, yPos);
            yPos += font.GetHeight();
            e.Graphics.DrawString(businessContact, font, brush, leftMargin, yPos);
            yPos += font.GetHeight() * 2;
            e.Graphics.DrawString(receiptInfo, font, brush, leftMargin, yPos);
            yPos += font.GetHeight() * 2;

            string header = "Item".PadRight(30) + "Quantity".PadRight(20) + "Price".PadRight(15) + "Subtotal\n";

            e.Graphics.DrawString(header, new Font(font, FontStyle.Bold), brush, leftMargin, yPos);
            yPos += font.GetHeight();

            string[,] items = {
                {"Coffee Bean [kg.]", labelcoffeeBean.Text, labelpriceCB.Text, labeltotalexpCD.Text},
                {"Worker [prsn.]", labelworker.Text, labelsalary.Text, labeltotalSalary.Text},
                {"Sticker [rm.]", labelsticker.Text, labelpriceSt.Text, labeltotalexpSt.Text},
                {"Prophane Tank [tnk.]", labelgasTank.Text, labelpriceGS.Text, labeltotalexpGS.Text},
                {"200g Pouch [pcs.]", labelaPU.Text, labelaPP.Text, labelaTotal.Text},
                {"250g Pouch [pcs.]", labelbPU.Text, labelbPP.Text, labelbTotal.Text},
                {"500g Pouch [pcs.]", labelcPU.Text, labelcPP.Text, labelcTotal.Text}
            };

            for (int i = 0; i < items.GetLength(0); i++)
            {
                string itemName = items[i, 0];
                string itemQuantity = items[i, 1];
                string itemPrice = items[i, 2];
                string itemSubtotal = items[i, 3];

                e.Graphics.DrawString(itemName, font, brush, leftMargin, yPos);
                e.Graphics.DrawString(itemQuantity, font, brush, leftMargin + 155, yPos);
                e.Graphics.DrawString(itemPrice, font, brush, leftMargin + 300, yPos);
                e.Graphics.DrawString(itemSubtotal, font, brush, leftMargin + 400, yPos);
                yPos += font.GetHeight();
            }

            yPos += font.GetHeight() * 2;

            string totalExpensesLabel = "Total Expenses: ";
            string totalExpenses = labeltotalexpProcess.Text;

            // Print total expenses.
            string totalExpensesDetails = $"{totalExpensesLabel.PadLeft(25)}{totalExpenses.PadLeft(15)}";
            e.Graphics.DrawString(totalExpensesDetails, new Font(font, FontStyle.Bold), brush, leftMargin, yPos);
            yPos += font.GetHeight() * 2;

            // Print footer.
            string thankYouMessage = "This is your process expenses!";
            e.Graphics.DrawString(thankYouMessage, font, brush, leftMargin, yPos);

            // Check if more pages are to be printed.
            e.HasMorePages = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (displayedProcessExp != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this process expense?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Assuming CRCSMSDataContext is your DataContext class
                        using (var dbContext = new CRCSMSDataContext())
                        {
                            var processToDelete = dbContext.tblExpProcesses.SingleOrDefault(p => p.processID == displayedProcessExp.processID);

                            if (processToDelete != null)
                            {
                                dbContext.tblExpProcesses.DeleteOnSubmit(processToDelete);
                                dbContext.SubmitChanges();

                                MessageBox.Show("Process expense deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Close the form
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Process expense not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No process expense details to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
