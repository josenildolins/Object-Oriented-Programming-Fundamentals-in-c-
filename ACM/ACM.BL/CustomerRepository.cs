using System.Collections.Generic;
using System.Linq;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            AddressRepository = new AddressRepository();
        }

        private AddressRepository AddressRepository { get; set; }


        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        public Customer Retrieve(int customerId)
        {
            // Create the instance of the Customer class
            // Pass in the requested id

            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "tasoha4484@eroyal.net";
                customer.FirstName = "Frodo";
                customer.Lastname = "Baggins";
                customer.AddressList = AddressRepository.RetrieveByCustomerId(customerId).ToList();
            }

            return customer;
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
        public List<Customer> Retrieve()
        {
            // Code that retrieves all of the customers

            return new List<Customer>();
        }

    }
}
