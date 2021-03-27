using System;
using System.Collections.Generic;
using System.Text;
using Entity.Concrete;

namespace DataAccess.Abstract
{
  public  interface ICustomerDal:IEntityRepository<Customer>
    {
    }
}
