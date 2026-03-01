using d01ApiV2.Common.Configuration;
using d01ApiV2.DbFactory;
using d01ApiV2.Repository.Interface.Profile;
using d01ApiV2.Repository.Implementation.Profile;
using d01ApiV2.Repository.Interface.Shared;
using d01ApiV2.Repository.Implementation.Shared;
using d01ApiV2.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
// Add a permissive CORS policy that allows any origin, method and header
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// Bind the 'ConnectionStrings' section to DbFactoryConfiguration and register it with DI.
// Consumers can inject IOptions<DbFactoryConfiguration> or DbFactoryConfiguration directly.
builder.Services.Configure<DbFactoryConfiguration>(builder.Configuration.GetSection("ConnectionStrings"));
builder.Services.AddSingleton(provider => provider.GetRequiredService<Microsoft.Extensions.Options.IOptions<DbFactoryConfiguration>>().Value);

// Register database factory and repository services
builder.Services.RegisterDbFactoryService();
builder.Services.RegisterRepositoryService();
//builder.Services.AddScoped<IBrandRepository, BrandRepository>();
//builder.Services.AddScoped<ISharedRepository, SharedRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// Enable the permissive CORS policy
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
