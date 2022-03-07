using System;
using System.Data;
using System.Xml.Xsl;

namespace ObligatoriskOpgave_Car
{
    public class Car
    {
        public int id;
        public string _model;
        public int _price;
        public string _licenseplate;
        
        public Car(int id, string model, int price, string licenseplate)
        {
            this.id = id;
            Model = model;
            Price = price;
            LicensePlate = licenseplate;
        }

        public Car()
        {
        }

        public string Model
        {
            get => _model;
            set
            {
                if (value == null) throw new ArgumentNullException("Model", "Model is null");
                if (value.Length < 4) throw new ArgumentException("Model length must be atleast 3 charaters");
                _model = value;
            }
        }

        public int Price
        {
            get => _price;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("price", "Price must be higher than 0");
                _price = value;
                
                }
        }
        public string LicensePlate
        {
            get => _licenseplate;
            set
            {
                if (value.Length >= 2 && value.Length <= 7) _licenseplate = value;
                else throw new ArgumentOutOfRangeException("licenseplate", value, "Wrong licenseplate");
            }
        }

        public override string ToString()
        {
            return " ID " + id + " Model " + Model + " Price " + Price + " LicensePlate " + LicensePlate;
        }
    }
}


