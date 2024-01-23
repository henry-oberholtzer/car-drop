using CarDrop.Models;

namespace CarDrop
{
  class Program
  {
    static void Main(string[] args)
    {
      WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

      builder.Services.AddControllersWithViews();

      WebApplication app = builder.Build();

      app.UseHttpsRedirection();

      app.UseRouting();
      app.UseStaticFiles();

      app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
      );
      Vehicle mazda = new("1993 Mazda Miata", 115, 66, 48, 2222);
      Vehicle ford = new("2011 Ford F150", 213, 80, 75, 4900);
      app.Run();

        }
  }
}
