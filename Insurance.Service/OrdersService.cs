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
    public class OrdersService : IOrdersService
    {
        private readonly IRepository<Orders> _ordersRepository;
        public OrdersService(IRepository<Orders> ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        public void AddOrder(Orders entity)
        {
            _ordersRepository.Add(entity);
        }

        public void DeleteOrder(Orders entity)
        {
            _ordersRepository.Delete(entity);
        }

        public IEnumerable<Orders> GetAllOrders()
        {
            return _ordersRepository.GetAll();
        }

        public Orders GetOrderById(int id)
        {
            return _ordersRepository.GetById(id);
        }

        public void UpdateOrder(Orders entity)
        {
            _ordersRepository.Update(entity);
        }
    }

    public interface IOrdersService
    {
        void AddOrder(Orders entity);
        void UpdateOrder(Orders entity);
        void DeleteOrder(Orders entity);
        Orders GetOrderById(int id);
        IEnumerable<Orders> GetAllOrders();
    }
}
