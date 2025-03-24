namespace MVCAppDay4Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AppDbContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=website}/{action=Index}/{id?}");
            #region Custom MiddleWare

            //app.Use(async (HttpContext, next) =>
            //{
            //    //Execute From Request 
            //    await HttpContext.Response.WriteAsync(" 1 Write the Middleware USE 1 \n");
            //    //call Next Middleware
            //    await next.Invoke();
            //    //When Go Back Response 
            //    await HttpContext.Response.WriteAsync(" 5 Write the Middleware USE  1 \n");
            //});

            //app.Use(async (HttpContext, next) =>
            //{
            //    //Execute From Request 
            //    await HttpContext.Response.WriteAsync(" 2 Write the Middleware USE 2 \n");
            //    //call Next Middleware
            //    await next.Invoke();
            //    //When Go Back Response 
            //    await HttpContext.Response.WriteAsync(" 4 Write the Middleware USE  2 \n");
            //});

            //app.Run(async (HttpContext) =>
            //{
            //    //Execute From Request 
            //    await HttpContext.Response.WriteAsync(" 3 Write the Middleware USE 3 \n");

            //});
            #endregion
            app.Run();
        }
    }
}
