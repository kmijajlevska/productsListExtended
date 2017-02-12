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
    public partial class Form1 : Form
    {
        private float total = 0;

        public Form1()
        {
            InitializeComponent();
            Product p1 = new Product();
            p1.Name = "Месо";
            p1.Category = "Исхрана";
            p1.Price = 300;
            Product p2 = new Product();
            p2.Name = "Mлеко";
            p2.Category = "Исхрана";
            p2.Price = 50;
            Product p3 = new Product();
            p3.Name = "Вино";
            p3.Category = "Пијалок";
            p3.Price = 200;
            Product p4 = new Product();
            p4.Name = "Пиво";
            p4.Category = "Пијалок";
            p4.Price = 100;
            Product p5 = new Product();
            p5.Name = "Шампон";
            p5.Category = "Хигена";
            p5.Price = 150;
            Product p6 = new Product();
            p6.Name = "Паста за заби";
            p6.Category = "Хигена";
            p6.Price = 120;
            lbProducts.Items.Add(p1);
            lbProducts.Items.Add(p2);
            lbProducts.Items.Add(p3);
            lbProducts.Items.Add(p4);
            lbProducts.Items.Add(p5);
            lbProducts.Items.Add(p6);
        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product product = (Product)lbProducts.SelectedItem;
            if (product != null)
            {
                tbName.Text = product.Name;
                tbCategory.Text = product.Category;
                tbPrice.Text = string.Format("{0:0,0.00}", product.Price);
            }
        }

        private void btnAddToBasket_Click(object sender, EventArgs e)
        {
            if (lbProducts.SelectedIndex != -1)
            {
                
                Product product = (Product)lbProducts.SelectedItem;
                ProductItem item = new ProductItem();
                item.Product = product;
                item.Amount = (float)nudAmount.Value;
                lbBasket.Items.Add(item);
                total += product.Price * item.Amount;
                setTotal();
            }
            else
            {
                MessageBox.Show("Избери продукт од листата!");
            }
        }

        private void btnRemoveFromBasket_Click(object sender, EventArgs e)
        {
            if (lbBasket.SelectedIndex != -1)
            {
                ProductItem productItem = (ProductItem)lbBasket.SelectedItem;
                total -= productItem.Product.Price;
                setTotal();
                lbBasket.Items.RemoveAt(lbBasket.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Избери продукт од кошничката!");
            }
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            NewProduct np = new NewProduct();
            if (np.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbProducts.Items.Add(np.Product);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (lbProducts.SelectedIndex != -1)
            {
                lbProducts.Items.RemoveAt(lbProducts.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Избери продукт од листата!");
            }
        }

        private void btnClearProducts_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дали сте сигурни дека сакате да ја испразните листата со продукти?",
                "Испразни ја листата?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lbProducts.Items.Clear();
            }
        }

        private void btnClearBasket_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дали сте сигурни дека сакате да ја испразните кошничката?",
                "Испразни ја кошничката?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lbBasket.Items.Clear();
                total = 0;
                setTotal();
            }
        }

        private void setTotal()
        {
            tbTotal.Text = string.Format("{0:0,0.00}", total);
        }
    }
}
