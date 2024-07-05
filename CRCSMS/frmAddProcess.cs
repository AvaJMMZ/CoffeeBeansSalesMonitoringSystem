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
    public partial class frmAddProcess : Form
    {
        public frmAddProcess()
        {
            InitializeComponent();
        }

        private void frmAddProcess_Load(object sender, EventArgs e)
        {
            numCB.ValueChanged += InputValueChanged;
            numW.ValueChanged += InputValueChanged;
            numSt.ValueChanged += InputValueChanged;
            numPG.ValueChanged += InputValueChanged;
            numCBPrice.ValueChanged += InputValueChanged;
            numS.ValueChanged += InputValueChanged;
            numStPrice.ValueChanged += InputValueChanged;
            numPGPrice.ValueChanged += InputValueChanged;
            num200PU.ValueChanged += InputValueChanged;
            num200PP.ValueChanged += InputValueChanged;
            num250PU.ValueChanged += InputValueChanged;
            num250PP.ValueChanged += InputValueChanged;
            num500PU.ValueChanged += InputValueChanged;
            num500PP.ValueChanged += InputValueChanged;
        }

        private void labelX_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void InputValueChanged(object sender, EventArgs e)
        {
            btnAddProcess.Enabled = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal totalCB = numCB.Value * numCBPrice.Value;
            decimal totalS = numW.Value * numS.Value;
            decimal totalSt = numSt.Value * numStPrice.Value;
            decimal totalPG = numPG.Value * numPGPrice.Value;
            decimal aTotal = num200PU.Value * num200PP.Value;
            decimal bTotal = num250PU.Value * num250PP.Value;
            decimal cTotal = num500PU.Value * num500PP.Value;

            numTotalCB.Text = totalCB.ToString();
            numTotalS.Text = totalS.ToString();
            numTotalSt.Text = totalSt.ToString();
            numTotalPG.Text = totalPG.ToString();
            numTotal200.Text = aTotal.ToString();
            numTotal250.Text = bTotal.ToString();
            numTotal500.Text = cTotal.ToString();

            decimal totalProcess = totalCB + totalS + totalSt + totalPG + aTotal + bTotal + cTotal;
            numTotalProcess.Text = totalProcess.ToString();

            btnAddProcess.Enabled = true;
        }

        private void btnAddProcess_Click(object sender, EventArgs e)
        {
            string coffeeBean = numCB.Value.ToString();
            string priceCB = numCBPrice.Value.ToString();
            string totalExpCD = numTotalCB.Text;
            string worker = numW.Text;
            string salary = numS.Value.ToString();
            string totalSalary = numTotalS.Text;
            string sticker = numSt.Value.ToString();
            string priceSt = numStPrice.Value.ToString();
            string totalExpSt = numTotalSt.Text;
            string gasTank = numPG.Value.ToString();
            string priceGS = numPGPrice.Value.ToString();
            string totalExpGS = numTotalPG.Text;
            string aPU = num200PU.Value.ToString();
            string aPP = num200PP.Value.ToString();
            string aTotal = numTotal200.Text;
            string bPU = num250PU.Value.ToString();
            string bPP = num250PP.Value.ToString();
            string bTotal = numTotal250.Text;
            string cPU = num500PU.Value.ToString();
            string cPP = num500PP.Value.ToString();
            string cTotal = numTotal500.Text;

            string totalExpProcess = numTotalProcess.Text;
            DateTime adateProcess = dateProcess.Value;

            tblExpProcess newExpProcess = new tblExpProcess
            {
                dateProcess = adateProcess.ToString(),
                coffeeBean = coffeeBean,
                priceCB = priceCB,
                totalexpCD = totalExpCD,
                worker = worker,
                salary = salary,
                totalSalary = totalSalary,
                sticker = sticker,
                priceSt = priceSt,
                totalexpSt = totalExpSt,
                gasTank = gasTank,
                priceGS = priceGS,
                totalexpGS = totalExpGS,
                aPU = aPU,
                aPP = aPP,
                aTotal = aTotal,
                bPU = bPU,
                bPP = bPP,
                bTotal = bTotal,
                cPU = cPU,
                cPP = cPP,
                cTotal = cTotal,

                totalexpProcess = totalExpProcess
            };

            using (CRCSMSDataContext db = new CRCSMSDataContext())
            {
                db.tblExpProcesses.InsertOnSubmit(newExpProcess);
                db.SubmitChanges();
            }

            MessageBox.Show("Process added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

    }
}
