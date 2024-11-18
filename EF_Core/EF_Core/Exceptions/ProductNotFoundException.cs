using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Exceptions
{
    class ProductNotFoundException : Exception
    {
        public ProductNotFoundException() : base("Product not founded, Please try again!") { }
        public ProductNotFoundException(string message) : base(message) { }
    }
}
