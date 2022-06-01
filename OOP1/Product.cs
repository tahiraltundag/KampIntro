using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }


        public Product(int id, int categoryId, string productName, double unitPrice, int unitsInStock)
        {
            Id = id;
            CategoryId = categoryId;
            ProductName = productName;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;
        }

    }
}
