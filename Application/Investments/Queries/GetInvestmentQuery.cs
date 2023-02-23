using Application.Common;
using DataModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Investments.Queries
{
    public class GetInvestmentQuery : IRequest<Investment>
    {
        public int Id { get; set; }
    }

    public class GetInvestmentQueryHandler : IRequestHandler<GetInvestmentQuery, Investment>
    {
        private readonly IApplicationDbContext _context;

        public GetInvestmentQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Investment> Handle(GetInvestmentQuery request, CancellationToken cancellationToken)
        {
            return await _context.Investments.FindAsync(request.Id, cancellationToken);
        }
    }
}
