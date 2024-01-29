using FluentValidation;
using RestaurantManagement.Models;

public class MenuItemValidator : AbstractValidator<MenuItemModel>
{
    public MenuItemValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MaximumLength(100);
        RuleFor(x => x.Description).NotEmpty();
        RuleFor(x => x.Price).GreaterThan(0);
        RuleFor(x => x.Category).NotEmpty();
    }
}
