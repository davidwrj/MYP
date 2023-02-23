using FluentValidation;

namespace Application.Investments.Commands.CreateInvestment
{
    public class CreateInvestmentCommandValidator : AbstractValidator<CreateInvestmentCommand>
    {
        public CreateInvestmentCommandValidator()
        {
            RuleFor(x => x.Name)
                .MaximumLength(150)
                .NotEmpty();

            RuleFor(x => x.Principle)
                .GreaterThanOrEqualTo(500000)
                .NotEmpty();

            RuleFor(x => x.InterestRate)
                .GreaterThan(0)
                .LessThan(1)
                .NotEmpty();
        }
    }
}
