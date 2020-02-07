﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }


        /// <summary>
        /// Retrieve one order item
        /// </summary>
        public OrderItem Retrieve(int orderItemId)
        {
            //Code that retrieves the defined order item.

            return new OrderItem();
        }

        ///<sumary>
        /// Saves the current order item.
        /// </sumary>
        public bool save()
        {
            // Code that Saves the defined order item.

            return true;
        }

        ///<summary>
        /// Validates the order item data
        /// </summary>
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}
