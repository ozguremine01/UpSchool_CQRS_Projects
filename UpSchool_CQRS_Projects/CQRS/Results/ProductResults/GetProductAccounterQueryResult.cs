namespace UpSchool_CQRS_Projects.CQRS.Results.ProductResults
{
    //Muhasebeciye göre listeleme yaparken ihtiyacım olan entityleri alıyorum.
    public class GetProductAccounterQueryResult
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Stock { get; set; }
        public int Tax { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
    }
}
