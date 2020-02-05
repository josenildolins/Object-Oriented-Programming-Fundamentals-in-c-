using System;
using System.Collections.Generic;

namespace ACM.BL
{
    class Order
    {
        public Order() : this(0)
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        public int CustomerId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingAddressId { get; set; };

        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        public Order Retrieve(int orderId)
        {
            // Code that retrieves the defined customer

            return new Order();
        }

        /// <summary>
        /// Sves the current customer
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined customer

            return true;
        }

        /// <summary>
        /// Retrieve all customers
        /// </summary>
        public List<Order> Retrieve()
        {
            // Code that retrieves all of the customers

            return new List<Order>();
        }

        /// <summary>
        /// Validates the order data.
        /// </summary>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

    }
}
