using Microsoft.AspNetCore.Mvc;
using RestaurantManagement.Models;

namespace RestaurantManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        private readonly MenuItemService _menuItemService;

        public MenuItemController(MenuItemService menuItemService)
        {
            _menuItemService = menuItemService;
        }

        [HttpGet]
        public ActionResult<List<MenuItemModel>> GetAllMenuItems()
        {
            var menuItems = _menuItemService.GetAllMenuItems();
            return Ok(menuItems);
        }

        [HttpGet("{id}")]
        public ActionResult<MenuItemModel> GetMenuItemById(int id)
        {
            var menuItem = _menuItemService.GetMenuItemById(id);
            if (menuItem == null)
            {
                return NotFound();
            }
            return Ok(menuItem);
        }

        [HttpPost]
        public ActionResult<MenuItemModel> CreateMenuItem(MenuItemModel menuItem)
        {
            _menuItemService.CreateMenuItem(menuItem);
            return CreatedAtAction(nameof(GetMenuItemById), new { id = menuItem.Id }, menuItem);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMenuItem(int id, MenuItemModel menuItem)
        {
            if (id != menuItem.Id)
            {
                return BadRequest();
            }

            _menuItemService.UpdateMenuItem(menuItem);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMenuItem(int id)
        {
            _menuItemService.DeleteMenuItem(id);
            return NoContent();
        }
    }
}