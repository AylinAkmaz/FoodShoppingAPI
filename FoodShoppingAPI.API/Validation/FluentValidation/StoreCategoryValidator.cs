using FluentValidation;
using FoodShoppingAPI.Entity.DTO.StoreCategoryDTO;

namespace FoodShoppingAPI.API.Validation.FluentValidation
{
    public class StoreCategoryValidator : AbstractValidator<StoreCategoryDTORequest>
    {
        public StoreCategoryValidator()
        {
            RuleFor(q => q.Name).NotEmpty().WithMessage("Market Kategori Adı Boş Olamaz");
        }
    }
}
