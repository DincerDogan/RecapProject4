using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.EntityFrameWork;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfRentalDal:EfEntityRepositoryBase<Rental,MyDatabaseContext>,IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                var result = from r in context.Rentals
                    join c in context.Cars
                        on r.CarId equals c.Id
                    join b in context.Brands
                        on c.BrandId equals b.BrandId
                    join cu in context.Customers
                        on r.CustomerId equals cu.Id
                    select new RentalDetailDto
                    {
                        Id = r.Id,
                        CarId = r.CarId,
                        BrandName = b.BrandName,
                        CompanyName = cu.CompanyName,
                        Description = c.Description,
                        ModelYear = c.ModelYear

                    };

                return result.ToList();
            }
        }

        public List<RentalDetailDto> GetRentalDetailsByCarId(int carId)
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                var result = from r in context.Rentals
                    join c in context.Cars
                        on r.CarId equals c.Id
                    join b in context.Brands
                        on c.BrandId equals b.BrandId
                    join cu in context.Customers
                        on r.CustomerId equals cu.Id
                    where r.CarId == carId
                    select new RentalDetailDto
                    {
                        Id = r.Id,
                        CarId = r.CarId,
                        BrandName = b.BrandName,
                        CompanyName = cu.CompanyName,
                        Description = c.Description,
                        ModelYear = c.ModelYear

                    };

                return result.ToList();
            }
        }

        public List<RentalDetailDto> GetRentalDetailsByCustomerId(int customerId)
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                var result = from r in context.Rentals
                    join c in context.Cars
                        on r.CarId equals c.Id
                    join b in context.Brands
                        on c.BrandId equals b.BrandId
                    join cu in context.Customers
                        on r.CustomerId equals cu.Id
                    where r.CustomerId == customerId
                    select new RentalDetailDto
                    {
                        Id = r.Id,
                        CarId = r.CarId,
                        BrandName = b.BrandName,
                        CompanyName = cu.CompanyName,
                        Description = c.Description,
                        ModelYear = c.ModelYear

                    };

                return result.ToList();
            }
        }
    }
}
