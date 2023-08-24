using FluentValidation;
using FoodShoppingAPI.Entity.DTO.FoodCategoryDTO;

namespace FoodShoppingAPI.API.Validation.FluentValidation
{
    public class FoodCategoryValidator : AbstractValidator<FoodCategoryDTORequest>
    {
        public FoodCategoryValidator()
        {
            RuleFor(q => q.Name).NotEmpty().WithMessage("Yemek Kategori Adı Boş Olamaz");


        }
    }
}
