using FluentValidation;
using FoodShoppingAPI.Entity.DTO.ProductDTO;

namespace FoodShoppingAPI.API.Validation.FluentValidation
{
    public class ProductValidator : AbstractValidator<ProductDTORequest>
    {
        public ProductValidator()
        {
            RuleFor(q => q.Name).NotEmpty().WithMessage("Ürün Adı Boş Olamaz");
            RuleFor(q => q.Description).NotEmpty().WithMessage("Ürün Açıklaması Boş Olamaz");
            RuleFor(q => q.UnitPrice).NotEmpty().WithMessage("Ürün Fiyatı Boş Olamaz");
            RuleFor(q => q.Quantity).NotEmpty().WithMessage("Ürün Miktarı Boş Olamaz");
           // RuleFor(q => q.FeaturedImage).NotEmpty().WithMessage("Ürün Resmi Boş Olamaz");

        }
    }
}
