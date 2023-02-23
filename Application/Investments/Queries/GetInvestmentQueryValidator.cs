using FluentValidation;

namespace Application.Investments.Queries
{
    public class GetInvestmentQueryValidator : AbstractValidator<GetInvestmentQuery>
    {
        public GetInvestmentQueryValidator()
        {
            RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Id is required.");
        }
    }
}
