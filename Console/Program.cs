using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " " + car.BrandId + " " + car.ColorId + " " + car.DailyPrice + " " + car.ModelYear + " " + car.Description);
            }
            

            carManager.Add(new Car { Id = 10, BrandId = 1, ColorId = 2, ModelYear = 2018, DailyPrice = 20000, Description = "BMW I20" });
            
            Console.WriteLine();
            Console.WriteLine("Araba eklendikten sonraki liste.");
            Console.WriteLine("--------------------------------");
            
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " " + car.BrandId + " " + car.ColorId + " " + car.DailyPrice + " " + car.ModelYear + " " + car.Description);
            }
            
            
            carManager.Delete(new Car {Id =4 });

            Console.WriteLine();
            Console.WriteLine("Araba silindikten sonraki liste.");
            Console.WriteLine("--------------------------------");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " " + car.BrandId + " " + car.ColorId + " " + car.DailyPrice + " " + car.ModelYear + " " + car.Description);
            }


            carManager.Update(new Car { Id = 2, BrandId = 3, ColorId = 2, ModelYear = 2021, DailyPrice = 25000, Description = "Mercedes A " });



            Console.WriteLine();
            Console.WriteLine("Araba guncellendikten  sonraki liste.");
            Console.WriteLine("--------------------------------");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " " + car.BrandId + " " + car.ColorId + " " + car.DailyPrice + " " + car.ModelYear + " " + car.Description);
            }

            Console.WriteLine();
            Console.WriteLine("GetById");
            Console.WriteLine(carManager.GetById(5).Description);
        }
    }
}
