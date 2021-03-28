using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Entity.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> cars;

        public InMemoryCarDal()
        {
            cars = new List<Car> {

                new Car{ Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 100000, Description = "Volvo", ModelYear = 2016 },
                new Car{ Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 500000, Description = "Togo", ModelYear = 2018 },
                new Car{ Id = 3, BrandId = 3, ColorId = 2, DailyPrice = 200000, Description = "Mercedes", ModelYear = 2020 },
                new Car{ Id = 4, BrandId = 1, ColorId = 3, DailyPrice = 600000, Description = "Honda", ModelYear = 2019 },
                new Car{ Id = 5, BrandId = 4, ColorId = 1, DailyPrice = 80000, Description = "Honda", ModelYear = 2009 }

            };
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Car car)
        {
            cars.Add(car);
        }

        public void Delete(Car car)
        {
            var selectedCar = cars.SingleOrDefault(c => c.Id == car.Id);
           
                cars.Remove(selectedCar);
           
        }

        public List<Car> GetAll()
        {
            return cars;
            
        }

        public List<Car> GetById(int id)
        {
            return cars.Where(c => c.Id == id).ToList();
            
        }

        public void Update(Car car)
        {
            var selectedCar = cars.SingleOrDefault(c => c.Id == car.Id);
           
                selectedCar.BrandId = car.BrandId;
                selectedCar.ColorId = car.ColorId;
                selectedCar.DailyPrice = car.DailyPrice;
                selectedCar.Description = car.Description;
                selectedCar.ModelYear = car.ModelYear;
          
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailsByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }
    }
}
