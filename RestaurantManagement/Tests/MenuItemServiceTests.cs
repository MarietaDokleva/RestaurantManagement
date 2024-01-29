using Moq;
using RestaurantManagement.Models;
using RestaurantManagement.Repositories;
using Xunit;

public class MenuItemServiceTests
{
    [Fact]
    public void GetAllMenuItems_ReturnsAllMenuItems()
    {
        // Arrange
        var mockRepository = new Mock<IMenuItemRepository>();
        var service = new MenuItemService(mockRepository.Object);

        // Act
        var result = service.GetAllMenuItems();

        // Assert
        Assert.NotNull(result);
        Assert.IsType<List<MenuItemModel>>(result);
        Assert.Empty(result); // Проверка за празен списък на елементи
    }
}
