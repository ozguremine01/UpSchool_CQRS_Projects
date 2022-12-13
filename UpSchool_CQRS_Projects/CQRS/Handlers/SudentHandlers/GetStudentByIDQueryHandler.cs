using UpSchool_CQRS_Projects.CQRS.Queries.StudentQueries;
using UpSchool_CQRS_Projects.CQRS.Results.StudentResults;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.SudentHandlers
{
    public class GetStudentByIDQueryHandler
    {
        private readonly ProductContext _context;

        public GetStudentByIDQueryHandler(ProductContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Tek bir değer döndüreceği için ToList yapmadık.!!!!
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public GetStudentByIDQueryResult Handle(GetStudentByIDQuery query)
        {
            var values = _context.Students.Find(query.Id);
            return new GetStudentByIDQueryResult
            {
                Age = values.Age,
                City = values.City,
                Name = values.Name,
                Surname = values.Surname,
                StudentID = values.StudentID
            };
        }
    }
}
