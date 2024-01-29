using FluentValidation;
using RestaurantManagement.Models;

public class OrderValidator : AbstractValidator<OrderModel>
{
    public OrderValidator()
    {
        RuleFor(x => x.Items).NotEmpty();
        RuleFor(x => x.TotalPrice).GreaterThan(0);
    }
}
