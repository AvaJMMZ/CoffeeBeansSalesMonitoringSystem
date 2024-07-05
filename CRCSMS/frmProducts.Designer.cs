namespace CRCSMS
{
    partial class frmProducts
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddStocks = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.labelManageProduct = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.tblProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRCSMSDataSet_tblProducts = new CRCSMS.CRCSMSDataSet_tblProducts();
            this.tblProductsTableAdapter = new CRCSMS.CRCSMSDataSet_tblProductsTableAdapters.tblProductsTableAdapter();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gramDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediumRoastDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.darkRoastDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.wholeBeansDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.coarseGroundDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fineGroundDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRCSMSDataSet_tblProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddStocks);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnAddProduct);
            this.panel1.Controls.Add(this.labelManageProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 54);
            this.panel1.TabIndex = 0;
            // 
            // btnAddStocks
            // 
            this.btnAddStocks.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAddStocks.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStocks.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddStocks.Location = new System.Drawing.Point(186, 9);
            this.btnAddStocks.Name = "btnAddStocks";
            this.btnAddStocks.Size = new System.Drawing.Size(112, 35);
            this.btnAddStocks.TabIndex = 4;
            this.btnAddStocks.Text = "Add Stocks";
            this.btnAddStocks.UseVisualStyleBackColor = false;
            this.btnAddStocks.Click += new System.EventHandler(this.btnAddStocks_Click);
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
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAddProduct.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddProduct.Location = new System.Drawing.Point(56, 9);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(112, 35);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // labelManageProduct
            // 
            this.labelManageProduct.AutoSize = true;
            this.labelManageProduct.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageProduct.Location = new System.Drawing.Point(486, 9);
            this.labelManageProduct.Name = "labelManageProduct";
            this.labelManageProduct.Size = new System.Drawing.Size(450, 38);
            this.labelManageProduct.TabIndex = 1;
            this.labelManageProduct.Text = "M A N A G E   P R O D U C T S";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.SandyBrown;
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProducts.ColumnHeadersHeight = 40;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.gramDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.stocksDataGridViewTextBoxColumn,
            this.mediumRoastDataGridViewCheckBoxColumn,
            this.darkRoastDataGridViewCheckBoxColumn,
            this.wholeBeansDataGridViewCheckBoxColumn,
            this.coarseGroundDataGridViewCheckBoxColumn,
            this.fineGroundDataGridViewCheckBoxColumn,
            this.btnEdit,
            this.btnDelete});
            this.dgvProducts.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvProducts.DataSource = this.tblProductsBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle8.NullValue = "NULL";
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.GridColor = System.Drawing.Color.PeachPuff;
            this.dgvProducts.Location = new System.Drawing.Point(0, 54);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1370, 591);
            this.dgvProducts.TabIndex = 1;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // tblProductsBindingSource
            // 
            this.tblProductsBindingSource.DataMember = "tblProducts";
            this.tblProductsBindingSource.DataSource = this.cRCSMSDataSet_tblProducts;
            // 
            // cRCSMSDataSet_tblProducts
            // 
            this.cRCSMSDataSet_tblProducts.DataSetName = "CRCSMSDataSet_tblProducts";
            this.cRCSMSDataSet_tblProducts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProductsTableAdapter
            // 
            this.tblProductsTableAdapter.ClearBeforeFill = true;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gramDataGridViewTextBoxColumn
            // 
            this.gramDataGridViewTextBoxColumn.DataPropertyName = "gram";
            this.gramDataGridViewTextBoxColumn.HeaderText = "Gram";
            this.gramDataGridViewTextBoxColumn.Name = "gramDataGridViewTextBoxColumn";
            this.gramDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stocksDataGridViewTextBoxColumn
            // 
            this.stocksDataGridViewTextBoxColumn.DataPropertyName = "stocks";
            this.stocksDataGridViewTextBoxColumn.HeaderText = "Stocks";
            this.stocksDataGridViewTextBoxColumn.Name = "stocksDataGridViewTextBoxColumn";
            this.stocksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mediumRoastDataGridViewCheckBoxColumn
            // 
            this.mediumRoastDataGridViewCheckBoxColumn.DataPropertyName = "mediumRoast";
            this.mediumRoastDataGridViewCheckBoxColumn.HeaderText = "Medium Roast";
            this.mediumRoastDataGridViewCheckBoxColumn.Name = "mediumRoastDataGridViewCheckBoxColumn";
            this.mediumRoastDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // darkRoastDataGridViewCheckBoxColumn
            // 
            this.darkRoastDataGridViewCheckBoxColumn.DataPropertyName = "darkRoast";
            this.darkRoastDataGridViewCheckBoxColumn.HeaderText = "Dark Roast";
            this.darkRoastDataGridViewCheckBoxColumn.Name = "darkRoastDataGridViewCheckBoxColumn";
            this.darkRoastDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // wholeBeansDataGridViewCheckBoxColumn
            // 
            this.wholeBeansDataGridViewCheckBoxColumn.DataPropertyName = "wholeBeans";
            this.wholeBeansDataGridViewCheckBoxColumn.HeaderText = "Whole Beans";
            this.wholeBeansDataGridViewCheckBoxColumn.Name = "wholeBeansDataGridViewCheckBoxColumn";
            this.wholeBeansDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // coarseGroundDataGridViewCheckBoxColumn
            // 
            this.coarseGroundDataGridViewCheckBoxColumn.DataPropertyName = "coarseGround";
            this.coarseGroundDataGridViewCheckBoxColumn.HeaderText = "Coarse Ground";
            this.coarseGroundDataGridViewCheckBoxColumn.Name = "coarseGroundDataGridViewCheckBoxColumn";
            this.coarseGroundDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // fineGroundDataGridViewCheckBoxColumn
            // 
            this.fineGroundDataGridViewCheckBoxColumn.DataPropertyName = "fineGround";
            this.fineGroundDataGridViewCheckBoxColumn.HeaderText = "Fine Ground";
            this.fineGroundDataGridViewCheckBoxColumn.Name = "fineGroundDataGridViewCheckBoxColumn";
            this.fineGroundDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // btnEdit
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = "NULL";
            this.btnEdit.DefaultCellStyle = dataGridViewCellStyle7;
            this.btnEdit.HeaderText = "";
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ReadOnly = true;
            this.btnEdit.Text = "Edit";
            this.btnEdit.ToolTipText = "Edit";
            this.btnEdit.UseColumnTextForButtonValue = true;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Text = "Delete";
            this.btnDelete.ToolTipText = "Delete";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1370, 645);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProducts";
            this.Text = "frmProducts";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRCSMSDataSet_tblProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelManageProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dgvProducts;
        private CRCSMSDataSet_tblProducts cRCSMSDataSet_tblProducts;
        private System.Windows.Forms.BindingSource tblProductsBindingSource;
        private CRCSMSDataSet_tblProductsTableAdapters.tblProductsTableAdapter tblProductsTableAdapter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddStocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gramDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mediumRoastDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn darkRoastDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn wholeBeansDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn coarseGroundDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fineGroundDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}