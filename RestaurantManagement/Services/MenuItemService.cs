using System.Collections.Generic;
using RestaurantManagement.Models;
using RestaurantManagement.Repositories;

public class MenuItemService
{
    private readonly IMenuItemRepository _menuItemRepository;

    public MenuItemService(IMenuItemRepository menuItemRepository)
    {
        _menuItemRepository = menuItemRepository;
    }

    public List<MenuItemModel> GetAllMenuItems()
    {
        return _menuItemRepository.GetAll();
    }

    public MenuItemModel GetMenuItemById(int id)
    {
        return _menuItemRepository.GetById(id);
    }

    public void CreateMenuItem(MenuItemModel menuItem)
    {
        _menuItemRepository.Add(menuItem);
    }

    public void UpdateMenuItem(MenuItemModel menuItem)
    {
        _menuItemRepository.Update(menuItem);
    }

    public void DeleteMenuItem(int id)
    {
        _menuItemRepository.Remove(id);
    }
}
