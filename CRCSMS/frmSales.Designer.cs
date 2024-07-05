namespace CRCSMS
{
    partial class frmSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelSales = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOrderedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTotalPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnViewDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tblOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRCSMSDataSet_tblOrders = new CRCSMS.CRCSMSDataSet_tblOrders();
            this.tblOrdersTableAdapter = new CRCSMS.CRCSMSDataSet_tblOrdersTableAdapters.tblOrdersTableAdapter();
            this.dgvtblDetails = new System.Windows.Forms.DataGridView();
            this.orderDetailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roastTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groundTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTotalPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblOrderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRCSMSDataSet_tblOrderDetails = new CRCSMS.CRCSMSDataSet_tblOrderDetails();
            this.tblOrderDetailsTableAdapter = new CRCSMS.CRCSMSDataSet_tblOrderDetailsTableAdapters.tblOrderDetailsTableAdapter();
            this.panelOrderDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrderDetails = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRCSMSDataSet_tblOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtblDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRCSMSDataSet_tblOrderDetails)).BeginInit();
            this.panelOrderDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSales
            // 
            this.labelSales.AutoSize = true;
            this.labelSales.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSales.Location = new System.Drawing.Point(650, 7);
            this.labelSales.Name = "labelSales";
            this.labelSales.Size = new System.Drawing.Size(152, 38);
            this.labelSales.TabIndex = 1;
            this.labelSales.Text = "S A L E S";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnAddOrder);
            this.panel1.Controls.Add(this.labelSales);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 54);
            this.panel1.TabIndex = 1;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.SandyBrown;
            this.btnFilter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.Maroon;
            this.btnFilter.Location = new System.Drawing.Point(410, 9);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(112, 35);
            this.btnFilter.TabIndex = 10;
            this.btnFilter.Text = "Filter Date";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "From:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "MMMM dd, yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(261, 3);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(143, 20);
            this.dtpFrom.TabIndex = 6;
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "MMMM dd, yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(261, 29);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(143, 20);
            this.dtpTo.TabIndex = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.SandyBrown;
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Maroon;
            this.btnRefresh.Location = new System.Drawing.Point(1187, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 35);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAddOrder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddOrder.Location = new System.Drawing.Point(65, 9);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(112, 35);
            this.btnAddOrder.TabIndex = 3;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.SandyBrown;
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProducts.ColumnHeadersHeight = 40;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dateOrderedDataGridViewTextBoxColumn,
            this.orderTotalPaymentDataGridViewTextBoxColumn,
            this.btnViewDetails});
            this.dgvProducts.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvProducts.DataSource = this.tblOrdersBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle9.NullValue = "NULL";
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.GridColor = System.Drawing.Color.PeachPuff;
            this.dgvProducts.Location = new System.Drawing.Point(0, 54);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1060, 591);
            this.dgvProducts.TabIndex = 2;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "orderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "Order ID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Costumer Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOrderedDataGridViewTextBoxColumn
            // 
            this.dateOrderedDataGridViewTextBoxColumn.DataPropertyName = "dateOrdered";
            this.dateOrderedDataGridViewTextBoxColumn.HeaderText = "Date Ordered";
            this.dateOrderedDataGridViewTextBoxColumn.Name = "dateOrderedDataGridViewTextBoxColumn";
            this.dateOrderedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderTotalPaymentDataGridViewTextBoxColumn
            // 
            this.orderTotalPaymentDataGridViewTextBoxColumn.DataPropertyName = "orderTotalPayment";
            this.orderTotalPaymentDataGridViewTextBoxColumn.HeaderText = "Total Payment";
            this.orderTotalPaymentDataGridViewTextBoxColumn.Name = "orderTotalPaymentDataGridViewTextBoxColumn";
            this.orderTotalPaymentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.HeaderText = "";
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.ReadOnly = true;
            this.btnViewDetails.Text = "View Order Details";
            this.btnViewDetails.UseColumnTextForButtonValue = true;
            // 
            // tblOrdersBindingSource
            // 
            this.tblOrdersBindingSource.DataMember = "tblOrders";
            this.tblOrdersBindingSource.DataSource = this.cRCSMSDataSet_tblOrders;
            // 
            // cRCSMSDataSet_tblOrders
            // 
            this.cRCSMSDataSet_tblOrders.DataSetName = "CRCSMSDataSet_tblOrders";
            this.cRCSMSDataSet_tblOrders.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOrdersTableAdapter
            // 
            this.tblOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // dgvtblDetails
            // 
            this.dgvtblDetails.AllowUserToDeleteRows = false;
            this.dgvtblDetails.AllowUserToResizeColumns = false;
            this.dgvtblDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.SandyBrown;
            this.dgvtblDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvtblDetails.AutoGenerateColumns = false;
            this.dgvtblDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtblDetails.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dgvtblDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtblDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvtblDetails.ColumnHeadersHeight = 40;
            this.dgvtblDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderDetailIDDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn1,
            this.productIDDataGridViewTextBoxColumn,
            this.roastTypeDataGridViewTextBoxColumn,
            this.groundTypeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.productTotalPaymentDataGridViewTextBoxColumn});
            this.dgvtblDetails.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvtblDetails.DataSource = this.tblOrderDetailsBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle12.NullValue = "NULL";
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtblDetails.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvtblDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvtblDetails.EnableHeadersVisualStyles = false;
            this.dgvtblDetails.GridColor = System.Drawing.Color.PeachPuff;
            this.dgvtblDetails.Location = new System.Drawing.Point(1060, 645);
            this.dgvtblDetails.Name = "dgvtblDetails";
            this.dgvtblDetails.ReadOnly = true;
            this.dgvtblDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvtblDetails.RowHeadersVisible = false;
            this.dgvtblDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtblDetails.Size = new System.Drawing.Size(310, 0);
            this.dgvtblDetails.TabIndex = 3;
            // 
            // orderDetailIDDataGridViewTextBoxColumn
            // 
            this.orderDetailIDDataGridViewTextBoxColumn.DataPropertyName = "orderDetailID";
            this.orderDetailIDDataGridViewTextBoxColumn.HeaderText = "orderDetailID";
            this.orderDetailIDDataGridViewTextBoxColumn.Name = "orderDetailIDDataGridViewTextBoxColumn";
            this.orderDetailIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderIDDataGridViewTextBoxColumn1
            // 
            this.orderIDDataGridViewTextBoxColumn1.DataPropertyName = "orderID";
            this.orderIDDataGridViewTextBoxColumn1.HeaderText = "orderID";
            this.orderIDDataGridViewTextBoxColumn1.Name = "orderIDDataGridViewTextBoxColumn1";
            this.orderIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "productID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roastTypeDataGridViewTextBoxColumn
            // 
            this.roastTypeDataGridViewTextBoxColumn.DataPropertyName = "roastType";
            this.roastTypeDataGridViewTextBoxColumn.HeaderText = "roastType";
            this.roastTypeDataGridViewTextBoxColumn.Name = "roastTypeDataGridViewTextBoxColumn";
            this.roastTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groundTypeDataGridViewTextBoxColumn
            // 
            this.groundTypeDataGridViewTextBoxColumn.DataPropertyName = "groundType";
            this.groundTypeDataGridViewTextBoxColumn.HeaderText = "groundType";
            this.groundTypeDataGridViewTextBoxColumn.Name = "groundTypeDataGridViewTextBoxColumn";
            this.groundTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productTotalPaymentDataGridViewTextBoxColumn
            // 
            this.productTotalPaymentDataGridViewTextBoxColumn.DataPropertyName = "productTotalPayment";
            this.productTotalPaymentDataGridViewTextBoxColumn.HeaderText = "productTotalPayment";
            this.productTotalPaymentDataGridViewTextBoxColumn.Name = "productTotalPaymentDataGridViewTextBoxColumn";
            this.productTotalPaymentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblOrderDetailsBindingSource
            // 
            this.tblOrderDetailsBindingSource.DataMember = "tblOrderDetails";
            this.tblOrderDetailsBindingSource.DataSource = this.cRCSMSDataSet_tblOrderDetails;
            // 
            // cRCSMSDataSet_tblOrderDetails
            // 
            this.cRCSMSDataSet_tblOrderDetails.DataSetName = "CRCSMSDataSet_tblOrderDetails";
            this.cRCSMSDataSet_tblOrderDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOrderDetailsTableAdapter
            // 
            this.tblOrderDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // panelOrderDetails
            // 
            this.panelOrderDetails.AutoScroll = true;
            this.panelOrderDetails.BackColor = System.Drawing.Color.PeachPuff;
            this.panelOrderDetails.Controls.Add(this.btnDelete);
            this.panelOrderDetails.Controls.Add(this.label1);
            this.panelOrderDetails.Controls.Add(this.lblOrderDetails);
            this.panelOrderDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOrderDetails.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelOrderDetails.Location = new System.Drawing.Point(1063, 54);
            this.panelOrderDetails.Name = "panelOrderDetails";
            this.panelOrderDetails.Size = new System.Drawing.Size(307, 591);
            this.panelOrderDetails.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(3, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 34);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(10, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 10, 3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Details:";
            // 
            // lblOrderDetails
            // 
            this.lblOrderDetails.AutoSize = true;
            this.lblOrderDetails.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrderDetails.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblOrderDetails.Location = new System.Drawing.Point(10, 113);
            this.lblOrderDetails.Margin = new System.Windows.Forms.Padding(10, 10, 3, 20);
            this.lblOrderDetails.Name = "lblOrderDetails";
            this.lblOrderDetails.Size = new System.Drawing.Size(78, 19);
            this.lblOrderDetails.TabIndex = 0;
            this.lblOrderDetails.Text = "Order ID:";
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1370, 645);
            this.Controls.Add(this.panelOrderDetails);
            this.Controls.Add(this.dgvtblDetails);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSales";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRCSMSDataSet_tblOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtblDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRCSMSDataSet_tblOrderDetails)).EndInit();
            this.panelOrderDetails.ResumeLayout(false);
            this.panelOrderDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvProducts;
        private CRCSMSDataSet_tblOrders cRCSMSDataSet_tblOrders;
        private System.Windows.Forms.BindingSource tblOrdersBindingSource;
        private CRCSMSDataSet_tblOrdersTableAdapters.tblOrdersTableAdapter tblOrdersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOrderedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTotalPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnViewDetails;
        private System.Windows.Forms.DataGridView dgvtblDetails;
        private CRCSMSDataSet_tblOrderDetails cRCSMSDataSet_tblOrderDetails;
        private System.Windows.Forms.BindingSource tblOrderDetailsBindingSource;
        private CRCSMSDataSet_tblOrderDetailsTableAdapters.tblOrderDetailsTableAdapter tblOrderDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDetailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roastTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groundTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTotalPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.FlowLayoutPanel panelOrderDetails;
        private System.Windows.Forms.Label lblOrderDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFilter;
    }
}