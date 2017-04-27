using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DrinkStore.Entities
{
    class Category
    {
        private int _categoryID;

        public int CategoryID
        {
            get { return _categoryID; }
            set { _categoryID = value; }
        }

        private string _categoryName;

        public string CategoryName
        {
            get { return _categoryName; }
            set { _categoryName = value; }
        }

        private int _categoryCount;

        public int CategoryCount
        {
            get { return _categoryCount; }
            set { _categoryCount = value; }
        }

        public Category(int CategoryID, string CategoryName, int CategoryCount)
        {
            this._categoryID = CategoryID;
            this._categoryName = CategoryName;
            this._categoryCount = CategoryCount;
        }

        public Category(DataRow row)
        {
            this._categoryID = (int)row["CategoryID"];
            this._categoryName = (string)row["CategoryName"];
            this._categoryCount = (int)row["CategoryCount"];
        }
    }
}
