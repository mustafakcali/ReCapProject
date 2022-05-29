using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColorId=3, ModelYear=2014, DailyPrice = 300, Description="BMW 3.16" },
                new Car{CarId=2, BrandId=5, ColorId=1, ModelYear=1969, DailyPrice = 7000, Description="Ford Mustang" },
                new Car{CarId=3, BrandId=2, ColorId=2, ModelYear=2015, DailyPrice = 500, Description="Audi a3" },
                new Car{CarId=4, BrandId=3, ColorId=4, ModelYear=2021, DailyPrice = 999, Description="Mercedes CLA 200 AMG" },
                new Car{CarId=5, BrandId=4, ColorId=5, ModelYear=2021, DailyPrice = 400, Description="Honda Civic" },
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(car);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.DailyPrice = car.DailyPrice;
            
        }
    }
}
