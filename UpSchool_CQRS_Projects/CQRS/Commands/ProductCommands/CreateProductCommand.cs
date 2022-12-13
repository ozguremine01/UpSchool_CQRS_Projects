using System;

namespace UpSchool_CQRS_Projects.CQRS.Commands.ProductCommands
{
    //Ekleme işleminde gerekli olan propertyler buraya eklendi.
    // Nullable parametresi false olanlar özellikle alındı. Eklendi.
    public class CreateProductCommand
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Stock { get; set; }
        public int Tax { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public decimal Cost { get; set; }
        public decimal Size { get; set; }
        public DateTime ProduceofDate { get; set; }
        public DateTime EndofDate { get; set; }
        public bool Status { get; set; }
    }
}
