using System.Collections.Generic;
using RestaurantManagement.Models;
using RestaurantManagement.Repositories;

public class OrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public List<OrderModel> GetAllOrders()
    {
        return _orderRepository.GetAll();
    }

    public OrderModel GetOrderById(int id)
    {
        return _orderRepository.GetById(id);
    }

    public void CreateOrder(OrderModel order)
    {
        _orderRepository.Add(order);
    }

    public void UpdateOrder(OrderModel order)
    {
        _orderRepository.Update(order);
    }

    public void DeleteOrder(int id)
    {
        _orderRepository.Remove(id);
    }
}
