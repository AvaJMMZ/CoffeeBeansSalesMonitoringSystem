namespace CRCSMS
{
    partial class frmAddMonthly
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
            this.top = new System.Windows.Forms.FlowLayoutPanel();
            this.labelX = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.txtMonthExp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.numMonthBud = new System.Windows.Forms.NumericUpDown();
            this.btnAddMonthly = new System.Windows.Forms.Button();
            this.top.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMonthBud)).BeginInit();
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
            this.top.Size = new System.Drawing.Size(583, 39);
            this.top.TabIndex = 4;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.ForeColor = System.Drawing.Color.White;
            this.labelX.Location = new System.Drawing.Point(540, 5);
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
            this.labelTitle.Location = new System.Drawing.Point(28, 5);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(3, 0, 250, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(259, 25);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Add Monthly Expenses";
            // 
            // txtMonthExp
            // 
            this.txtMonthExp.BackColor = System.Drawing.Color.PeachPuff;
            this.txtMonthExp.Cursor = System.Windows.Forms.Cursors.No;
            this.txtMonthExp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtMonthExp.Location = new System.Drawing.Point(293, 74);
            this.txtMonthExp.Name = "txtMonthExp";
            this.txtMonthExp.Size = new System.Drawing.Size(234, 26);
            this.txtMonthExp.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(42, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Monthly Expenses Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(25, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Estimated Monthly Budget:";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.PeachPuff;
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.numMonthBud);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(293, 119);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(234, 36);
            this.flowLayoutPanel2.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 8, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "₱";
            // 
            // numMonthBud
            // 
            this.numMonthBud.BackColor = System.Drawing.Color.PeachPuff;
            this.numMonthBud.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMonthBud.Location = new System.Drawing.Point(29, 5);
            this.numMonthBud.Margin = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.numMonthBud.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numMonthBud.Name = "numMonthBud";
            this.numMonthBud.Size = new System.Drawing.Size(193, 26);
            this.numMonthBud.TabIndex = 5;
            // 
            // btnAddMonthly
            // 
            this.btnAddMonthly.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAddMonthly.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMonthly.Location = new System.Drawing.Point(118, 196);
            this.btnAddMonthly.Name = "btnAddMonthly";
            this.btnAddMonthly.Size = new System.Drawing.Size(368, 39);
            this.btnAddMonthly.TabIndex = 38;
            this.btnAddMonthly.Text = "ADD MONTHLY EXPENSES";
            this.btnAddMonthly.UseVisualStyleBackColor = false;
            this.btnAddMonthly.Click += new System.EventHandler(this.btnAddMonthly_Click);
            // 
            // frmAddMonthly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(583, 275);
            this.Controls.Add(this.btnAddMonthly);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.txtMonthExp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddMonthly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddMonthly";
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMonthBud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel top;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox txtMonthExp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numMonthBud;
        private System.Windows.Forms.Button btnAddMonthly;
    }
}