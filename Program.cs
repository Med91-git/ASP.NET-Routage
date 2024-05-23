namespace ASP.Net_Routage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}") ;

            // Version par attributs
            app.MapControllerRoute(
                name: "Say", 
                pattern: "{controller=Hello}/{action=SayHello}/{id?}");  

            app.MapControllerRoute(
                name: "Yell", 
                pattern: "{controller=Hello}/{action=YellHello}/{id?}");

            // Version conventionnelle
            /*app.MapControllerRoute(
                name: "Hello",
                pattern: "{controller=Hello}/{action=SayHello}/{id?}");*/  

            

            app.Run();
        }
    }
}
