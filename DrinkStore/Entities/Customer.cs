using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DrinkStore.Entities
{
    class Customer
    {
        private int _customerID;

        public int CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }

        private string _customerName;

        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }

        private int _phoneNumber;

        public int PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public Customer()
        {
        }

        public Customer(DataRow row)
        {
            this._customerID = (int)row["CustomerID"];
            this._customerName = (string)row["CustomerName"];
            this._phoneNumber = (int)row["PhoneNumber"];
            this._email = (string)row["Email"];
        }
    }
}
