using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Entity.Abstract;

namespace DataAccess.Abstract
{
    //Core katmanı diğer katmanları referans almaz yani northwinde ya da başka bir veritabanına bağlı olamaz
    //generic constraint
    //class : referans tip
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //new() : new'lernebilir demek
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //generic constraint
        //class : referans tip olabilir demek
        //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
        //new() : new'lenebilir olmalı
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        T GetById(Expression<Func<T, bool>> filter);//GetById    Get olabilir!!!
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
