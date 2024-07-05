namespace CRCSMS
{
    partial class frmAddOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.top = new System.Windows.Forms.FlowLayoutPanel();
            this.labelX = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
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
            this.tblProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRCSMSDataSet_dgvProductList = new CRCSMS.CRCSMSDataSet_dgvProductList();
            this.conAllProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.conProduct = new System.Windows.Forms.Panel();
            this.labelGram = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.conCart = new System.Windows.Forms.FlowLayoutPanel();
            this.labelCart = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roastType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groundType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTotalPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelCosName = new System.Windows.Forms.Label();
            this.tblProductsTableAdapter = new CRCSMS.CRCSMSDataSet_dgvProductListTableAdapters.tblProductsTableAdapter();
            this.labelStocks = new System.Windows.Forms.Label();
            this.top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRCSMSDataSet_dgvProductList)).BeginInit();
            this.conAllProducts.SuspendLayout();
            this.conProduct.SuspendLayout();
            this.panel1.SuspendLayout();
            this.conCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.SaddleBrown;
            this.top.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.top.Controls.Add(this.labelX);
            this.top.Controls.Add(this.labelTitle);
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Padding = new System.Windows.Forms.Padding(5);
            this.top.Size = new System.Drawing.Size(1100, 39);
            this.top.TabIndex = 2;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.ForeColor = System.Drawing.Color.White;
            this.labelX.Location = new System.Drawing.Point(1057, 5);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(26, 24);
            this.labelX.TabIndex = 1;
            this.labelX.Text = "X";
            this.labelX.Click += new System.EventHandler(this.labelX_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.SandyBrown;
            this.labelTitle.Location = new System.Drawing.Point(481, 5);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(3, 0, 450, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(123, 25);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Add Order";
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToDeleteRows = false;
            this.dgvProductList.AllowUserToResizeColumns = false;
            this.dgvProductList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SandyBrown;
            this.dgvProductList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductList.AutoGenerateColumns = false;
            this.dgvProductList.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dgvProductList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductList.ColumnHeadersHeight = 40;
            this.dgvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.gramDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.stocksDataGridViewTextBoxColumn,
            this.mediumRoastDataGridViewCheckBoxColumn,
            this.darkRoastDataGridViewCheckBoxColumn,
            this.wholeBeansDataGridViewCheckBoxColumn,
            this.coarseGroundDataGridViewCheckBoxColumn,
            this.fineGroundDataGridViewCheckBoxColumn});
            this.dgvProductList.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvProductList.DataSource = this.tblProductsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle3.NullValue = "NULL";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProductList.EnableHeadersVisualStyles = false;
            this.dgvProductList.GridColor = System.Drawing.Color.PeachPuff;
            this.dgvProductList.Location = new System.Drawing.Point(0, 39);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductList.RowHeadersVisible = false;
            this.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductList.Size = new System.Drawing.Size(1100, 0);
            this.dgvProductList.TabIndex = 3;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "productID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "productName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gramDataGridViewTextBoxColumn
            // 
            this.gramDataGridViewTextBoxColumn.DataPropertyName = "gram";
            this.gramDataGridViewTextBoxColumn.HeaderText = "gram";
            this.gramDataGridViewTextBoxColumn.Name = "gramDataGridViewTextBoxColumn";
            this.gramDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stocksDataGridViewTextBoxColumn
            // 
            this.stocksDataGridViewTextBoxColumn.DataPropertyName = "stocks";
            this.stocksDataGridViewTextBoxColumn.HeaderText = "stocks";
            this.stocksDataGridViewTextBoxColumn.Name = "stocksDataGridViewTextBoxColumn";
            this.stocksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mediumRoastDataGridViewCheckBoxColumn
            // 
            this.mediumRoastDataGridViewCheckBoxColumn.DataPropertyName = "mediumRoast";
            this.mediumRoastDataGridViewCheckBoxColumn.HeaderText = "mediumRoast";
            this.mediumRoastDataGridViewCheckBoxColumn.Name = "mediumRoastDataGridViewCheckBoxColumn";
            this.mediumRoastDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // darkRoastDataGridViewCheckBoxColumn
            // 
            this.darkRoastDataGridViewCheckBoxColumn.DataPropertyName = "darkRoast";
            this.darkRoastDataGridViewCheckBoxColumn.HeaderText = "darkRoast";
            this.darkRoastDataGridViewCheckBoxColumn.Name = "darkRoastDataGridViewCheckBoxColumn";
            this.darkRoastDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // wholeBeansDataGridViewCheckBoxColumn
            // 
            this.wholeBeansDataGridViewCheckBoxColumn.DataPropertyName = "wholeBeans";
            this.wholeBeansDataGridViewCheckBoxColumn.HeaderText = "wholeBeans";
            this.wholeBeansDataGridViewCheckBoxColumn.Name = "wholeBeansDataGridViewCheckBoxColumn";
            this.wholeBeansDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // coarseGroundDataGridViewCheckBoxColumn
            // 
            this.coarseGroundDataGridViewCheckBoxColumn.DataPropertyName = "coarseGround";
            this.coarseGroundDataGridViewCheckBoxColumn.HeaderText = "coarseGround";
            this.coarseGroundDataGridViewCheckBoxColumn.Name = "coarseGroundDataGridViewCheckBoxColumn";
            this.coarseGroundDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // fineGroundDataGridViewCheckBoxColumn
            // 
            this.fineGroundDataGridViewCheckBoxColumn.DataPropertyName = "fineGround";
            this.fineGroundDataGridViewCheckBoxColumn.HeaderText = "fineGround";
            this.fineGroundDataGridViewCheckBoxColumn.Name = "fineGroundDataGridViewCheckBoxColumn";
            this.fineGroundDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // tblProductsBindingSource
            // 
            this.tblProductsBindingSource.DataMember = "tblProducts";
            this.tblProductsBindingSource.DataSource = this.cRCSMSDataSet_dgvProductList;
            // 
            // cRCSMSDataSet_dgvProductList
            // 
            this.cRCSMSDataSet_dgvProductList.DataSetName = "CRCSMSDataSet_dgvProductList";
            this.cRCSMSDataSet_dgvProductList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conAllProducts
            // 
            this.conAllProducts.AutoScroll = true;
            this.conAllProducts.BackColor = System.Drawing.Color.PeachPuff;
            this.conAllProducts.Controls.Add(this.conProduct);
            this.conAllProducts.Controls.Add(this.panel1);
            this.conAllProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.conAllProducts.Location = new System.Drawing.Point(0, 76);
            this.conAllProducts.Name = "conAllProducts";
            this.conAllProducts.Padding = new System.Windows.Forms.Padding(8, 5, 0, 5);
            this.conAllProducts.Size = new System.Drawing.Size(628, 603);
            this.conAllProducts.TabIndex = 4;
            // 
            // conProduct
            // 
            this.conProduct.BackColor = System.Drawing.Color.SandyBrown;
            this.conProduct.Controls.Add(this.labelStocks);
            this.conProduct.Controls.Add(this.labelGram);
            this.conProduct.Controls.Add(this.labelPrice);
            this.conProduct.Controls.Add(this.labelID);
            this.conProduct.Controls.Add(this.labelProductName);
            this.conProduct.Location = new System.Drawing.Point(18, 15);
            this.conProduct.Margin = new System.Windows.Forms.Padding(10);
            this.conProduct.Name = "conProduct";
            this.conProduct.Size = new System.Drawing.Size(276, 154);
            this.conProduct.TabIndex = 0;
            // 
            // labelGram
            // 
            this.labelGram.AutoSize = true;
            this.labelGram.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelGram.ForeColor = System.Drawing.Color.Maroon;
            this.labelGram.Location = new System.Drawing.Point(27, 75);
            this.labelGram.Name = "labelGram";
            this.labelGram.Size = new System.Drawing.Size(56, 19);
            this.labelGram.TabIndex = 9;
            this.labelGram.Text = "Gram:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelPrice.ForeColor = System.Drawing.Color.Maroon;
            this.labelPrice.Location = new System.Drawing.Point(27, 106);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(54, 19);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Price:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelID.ForeColor = System.Drawing.Color.Maroon;
            this.labelID.Location = new System.Drawing.Point(27, 43);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(31, 19);
            this.labelID.TabIndex = 7;
            this.labelID.Text = "ID:";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.ForeColor = System.Drawing.Color.Maroon;
            this.labelProductName.Location = new System.Drawing.Point(13, 10);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(141, 22);
            this.labelProductName.TabIndex = 6;
            this.labelProductName.Text = "Product Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(314, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 154);
            this.panel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(3, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Stocks:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(27, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gram:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(27, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(27, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(13, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Product Name";
            // 
            // conCart
            // 
            this.conCart.BackColor = System.Drawing.Color.Chocolate;
            this.conCart.Controls.Add(this.labelCart);
            this.conCart.Controls.Add(this.dgvCart);
            this.conCart.Controls.Add(this.btnAddOrder);
            this.conCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conCart.Location = new System.Drawing.Point(628, 76);
            this.conCart.Name = "conCart";
            this.conCart.Size = new System.Drawing.Size(472, 603);
            this.conCart.TabIndex = 5;
            // 
            // labelCart
            // 
            this.labelCart.AutoSize = true;
            this.labelCart.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.labelCart.ForeColor = System.Drawing.Color.PeachPuff;
            this.labelCart.Location = new System.Drawing.Point(200, 10);
            this.labelCart.Margin = new System.Windows.Forms.Padding(200, 10, 3, 0);
            this.labelCart.Name = "labelCart";
            this.labelCart.Size = new System.Drawing.Size(102, 31);
            this.labelCart.TabIndex = 0;
            this.labelCart.Text = "C A R T";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AllowUserToResizeColumns = false;
            this.dgvCart.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.SandyBrown;
            this.dgvCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCart.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dgvCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCart.ColumnHeadersHeight = 40;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.roastType,
            this.groundType,
            this.quantity,
            this.productTotalPayment,
            this.delete});
            this.dgvCart.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle6.NullValue = "NULL";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCart.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCart.EnableHeadersVisualStyles = false;
            this.dgvCart.GridColor = System.Drawing.Color.PeachPuff;
            this.dgvCart.Location = new System.Drawing.Point(10, 51);
            this.dgvCart.Margin = new System.Windows.Forms.Padding(10);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(454, 458);
            this.dgvCart.TabIndex = 12;
            this.dgvCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellContentClick);
            // 
            // productID
            // 
            this.productID.HeaderText = "Product ID";
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            // 
            // roastType
            // 
            this.roastType.HeaderText = "Roast Type";
            this.roastType.Name = "roastType";
            this.roastType.ReadOnly = true;
            // 
            // groundType
            // 
            this.groundType.HeaderText = "Ground Type";
            this.groundType.Name = "groundType";
            this.groundType.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // productTotalPayment
            // 
            this.productTotalPayment.HeaderText = "Product Cost";
            this.productTotalPayment.Name = "productTotalPayment";
            this.productTotalPayment.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.HeaderText = "Delete";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Text = "Delete";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.Chocolate;
            this.btnAddOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddOrder.Location = new System.Drawing.Point(280, 522);
            this.btnAddOrder.Margin = new System.Windows.Forms.Padding(280, 3, 3, 3);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(172, 37);
            this.btnAddOrder.TabIndex = 11;
            this.btnAddOrder.Text = "ADD ORDER";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(181, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(387, 29);
            this.txtName.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelCosName);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 37);
            this.panel2.TabIndex = 11;
            // 
            // labelCosName
            // 
            this.labelCosName.AutoSize = true;
            this.labelCosName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCosName.Location = new System.Drawing.Point(63, 9);
            this.labelCosName.Name = "labelCosName";
            this.labelCosName.Size = new System.Drawing.Size(109, 19);
            this.labelCosName.TabIndex = 12;
            this.labelCosName.Text = "Buyer Name:";
            // 
            // tblProductsTableAdapter
            // 
            this.tblProductsTableAdapter.ClearBeforeFill = true;
            // 
            // labelStocks
            // 
            this.labelStocks.AutoSize = true;
            this.labelStocks.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.labelStocks.ForeColor = System.Drawing.Color.Maroon;
            this.labelStocks.Location = new System.Drawing.Point(3, 137);
            this.labelStocks.Name = "labelStocks";
            this.labelStocks.Size = new System.Drawing.Size(48, 14);
            this.labelStocks.TabIndex = 10;
            this.labelStocks.Text = "Stocks:";
            // 
            // frmAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1100, 679);
            this.Controls.Add(this.conCart);
            this.Controls.Add(this.conAllProducts);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvProductList);
            this.Controls.Add(this.top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddOrder";
            this.Load += new System.EventHandler(this.frmAddOrder_Load);
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRCSMSDataSet_dgvProductList)).EndInit();
            this.conAllProducts.ResumeLayout(false);
            this.conProduct.ResumeLayout(false);
            this.conProduct.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.conCart.ResumeLayout(false);
            this.conCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel top;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dgvProductList;
        private CRCSMSDataSet_dgvProductList cRCSMSDataSet_dgvProductList;
        private System.Windows.Forms.BindingSource tblProductsBindingSource;
        private CRCSMSDataSet_dgvProductListTableAdapters.tblProductsTableAdapter tblProductsTableAdapter;
        private System.Windows.Forms.FlowLayoutPanel conCart;
        private System.Windows.Forms.FlowLayoutPanel conAllProducts;
        private System.Windows.Forms.Panel conProduct;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelGram;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label labelCart;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelCosName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn roastType;
        private System.Windows.Forms.DataGridViewTextBoxColumn groundType;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTotalPayment;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.Label labelStocks;
    }
}