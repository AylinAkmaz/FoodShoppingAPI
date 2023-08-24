using FluentValidation;
using FoodShoppingAPI.Entity.DTO.OrderDTO;

namespace FoodShoppingAPI.API.Validation.FluentValidation
{
    public class OrderValidator : AbstractValidator<OrderDTORequest>
    {
        public OrderValidator()
        {
            RuleFor(q => q.Name).NotEmpty().WithMessage("Sipariş Adı Boş Olamaz");
        }
    }
}
