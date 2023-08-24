using FluentValidation;
using FoodShoppingAPI.Entity.DTO.RoleDTO;

namespace FoodShoppingAPI.API.Validation.FluentValidation
{
    public class RoleValidator : AbstractValidator<RoleDTORequest>
    {
        public RoleValidator()
        {
            RuleFor(q => q.Name).NotEmpty().WithMessage("Rol Adı Boş Olamaz");
        }
    }
}
