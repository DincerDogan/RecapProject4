using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFrameWork;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,MyDatabaseContext>, ICarDal
    {
        //using içine yazılan nesneler using bitince garbic collector tarafından temizlenir(bellekten atılır)
        //IDisposable pattern implementation of c#
        //public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        //{
        //    using (MyDatabaseContext context = new MyDatabaseContext())
        //    {
        //        return filter == null                            //Filtre null mı ?
        //            ? context.Set<Car>().ToList()                //Evetse bura çalışır
        //            : context.Set<Car>().Where(f ilter).ToList(); //Değilse bura çalışır
        //    }
        //}

        //public Car GetById(Expression<Func<Car, bool>> filter)
        //{
        //    using (MyDatabaseContext context = new MyDatabaseContext())
        //    {
        //        return context.Set<Car>().SingleOrDefault(filter); //filtre kontrolune gerek yok ilk tek elemani getir
        //    }
        //}

        //public void Add(Car entity)
        //{
        //    using (MyDatabaseContext context = new MyDatabaseContext())
        //    {
        //        var addedEntity = context.Entry(entity);//Referansı yakala
        //        addedEntity.State = EntityState.Added;//Bu eklenecek bir nesne
        //        context.SaveChanges();//Değişikliği kaydet
        //    }
        //}

        //public void Delete(Car entity)
        //{
        //    using (MyDatabaseContext context = new MyDatabaseContext())
        //    {
        //        var deletedEntity = context.Entry(entity);//Referansı yakala
        //        deletedEntity.State = EntityState.Deleted;//Bu silinecek bir nesne
        //        context.SaveChanges();//Değişikliği kaydet
        //    }
        //}

        //public void Update(Car entity)
        //{
        //    using (MyDatabaseContext context = new MyDatabaseContext())
        //    {
        //        var updatedEntity = context.Entry(entity);//Referansı yakala
        //        updatedEntity.State = EntityState.Modified;//Bu güncellenecek bir nesne
        //        context.SaveChanges();//Değişikliği kaydet
        //    }
        //}

        public List<CarDetailDto> GetCarDetails()
        {
            using (MyDatabaseContext context=new MyDatabaseContext())
            {
                var result = from car in context.Cars
                    join b in context.Brands
                        on car.BrandId equals b.BrandId
                    join co in context.Colors
                        on car.ColorId equals co.ColorId
                    select new CarDetailDto
                    {
                        BrandName = b.BrandName,
                        ColorName= co.ColorName,
                        DailyPrice = car.DailyPrice,
                        Description = car.Description,
                        Id = car.Id,
                        ModelYear = car.ModelYear,
                       

                    };
                return result.ToList();

            }
        }

        public List<CarDetailDto> GetCarDetailsByColorId(int colorId)
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                var result = from c in context.Cars
                    join b in context.Brands
                        on c.BrandId equals b.BrandId
                    join cl in context.Colors
                        on c.ColorId equals cl.ColorId
                    where c.ColorId == colorId
                    select new CarDetailDto
                    {
                        Id = c.Id,
                        BrandName = b.BrandName,
                        ModelYear = c.ModelYear,
                        ColorName = cl.ColorName,
                        DailyPrice = c.DailyPrice,
                        Description = c.Description
                    };

                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByBrandId(int brandId)
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                var result = from c in context.Cars
                    join b in context.Brands
                        on c.BrandId equals b.BrandId
                    join cl in context.Colors
                        on c.ColorId equals cl.ColorId
                    where c.BrandId == brandId
                    select new CarDetailDto
                    {
                        Id = c.Id,
                        BrandName = b.BrandName,
                        ModelYear = c.ModelYear,
                        ColorName = cl.ColorName,
                        DailyPrice = c.DailyPrice,
                        Description = c.Description
                    };

                return result.ToList();
            }
        }
    }
}
