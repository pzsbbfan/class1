using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           car.RunTest();
           Console.ReadLine();
        }

    }

    class car
    {
        private int year;
        private string model;
        private bool isDrivable;
        private double price;

        public car(int year, string model, double Price, bool isDrivable = false)
        { 
            this.year = year;
            this.model = model;
            this.isDrivable = isDrivable;
            this.price = Price;
        }

        public override string ToString()
        {
            return $"model: {model,15}   year: {year,8}   price: {price,8}   Electrical?: {isDrivable,10}";
        }

        public static void RunTest()
        {
            car car1 = new car(2017,"Hyundai Tucson", 49999.99);
            Console.WriteLine(car1);

            car car2 = new car(2022, "BMW", 780000);
            Console.WriteLine(car2);

            car car3 = new car(2022, "benz", 800000.99, true);
            Console.WriteLine(car3);

            car car4 = new car(2018, "kam", 84532.21, true);
            Console.WriteLine(car4);
        }
    }
}
