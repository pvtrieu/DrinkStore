using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DrinkStore.Entities
{
    class Order
    {
        private int _orderID;

        public int OrderID
        {
            get { return _orderID; }
            set { _orderID = value; }
        }

        private int _customerID;

        public int CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }

        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        private float _price_Total;

        public float Price_Total
        {
            get { return _price_Total; }
            set { _price_Total = value; }
        }

        private List<OrderList> _orderList;

        internal List<OrderList> OrderList
        {
            get { return _orderList; }
            set { _orderList = value; }
        }
        public Order()//int OrderID, int CustomerID, DateTime Date, float Price_Total)
        {
            //this._orderID = OrderID;
            //this._customerID = CustomerID;
            //this._date = Date;
            //this._price_Total = Price_Total;
        }

        public Order(DataRow row)
        {
            this._orderID = (int)row["OrderID"];
            this._customerID = (int)row["CustomerID"];
            this._date = (DateTime)row["Date"];
            this._price_Total = (int)row["Price_Total"];
        }
    }
}
