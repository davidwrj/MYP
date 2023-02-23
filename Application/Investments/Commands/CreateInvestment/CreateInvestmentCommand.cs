using Application.Common;
using DataModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Investments.Commands.CreateInvestment
{
    public class CreateInvestmentCommand : IRequest<int>
    {
        public string Name { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public InterestTypes InterestType { get; set; }
        public decimal InterestRate { get; set; }
        public decimal Principle { get; set; }
    }

    public class CreateInvestmentCommandHandler : IRequestHandler<CreateInvestmentCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateInvestmentCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateInvestmentCommand request, CancellationToken cancellationToken)
        {
            // this should also include domain events, in case any other modules are interested in the new investment created.

            Investment entity = new Investment
            {
                Name = request.Name,
                StartDate = request.StartDate,
                InterestType = request.InterestType,
                InterestRate = request.InterestRate,
                Principle = request.Principle
            };

            _context.Investments.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
