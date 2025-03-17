using Microsoft.AspNetCore.Mvc;

namespace MVCAppDay4Demo.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _appDbContext;
        //Ctor
        public ProductsController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        //List 
        public IActionResult Index()
        {
            var products = _appDbContext.Products.ToList();
            return View(products);
        }
        //public 
        //View To Open View 
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //Create Post (Insert Data)
        [HttpPost]
        public IActionResult Create(Product products)
        {
            //Validation
            //Save 

            return View();
        }




    }
}
