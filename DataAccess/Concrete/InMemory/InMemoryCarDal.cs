using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        //GetById, GetAll, Add, Update, Delete
        List<Car> _cars;

        public InMemoryCarDal()
        {
            //_cars = new List<Car>()
            //{
            //    new Car{Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 10000, ModelYear = 2019, Descriptions = "BMW 320d"},
            //    new Car{Id = 2, BrandId = 2, ColorId = 1, DailyPrice = 12000, ModelYear = 2018 , Descriptions = "Audi A4"},
            //    new Car{Id = 3, BrandId = 2, ColorId = 2, DailyPrice = 13000, ModelYear = 2019 , Descriptions = "Audi A3"},
            //    new Car{Id = 4, BrandId = 3, ColorId = 1, DailyPrice = 15000, ModelYear = 2017 , Descriptions = "Mercedes C200"},
            //    new Car{Id = 5, BrandId = 3, ColorId = 3, DailyPrice = 14000, ModelYear = 2015 , Descriptions = "Mercedes C200D"},
            //    new Car{Id = 6, BrandId = 3, ColorId = 4, DailyPrice = 17000, ModelYear = 2020 , Descriptions = "Mercedes E"}

            //};
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
            carToUpdate.Descriptions = car.Descriptions;
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

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}

