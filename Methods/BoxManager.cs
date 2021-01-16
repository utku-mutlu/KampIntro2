using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BoxManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi : "+product.ProductName);
        }
        public void Add2(string ProductName,string Content, double Price )
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi : " + ProductName);
        }
    }
}
