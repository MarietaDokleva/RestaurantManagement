using Moq;
using RestaurantManagement.Models;
using RestaurantManagement.Repositories;
using Xunit;

public class OrderServiceTests
{
    [Fact]
    public void GetAllOrders_ReturnsAllOrders()
    {
        // Arrange
        var mockRepository = new Mock<IOrderRepository>();
        var service = new OrderService(mockRepository.Object);

        // Act
        var result = service.GetAllOrders();

        // Assert
        Assert.NotNull(result);
        Assert.IsType<List<OrderModel>>(result);
        Assert.Empty(result); // Проверка за празен списък на поръчки
    }
}
