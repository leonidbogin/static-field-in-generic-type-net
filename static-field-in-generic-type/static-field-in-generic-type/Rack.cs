using System;
using System.Collections.Generic;
using System.Text;

namespace static_field_in_generic_type
{
    public class Rack<T> where T : Product
    {
        private List<Product> Products { get; set; }
        public static int Count{ get; set; }

        public Rack()
        {
            Products = new List<Product>();
        }

        public void Add(T product)
        {
            Products.Add(product);
            Count++;
        }
    }
}
