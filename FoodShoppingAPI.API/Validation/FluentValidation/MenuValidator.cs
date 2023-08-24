using FluentValidation;
using FoodShoppingAPI.Entity.DTO.MenuDTO;

namespace FoodShoppingAPI.API.Validation.FluentValidation
{
    public class MenuValidator : AbstractValidator<MenuDTORequest>
    {
        public MenuValidator()
        {
            RuleFor(q => q.Name).NotEmpty().WithMessage("Menu Adı Boş Olamaz");
            RuleFor(q => q.Description).NotEmpty().WithMessage("Menu Açıklaması Boş Olamaz");
            RuleFor(q => q.UnitPrice).NotEmpty().WithMessage("Menu Fiyatı Boş Olamaz");
            RuleFor(q => q.Quantity).NotEmpty().WithMessage("Menu Miktarı Boş Olamaz");
         

        }
    }
}
