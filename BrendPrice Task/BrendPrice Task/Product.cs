using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrendPrice_Task
{
     public class Product
    {
        public string Name;
        public string BrandName;
        public double Price;
        public Product(string Name,string BrandName, double Price)
        {
            this.Name = Name;
            this.BrandName = BrandName;
            this.Price = Price;
        }
    }
}
