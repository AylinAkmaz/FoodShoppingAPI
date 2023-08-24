using FluentValidation;
using FoodShoppingAPI.Entity.DTO.StoreDetailDTO;

namespace FoodShoppingAPI.API.Validation.FluentValidation
{
    public class StoreDetailValidator: AbstractValidator<StoreDetailDTORequest>
    {
        public StoreDetailValidator()
        {
            RuleFor(q => q.Name).NotEmpty().WithMessage("Market Detay Adı Boş Olamaz");
        }
    }
}
