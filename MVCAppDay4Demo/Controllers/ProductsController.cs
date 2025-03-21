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
        // Index --> List  
        public async Task<IActionResult> Index()
        {
            var products = await _appDbContext.Products.ToListAsync();
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

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            //Validation Serve Side 
            if (ModelState.IsValid)
            {
                //Save 
                _appDbContext.Products.Add(product);
                await _appDbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }




    }
}
