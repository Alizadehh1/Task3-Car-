using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Car
    {
        public string marka;
        public string model;
        public double price;
        public int year;
        public string GetFullName()
        {
            return $"Marka-{marka}, Model-{model}, Price-{price}, Year-{year}";

        }
    }

}
