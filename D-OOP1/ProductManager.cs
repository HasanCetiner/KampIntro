using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        publc void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "eklendi.");
        }

        publc void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }
    }
}
