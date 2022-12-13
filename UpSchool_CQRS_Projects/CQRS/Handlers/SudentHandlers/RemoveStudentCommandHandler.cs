using UpSchool_CQRS_Projects.CQRS.Commands.StudentCommands;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.SudentHandlers
{
    public class RemoveStudentCommandHandler
    {
        private readonly ProductContext _context;

        public RemoveStudentCommandHandler(ProductContext context)
        {
            _context = context;
        }
        //id'le de olurdu.
        /// <summary>
        /// 12.12.2022 tarihli derse bak. Orada anlatıyor.
        /// </summary>
        /// <param name="command"></param>
        public void Handle(RemoveStudentCommand command)
        {
            var values = _context.Students.Find(command.id);
            _context.Students.Remove(values);
            _context.SaveChanges();
        }
    }
}
