using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entity.DTOs;


namespace Business.Abstract
{
    public interface ICarService
    {
       IDataResult<List<Car>> GetAllCar();
        IDataResult<Car> GetById(int carId);
       IDataResult<List<Car>> GetCarsByBrandId(int brandId);
       IDataResult<List<Car>> GetCarsByColorId(int colorId);//colorId
        
        IDataResult<List<Car>> GetCarsByDailyPrice(decimal min, decimal max);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult UpdateCar(Car car);
        IResult DeleteCar(Car car);
        IResult AddCar(Car car);

        IDataResult<List<CarDetailDto>> GetCarDetailsByColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetailsByBrandId(int brandId);
        IDataResult<List<Car>> GetAllCarsIsNotNull();



    }
}
