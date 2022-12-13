using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using UpSchool_CQRS_Projects.CQRS.Results.ProductResults;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.ProductHandlers
{
   
    public class GetProductAccounterQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductAccounterQueryHandler(ProductContext productContext)
        {
            this._productContext = productContext;
        }
        //Burada x -> Products classına ait propertyleri tutuyor.
        // AsNoTracking () -> Sorgu performansını arttırmak için -> sadece SaveChanges in bulunduğu yerlerde takip yapılır. Burada sadece get yapılıyor. -> Listeleme o yüzden savechanges lik bir olay yok. 
        public List<GetProductAccounterQueryResult> Handle()
        {
            var values = _productContext.Products.Select(x => new GetProductAccounterQueryResult
            {
                ProductID = x.ProductID,
                Brand = x.Brand,
                Name = x.Name,
                PurchasePrice = x.PurchasePrice,
                SalePrice = x.SalePrice,
                Tax= x.Tax,
                Stock = x.Stock,

            }).AsNoTracking().ToList();
            return values;
        }
    }
}
