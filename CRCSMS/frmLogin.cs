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
    public partial class frmLogin : Form
    {
        private CRCSMSDataContext dbcon = new CRCSMSDataContext();

        public frmLogin()
        {
            InitializeComponent();
            labelX.MouseEnter += Label_MouseEnter;
            labelX.MouseLeave += Label_MouseLeave;

            btnLogin.MouseEnter += (sender, e) =>
            {
                btnLogin.BackColor = Color.SandyBrown;
                btnLogin.ForeColor = Color.Black;
            };

            btnLogin.MouseLeave += (sender, e) =>
            {
                btnLogin.BackColor = Color.SaddleBrown;
                btnLogin.ForeColor = Color.White;
            };
        }

        private void labelX_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            labelX.ForeColor = Color.Red;
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            labelX.ForeColor = SystemColors.Control;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtUsername.Text.Trim();
            string enteredPassword = txtPassword.Text.Trim();

            var admin = dbcon.tblAdmins
                .FirstOrDefault(a => a.username == enteredUsername && a.password == enteredPassword);

            if (admin != null)
            {
                MessageBox.Show("Login successful!");

                frmDashboard dashboardForm = new frmDashboard();
                dashboardForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !cbShowPass.Checked; 
        }
    }
}
