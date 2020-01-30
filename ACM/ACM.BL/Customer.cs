﻿using System.Collections.Generic;

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


        public static int InstanceCount { get; set; }
    }
}
