namespace CRCSMS
{
    partial class frmMoreDetails
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
            this.labelGrindOption = new System.Windows.Forms.Label();
            this.labelRoastType = new System.Windows.Forms.Label();
            this.rbMR = new System.Windows.Forms.RadioButton();
            this.panelRoast = new System.Windows.Forms.Panel();
            this.rbDR = new System.Windows.Forms.RadioButton();
            this.panelGrind = new System.Windows.Forms.Panel();
            this.rbFG = new System.Windows.Forms.RadioButton();
            this.rbCG = new System.Windows.Forms.RadioButton();
            this.rbWB = new System.Windows.Forms.RadioButton();
            this.updownQuantity = new System.Windows.Forms.NumericUpDown();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.panelRoast.SuspendLayout();
            this.panelGrind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGrindOption
            // 
            this.labelGrindOption.AutoSize = true;
            this.labelGrindOption.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrindOption.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelGrindOption.Location = new System.Drawing.Point(88, 16);
            this.labelGrindOption.Name = "labelGrindOption";
            this.labelGrindOption.Size = new System.Drawing.Size(346, 22);
            this.labelGrindOption.TabIndex = 17;
            this.labelGrindOption.Text = "Choose Grind Type for this Product:";
            // 
            // labelRoastType
            // 
            this.labelRoastType.AutoSize = true;
            this.labelRoastType.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoastType.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelRoastType.Location = new System.Drawing.Point(92, 18);
            this.labelRoastType.Name = "labelRoastType";
            this.labelRoastType.Size = new System.Drawing.Size(336, 22);
            this.labelRoastType.TabIndex = 16;
            this.labelRoastType.Text = "Choos Roast Type for this Product:";
            // 
            // rbMR
            // 
            this.rbMR.AutoSize = true;
            this.rbMR.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMR.Location = new System.Drawing.Point(116, 58);
            this.rbMR.Name = "rbMR";
            this.rbMR.Size = new System.Drawing.Size(127, 22);
            this.rbMR.TabIndex = 23;
            this.rbMR.TabStop = true;
            this.rbMR.Text = "Meduim Roast";
            this.rbMR.UseVisualStyleBackColor = true;
            // 
            // panelRoast
            // 
            this.panelRoast.Controls.Add(this.labelID);
            this.panelRoast.Controls.Add(this.rbDR);
            this.panelRoast.Controls.Add(this.labelRoastType);
            this.panelRoast.Controls.Add(this.rbMR);
            this.panelRoast.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRoast.Location = new System.Drawing.Point(0, 0);
            this.panelRoast.Name = "panelRoast";
            this.panelRoast.Size = new System.Drawing.Size(519, 100);
            this.panelRoast.TabIndex = 24;
            // 
            // rbDR
            // 
            this.rbDR.AutoSize = true;
            this.rbDR.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDR.Location = new System.Drawing.Point(281, 58);
            this.rbDR.Name = "rbDR";
            this.rbDR.Size = new System.Drawing.Size(104, 22);
            this.rbDR.TabIndex = 24;
            this.rbDR.TabStop = true;
            this.rbDR.Text = "Dark Roast";
            this.rbDR.UseVisualStyleBackColor = true;
            // 
            // panelGrind
            // 
            this.panelGrind.Controls.Add(this.rbFG);
            this.panelGrind.Controls.Add(this.rbCG);
            this.panelGrind.Controls.Add(this.rbWB);
            this.panelGrind.Controls.Add(this.labelGrindOption);
            this.panelGrind.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGrind.Location = new System.Drawing.Point(0, 100);
            this.panelGrind.Name = "panelGrind";
            this.panelGrind.Size = new System.Drawing.Size(519, 100);
            this.panelGrind.TabIndex = 25;
            // 
            // rbFG
            // 
            this.rbFG.AutoSize = true;
            this.rbFG.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFG.Location = new System.Drawing.Point(355, 59);
            this.rbFG.Name = "rbFG";
            this.rbFG.Size = new System.Drawing.Size(115, 22);
            this.rbFG.TabIndex = 27;
            this.rbFG.TabStop = true;
            this.rbFG.Text = "Fine Ground";
            this.rbFG.UseVisualStyleBackColor = true;
            // 
            // rbCG
            // 
            this.rbCG.AutoSize = true;
            this.rbCG.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCG.Location = new System.Drawing.Point(205, 59);
            this.rbCG.Name = "rbCG";
            this.rbCG.Size = new System.Drawing.Size(135, 22);
            this.rbCG.TabIndex = 26;
            this.rbCG.TabStop = true;
            this.rbCG.Text = "Coarse Ground";
            this.rbCG.UseVisualStyleBackColor = true;
            // 
            // rbWB
            // 
            this.rbWB.AutoSize = true;
            this.rbWB.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWB.Location = new System.Drawing.Point(63, 59);
            this.rbWB.Name = "rbWB";
            this.rbWB.Size = new System.Drawing.Size(119, 22);
            this.rbWB.TabIndex = 25;
            this.rbWB.TabStop = true;
            this.rbWB.Text = "Whole Beans";
            this.rbWB.UseVisualStyleBackColor = true;
            // 
            // updownQuantity
            // 
            this.updownQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updownQuantity.Location = new System.Drawing.Point(232, 219);
            this.updownQuantity.Name = "updownQuantity";
            this.updownQuantity.Size = new System.Drawing.Size(120, 26);
            this.updownQuantity.TabIndex = 26;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelQuantity.Location = new System.Drawing.Point(147, 221);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(79, 19);
            this.labelQuantity.TabIndex = 27;
            this.labelQuantity.Text = "Quantity:";
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtoCart.Location = new System.Drawing.Point(178, 261);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(162, 33);
            this.btnAddtoCart.TabIndex = 28;
            this.btnAddtoCart.Text = "Add to Cart";
            this.btnAddtoCart.UseVisualStyleBackColor = true;
            this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(12, 9);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 29;
            this.labelID.Text = "ID";
            // 
            // frmMoreDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 311);
            this.Controls.Add(this.btnAddtoCart);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.updownQuantity);
            this.Controls.Add(this.panelGrind);
            this.Controls.Add(this.panelRoast);
            this.Name = "frmMoreDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMoreDetails";
            this.panelRoast.ResumeLayout(false);
            this.panelRoast.PerformLayout();
            this.panelGrind.ResumeLayout(false);
            this.panelGrind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelGrindOption;
        private System.Windows.Forms.Label labelRoastType;
        private System.Windows.Forms.RadioButton rbMR;
        private System.Windows.Forms.Panel panelRoast;
        private System.Windows.Forms.RadioButton rbDR;
        private System.Windows.Forms.Panel panelGrind;
        private System.Windows.Forms.RadioButton rbFG;
        private System.Windows.Forms.RadioButton rbCG;
        private System.Windows.Forms.RadioButton rbWB;
        private System.Windows.Forms.NumericUpDown updownQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.Label labelID;
    }
}