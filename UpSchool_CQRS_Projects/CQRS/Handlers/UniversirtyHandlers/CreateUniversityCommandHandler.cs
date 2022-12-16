﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using UpSchool_CQRS_Projects.CQRS.Commands.UniversityCommands;
using UpSchool_CQRS_Projects.DAL.Context;
using UpSchool_CQRS_Projects.DAL.Entities;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.UniversirtyHandlers
{
    public class CreateUniversityCommandHandler : IRequestHandler<CreateUniversityCommand>
    {
        private readonly ProductContext _context;

        public async Task<Unit> Handle(CreateUniversityCommand request, CancellationToken cancellationToken)
        {
            _context.Universities.Add(new University
            {
                City = request.City,
                Name = request.Name,
                Population = request.Population,
                FacultyCount = request.FacultyCount
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }

    }
}
