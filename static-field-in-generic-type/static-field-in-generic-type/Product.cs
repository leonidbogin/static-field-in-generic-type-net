using System;
using System.Collections.Generic;
using System.Text;

namespace static_field_in_generic_type
{
    public abstract class Product
    {
        public string Name { get; set; }

        public Product()
        {

        }

        public Product(string name)
        {
            Name = name;
        }
    }
}
