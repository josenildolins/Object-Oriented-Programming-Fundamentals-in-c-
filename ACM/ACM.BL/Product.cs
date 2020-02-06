using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Product : EntityBase
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }


        public override string ToString() => ProductName;

        /// <summary>
        /// Validate the Product data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        public Product Retrieve(int product)
        {
            // Code that retrieves the defined customer

            return new Product();
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
        public List<Product> Retrieve()
        {
            // Code that retrieves all of the customers

            return new List<Product>();
        }
    }
}
