using AppContext = Module6HW2.db.AppContext;
using Module6HW2.core.Interface;
using Module6HW2.core.Service;
using ProductStore = Module6HW2.infrastructure.ProductStore;
using React.AspNet;

namespace Module6HW2.api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var provider = builder.Services.BuildServiceProvider();
            var service = provider.GetRequiredService<IConfiguration>();

            builder.Services.AddCors(options =>
            {
                var react = service.GetValue<string>("frontend_url");
                options.AddDefaultPolicy(builder =>
                {
                    builder.WithOrigins(react).AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
                });
            }
            );

            builder.Services.AddSingleton<AppContext>();
            builder.Services.AddScoped<IProductService, ProductService>();

            builder.Services.AddSingleton<IProductStore, ProductStore>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

         //   app.UseHttpsRedirection();
            app.UseCors();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}