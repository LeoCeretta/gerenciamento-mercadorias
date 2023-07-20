using LEKSupplyApplication.Data;
using LEKSupplyApplication.Repositorio;
using Microsoft.EntityFrameworkCore;

namespace LEKSupplyApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            
            //Configuração do banco de dados
            var provider = builder.Services.BuildServiceProvider();
            var configuration = provider.GetRequiredService<IConfiguration>();
            builder.Services.AddEntityFrameworkSqlServer().
                AddDbContext<BancoContext>(o => o.UseSqlServer(configuration.GetConnectionString("DataBase")));
            builder.Services.AddScoped<InterfaceMercadoriaRepositorio, MercadoriaRepositorio>();
            builder.Services.AddScoped<InterfaceEntradaRepositorio, EntradaRepositorio>();
            //builder.Services.AddScoped<InterfaceSaidaRepositorio, SaidaRepositorio>();

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
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}