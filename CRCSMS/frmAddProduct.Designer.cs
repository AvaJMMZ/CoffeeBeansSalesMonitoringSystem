namespace CRCSMS
{
    partial class frmAddProduct
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
            this.labelProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtGram = new System.Windows.Forms.TextBox();
            this.labelGram = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelRoastType = new System.Windows.Forms.Label();
            this.labelGrindOption = new System.Windows.Forms.Label();
            this.chbMR = new System.Windows.Forms.CheckBox();
            this.chbDR = new System.Windows.Forms.CheckBox();
            this.chbWB = new System.Windows.Forms.CheckBox();
            this.chbCG = new System.Windows.Forms.CheckBox();
            this.chbFG = new System.Windows.Forms.CheckBox();
            this.top.SuspendLayout();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.SaddleBrown;
            this.top.Controls.Add(this.labelX);
            this.top.Controls.Add(this.labelTitle);
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Padding = new System.Windows.Forms.Padding(5);
            this.top.Size = new System.Drawing.Size(676, 33);
            this.top.TabIndex = 1;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.ForeColor = System.Drawing.Color.White;
            this.labelX.Location = new System.Drawing.Point(637, 5);
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
            this.labelTitle.Location = new System.Drawing.Point(40, 5);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(3, 0, 450, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(144, 25);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Add Product";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.BackColor = System.Drawing.Color.SandyBrown;
            this.labelProductName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelProductName.Location = new System.Drawing.Point(131, 82);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(148, 22);
            this.labelProductName.TabIndex = 2;
            this.labelProductName.Text = "Product Name:";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(291, 81);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(277, 26);
            this.txtProductName.TabIndex = 3;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAddProduct.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAddProduct.Location = new System.Drawing.Point(123, 481);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(445, 46);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "ADD PRODUCT";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtGram
            // 
            this.txtGram.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGram.Location = new System.Drawing.Point(291, 131);
            this.txtGram.Name = "txtGram";
            this.txtGram.Size = new System.Drawing.Size(277, 26);
            this.txtGram.TabIndex = 6;
            // 
            // labelGram
            // 
            this.labelGram.AutoSize = true;
            this.labelGram.BackColor = System.Drawing.Color.SandyBrown;
            this.labelGram.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGram.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelGram.Location = new System.Drawing.Point(131, 132);
            this.labelGram.Name = "labelGram";
            this.labelGram.Size = new System.Drawing.Size(68, 22);
            this.labelGram.TabIndex = 5;
            this.labelGram.Text = "Gram:";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(291, 188);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(277, 26);
            this.txtPrice.TabIndex = 8;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.SandyBrown;
            this.labelPrice.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelPrice.Location = new System.Drawing.Point(131, 189);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(65, 22);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Price:";
            // 
            // labelRoastType
            // 
            this.labelRoastType.AutoSize = true;
            this.labelRoastType.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoastType.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelRoastType.Location = new System.Drawing.Point(125, 252);
            this.labelRoastType.Name = "labelRoastType";
            this.labelRoastType.Size = new System.Drawing.Size(434, 22);
            this.labelRoastType.TabIndex = 9;
            this.labelRoastType.Text = "Choose Available Roast Type for this Product:";
            // 
            // labelGrindOption
            // 
            this.labelGrindOption.AutoSize = true;
            this.labelGrindOption.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrindOption.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelGrindOption.Location = new System.Drawing.Point(119, 348);
            this.labelGrindOption.Name = "labelGrindOption";
            this.labelGrindOption.Size = new System.Drawing.Size(449, 22);
            this.labelGrindOption.TabIndex = 10;
            this.labelGrindOption.Text = "Choose Available Grind Option for this Product:";
            // 
            // chbMR
            // 
            this.chbMR.AutoSize = true;
            this.chbMR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMR.ForeColor = System.Drawing.Color.White;
            this.chbMR.Location = new System.Drawing.Point(180, 298);
            this.chbMR.Name = "chbMR";
            this.chbMR.Size = new System.Drawing.Size(137, 23);
            this.chbMR.TabIndex = 11;
            this.chbMR.Text = "Meduim Roast";
            this.chbMR.UseVisualStyleBackColor = true;
            // 
            // chbDR
            // 
            this.chbDR.AutoSize = true;
            this.chbDR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDR.ForeColor = System.Drawing.Color.White;
            this.chbDR.Location = new System.Drawing.Point(375, 298);
            this.chbDR.Name = "chbDR";
            this.chbDR.Size = new System.Drawing.Size(113, 23);
            this.chbDR.TabIndex = 12;
            this.chbDR.Text = "Dark Roast";
            this.chbDR.UseVisualStyleBackColor = true;
            // 
            // chbWB
            // 
            this.chbWB.AutoSize = true;
            this.chbWB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbWB.ForeColor = System.Drawing.Color.White;
            this.chbWB.Location = new System.Drawing.Point(129, 395);
            this.chbWB.Name = "chbWB";
            this.chbWB.Size = new System.Drawing.Size(129, 23);
            this.chbWB.TabIndex = 13;
            this.chbWB.Text = "Whole Beans";
            this.chbWB.UseVisualStyleBackColor = true;
            // 
            // chbCG
            // 
            this.chbCG.AutoSize = true;
            this.chbCG.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbCG.ForeColor = System.Drawing.Color.White;
            this.chbCG.Location = new System.Drawing.Point(276, 395);
            this.chbCG.Name = "chbCG";
            this.chbCG.Size = new System.Drawing.Size(145, 23);
            this.chbCG.TabIndex = 14;
            this.chbCG.Text = "Coarse Ground";
            this.chbCG.UseVisualStyleBackColor = true;
            // 
            // chbFG
            // 
            this.chbFG.AutoSize = true;
            this.chbFG.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFG.ForeColor = System.Drawing.Color.White;
            this.chbFG.Location = new System.Drawing.Point(436, 395);
            this.chbFG.Name = "chbFG";
            this.chbFG.Size = new System.Drawing.Size(123, 23);
            this.chbFG.TabIndex = 15;
            this.chbFG.Text = "Fine Ground";
            this.chbFG.UseVisualStyleBackColor = true;
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(676, 586);
            this.Controls.Add(this.chbFG);
            this.Controls.Add(this.chbCG);
            this.Controls.Add(this.chbWB);
            this.Controls.Add(this.chbDR);
            this.Controls.Add(this.chbMR);
            this.Controls.Add(this.labelGrindOption);
            this.Controls.Add(this.labelRoastType);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.txtGram);
            this.Controls.Add(this.labelGram);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddProduct";
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel top;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtGram;
        private System.Windows.Forms.Label labelGram;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelRoastType;
        private System.Windows.Forms.Label labelGrindOption;
        private System.Windows.Forms.CheckBox chbMR;
        private System.Windows.Forms.CheckBox chbDR;
        private System.Windows.Forms.CheckBox chbWB;
        private System.Windows.Forms.CheckBox chbCG;
        private System.Windows.Forms.CheckBox chbFG;
    }
}