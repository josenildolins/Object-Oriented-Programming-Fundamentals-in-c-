using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {
             
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }
        
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string FullName
        {
            get
            {
                string fullName = Lastname;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        private string _lastName;
        public string Lastname { 
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        /// <summary>
        /// Validate the customer data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(Lastname)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        public Customer Retrieve(int customer)
        {
            // Code that retrieves the defined customer

            return new Customer();
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


        public static int InstanceCount { get; set; }
    }
}
