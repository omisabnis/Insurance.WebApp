using Insurance.Data.Common;
using Insurance.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Data.Repositories
{
    public class OrdersRepository : IRepository<Orders>
    {
        public void Add(Orders entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Orders entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Orders> GetAll()
        {
            var orders = new List<Orders>() { new Orders {Id = 1, CustomerId = 1, ServiceCount = 2, AccountNumber = "Undefined", CustomerName = "Michael Smith"  },
                                              new Orders { Id = 2, CustomerId = 2, ServiceCount = 1, AccountNumber = "Undefined", CustomerName = "Tom Lee"} };
            return orders;
        }

        public Orders GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Orders entity)
        {
            throw new NotImplementedException();
        }
    }

    
}
