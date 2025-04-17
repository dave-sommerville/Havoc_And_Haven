using Microsoft.EntityFrameworkCore;
using Havoc_And_Haven.DAL;
using Havoc_And_Haven.BLL;
using Havoc_And_Haven.BL;

namespace Havoc_And_Haven
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<HavocAndHavenDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddScoped<LocationRepository>();
            builder.Services.AddScoped<LocationService>();

            builder.Services.AddScoped<BattleRepository>();
            builder.Services.AddScoped<BattleService>();

            builder.Services.AddScoped<CrisisEventRepository>();
            builder.Services.AddScoped<CrisisEventService>();

            builder.Services.AddScoped<HeadquartersRepository>();
            builder.Services.AddScoped<HeadquartersService>();

            builder.Services.AddScoped<LairRepository>();
            builder.Services.AddScoped<LairService>();

            builder.Services.AddScoped<UserRepository>();
            builder.Services.AddScoped<UserService>();

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
