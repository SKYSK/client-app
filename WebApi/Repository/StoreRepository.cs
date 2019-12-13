using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Repository
{
    public class StoreRepository : IRepository<Store>
    {
        public void Add(Store item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Store item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Store> GetAll()
        {
            var stores = new List<Store>();
            stores.Add(new Store() { Id = 1, Name = "Store1", Category = "Ethnic", Rate = new decimal(2.5) });
            stores.Add(new Store() { Id = 2, Name = "Store2", Category = "India", Rate = new decimal(4) });
            return stores;

        }

        public Store GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Store item)
        {
            throw new NotImplementedException();
        }
    }
}
