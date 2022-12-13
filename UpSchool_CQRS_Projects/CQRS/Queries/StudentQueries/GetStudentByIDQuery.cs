namespace UpSchool_CQRS_Projects.CQRS.Queries.StudentQueries
{
    public class GetStudentByIDQuery
    {
        public GetStudentByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
