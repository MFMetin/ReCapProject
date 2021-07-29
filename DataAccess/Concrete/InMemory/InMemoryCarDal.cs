using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        //GetById, GetAll, Add, Update, Delete
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 10000, ModelYear = 2019, Description = "BMW 320d"},
                new Car{Id = 2, BrandId = 2, ColorId = 1, DailyPrice = 12000, ModelYear = 2018 , Description = "Audi A4"},
                new Car{Id = 3, BrandId = 2, ColorId = 2, DailyPrice = 13000, ModelYear = 2019 , Description = "Audi A3"},
                new Car{Id = 4, BrandId = 3, ColorId = 1, DailyPrice = 15000, ModelYear = 2017 , Description = "Mercedes C200"},
                new Car{Id = 5, BrandId = 3, ColorId = 3, DailyPrice = 14000, ModelYear = 2015 , Description = "Mercedes C200D"},
                new Car{Id = 6, BrandId = 3, ColorId = 4, DailyPrice = 17000, ModelYear = 2020 , Description = "Mercedes E"}

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }


        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }


        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }


        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            Car carToGet = _cars.SingleOrDefault(c => c.Id == id);
            return carToGet;
        }

        
    }
}

