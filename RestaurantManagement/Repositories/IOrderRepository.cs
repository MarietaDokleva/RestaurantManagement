using System.Collections.Generic;
using RestaurantManagement.Models;

namespace RestaurantManagement.Repositories
{
    public interface IOrderRepository
    {
        List<OrderModel> GetAll();
        OrderModel GetById(int id);
        void Add(OrderModel order);
        void Update(OrderModel order);
        void Remove(int id);
    }
}
