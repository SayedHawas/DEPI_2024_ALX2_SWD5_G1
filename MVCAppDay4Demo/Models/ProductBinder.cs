using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace MVCAppDay4Demo.Models
{
    public class ProductBinder : IModelBinder
    {
        public async Task BindModelAsync(ModelBindingContext bindingContext)
        {
            //Product ---> "Name,Price,Description"
            string name = bindingContext.HttpContext.Request.Form["Name"];
            string price = bindingContext.HttpContext.Request.Form["Price"];
            string description = bindingContext.HttpContext.Request.Form["Description"];

            double newPrice = Convert.ToDouble(price) + 10;


            Product product = new Product()
            {
                Name = name,
                Price = newPrice,
                Description = description
            };

            // Validate and Length Name
            if (name.Length < 5)
            {
                bindingContext.ModelState.AddModelError("Name", "Must Enter Name More than 5 Letters");
                bindingContext.Result = ModelBindingResult.Failed();
                //return;
            }

            // Set the result as successful and pass the employee object
            bindingContext.Result = ModelBindingResult.Success(product);
        }
    }
}
