using System;

namespace GenericCollectionApp.Modal
{
    class Lineitem
    {
        private int _id;
        private string _productName;
        private int _quantity;
        private int _unitPrice;

        public Lineitem(int id, string productname, int quantity, int unitprice)
        {
            _id = id;
            _productName = productname;
            _quantity = quantity;
            _unitPrice = unitprice;
        }

        public int UnitTotalPrice()
        {
            return _quantity * _unitPrice;
        }

        public int ID
        {
            get
            {
                return _id;
            }
        }

        public string ProductName
        {
            get
            {
                return _productName;
            }
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }
        }

        public int UnitPrice
        {
            get
            {
                return _unitPrice;
            }
        }
    }
}
