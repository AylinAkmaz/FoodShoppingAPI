using FluentValidation;
using FoodShoppingAPI.Entity.DTO.MenuDTO;
using FoodShoppingAPI.Entity.DTO.OrderDetailDTO;

namespace FoodShoppingAPI.API.Validation.FluentValidation
{
    public class OrderDetailValidator : AbstractValidator<OrderDetailDTORequest>
    {
        public OrderDetailValidator()
        {
            RuleFor(q => q.Name).NotEmpty().WithMessage("Menu Adı Boş Olamaz");
            RuleFor(q => q.Discount).NotEmpty().WithMessage("İndirim Miktarı Boş Olamaz");
            RuleFor(q => q.UnitPrice).NotEmpty().WithMessage("Sipariş Tutarı Boş Olamaz");
            RuleFor(q => q.Quantity).NotEmpty().WithMessage("Sipariş Miktarı Boş Olamaz");

        }
    }
}
