namespace CRCSMS
{
    partial class frmExpMonthly
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddMonthly = new System.Windows.Forms.Button();
            this.labelSales = new System.Windows.Forms.Label();
            this.dgvExpMonthly = new System.Windows.Forms.DataGridView();
            this.cRCSMSDataSet_tblMonthlyExp = new CRCSMS.CRCSMSDataSet_tblMonthlyExp();
            this.tblMonthlyExpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblMonthlyExpTableAdapter = new CRCSMS.CRCSMSDataSet_tblMonthlyExpTableAdapters.tblMonthlyExpTableAdapter();
            this.monthExpIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthExpNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyBudgetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpMonthly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRCSMSDataSet_tblMonthlyExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMonthlyExpBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnAddMonthly);
            this.panel1.Controls.Add(this.labelSales);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1354, 54);
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
            // 
            // btnAddMonthly
            // 
            this.btnAddMonthly.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAddMonthly.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMonthly.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddMonthly.Location = new System.Drawing.Point(65, 9);
            this.btnAddMonthly.Name = "btnAddMonthly";
            this.btnAddMonthly.Size = new System.Drawing.Size(177, 35);
            this.btnAddMonthly.TabIndex = 3;
            this.btnAddMonthly.Text = "Add Monthly Expenses";
            this.btnAddMonthly.UseVisualStyleBackColor = false;
            this.btnAddMonthly.Click += new System.EventHandler(this.btnAddMonthly_Click);
            // 
            // labelSales
            // 
            this.labelSales.AutoSize = true;
            this.labelSales.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSales.Location = new System.Drawing.Point(481, 7);
            this.labelSales.Name = "labelSales";
            this.labelSales.Size = new System.Drawing.Size(474, 38);
            this.labelSales.TabIndex = 1;
            this.labelSales.Text = "M O N T H L Y   E X P E N S E S";
            // 
            // dgvExpMonthly
            // 
            this.dgvExpMonthly.AllowUserToAddRows = false;
            this.dgvExpMonthly.AllowUserToDeleteRows = false;
            this.dgvExpMonthly.AllowUserToResizeColumns = false;
            this.dgvExpMonthly.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SandyBrown;
            this.dgvExpMonthly.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExpMonthly.AutoGenerateColumns = false;
            this.dgvExpMonthly.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpMonthly.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dgvExpMonthly.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpMonthly.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExpMonthly.ColumnHeadersHeight = 40;
            this.dgvExpMonthly.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.monthExpIDDataGridViewTextBoxColumn,
            this.monthExpNameDataGridViewTextBoxColumn,
            this.monthlyBudgetDataGridViewTextBoxColumn,
            this.btnDelete});
            this.dgvExpMonthly.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvExpMonthly.DataSource = this.tblMonthlyExpBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle3.NullValue = "NULL";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpMonthly.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExpMonthly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExpMonthly.EnableHeadersVisualStyles = false;
            this.dgvExpMonthly.GridColor = System.Drawing.Color.PeachPuff;
            this.dgvExpMonthly.Location = new System.Drawing.Point(0, 54);
            this.dgvExpMonthly.Name = "dgvExpMonthly";
            this.dgvExpMonthly.ReadOnly = true;
            this.dgvExpMonthly.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvExpMonthly.RowHeadersVisible = false;
            this.dgvExpMonthly.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpMonthly.Size = new System.Drawing.Size(1354, 552);
            this.dgvExpMonthly.TabIndex = 3;
            this.dgvExpMonthly.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpMonthly_CellContentClick);
            // 
            // cRCSMSDataSet_tblMonthlyExp
            // 
            this.cRCSMSDataSet_tblMonthlyExp.DataSetName = "CRCSMSDataSet_tblMonthlyExp";
            this.cRCSMSDataSet_tblMonthlyExp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMonthlyExpBindingSource
            // 
            this.tblMonthlyExpBindingSource.DataMember = "tblMonthlyExp";
            this.tblMonthlyExpBindingSource.DataSource = this.cRCSMSDataSet_tblMonthlyExp;
            // 
            // tblMonthlyExpTableAdapter
            // 
            this.tblMonthlyExpTableAdapter.ClearBeforeFill = true;
            // 
            // monthExpIDDataGridViewTextBoxColumn
            // 
            this.monthExpIDDataGridViewTextBoxColumn.DataPropertyName = "monthExpID";
            this.monthExpIDDataGridViewTextBoxColumn.HeaderText = "Expenses ID";
            this.monthExpIDDataGridViewTextBoxColumn.Name = "monthExpIDDataGridViewTextBoxColumn";
            this.monthExpIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monthExpNameDataGridViewTextBoxColumn
            // 
            this.monthExpNameDataGridViewTextBoxColumn.DataPropertyName = "monthExpName";
            this.monthExpNameDataGridViewTextBoxColumn.HeaderText = "Expense Name";
            this.monthExpNameDataGridViewTextBoxColumn.Name = "monthExpNameDataGridViewTextBoxColumn";
            this.monthExpNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monthlyBudgetDataGridViewTextBoxColumn
            // 
            this.monthlyBudgetDataGridViewTextBoxColumn.DataPropertyName = "monthlyBudget";
            this.monthlyBudgetDataGridViewTextBoxColumn.HeaderText = "Monthly Budget";
            this.monthlyBudgetDataGridViewTextBoxColumn.Name = "monthlyBudgetDataGridViewTextBoxColumn";
            this.monthlyBudgetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // frmExpMonthly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1354, 606);
            this.Controls.Add(this.dgvExpMonthly);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExpMonthly";
            this.Text = "frmExpMonthly";
            this.Load += new System.EventHandler(this.frmExpMonthly_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpMonthly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRCSMSDataSet_tblMonthlyExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMonthlyExpBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddMonthly;
        private System.Windows.Forms.Label labelSales;
        private System.Windows.Forms.DataGridView dgvExpMonthly;
        private CRCSMSDataSet_tblMonthlyExp cRCSMSDataSet_tblMonthlyExp;
        private System.Windows.Forms.BindingSource tblMonthlyExpBindingSource;
        private CRCSMSDataSet_tblMonthlyExpTableAdapters.tblMonthlyExpTableAdapter tblMonthlyExpTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthExpIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthExpNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyBudgetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}