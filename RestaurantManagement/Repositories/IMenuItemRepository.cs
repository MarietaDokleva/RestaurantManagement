using System.Collections.Generic;
using RestaurantManagement.Models;

namespace RestaurantManagement.Repositories
{
    public interface IMenuItemRepository
    {
        List<MenuItemModel> GetAll();
        MenuItemModel GetById(int id);
        void Add(MenuItemModel menuItem);
        void Update(MenuItemModel menuItem);
        void Remove(int id);
    }
}
