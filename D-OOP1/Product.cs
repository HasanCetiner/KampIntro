using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{           //snipped = prop yazdığımızda altta görülen nokta nookta olan hazır kodlara denir
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UMyProperty { get; set; }
        public int UnitsInStock  { get; set; }

    }
}
// CRUD = Create, Read, Update, Delete