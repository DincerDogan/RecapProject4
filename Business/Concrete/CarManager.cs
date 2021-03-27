using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using FluentValidation;
using ValidationException = FluentValidation.ValidationException;


namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult AddCar(Car car)
        {
            //Bussiness Code
            //Bir categoride en fazla 10 urun olabilir
            //Validation
            ////if (car.DailyPrice > 0 && car.Description.Length > 2)
            ////{
            
               //var context =new ValidationContext<Car>(car);
               //CarValidator carValidator=new CarValidator();
               //var result = carValidator.Validate(context);
               //if (!result.IsValid)
               //{
               //  throw new ValidationException(result.Errors);
               //}
               

               //////ValidationTool.Validate(new CarValidator(), car);
               //business codes
               //Loglama
               //cacheremove
               //performance
               //transaction
               //yetkilendirme
               //
               _carDal.Add(car);
                return new SuccessResult(Messages.CarAdded);


            ////}
            ////else if (car.DailyPrice <= 0)
            ////    return new ErrorResult(Messages.CarDailyPriceInvalid);
            ////else if (car.Description.Length <= 2)
            ////    return new ErrorResult(Messages.CarDescriptionInvalid);
            ////else return new ErrorResult(Messages.InvalidRequest);

        }

        public IDataResult<List<CarDetailDto>> GetCarDetailsByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAllCarsIsNotNull()
        {
            throw new NotImplementedException();
        }

        public IResult DeleteCar(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAllCar()
        {
         // return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.Description.Length > 3),Messages.ProductAdded);//Adi 3 karakterten buyuk olan extra

         if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<Car> GetById(int carId)
        {
            return  new SuccessDataResult<Car>(_carDal.GetById(c => c.Id == carId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brandId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId));
        }

        public IDataResult<List<Car>> GetCarsByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max));
        }

        //public List<Car> GetCarById(int id)
        //{
        //    return _carDal.GetById( id);
        //}

        public IResult UpdateCar(Car car)
        {
            if (car.DailyPrice > 0 && car.Description.Length > 2)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.CarUpdated);
            }
            else if (car.DailyPrice <= 0)
                return new ErrorResult(Messages.CarDailyPriceInvalid);
            else if (car.Description.Length <= 2)
                return new ErrorResult(Messages.CarDescriptionInvalid);
            else return new ErrorResult(Messages.InvalidRequest);
        }


    }
}
