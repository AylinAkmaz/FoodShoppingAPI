using FluentValidation;
using FoodShoppingAPI.Entity.DTO.StoreProductDTO;
using FoodShoppingAPI.Entity.DTO.StoresDTO;

namespace FoodShoppingAPI.API.Validation.FluentValidation
{
    public class StoresValidator : AbstractValidator<StoresDTORequest>
    {
        public StoresValidator()
        {
            RuleFor(q => q.Name).NotEmpty().WithMessage("Market Adı Boş Olamaz");


        }



    }
}
