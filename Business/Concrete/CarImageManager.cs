using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Bussiness;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
 public class CarImageManager: ICarImageService
    {
        ICarImageDal _carImageDal;
        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(CarImage carImage)
        {
            var result = BussinessRules.Run(CheckCarImageLimitExceded(carImage.CarId));

            if (result != null)
            {
                return result;
            }

            TakeImagePath(carImage);

            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.Added);
        }
        public IResult Delete(CarImage carImages)
        {
            _carImageDal.Delete(carImages);
            return new SuccessResult(Messages.Deleted);
        }
        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(), Messages.Listed);
        }
        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.GetById(c => c.Id == id));
        }
        public IDataResult<List<CarImage>> GetImagesByCarId(int id)
        {
            var result = BussinessRules.Run(CheckCarImageCount(id));

            if (result != null)
            {
                return new ErrorDataResult<List<CarImage>>(new List<CarImage> { new CarImage { ImagePath = "C:\\Users\\DDogan\\Desktop\\EnginHoca\\Proje\\Images\\CarImages\\logo.jpg" } });
            }

            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == id));

        }
        public IResult Update(CarImage carImage)
        {
            var result = BussinessRules.Run(CheckCarImageLimitExceded(carImage.CarId));

            if (result != null)
            {
                return result;
            }

            string newPath = TakeImagePath(carImage);
            carImage.ImagePath = newPath;
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.Updated);
        }

        private string TakeImagePath(CarImage carImage)
        {
            var newPath = Guid.NewGuid().ToString() + ".jpg";
            carImage.ImagePath = newPath;
            return newPath;
        }
        private IResult CheckCarImageLimitExceded(int id)
        {
            var result = _carImageDal.GetAll(c => c.CarId == id);
            if (result.Count >= 5)
            {
                return new ErrorResult(Messages.CarImageLimitExceeded);
            }
            return new SuccessResult();
        }
        private IResult CheckCarImageCount(int id)
        {
            var result = _carImageDal.GetAll(c => c.CarId == id).Count == 0;
            if (result)
            {
                return new ErrorResult(Messages.NoCarImages);
            }
            return new SuccessResult();
        }
    }
}
