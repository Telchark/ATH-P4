using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public ICollection<OrderDetails> Details;

        public Order(ICollection<OrderDetails> details)
        {
            Details = details;
        }


    }
}
