using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DrinkStore.Entities
{
    class Import
    {
        private int _importID;

        public int ImportID
        {
            get { return _importID; }
            set { _importID = value; }
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

        private DateTime _importDate;

        public DateTime ImportDate
        {
            get { return _importDate; }
            set { _importDate = value; }
        }

        private float _price_Base;

        public float Price_Base
        {
            get { return _price_Base; }
            set { _price_Base = value; }
        }

        public Import(int ImportID, int ProductID, DateTime ImportDate ,int Qnt_Cask, int Qnt_Bottle, int Price_Base)
        {
            this._importID = ImportID;
            this._productID = ProductID;
            this._importDate = ImportDate;
            this._qnt_Cask = Qnt_Cask;
            this._qnt_Bottle = Qnt_Bottle;
            this._price_Base = Price_Base;
        }

        public Import(DataRow row)
        {
            this._importID = (int)row["ImportID"];
            this._productID = (int)row["ProductID"];
            this._importDate = (DateTime)row["ImportDate"];
            this._qnt_Cask = (int)row["Qnt_Cask"];
            this._qnt_Bottle = (int)row["Qnt_Bottle"];
            this._price_Base = (int)row["Price_Base"];
        }
    }
}
