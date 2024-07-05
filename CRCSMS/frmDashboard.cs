using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CRCSMS
{
    public partial class frmDashboard : Form
    {
        frmProducts productsForm;
        frmSales salesForm;
        frmExpPerProcess expPerProcessForm;
        frmExpMonthly expMonthlyForm;
        frmReport reportForm;
        private CRCSMSDataContext db = new CRCSMSDataContext();
        private List<int> yearsList;

        public frmDashboard()
        {
            InitializeComponent();
            InitializeButtonEvents();
            PopulateYears();

            btnHome.MouseEnter += (sender, e) =>
            {
                btnHome.BackColor = Color.Maroon;
            };

            btnHome.MouseLeave += (sender, e) =>
            {
                btnHome.BackColor = Color.SandyBrown;
            };
        }

        private void PopulateYears()
        {
            yearsList = db.tblOrders.Select(order => order.dateOrdered.Value.Year).Distinct().ToList();
            cbYear.Items.Add("ALL");
            foreach (int year in yearsList)
            {
                cbYear.Items.Add(year);
            }
            cbYear.SelectedIndex = 0;
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            menuExpenses.Show(btnExpenses, new Point(1, btnExpenses.Height + 5));
        }

        private void btnYourProducts_Click(object sender, EventArgs e)
        {
            panelReport.Visible = false;

            if (productsForm == null)
            {
                productsForm = new frmProducts();
                productsForm.FormClosed += ProductsForm_FormClosed;
                productsForm.MdiParent = this;
                productsForm.Dock = DockStyle.Fill;
                productsForm.Show();
            }
            else
            {
                productsForm.Activate();
            }
        }

        private void ProductsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            productsForm = null;
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            panelReport.Visible = false;

            if (salesForm == null)
            {
                salesForm = new frmSales();
                salesForm.FormClosed += SalesForm_FormClosed;
                salesForm.MdiParent = this;
                salesForm.Dock = DockStyle.Fill;
                salesForm.Show();
            }
            else
            {
                salesForm.Activate();
            }
        }

        private void SalesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            salesForm = null;
        }

        private void perProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelReport.Visible = false;

            if (expPerProcessForm == null)
            {
                expPerProcessForm = new frmExpPerProcess();
                expPerProcessForm.FormClosed += ExpPerProcessForm_FormClosed;
                expPerProcessForm.MdiParent = this;
                expPerProcessForm.Dock = DockStyle.Fill;
                expPerProcessForm.Show();
            }
            else
            {
                expPerProcessForm.Activate();
            }
        }

        private void ExpPerProcessForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            expPerProcessForm = null;
        }

        private void monthlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelReport.Visible = false;

            if (expMonthlyForm == null)
            {
                expMonthlyForm = new frmExpMonthly();
                expMonthlyForm.FormClosed += ExpMonthlyForm_FormClosed;
                expMonthlyForm.MdiParent = this;
                expMonthlyForm.Dock = DockStyle.Fill;
                expMonthlyForm.Show();
            }
            else
            {
                expMonthlyForm.Activate();
            }
        }

        private void ExpMonthlyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            expMonthlyForm = null;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            panelReport.Visible = false;

            if (reportForm == null)
            {
                reportForm = new frmReport();
                reportForm.FormClosed += reportForm_FormClosed;
                reportForm.MdiParent = this;
                reportForm.Dock = DockStyle.Fill;
                reportForm.Show();
            }
            else
            {
                productsForm.Activate();
            }
        }

        private void reportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportForm = null;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelReport.Visible = true;
        }

        private void InitializeButtonEvents()
        {
            btnYourProducts.MouseEnter += AllButton_MouseEnter;
            btnYourProducts.MouseLeave += AllButton_MouseLeave;

            btnSales.MouseEnter += AllButton_MouseEnter;
            btnSales.MouseLeave += AllButton_MouseLeave;

            btnExpenses.MouseEnter += AllButton_MouseEnter;
            btnExpenses.MouseLeave += AllButton_MouseLeave;
        }

        private void AllButton_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.Maroon;
            button.ForeColor = Color.SandyBrown;
        }

        private void AllButton_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.SandyBrown;
            button.ForeColor= Color.Maroon;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            // Iterate over each month
            for (int month = 1; month <= 12; month++)
            {
                // Fetch sales for the current month
                var sales = (from order in db.tblOrders
                             where order.dateOrdered.HasValue && order.dateOrdered.Value.Month == month
                             select order.orderTotalPayment).Sum();

                // Fetch all expenses from the database
                var allExpenses = (from expense in db.tblExpProcesses
                                   select expense).ToList();

                // Filter and sum expenses for the current month in memory
                var expenses = allExpenses.Where(expense => {
                    DateTime date;
                    return DateTime.TryParseExact(expense.dateProcess, "dd/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out date) && date.Month == month;
                }).Sum(expense => Convert.ToInt32(expense.totalexpProcess));

                // Fetch and sum all monthly budgets
                var sumMonthlyBudget = db.tblMonthlyExps
                                .Select(exp => Convert.ToInt32(exp.monthlyBudget))
                                .Sum();

                // Add monthlyBudget to expenses
                expenses += sumMonthlyBudget;
                var income = sales - expenses;

                // Format numbers with peso sign and thousands separator
                string formattedSales = sales != null ? string.Format("₱{0:#,0}", sales) : "NONE";
                string formattedExpenses = expenses != 0 ? string.Format("₱{0:#,0}", expenses) : "NONE";
                string formattedIncome = (income != 0 && income != null) ? string.Format("₱{0:#,0}", income) : "NONE";

                // Adjust expenses to NONE if equal to monthly sum
                if ((sales != 0 || sales == null) && income > 0)
                {
                    formattedExpenses = string.Format("₱{0:#,0}", expenses);
                }
                else if (expenses == sumMonthlyBudget)
                {
                    formattedExpenses = "NONE";
                }

                // Update labels for the current month
                switch (month)
                {
                    case 1:
                        lblJanSales.Text = formattedSales;
                        lblJanExpenses.Text = formattedExpenses;
                        lblJanIncome.Text = formattedIncome;
                        break;
                    case 2:
                        lblFebSales.Text = formattedSales;
                        lblFebExpenses.Text = formattedExpenses;
                        lblFebIncome.Text = formattedIncome;
                        break;
                    case 3:
                        lblMarSales.Text = formattedSales;
                        lblMarExpenses.Text = formattedExpenses;
                        lblMarIncome.Text = formattedIncome;
                        break;
                    case 4:
                        lblAprSales.Text = formattedSales;
                        lblAprExpenses.Text = formattedExpenses;
                        lblAprIncome.Text = formattedIncome;
                        break;
                    case 5:
                        lblMaySales.Text = formattedSales;
                        lblMayExpenses.Text = formattedExpenses;
                        lblMayIncome.Text = formattedIncome;
                        break;
                    case 6:
                        lblJuneSales.Text = formattedSales;
                        lblJuneExpenses.Text = formattedExpenses;
                        lblJuneIncome.Text = formattedIncome;
                        break;
                    case 7:
                        lblJulySales.Text = formattedSales;
                        lblJulyExpenses.Text = formattedExpenses;
                        lblJulyIncome.Text = formattedIncome;
                        break;
                    case 8:
                        lblAugSales.Text = formattedSales;
                        lblAugExpenses.Text = formattedExpenses;
                        lblAugIncome.Text = formattedIncome;
                        break;
                    case 9:
                        lblSeptSales.Text = formattedSales;
                        lblSeptExpenses.Text = formattedExpenses;
                        lblSeptIncome.Text = formattedIncome;
                        break;
                    case 10:
                        lblOctSales.Text = formattedSales;
                        lblOctExpenses.Text = formattedExpenses;
                        lblOctIncome.Text = formattedIncome;
                        break;
                    case 11:
                        lblNovSales.Text = formattedSales;
                        lblNovExpenses.Text = formattedExpenses;
                        lblNovIncome.Text = formattedIncome;
                        break;
                    case 12:
                        lblDecSales.Text = formattedSales;
                        lblDecExpenses.Text = formattedExpenses;
                        lblDecIncome.Text = formattedIncome;
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            db.Dispose();
            db = new CRCSMSDataContext();

            cbYear.SelectedIndex = 0;

            frmDashboard_Load(sender, e);
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected year from the combo box
            string selectedYear = cbYear.SelectedItem.ToString();

            // Determine whether "ALL" is selected
            bool allSelected = selectedYear == "ALL";

            // Iterate over each month
            for (int month = 1; month <= 12; month++)
            {
                // Fetch sales for the current year and month
                var sales = allSelected ?
                    (from order in db.tblOrders
                     where order.dateOrdered.HasValue && order.dateOrdered.Value.Month == month
                     select order.orderTotalPayment).Sum() :
                    (from order in db.tblOrders
                     where order.dateOrdered.HasValue && order.dateOrdered.Value.Year.ToString() == selectedYear && order.dateOrdered.Value.Month == month
                     select order.orderTotalPayment).Sum();

                // Fetch all expenses for the current year and month from the database
                var allExpenses = allSelected ?
                    (from expense in db.tblExpProcesses
                     select expense).ToList() :
                    (from expense in db.tblExpProcesses
                     select expense)
                    .ToList()
                    .Where(expense => {
                        DateTime date;
                        return DateTime.TryParseExact(expense.dateProcess, "dd/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out date) && date.Year.ToString() == selectedYear;
                    }).ToList();

                // Filter and sum expenses for the current year and month in memory
                var expenses = allSelected ?
                    allExpenses.Where(expense =>
                    {
                        DateTime date;
                        return DateTime.TryParseExact(expense.dateProcess, "dd/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out date) && date.Month == month;
                    }).Sum(expense => Convert.ToInt32(expense.totalexpProcess)) :
                    allExpenses.Where(expense =>
                    {
                        DateTime date;
                        return DateTime.TryParseExact(expense.dateProcess, "dd/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out date) && date.Month == month;
                    }).Sum(expense => Convert.ToInt32(expense.totalexpProcess));

                // Fetch and sum all monthly budgets for the selected year
                var sumMonthlyBudget = db.tblMonthlyExps
                                .Select(exp => Convert.ToInt32(exp.monthlyBudget))
                                .Sum();

                // Add monthlyBudget to expenses
                expenses += sumMonthlyBudget;
                var income = sales - expenses;

                // Format numbers with peso sign and thousands separator
                string formattedSales = sales != null ? string.Format("₱{0:#,0}", sales) : "NONE";
                string formattedExpenses = expenses != 0 ? string.Format("₱{0:#,0}", expenses) : "NONE";
                string formattedIncome = (income != 0 && income != null) ? string.Format("₱{0:#,0}", income) : "NONE";

                // Adjust expenses to NONE if equal to monthly sum
                if ((sales != 0 || sales == null) && income > 0)
                {
                    formattedExpenses = string.Format("₱{0:#,0}", expenses);
                }
                else if (expenses == sumMonthlyBudget)
                {
                    formattedExpenses = "NONE";
                }

                // Update labels for the current month
                switch (month)
                {
                    case 1:
                        lblJanSales.Text = formattedSales;
                        lblJanExpenses.Text = formattedExpenses;
                        lblJanIncome.Text = formattedIncome;
                        break;
                    case 2:
                        lblFebSales.Text = formattedSales;
                        lblFebExpenses.Text = formattedExpenses;
                        lblFebIncome.Text = formattedIncome;
                        break;
                    case 3:
                        lblMarSales.Text = formattedSales;
                        lblMarExpenses.Text = formattedExpenses;
                        lblMarIncome.Text = formattedIncome;
                        break;
                    case 4:
                        lblAprSales.Text = formattedSales;
                        lblAprExpenses.Text = formattedExpenses;
                        lblAprIncome.Text = formattedIncome;
                        break;
                    case 5:
                        lblMaySales.Text = formattedSales;
                        lblMayExpenses.Text = formattedExpenses;
                        lblMayIncome.Text = formattedIncome;
                        break;
                    case 6:
                        lblJuneSales.Text = formattedSales;
                        lblJuneExpenses.Text = formattedExpenses;
                        lblJuneIncome.Text = formattedIncome;
                        break;
                    case 7:
                        lblJulySales.Text = formattedSales;
                        lblJulyExpenses.Text = formattedExpenses;
                        lblJulyIncome.Text = formattedIncome;
                        break;
                    case 8:
                        lblAugSales.Text = formattedSales;
                        lblAugExpenses.Text = formattedExpenses;
                        lblAugIncome.Text = formattedIncome;
                        break;
                    case 9:
                        lblSeptSales.Text = formattedSales;
                        lblSeptExpenses.Text = formattedExpenses;
                        lblSeptIncome.Text = formattedIncome;
                        break;
                    case 10:
                        lblOctSales.Text = formattedSales;
                        lblOctExpenses.Text = formattedExpenses;
                        lblOctIncome.Text = formattedIncome;
                        break;
                    case 11:
                        lblNovSales.Text = formattedSales;
                        lblNovExpenses.Text = formattedExpenses;
                        lblNovIncome.Text = formattedIncome;
                        break;
                    case 12:
                        lblDecSales.Text = formattedSales;
                        lblDecExpenses.Text = formattedExpenses;
                        lblDecIncome.Text = formattedIncome;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
