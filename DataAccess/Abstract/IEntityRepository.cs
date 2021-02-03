using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    // whereden sonra T bir class ve entity implemente eden bir nesne ise diye filtrelendi
    //T: class,IEntity,new()  Tbir class olacak , t bir entity olacak ,
    public interface IEntityRepository<T> where T: class,IEntity,new() 
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); // Toplu veya isteğe göre filtre işlemi.
        T Get(Expression<Func<T,bool>> filter); // tek bir nesneyi filtrelemek için kullanılır.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
 
    }
}
