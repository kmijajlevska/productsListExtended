using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProductsList
{
    public partial class NewProduct : Form
    {
        public Product Product { get; set; }

        private bool isValid = true;

        public NewProduct()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Length == 0)
            {
                MessageBox.Show("Името не смее да биде празно");
                return;
            }
            if (tbCategory.Text.Length == 0)
            {
                MessageBox.Show("Категоријата не смее да биде празна!");
                return;
            }
            float price;
            if (!float.TryParse(tbPrice.Text, out price))
            {
                MessageBox.Show("Внеси број за цената!");
                return;
            }
            Product = new Product();
            Product.Name = tbName.Text;
            Product.Category = tbCategory.Text;
            Product.Price = price;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

       
    }
}
