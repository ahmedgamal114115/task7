using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solDay7
{
    public class Car
    {
        #region attributes
        private int id;
        private string brand;
        private double price;
        #endregion

        #region properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        #endregion
        
        #region constucrots
        public Car()
        {

        }
        public Car(int _id)
        {
            id = _id;
        }
        public Car(int _id, string _brand)
        {
            id = _id;
            brand = _brand;
        }
        public Car(int _id, string _brand, double _price)
        {
            id = _id;
            brand = _brand;
            price = _price;
        }

        #endregion





    }
}
