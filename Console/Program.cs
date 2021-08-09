using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EfCarDal());

            //var result = carManager.Add(new Car
            //{
            //    BrandId = 2,
            //    ColorId = 3,
            //    DailyPrice = 1,
            //    Descriptions = " abc",
            //    ModelYear = "2020"
            //});

            //Console.WriteLine(result.Message);

            RentalManager rentalManager = new RentalManager(new EfRentDal());

            var result = rentalManager.Add(new Rental
            {
                CarId = 3,
                CustomerId = 5,
                RentDate = DateTime.Now,
               
            }) ; 
            Console.WriteLine(result.Message);
        }
    }
}
