using System;
using System.Collections.Generic;
using System.Text;
using Entity.Concrete;
using Entity.DTOs;

namespace DataAccess.Abstract
{
   public interface IRentalDal:IEntityRepository<Rental>
    {
        List<RentalDetailDto> GetRentalDetails();
        List<RentalDetailDto> GetRentalDetailsByCarId(int carId);
        List<RentalDetailDto> GetRentalDetailsByCustomerId(int customerId);
    }
}
