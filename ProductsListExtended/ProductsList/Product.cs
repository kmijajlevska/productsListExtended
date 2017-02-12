using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductsList
{
    public class Product
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public float Price { get; set; }

        public override string ToString()
        {
            return string.Format("{0}", Name);
        }
    }
}
