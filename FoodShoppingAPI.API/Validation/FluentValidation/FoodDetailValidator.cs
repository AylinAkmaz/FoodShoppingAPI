using FluentValidation;
using FoodShoppingAPI.Entity.DTO.FoodDetailDTO;

namespace FoodShoppingAPI.API.Validation.FluentValidation
{
    public class FoodDetailValidator : AbstractValidator<FoodDetailDTORequest>
    {
        public FoodDetailValidator()
        {
            RuleFor(q => q.Name).NotEmpty().WithMessage("Yemek Mağza Adı Boş Olamaz");
            RuleFor(q => q.Adress).NotEmpty().WithMessage("Yemek Mağza Adresi Boş Olamaz");
            RuleFor(q => q.Openning).NotEmpty().WithMessage("Yemek Mağzası Açılış Saati Boş Olamaz");
            RuleFor(q => q.Closing).NotEmpty().WithMessage("Yemek Mağzası Kapanış Saati Boş Olamaz");
            RuleFor(q => q.DeliveryTıme).NotEmpty().WithMessage("Yemek Mağzası Teslimat Süresi Boş Olamaz");
            RuleFor(q => q.About).NotEmpty().WithMessage("Yemek Mağza Açıklama Alanı Boş Olamaz");



        }
    }
    
}
