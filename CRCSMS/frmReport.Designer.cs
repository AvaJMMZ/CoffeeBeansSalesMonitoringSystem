namespace CRCSMS
{
    partial class frmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelManageProduct = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.flpSideBarCon = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnStocks = new System.Windows.Forms.Button();
            this.btnSoldItems = new System.Windows.Forms.Button();
            this.btnTotalIncome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flpSideBarCon.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.labelManageProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1354, 54);
            this.panel1.TabIndex = 1;
            // 
            // labelManageProduct
            // 
            this.labelManageProduct.AutoSize = true;
            this.labelManageProduct.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageProduct.Location = new System.Drawing.Point(486, 9);
            this.labelManageProduct.Name = "labelManageProduct";
            this.labelManageProduct.Size = new System.Drawing.Size(343, 38);
            this.labelManageProduct.TabIndex = 1;
            this.labelManageProduct.Text = "P R I N T   R E P O R T";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.SandyBrown;
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Maroon;
            this.btnRefresh.Location = new System.Drawing.Point(1212, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 35);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // flpSideBarCon
            // 
            this.flpSideBarCon.BackColor = System.Drawing.Color.SaddleBrown;
            this.flpSideBarCon.Controls.Add(this.btnSales);
            this.flpSideBarCon.Controls.Add(this.btnStocks);
            this.flpSideBarCon.Controls.Add(this.btnSoldItems);
            this.flpSideBarCon.Controls.Add(this.btnTotalIncome);
            this.flpSideBarCon.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpSideBarCon.Location = new System.Drawing.Point(0, 54);
            this.flpSideBarCon.Name = "flpSideBarCon";
            this.flpSideBarCon.Size = new System.Drawing.Size(209, 552);
            this.flpSideBarCon.TabIndex = 2;
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSales.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.Color.Maroon;
            this.btnSales.Location = new System.Drawing.Point(20, 20);
            this.btnSales.Margin = new System.Windows.Forms.Padding(20, 20, 3, 3);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(165, 35);
            this.btnSales.TabIndex = 3;
            this.btnSales.Text = "SALES";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnStocks
            // 
            this.btnStocks.BackColor = System.Drawing.Color.SandyBrown;
            this.btnStocks.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStocks.ForeColor = System.Drawing.Color.Maroon;
            this.btnStocks.Location = new System.Drawing.Point(20, 61);
            this.btnStocks.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnStocks.Name = "btnStocks";
            this.btnStocks.Size = new System.Drawing.Size(165, 35);
            this.btnStocks.TabIndex = 4;
            this.btnStocks.Text = "STOCKS";
            this.btnStocks.UseVisualStyleBackColor = false;
            // 
            // btnSoldItems
            // 
            this.btnSoldItems.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSoldItems.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoldItems.ForeColor = System.Drawing.Color.Maroon;
            this.btnSoldItems.Location = new System.Drawing.Point(20, 102);
            this.btnSoldItems.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnSoldItems.Name = "btnSoldItems";
            this.btnSoldItems.Size = new System.Drawing.Size(165, 35);
            this.btnSoldItems.TabIndex = 5;
            this.btnSoldItems.Text = "SOLD ITEMS";
            this.btnSoldItems.UseVisualStyleBackColor = false;
            // 
            // btnTotalIncome
            // 
            this.btnTotalIncome.BackColor = System.Drawing.Color.SandyBrown;
            this.btnTotalIncome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalIncome.ForeColor = System.Drawing.Color.Maroon;
            this.btnTotalIncome.Location = new System.Drawing.Point(20, 143);
            this.btnTotalIncome.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnTotalIncome.Name = "btnTotalIncome";
            this.btnTotalIncome.Size = new System.Drawing.Size(165, 35);
            this.btnTotalIncome.TabIndex = 6;
            this.btnTotalIncome.Text = "TOTAL INCOME";
            this.btnTotalIncome.UseVisualStyleBackColor = false;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1354, 606);
            this.Controls.Add(this.flpSideBarCon);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flpSideBarCon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelManageProduct;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.FlowLayoutPanel flpSideBarCon;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnStocks;
        private System.Windows.Forms.Button btnSoldItems;
        private System.Windows.Forms.Button btnTotalIncome;
    }
}