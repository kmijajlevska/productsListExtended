namespace ProductsList
{
    partial class Form1
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
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbBasket = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddToBasket = new System.Windows.Forms.Button();
            this.btnRemoveFromBasket = new System.Windows.Forms.Button();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnClearProducts = new System.Windows.Forms.Button();
            this.btnClearBasket = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.Location = new System.Drawing.Point(12, 25);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(213, 303);
            this.lbProducts.TabIndex = 0;
            this.lbProducts.SelectedIndexChanged += new System.EventHandler(this.lbProducts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Листа на продукти:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Име";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbCategory);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(231, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 152);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Детали за продуктот";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(7, 121);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbPrice.Size = new System.Drawing.Size(104, 20);
            this.tbPrice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цена:";
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(7, 77);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.ReadOnly = true;
            this.tbCategory.Size = new System.Drawing.Size(214, 20);
            this.tbCategory.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Категорија:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(7, 33);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(214, 20);
            this.tbName.TabIndex = 3;
            // 
            // lbBasket
            // 
            this.lbBasket.FormattingEnabled = true;
            this.lbBasket.Location = new System.Drawing.Point(465, 25);
            this.lbBasket.Name = "lbBasket";
            this.lbBasket.Size = new System.Drawing.Size(232, 264);
            this.lbBasket.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Кошничка:";
            // 
            // btnAddToBasket
            // 
            this.btnAddToBasket.Location = new System.Drawing.Point(232, 183);
            this.btnAddToBasket.Name = "btnAddToBasket";
            this.btnAddToBasket.Size = new System.Drawing.Size(153, 23);
            this.btnAddToBasket.TabIndex = 6;
            this.btnAddToBasket.Text = "Додади во кошничка >>";
            this.btnAddToBasket.UseVisualStyleBackColor = true;
            this.btnAddToBasket.Click += new System.EventHandler(this.btnAddToBasket_Click);
            // 
            // btnRemoveFromBasket
            // 
            this.btnRemoveFromBasket.Location = new System.Drawing.Point(232, 221);
            this.btnRemoveFromBasket.Name = "btnRemoveFromBasket";
            this.btnRemoveFromBasket.Size = new System.Drawing.Size(220, 23);
            this.btnRemoveFromBasket.TabIndex = 7;
            this.btnRemoveFromBasket.Text = "Избриши од кошничка";
            this.btnRemoveFromBasket.UseVisualStyleBackColor = true;
            this.btnRemoveFromBasket.Click += new System.EventHandler(this.btnRemoveFromBasket_Click);
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Location = new System.Drawing.Point(232, 259);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(220, 23);
            this.btnAddNewProduct.TabIndex = 8;
            this.btnAddNewProduct.Text = "Додади нов продукт";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(232, 297);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(220, 23);
            this.btnDeleteProduct.TabIndex = 9;
            this.btnDeleteProduct.Text = "Избриши продукт";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnClearProducts
            // 
            this.btnClearProducts.Location = new System.Drawing.Point(12, 335);
            this.btnClearProducts.Name = "btnClearProducts";
            this.btnClearProducts.Size = new System.Drawing.Size(213, 23);
            this.btnClearProducts.TabIndex = 10;
            this.btnClearProducts.Text = "Испразни ја листата со продукти?";
            this.btnClearProducts.UseVisualStyleBackColor = true;
            this.btnClearProducts.Click += new System.EventHandler(this.btnClearProducts_Click);
            // 
            // btnClearBasket
            // 
            this.btnClearBasket.Location = new System.Drawing.Point(465, 334);
            this.btnClearBasket.Name = "btnClearBasket";
            this.btnClearBasket.Size = new System.Drawing.Size(232, 23);
            this.btnClearBasket.TabIndex = 11;
            this.btnClearBasket.Text = "Испразни ја кошничката?";
            this.btnClearBasket.UseVisualStyleBackColor = true;
            this.btnClearBasket.Click += new System.EventHandler(this.btnClearBasket_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Вкупно:";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(521, 296);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbTotal.Size = new System.Drawing.Size(176, 20);
            this.tbTotal.TabIndex = 13;
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(392, 184);
            this.nudAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudAmount.Size = new System.Drawing.Size(66, 20);
            this.nudAmount.TabIndex = 14;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 369);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClearBasket);
            this.Controls.Add(this.btnClearProducts);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnAddNewProduct);
            this.Controls.Add(this.btnRemoveFromBasket);
            this.Controls.Add(this.btnAddToBasket);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbBasket);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbProducts);
            this.Name = "Form1";
            this.Text = "Потрошувачка кошничка";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ListBox lbBasket;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddToBasket;
        private System.Windows.Forms.Button btnRemoveFromBasket;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnClearProducts;
        private System.Windows.Forms.Button btnClearBasket;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.NumericUpDown nudAmount;
    }
}

