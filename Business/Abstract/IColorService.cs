using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        //List<Color> GetAll();
        //Color GetById(int colorId);
        //void Add(Color color);
        //void Delete(Color color);
        //void Update(Color color);

        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetByColorId(int id);
        IResult Add(Color color);
        IResult Delete(Color color);
        IResult Update(Color color);
    }
}
