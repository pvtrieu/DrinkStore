using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DrinkStore.Entities
{
    class Product
    {
        private int _productID;

        public int ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }

        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
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

        private float _price_Sell;

        public float Price_Sell
        {
            get { return _price_Sell; }
            set { _price_Sell = value; }
        }

        private int _categoryID;

        public int CategoryID
        {
            get { return _categoryID; }
            set { _categoryID = value; }
        }

        public Product()
        {
        }

        public Product(int ProductID, string Title, int Qnt_Cask, int Qnt_Bottle, int Price_Sell, int CategoryID)
        {
            this._productID = ProductID;
            this._title = Title;
            this._qnt_Cask = Qnt_Cask;
            this._qnt_Bottle = Qnt_Bottle;
            this._price_Sell = Price_Sell;
        }

        public Product(DataRow row)
        {
            this._productID = (int)row["ProductID"];
            this._title = row["Title"].ToString();
            this._qnt_Cask = (int)row["Qnt_Cask"];
            this._qnt_Bottle = (int)row["Qnt_Bottle"];
            this._price_Sell = (int)row["Price_Sell"];
            this._categoryID = (int)row["CategoryID"];
        }
    }
}
