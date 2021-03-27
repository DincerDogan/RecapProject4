using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entity.Concrete;
using Entity.DTOs;

namespace Business.Abstract
{
  public  interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> Get(int id);
 
       
        IResult Delete(Rental rental);
        IResult Rent(int carId, int customerId);
        IResult Update(Rental rental);

        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IDataResult<List<RentalDetailDto>> GetRentalDetailsByCarId(int carId);
        IDataResult<List<RentalDetailDto>> GetRentalDetailsByCustomerId(int customerId);
    }
}
