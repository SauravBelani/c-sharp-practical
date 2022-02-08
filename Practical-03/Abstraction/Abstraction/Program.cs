using System;

namespace Abstraction
{
    public class Laptop
    {
        private string brand;
        private string model;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public void LaptopDetails()
        {
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Model: " + model);
        }
        /// <summary>
        /// Private mathod are not access from Main class
        /// </summary>
        private void MotherBoardInfo()
        {
            Console.WriteLine("MotheBoard Information");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Laptop l = new Laptop();
            l.Brand = "Dell";
            l.Model = "Inspiron 14R";
            l.LaptopDetails();
            //l.MotherBoardInfo();
        }
    }
}
