using Insurance.Data.Common;
using Insurance.Data.Repositories;
using Insurance.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<Customer> _customerRepository;
        public CustomerService(IRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public void AddCustomer(Customer entity)
        {
            _customerRepository.Add(entity);
        }

        public void DeleteCustomer(Customer entity)
        {
            _customerRepository.Delete(entity);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customerRepository.GetAll();
        }

        public Customer GetCustomerById(int id)
        {
            return _customerRepository.GetById(id);
        }

        public void UpdateCustomer(Customer entity)
        {
            _customerRepository.Update(entity);
        }
    }

    public interface ICustomerService
    {
        void AddCustomer(Customer entity);
        void UpdateCustomer(Customer entity);
        void DeleteCustomer(Customer entity);
        Customer GetCustomerById(int id);
        IEnumerable<Customer> GetAllCustomers();
    }
}
