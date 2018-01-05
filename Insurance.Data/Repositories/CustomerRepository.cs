using Insurance.Data.Common;
using Insurance.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Data.Repositories
{
    public class CustomerRepository : IRepository<Customer>
    {

        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            var customers = new List<Customer>() { new Customer { Id = 1, FirstName = "Alan", LastName = "Wright", AccountNumber = "undefined" },
            new Customer { Id = 2, FirstName = "Michael", LastName = "Smith", AccountNumber = "undefined"} };
            return customers;
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }

   
}
