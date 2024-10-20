using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RestFulApi;
using RestFulApi.Data;
using RestFulApi.Service;

var builder = WebApplication.CreateBuilder(args);

// Add CORS configuration
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder =>
        {
            builder.WithOrigins("https://www.knzgrup.com.tr") // Sadece bu domain izinli
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Add services to the container.
builder.Services.AddScoped<IPostService,PostManager>();
builder.Services.AddScoped<ICategoriesService, CategoriesManager>();
builder.Services.AddScoped<IProductsService, ProductsManager>();
builder.Services.AddScoped<ISiparisService, SiparisManager>();
builder.Services.AddScoped<ISiparisDetayService, SiparisDetayManager>();
builder.Services.AddScoped<IPanelDetayListService, PanelDetayListManager>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(EfRepository<>));
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseCors(policy=>policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseAuthorization();

app.MapControllers();

app.Run();
