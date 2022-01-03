using System;

namespace CollectionApp.Modal
{
    public class LineItem
    {
        private int _id;
        private string _productName;
        private int _quantity;
        private int _unitPrice;
        private int _totalprice;
        private int _totalunitprice;

        public LineItem(int id, string productname, int quantity, int unitprice)
        {
            _id = id;
            _productName = productname;
            _quantity = quantity;
            _unitPrice = unitprice;
        }

        public void TotalPrice(LineItem lineitem)
        {
            for (int i = 0; i <= lineitem._id; i++)
            {
                _totalprice = _totalprice + _totalunitprice;
            }
        }

        public int TotalUnitPrice
        {
            
            get
            {
                _totalunitprice = _quantity * _unitPrice;
                return _totalunitprice;
            }
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
