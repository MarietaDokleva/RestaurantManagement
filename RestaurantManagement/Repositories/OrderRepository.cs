using System.Collections.Generic;
using System.Linq;
using RestaurantManagement.Models;

namespace RestaurantManagement.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private List<OrderModel> _orders = new List<OrderModel>();

        public List<OrderModel> GetAll()
        {
            return _orders;
        }

        public OrderModel GetById(int id)
        {
            return _orders.FirstOrDefault(x => x.Id == id);
        }

        public void Add(OrderModel order)
        {
            order.Id = _orders.Count + 1;
            _orders.Add(order);
        }

        public void Update(OrderModel order)
        {
            var existingOrder = GetById(order.Id);
            if (existingOrder != null)
            {
                existingOrder.Items = order.Items;
                existingOrder.TotalPrice = order.TotalPrice;
            }
        }

        public void Remove(int id)
        {
            var orderToRemove = GetById(id);
            if (orderToRemove != null)
            {
                _orders.Remove(orderToRemove);
            }
        }
    }
}
