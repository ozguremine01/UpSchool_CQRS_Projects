namespace UpSchool_CQRS_Projects.CQRS.Results.StudentResults
{
    //Silme ve güncelleme işlemlerinde ilk önce listeleme yapılmalı. O yüzden ilk önce Results'ta tanımlama yapıldı.
    public class GetAllStudentQueryResult
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
    }
}
