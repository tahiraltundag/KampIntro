using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(1,2,"Masa",138.50,322);
            Product product2 = new Product(2, 3, "Kalem", 32.45, 455);

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

        }
    }
}
