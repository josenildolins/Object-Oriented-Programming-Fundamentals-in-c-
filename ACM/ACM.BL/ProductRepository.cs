using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        ///<sumary>
        ///Retrieve one product.
        /// </sumary>
        public Product retrieve(int productId)
        {
            // Create the instance of the product class
            // Pass in the requested id
            Product product = new Product(productId);

            if(productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size set of 4 Bright yellow Mini Sunflower";
                product.CurrentPrice = 15.96M;
            }
            return product;
        }

        public bool Save(Product product)
        {
            return true;
        }
        
    }
}

