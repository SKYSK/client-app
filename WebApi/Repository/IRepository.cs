using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Repository
{
    interface IRepository<T>
    {
        T GetOne(int id);

        IEnumerable<T> GetAll();

        void Add(T item);

        void Update(T item);

        void Delete(T item);
    }
}
