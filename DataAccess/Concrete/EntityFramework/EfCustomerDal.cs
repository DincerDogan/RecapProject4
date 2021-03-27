using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFrameWork;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
  public  class EfCustomerDal:EfEntityRepositoryBase<Customer, MyDatabaseContext>,ICustomerDal
    {
    }
}
