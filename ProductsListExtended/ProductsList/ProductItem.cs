using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductsList
{
    public class ProductItem
    {
        public Product Product { get; set; }

        public float Amount { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1:0.0} x {2:0.0} = {3:0,0.00}", Product.Name, Amount, Product.Price, Amount * Product.Price);
        }
    }
}
