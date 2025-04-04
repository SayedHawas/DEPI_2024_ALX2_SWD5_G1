using Microsoft.AspNetCore.Mvc;

namespace MVCAppDay4Demo.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            var productList = await _context.Products.ToListAsync();
            List<Product> products = new List<Product>();

            foreach (var item in productList)
            {
                if (System.IO.File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/products", item.Image))) //+ ".jpg"
                {
                    products.Add(item);
                }
                else
                {
                    item.Image = "";
                    products.Add(item);
                }
            }
            ViewData["x"] = "Welcome in MVC ";
            return View(products);
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            if (System.IO.File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/products", product.Image))) //+ ".jpg"
            {
                return View(product);
            }
            else
            {
                product.Image = "default";
                return View(product);
            }
            //return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([ModelBinder(typeof(ProductBinder))] Product product, IFormFile image)
        {
            //IO    sayed.jpg
            string _Extenstion = Path.GetExtension(image.FileName); //jpg
            string _FileNameWithoutExtension = Path.GetFileNameWithoutExtension(image.FileName);//sayed
            string _fileName = _FileNameWithoutExtension + DateTime.Now.ToString("yyMMddhhssfff") + _Extenstion;


            #region Deal with File Or stream
            if (image != null && image.Length > 0)
            {
                //var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/products", image.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/products", _fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await image.CopyToAsync(stream);
                }
                //product.Image = image.FileName;
                product.Image = _fileName;
            }
            #endregion
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Price,Image")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }

        public async Task<IActionResult> Card(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);

            if (product == null)
            {
                return NotFound();
            }
            if (System.IO.File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/products", product.Image)))
            {
                return View(product);
            }
            else
            {
                product.Image = "default.jpg";
                return View(product);
            }
        }

        public async Task<IActionResult> Gallery()
        {
            return View(await _context.Products.ToListAsync());
        }

    }
}
