using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using TableResevationforRestaurant.Authorization;
using TableResevationforRestaurant.Models;
using TableResevationforRestaurant.Repository.Auth;
using TableResevationforRestaurant.Repository.Customer_details;
using TableResevationforRestaurant.Repository.FoodCategories;
using TableResevationforRestaurant.Repository.Hotel_Details;
using TableResevationforRestaurant.Repository.product_details;
using TableResevationforRestaurant.Repository.reserve;
using TableResevationforRestaurant.Repository.Table_details;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TableReseravtionContext>(optionsAction: options => options.UseSqlServer(builder.Configuration.GetConnectionString(name: "SQLConnection")));
builder.Services.AddDbContext<DBContext>(optionsAction: options => options.UseSqlServer(builder.Configuration.GetConnectionString(name: "Authorization")));

builder.Services.AddScoped<IHotel,HotelServices>();
builder.Services.AddScoped<Itable,TableServices>();
builder.Services.AddScoped<Iproduct,productServices>();
builder.Services.AddScoped<Icategory,CategorySevices>();
builder.Services.AddScoped<Icustomers,customerServices>();
builder.Services.AddScoped<Ireserve,ReservationServices>();
builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddCors(option =>
{
    option.AddPolicy("ProductPolicy", builder =>
    {
        builder.AllowAnyHeader();
        builder.AllowAnyMethod();
        builder.AllowAnyOrigin();
    });
});

// For Identity  
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<DBContext>()
    .AddDefaultTokenProviders();

// Adding Authentication 
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})

// Adding Jwt Bearer  
.AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = builder.Configuration["JWT:ValidAudience"],
        ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
        ClockSkew = TimeSpan.Zero,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
    };
});

builder.Services.AddTransient<ITokenService,TokenService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(options =>
            options.WithOrigins("*").
            AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
app.UseCors("ProductPolicy");
app.UseAuthorization();

app.MapControllers();

app.Run();
