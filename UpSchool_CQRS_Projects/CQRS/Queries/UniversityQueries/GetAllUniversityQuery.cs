using MediatR;
using System.Collections.Generic;
using UpSchool_CQRS_Projects.CQRS.Results.StudentResults;

namespace UpSchool_CQRS_Projects.CQRS.Queries.UniversityQueries
{
    public class GetAllUniversityQuery : IRequest<List<GetAllStudentQueryResult>>
    {

    }
}
