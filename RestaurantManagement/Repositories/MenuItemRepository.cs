using System.Collections.Generic;
using System.Linq;
using RestaurantManagement.Models;

namespace RestaurantManagement.Repositories
{
    public class MenuItemRepository : IMenuItemRepository
    {
        private List<MenuItemModel> _menuItems = new List<MenuItemModel>();

        public List<MenuItemModel> GetAll()
        {
            return _menuItems;
        }

        public MenuItemModel GetById(int id)
        {
            return _menuItems.FirstOrDefault(x => x.Id == id);
        }

        public void Add(MenuItemModel menuItem)
        {
            menuItem.Id = _menuItems.Count + 1;
            _menuItems.Add(menuItem);
        }

        public void Update(MenuItemModel menuItem)
        {
            var existingMenuItem = GetById(menuItem.Id);
            if (existingMenuItem != null)
            {
                existingMenuItem.Name = menuItem.Name;
                existingMenuItem.Description = menuItem.Description;
                existingMenuItem.Price = menuItem.Price;
                existingMenuItem.Category = menuItem.Category;
            }
        }

        public void Remove(int id)
        {
            var menuItemToRemove = GetById(id);
            if (menuItemToRemove != null)
            {
                _menuItems.Remove(menuItemToRemove);
            }
        }
    }
}
