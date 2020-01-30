using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public  class Order
    {
        public Order()
        {
           
        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public DateTimeOffset? OrderDate{ get; set; }
        public int OrderId { get; set; }

        /// <summary>
        /// Retrieve one customer.
        /// </summary>
       

        /// <summary>
        /// Validates the order data.
        /// </summary>
        public bool Validate()
        {
            var isValidate = true;

            if (OrderDate == null) isValidate = false;

            return isValidate;
        }

    }
}
