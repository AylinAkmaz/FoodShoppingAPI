using FluentValidation;
using FoodShoppingAPI.Entity.DTO.StoreProductDTO;

namespace FoodShoppingAPI.API.Validation.FluentValidation
{
    public class StoreProductValidator : AbstractValidator<StoreProductDTORequest>
    {
        public StoreProductValidator()
        {
            RuleFor(q => q.Name).NotEmpty().WithMessage("Market Ürün Adı Boş Olamaz");
            RuleFor(q => q.Description).NotEmpty().WithMessage("Market Ürün Açıklaması Boş Olamaz");
            RuleFor(q => q.FeaturedImage).NotEmpty().WithMessage("Market Ürün Resmi Boş Olamaz");
            RuleFor(q => q.UnitPrice).NotEmpty().WithMessage("Market Ürün Fiyatı Boş Olamaz");
            RuleFor(q => q.Quantity).NotEmpty().WithMessage("Market Ürün Miktarı Boş Olamaz");


        }



    }
}
