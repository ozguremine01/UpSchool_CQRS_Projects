namespace UpSchool_CQRS_Projects.CQRS.Queries.ProductQueries
{
    public class GetProductAccounterByIDQuery
    {
        public GetProductAccounterByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
