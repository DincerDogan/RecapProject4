using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entity.Concrete;

namespace Business.Abstract
{
   public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetByUserId(int id);
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);

        List<OperationClaim> GetClaims(User user);
    //  void Add_Operation(User user);
        User GetByMail(string email);
    }

}
