using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Entity.Concrete;

namespace DataAccess.Abstract
{
   public interface IUserDal:IEntityRepository<User>
    {

    }
}
