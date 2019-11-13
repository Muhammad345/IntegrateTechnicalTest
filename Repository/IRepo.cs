using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrateTechnicalTest.Repository
{
    public interface IRepo<T>
    {
        IQueryable<T> GetAll();
        T GetSpecific(int Id);

        bool Create(T entity);

        bool Update(int key, T entity);

        bool Delete(int key);
    }
}
