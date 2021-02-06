using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{ 
    //generic constaint
    //class: referans tip
    //IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    public interface IEntityRepository<T> where T:class
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
