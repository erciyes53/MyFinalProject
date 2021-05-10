using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint
    //T için class verdik o referans tip demek
    //IEntity demek ya IEntity nesnesi yada onu implemente eden bir nesne olabilir demek
    //new demk newlenebilir demektit
  public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //filter=null ise filtre vermeyebilrim demek
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        //filter böyle bırakılırsa filtre alacak demektir kesin
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
