using System.Xml.Linq;

namespace MvcDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews(); 
            var app = builder.Build();
            app.UseRouting();
            #region
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/home", async context => await context.Response.WriteAsJsonAsync("hello to home page"));
            //endpoints.MapGet("/products/{id}", async context =>
            //  {
            //      var idData = context.Request.RouteValues["id"];

            //      if (idData is not null)
            //      {
            //          int id = Convert.ToInt32(idData);
            //          await context.Response.WriteAsJsonAsync($"product with id{id}");

            //      }
            //      else
            //      {
            //          await context.Response.WriteAsJsonAsync($"product with no id");
            //      }
            //  });


            //    endpoints.MapGet("/books/{id}/{author}", async context =>
            //    {
            //        int id = Convert.ToInt32(context.Request.RouteValues["id"]);
            //        string author = context.Request.RouteValues["author"].ToString();

            //        await context.Response.WriteAsJsonAsync($"book with id{id} and author {author}");

            //    });
            //});
            #endregion

            app.MapControllerRoute(
                name: "default",
                pattern:"/{Controller=Home}/{Action=Index}",
                defaults: new { Controller="Home",Action="Index"}
                );
            app.Run();
            }
    }
    }
