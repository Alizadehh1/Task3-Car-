using System;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many cars do you want to upload: ");
            int len=Convert.ToInt32(Console.ReadLine());
            Car[] Cars= new Car[len];
            
            for(int i=0; i<Cars.Length; i++)
            {
                Car cars= new Car();

                Console.Write($"Brand of Car {i+1}: ");
                cars.marka=Console.ReadLine();

                Console.Write($"Model of Car {i + 1}: ");
                cars.model = Console.ReadLine();

                Console.Write($"Price of Car {i + 1}: ");
                cars.price=Convert.ToDouble(Console.ReadLine());

                Console.Write($"Year of Car {i + 1}: ");
                cars.year = Convert.ToInt32(Console.ReadLine());

                Cars[i] = cars;

            }
            foreach(var car in Cars)
            {
                string name = car.GetFullName();
                Console.WriteLine("Your Car Properties : " + name);
            }


        }
    }
}
