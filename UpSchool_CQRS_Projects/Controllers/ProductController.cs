using Microsoft.AspNetCore.Mvc;
using UpSchool_CQRS_Projects.CQRS.Commands.ProductCommands;
using UpSchool_CQRS_Projects.CQRS.Handlers.ProductHandlers;
using UpSchool_CQRS_Projects.CQRS.Queries.ProductQueries;

namespace UpSchool_CQRS_Projects.Controllers
{
    public class ProductController : Controller
    {
        private readonly GetProductAccounterQueryHandler _getProductAccounterQueryHandler;
        private readonly GetProductStorageQueryHandler _getProductStorageQueryHandler;
        private readonly GetProductHumanResourceByIDQueryHandler _getProductHumanResourceByIDQueryHandler;
        private readonly GetProductAccounterByIDQueryHandler _getProductAccounterByIDQueryHandler;
        private readonly CreateProductCommandQueryHandler _createProductCommandQueryHandler;
        public ProductController(GetProductAccounterQueryHandler getProductAccounterQueryHandler, GetProductStorageQueryHandler getProductStorageQueryHandler, GetProductHumanResourceByIDQueryHandler getProductHumanResourceByIDQueryHandler, GetProductAccounterByIDQueryHandler getProductAccounterByIDQueryHandler, CreateProductCommandQueryHandler createProductCommandQueryHandler)
        {
            _getProductHumanResourceByIDQueryHandler = getProductHumanResourceByIDQueryHandler;
            _getProductAccounterQueryHandler = getProductAccounterQueryHandler;
            _getProductStorageQueryHandler = getProductStorageQueryHandler;
            _getProductAccounterByIDQueryHandler = getProductAccounterByIDQueryHandler;
            _createProductCommandQueryHandler = createProductCommandQueryHandler;
        }

        public IActionResult Index()
        {
            var values = _getProductAccounterQueryHandler.Handle();
            return View(values);
        }

        public IActionResult AccounterIndexByID(int id)
        {
            var values = _getProductAccounterByIDQueryHandler.Handle(new GetProductAccounterByIDQuery(id));
            return View(values);
        }
        public IActionResult StoragerIndex()
        {
            var values= _getProductStorageQueryHandler.Handle();
            return View(values);
        }

        public IActionResult GetHumanResourceIndex(int id)
        {
            var values = _getProductHumanResourceByIDQueryHandler.Handle(new GetProductHumanResourceByIDQuery(id));
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(CreateProductCommand command)
        {
            _createProductCommandQueryHandler.Handle(command);
            return RedirectToAction("Index");
        }

    }
}
