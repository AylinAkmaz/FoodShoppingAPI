using FluentValidation;
using FoodShoppingAPI.Entity.DTO.FoodDetailDTO;
using FoodShoppingAPI.Entity.DTO.FoodProductDTO;

namespace FoodShoppingAPI.API.Validation.FluentValidation
{
    public class FoodProductValidator : AbstractValidator<FoodProductDTORequest>
    {
        public FoodProductValidator()
        {
            RuleFor(q => q.Name).NotEmpty().WithMessage("Yemek Ürünü Adı Boş Olamaz");
            RuleFor(q => q.Description).NotEmpty().WithMessage("Yemek Ürünü Açıklaması Boş Olamaz");
            RuleFor(q => q.UnitPrice).NotEmpty().WithMessage("Yemek Ürünü Fiyatı Boş Olamaz");
            RuleFor(q => q.Quantity).NotEmpty().WithMessage("Yemek Ürünü Miktarı Boş Olamaz");
           



        }

    }
}
