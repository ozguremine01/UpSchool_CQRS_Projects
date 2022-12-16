﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using UpSchool_CQRS_Projects.CQRS.Commands.UniversityCommands;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.UniversirtyHandlers
{
    public class UpdateUniversityCommandHandler : IRequestHandler<UpdateUniversityCommand>
    {
        private readonly ProductContext _context;

        public UpdateUniversityCommandHandler(ProductContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateUniversityCommand request, CancellationToken cancellationToken)
        {
            //throw new System.NotImplementedException();
            var values = _context.Universities.Find(request.UniversityID);
            values.Name = request.Name;
            values.City= request.City;
            values.Population = request.Population;
            await _context.SaveChangesAsync();
            return Unit.Value;
                
        }
    }
}
