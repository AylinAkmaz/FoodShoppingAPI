using FluentValidation;
using FoodShoppingAPI.Entity.DTO.CatetgoryDTO;
using FoodShoppingAPI.Entity.DTO.FoodCategoryDTO;

namespace FoodShoppingAPI.API.Validation.FluentValidation
{
    public class CategoryValidator : AbstractValidator<CategoryDTORequest>
    {
        public CategoryValidator()
        {
            RuleFor(q => q.Name).NotEmpty().WithMessage("Kategori Adı Boş Olamaz");


        }
    }
}
