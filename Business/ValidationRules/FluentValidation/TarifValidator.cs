using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class TarifValidator : AbstractValidator<Tarif>
    {
        public TarifValidator()
        {
            RuleFor(u => u.CategoryId).NotEmpty();
            RuleFor(u => u.Title).NotEmpty();
            RuleFor(u => u.Slug).NotEmpty();
            RuleFor(u => u.ImagePath).NotEmpty();
           
        }
    }
}
