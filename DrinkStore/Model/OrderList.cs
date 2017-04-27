using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DrinkStore.Entities
{
    class OrderList
    {
        private int _orderID;

        public int OrderID
        {
            get { return _orderID; }
            set { _orderID = value; }
        }

        private int _productID;

        public int ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }

        private int _qnt_Cask;

        public int Qnt_Cask
        {
            get { return _qnt_Cask; }
            set { _qnt_Cask = value; }
        }

        private int _qnt_Bottle;

        public int Qnt_Bottle
        {
            get { return _qnt_Bottle; }
            set { _qnt_Bottle = value; }
        }

        public OrderList()
        {
        }

        public OrderList(DataRow row)
        {
            this._orderID = (int)row["OrderID"];
            this._productID = (int)row["ProductID"];
            this._qnt_Cask = (int)row["Qnt_Cask"];
            this._qnt_Bottle = (int)row["Qnt_Bottle"];
        }
    }
}
