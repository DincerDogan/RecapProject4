using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFrameWork;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCarImageDal : EfEntityRepositoryBase<CarImage, MyDatabaseContext>,ICarImageDal
    {

    }
}
