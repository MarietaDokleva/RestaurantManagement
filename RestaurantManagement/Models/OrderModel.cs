using System;
using System.Collections.Generic;

namespace RestaurantManagement.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public DateTime OrderDateTime { get; set; }
        public List<MenuItemModel> Items { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
