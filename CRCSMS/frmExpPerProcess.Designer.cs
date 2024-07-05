namespace CRCSMS
{
    partial class frmExpPerProcess
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddProcess = new System.Windows.Forms.Button();
            this.labelSales = new System.Windows.Forms.Label();
            this.dgvProcessExp = new System.Windows.Forms.DataGridView();
            this.processIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateProcessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalexpCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalexpStDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalexpGSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalexpProcessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeBeanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stickerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceStDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gasTankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnViewDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tblExpProcessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRCSMSDataSet_tblExpProcess = new CRCSMS.CRCSMSDataSet_tblExpProcess();
            this.tblExpProcessTableAdapter = new CRCSMS.CRCSMSDataSet_tblExpProcessTableAdapters.tblExpProcessTableAdapter();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblExpProcessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRCSMSDataSet_tblExpProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnAddProcess);
            this.panel1.Controls.Add(this.labelSales);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 61);
            this.panel1.TabIndex = 2;
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
            // btnAddProcess
            // 
            this.btnAddProcess.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAddProcess.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProcess.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddProcess.Location = new System.Drawing.Point(65, 9);
            this.btnAddProcess.Name = "btnAddProcess";
            this.btnAddProcess.Size = new System.Drawing.Size(112, 35);
            this.btnAddProcess.TabIndex = 3;
            this.btnAddProcess.Text = "Add Process";
            this.btnAddProcess.UseVisualStyleBackColor = false;
            this.btnAddProcess.Click += new System.EventHandler(this.btnAddProcess_Click);
            // 
            // labelSales
            // 
            this.labelSales.AutoSize = true;
            this.labelSales.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSales.Location = new System.Drawing.Point(555, 11);
            this.labelSales.Name = "labelSales";
            this.labelSales.Size = new System.Drawing.Size(468, 38);
            this.labelSales.TabIndex = 1;
            this.labelSales.Text = "P R O C E S S   E X P E N S E S";
            // 
            // dgvProcessExp
            // 
            this.dgvProcessExp.AllowUserToAddRows = false;
            this.dgvProcessExp.AllowUserToDeleteRows = false;
            this.dgvProcessExp.AllowUserToResizeColumns = false;
            this.dgvProcessExp.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.SandyBrown;
            this.dgvProcessExp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProcessExp.AutoGenerateColumns = false;
            this.dgvProcessExp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProcessExp.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dgvProcessExp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProcessExp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProcessExp.ColumnHeadersHeight = 40;
            this.dgvProcessExp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.processIDDataGridViewTextBoxColumn,
            this.dateProcessDataGridViewTextBoxColumn,
            this.totalexpCDDataGridViewTextBoxColumn,
            this.totalSalaryDataGridViewTextBoxColumn,
            this.totalexpStDataGridViewTextBoxColumn,
            this.totalexpGSDataGridViewTextBoxColumn,
            this.aTotalDataGridViewTextBoxColumn,
            this.bTotalDataGridViewTextBoxColumn,
            this.cTotalDataGridViewTextBoxColumn,
            this.totalexpProcessDataGridViewTextBoxColumn,
            this.coffeeBeanDataGridViewTextBoxColumn,
            this.priceCBDataGridViewTextBoxColumn,
            this.workerDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.stickerDataGridViewTextBoxColumn,
            this.priceStDataGridViewTextBoxColumn,
            this.gasTankDataGridViewTextBoxColumn,
            this.priceGSDataGridViewTextBoxColumn,
            this.aPUDataGridViewTextBoxColumn,
            this.aPPDataGridViewTextBoxColumn,
            this.bPUDataGridViewTextBoxColumn,
            this.bPPDataGridViewTextBoxColumn,
            this.cPUDataGridViewTextBoxColumn,
            this.cPPDataGridViewTextBoxColumn,
            this.btnViewDetails});
            this.dgvProcessExp.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvProcessExp.DataSource = this.tblExpProcessBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle6.NullValue = "NULL";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProcessExp.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProcessExp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProcessExp.EnableHeadersVisualStyles = false;
            this.dgvProcessExp.GridColor = System.Drawing.Color.PeachPuff;
            this.dgvProcessExp.Location = new System.Drawing.Point(0, 61);
            this.dgvProcessExp.Name = "dgvProcessExp";
            this.dgvProcessExp.ReadOnly = true;
            this.dgvProcessExp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProcessExp.RowHeadersVisible = false;
            this.dgvProcessExp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcessExp.Size = new System.Drawing.Size(1370, 584);
            this.dgvProcessExp.TabIndex = 3;
            this.dgvProcessExp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcessExp_CellContentClick);
            // 
            // processIDDataGridViewTextBoxColumn
            // 
            this.processIDDataGridViewTextBoxColumn.DataPropertyName = "processID";
            this.processIDDataGridViewTextBoxColumn.HeaderText = "Process ID";
            this.processIDDataGridViewTextBoxColumn.Name = "processIDDataGridViewTextBoxColumn";
            this.processIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateProcessDataGridViewTextBoxColumn
            // 
            this.dateProcessDataGridViewTextBoxColumn.DataPropertyName = "dateProcess";
            this.dateProcessDataGridViewTextBoxColumn.HeaderText = "Date Processed";
            this.dateProcessDataGridViewTextBoxColumn.Name = "dateProcessDataGridViewTextBoxColumn";
            this.dateProcessDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalexpCDDataGridViewTextBoxColumn
            // 
            this.totalexpCDDataGridViewTextBoxColumn.DataPropertyName = "totalexpCD";
            this.totalexpCDDataGridViewTextBoxColumn.HeaderText = "Coffee Bean Expenses";
            this.totalexpCDDataGridViewTextBoxColumn.Name = "totalexpCDDataGridViewTextBoxColumn";
            this.totalexpCDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalSalaryDataGridViewTextBoxColumn
            // 
            this.totalSalaryDataGridViewTextBoxColumn.DataPropertyName = "totalSalary";
            this.totalSalaryDataGridViewTextBoxColumn.HeaderText = "Total Salary";
            this.totalSalaryDataGridViewTextBoxColumn.Name = "totalSalaryDataGridViewTextBoxColumn";
            this.totalSalaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalexpStDataGridViewTextBoxColumn
            // 
            this.totalexpStDataGridViewTextBoxColumn.DataPropertyName = "totalexpSt";
            this.totalexpStDataGridViewTextBoxColumn.HeaderText = "Photo Sticker Expenses";
            this.totalexpStDataGridViewTextBoxColumn.Name = "totalexpStDataGridViewTextBoxColumn";
            this.totalexpStDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalexpGSDataGridViewTextBoxColumn
            // 
            this.totalexpGSDataGridViewTextBoxColumn.DataPropertyName = "totalexpGS";
            this.totalexpGSDataGridViewTextBoxColumn.HeaderText = "Propane Tank Expenses";
            this.totalexpGSDataGridViewTextBoxColumn.Name = "totalexpGSDataGridViewTextBoxColumn";
            this.totalexpGSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aTotalDataGridViewTextBoxColumn
            // 
            this.aTotalDataGridViewTextBoxColumn.DataPropertyName = "aTotal";
            this.aTotalDataGridViewTextBoxColumn.HeaderText = "200g Pouch Expenses";
            this.aTotalDataGridViewTextBoxColumn.Name = "aTotalDataGridViewTextBoxColumn";
            this.aTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bTotalDataGridViewTextBoxColumn
            // 
            this.bTotalDataGridViewTextBoxColumn.DataPropertyName = "bTotal";
            this.bTotalDataGridViewTextBoxColumn.HeaderText = "250g Pouch Expenses";
            this.bTotalDataGridViewTextBoxColumn.Name = "bTotalDataGridViewTextBoxColumn";
            this.bTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cTotalDataGridViewTextBoxColumn
            // 
            this.cTotalDataGridViewTextBoxColumn.DataPropertyName = "cTotal";
            this.cTotalDataGridViewTextBoxColumn.HeaderText = "500g Pouch Expenses";
            this.cTotalDataGridViewTextBoxColumn.Name = "cTotalDataGridViewTextBoxColumn";
            this.cTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalexpProcessDataGridViewTextBoxColumn
            // 
            this.totalexpProcessDataGridViewTextBoxColumn.DataPropertyName = "totalexpProcess";
            this.totalexpProcessDataGridViewTextBoxColumn.HeaderText = "Total Process Expenses";
            this.totalexpProcessDataGridViewTextBoxColumn.Name = "totalexpProcessDataGridViewTextBoxColumn";
            this.totalexpProcessDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coffeeBeanDataGridViewTextBoxColumn
            // 
            this.coffeeBeanDataGridViewTextBoxColumn.DataPropertyName = "coffeeBean";
            this.coffeeBeanDataGridViewTextBoxColumn.HeaderText = "coffeeBean";
            this.coffeeBeanDataGridViewTextBoxColumn.Name = "coffeeBeanDataGridViewTextBoxColumn";
            this.coffeeBeanDataGridViewTextBoxColumn.ReadOnly = true;
            this.coffeeBeanDataGridViewTextBoxColumn.Visible = false;
            // 
            // priceCBDataGridViewTextBoxColumn
            // 
            this.priceCBDataGridViewTextBoxColumn.DataPropertyName = "priceCB";
            this.priceCBDataGridViewTextBoxColumn.HeaderText = "priceCB";
            this.priceCBDataGridViewTextBoxColumn.Name = "priceCBDataGridViewTextBoxColumn";
            this.priceCBDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceCBDataGridViewTextBoxColumn.Visible = false;
            // 
            // workerDataGridViewTextBoxColumn
            // 
            this.workerDataGridViewTextBoxColumn.DataPropertyName = "worker";
            this.workerDataGridViewTextBoxColumn.HeaderText = "worker";
            this.workerDataGridViewTextBoxColumn.Name = "workerDataGridViewTextBoxColumn";
            this.workerDataGridViewTextBoxColumn.ReadOnly = true;
            this.workerDataGridViewTextBoxColumn.Visible = false;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            this.salaryDataGridViewTextBoxColumn.Visible = false;
            // 
            // stickerDataGridViewTextBoxColumn
            // 
            this.stickerDataGridViewTextBoxColumn.DataPropertyName = "sticker";
            this.stickerDataGridViewTextBoxColumn.HeaderText = "sticker";
            this.stickerDataGridViewTextBoxColumn.Name = "stickerDataGridViewTextBoxColumn";
            this.stickerDataGridViewTextBoxColumn.ReadOnly = true;
            this.stickerDataGridViewTextBoxColumn.Visible = false;
            // 
            // priceStDataGridViewTextBoxColumn
            // 
            this.priceStDataGridViewTextBoxColumn.DataPropertyName = "priceSt";
            this.priceStDataGridViewTextBoxColumn.HeaderText = "priceSt";
            this.priceStDataGridViewTextBoxColumn.Name = "priceStDataGridViewTextBoxColumn";
            this.priceStDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceStDataGridViewTextBoxColumn.Visible = false;
            // 
            // gasTankDataGridViewTextBoxColumn
            // 
            this.gasTankDataGridViewTextBoxColumn.DataPropertyName = "gasTank";
            this.gasTankDataGridViewTextBoxColumn.HeaderText = "gasTank";
            this.gasTankDataGridViewTextBoxColumn.Name = "gasTankDataGridViewTextBoxColumn";
            this.gasTankDataGridViewTextBoxColumn.ReadOnly = true;
            this.gasTankDataGridViewTextBoxColumn.Visible = false;
            // 
            // priceGSDataGridViewTextBoxColumn
            // 
            this.priceGSDataGridViewTextBoxColumn.DataPropertyName = "priceGS";
            this.priceGSDataGridViewTextBoxColumn.HeaderText = "priceGS";
            this.priceGSDataGridViewTextBoxColumn.Name = "priceGSDataGridViewTextBoxColumn";
            this.priceGSDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceGSDataGridViewTextBoxColumn.Visible = false;
            // 
            // aPUDataGridViewTextBoxColumn
            // 
            this.aPUDataGridViewTextBoxColumn.DataPropertyName = "aPU";
            this.aPUDataGridViewTextBoxColumn.HeaderText = "aPU";
            this.aPUDataGridViewTextBoxColumn.Name = "aPUDataGridViewTextBoxColumn";
            this.aPUDataGridViewTextBoxColumn.ReadOnly = true;
            this.aPUDataGridViewTextBoxColumn.Visible = false;
            // 
            // aPPDataGridViewTextBoxColumn
            // 
            this.aPPDataGridViewTextBoxColumn.DataPropertyName = "aPP";
            this.aPPDataGridViewTextBoxColumn.HeaderText = "aPP";
            this.aPPDataGridViewTextBoxColumn.Name = "aPPDataGridViewTextBoxColumn";
            this.aPPDataGridViewTextBoxColumn.ReadOnly = true;
            this.aPPDataGridViewTextBoxColumn.Visible = false;
            // 
            // bPUDataGridViewTextBoxColumn
            // 
            this.bPUDataGridViewTextBoxColumn.DataPropertyName = "bPU";
            this.bPUDataGridViewTextBoxColumn.HeaderText = "bPU";
            this.bPUDataGridViewTextBoxColumn.Name = "bPUDataGridViewTextBoxColumn";
            this.bPUDataGridViewTextBoxColumn.ReadOnly = true;
            this.bPUDataGridViewTextBoxColumn.Visible = false;
            // 
            // bPPDataGridViewTextBoxColumn
            // 
            this.bPPDataGridViewTextBoxColumn.DataPropertyName = "bPP";
            this.bPPDataGridViewTextBoxColumn.HeaderText = "bPP";
            this.bPPDataGridViewTextBoxColumn.Name = "bPPDataGridViewTextBoxColumn";
            this.bPPDataGridViewTextBoxColumn.ReadOnly = true;
            this.bPPDataGridViewTextBoxColumn.Visible = false;
            // 
            // cPUDataGridViewTextBoxColumn
            // 
            this.cPUDataGridViewTextBoxColumn.DataPropertyName = "cPU";
            this.cPUDataGridViewTextBoxColumn.HeaderText = "cPU";
            this.cPUDataGridViewTextBoxColumn.Name = "cPUDataGridViewTextBoxColumn";
            this.cPUDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPUDataGridViewTextBoxColumn.Visible = false;
            // 
            // cPPDataGridViewTextBoxColumn
            // 
            this.cPPDataGridViewTextBoxColumn.DataPropertyName = "cPP";
            this.cPPDataGridViewTextBoxColumn.HeaderText = "cPP";
            this.cPPDataGridViewTextBoxColumn.Name = "cPPDataGridViewTextBoxColumn";
            this.cPPDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPPDataGridViewTextBoxColumn.Visible = false;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.HeaderText = "";
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.ReadOnly = true;
            this.btnViewDetails.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnViewDetails.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseColumnTextForButtonValue = true;
            // 
            // tblExpProcessBindingSource
            // 
            this.tblExpProcessBindingSource.DataMember = "tblExpProcess";
            this.tblExpProcessBindingSource.DataSource = this.cRCSMSDataSet_tblExpProcess;
            // 
            // cRCSMSDataSet_tblExpProcess
            // 
            this.cRCSMSDataSet_tblExpProcess.DataSetName = "CRCSMSDataSet_tblExpProcess";
            this.cRCSMSDataSet_tblExpProcess.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblExpProcessTableAdapter
            // 
            this.tblExpProcessTableAdapter.ClearBeforeFill = true;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.SandyBrown;
            this.btnFilter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.Maroon;
            this.btnFilter.Location = new System.Drawing.Point(414, 14);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(112, 35);
            this.btnFilter.TabIndex = 11;
            this.btnFilter.Text = "Filter Date";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "From:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "MMMM dd, yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(265, 8);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(143, 20);
            this.dtpFrom.TabIndex = 13;
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "MMMM dd, yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(265, 34);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(143, 20);
            this.dtpTo.TabIndex = 12;
            // 
            // frmExpPerProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1370, 645);
            this.Controls.Add(this.dgvProcessExp);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExpPerProcess";
            this.Text = "frmExpPerProcess";
            this.Load += new System.EventHandler(this.frmExpPerProcess_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblExpProcessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRCSMSDataSet_tblExpProcess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddProcess;
        private System.Windows.Forms.Label labelSales;
        private System.Windows.Forms.DataGridView dgvProcessExp;
        private CRCSMSDataSet_tblExpProcess cRCSMSDataSet_tblExpProcess;
        private System.Windows.Forms.BindingSource tblExpProcessBindingSource;
        private CRCSMSDataSet_tblExpProcessTableAdapters.tblExpProcessTableAdapter tblExpProcessTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn processIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateProcessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalexpCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalexpStDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalexpGSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalexpProcessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeBeanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceCBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stickerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceStDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gasTankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnViewDetails;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
    }
}