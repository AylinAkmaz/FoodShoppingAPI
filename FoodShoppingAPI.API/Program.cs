using FoodShoppingAPI.Business.Abstract;
using FoodShoppingAPI.Business.Concrete;
using FoodShoppingAPI.Busýness;
using FoodShoppingAPI.Busýness.Abstract;
using FoodShoppingAPI.Busýness.Concrete;
using FoodShoppingAPI.DAL.Abstract.DataManagment;
using FoodShoppingAPI.DAL.Concrete.Context;
using FoodShoppingAPI.DAL.Concrete.EfRepository.Base;
using FoodShoppingAPI.Helper.Globals;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using FoodShoppingAPI.API.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpContextAccessor();
builder.Services.AddDbContext<FoodShopContext>();
builder.Services.AddScoped<IUnitOfWork, EFUnitOfWork>();
builder.Services.AddScoped<IFoodCategoryService, FoodCategoryManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IFoodDetailService, FoodDetailManager>();
builder.Services.AddScoped<IFoodProductService, FoodProductManager>();
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IStoreCategoryService, StoreCategoryManager>();
builder.Services.AddScoped<IStoreDetailService, StoreDetailManager>();
builder.Services.AddScoped<IStoresService, StoresManager>();
builder.Services.AddScoped<IStoreProductService, StoreProductManager>();
builder.Services.AddScoped<IRoleService, RoleManager>();
builder.Services.AddScoped<IOrderService, OrderManager>();
builder.Services.AddScoped<IStoreOrderService, StoreOrderManager>();
builder.Services.AddScoped<IStoreOrderDetailService, StoreOrderDetailManager>();
builder.Services.AddScoped<IUserService, UserManager>();
builder.Services.AddScoped<IOrderDetailService, OrderDetailManager>();
builder.Services.AddScoped<IMenuService, MenuManager>();
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.Configure<JWTExceptURLList>(builder.Configuration.GetSection(nameof(JWTExceptURLList)));



var app = builder.Build();

//app.UseGlobalExceptionMiddleware();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//app.UseApiAuthorizationMiddleware();




app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
