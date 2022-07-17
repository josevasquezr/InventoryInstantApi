using Contexts;
using Fritz.InstantAPIs;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSqlite<InventoryContext>("Data Source=InventoryInstantDb.db");
builder.Services.AddInstantAPIs();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapInstantAPIs<InventoryContext>(config =>
{
	config.IncludeTable(db => db.Categories, ApiMethodsToGenerate.All, "Categories");
	config.IncludeTable(db => db.Products, ApiMethodsToGenerate.All, "Products");
	config.IncludeTable(db => db.Warehouses, ApiMethodsToGenerate.All, "Warehouses");
	config.IncludeTable(db => db.Storages, ApiMethodsToGenerate.All, "Storages");
	config.IncludeTable(db => db.InOuts, ApiMethodsToGenerate.All, "InOuts");
});

app.Run();
