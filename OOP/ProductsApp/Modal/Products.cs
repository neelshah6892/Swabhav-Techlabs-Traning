using System;

namespace ProductsApp.Modal
{
    class Products
    {
        private static int _id = 0;
        private float _price;
        private string _name;
        private float _discount;
        private float finalprice;
        public Products(string name, float price, float discount)
        {
            _name = name;
            _price = price;
            _discount = discount;
        }

        public float finalPrice
        {
            get
            {
                float discountValue = _price * _discount / 100;
                return finalprice = _price - discountValue;
            }
        }
        public int ID
        {
            get
            {
                return _id = ++_id; ;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public float Price
        {
            get
            {
                return _price;
            }
        }

        public float Discount
        {
            get
            {
                return _discount;
            }
        }

    }
}
