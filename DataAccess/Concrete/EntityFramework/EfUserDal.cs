using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFrameWork;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfUserDal:EfEntityRepositoryBase<User,MyDatabaseContext>,IUserDal
    {
    }
}
