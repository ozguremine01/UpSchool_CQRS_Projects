using UpSchool_CQRS_Projects.CQRS.Commands.StudentCommands;
using UpSchool_CQRS_Projects.DAL.Context;
using UpSchool_CQRS_Projects.DAL.Entities;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.SudentHandlers
{
    public class CreateStudentCommandHandler
    {
        private readonly ProductContext _context;

        public CreateStudentCommandHandler(ProductContext context)
        {
            _context = context;
        }

        public void Handle(CreateStudentCommand command )
        {
            _context.Students.Add(new Student
            {
                Name = command.Name,
                Age = command.Age,
                City = command.City,
                Surname = command.Surname,
                Status = false

            });
            _context.SaveChanges();
        }
    }
}
