using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entity.DTOs;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        // Generic sinifla gerek kalmaz
        //List<Car> GetAll();
        //List<Car> GetById(int id);
        //void Update(Car car);
        //void Add(Car car);
        //void Delete(Car car);
        List<CarDetailDto> GetCarDetails();

        List<CarDetailDto> GetCarDetailsByColorId(int colorId);
        List<CarDetailDto> GetCarDetailsByBrandId(int brandId);

    }
}
