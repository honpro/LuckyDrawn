using ProjectAlta;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using ProjectAlta.Repository;
using ProjectAlta.Context;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AddContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProjectAltaContext") ?? throw new InvalidOperationException("Connection string 'ProjectAltaContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
builder.Services.ServicesCollection(builder.Configuration);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<iAccountRepository, AccountRepository>();
builder.Services.AddScoped<iBarcodeRepository, BarcodesRepository>();
builder.Services.AddScoped<iBarcodesUsageHistoryRepository, BarcodesUsageHistoryRepository>();
builder.Services.AddScoped<iCharsetBarcodeRepository, CharsetBarcodeRepository>();
builder.Services.AddScoped<iCharsetTypeRepository, CharsetTypeRepository>();
builder.Services.AddScoped<iCodeDetailRepository, CodeDetailRepository>();
builder.Services.AddScoped<iCustomerRepository, CustomerRepository>();
builder.Services.AddScoped<iCustomerTypeRepository, CustomerTypeRepository>();
builder.Services.AddScoped<iCustomerTypeofBussinessRepository, CustomerTypeofBussinessRepository>();
builder.Services.AddScoped<iGiftRepository, GiftRepository>();
builder.Services.AddScoped<iGiftsOfCampignRepository, GiftsOfCampignRepository>();
builder.Services.AddScoped<iProgramSizeRepository, ProgramSizeRepository>();
builder.Services.AddScoped<iRulesForGiftRepository, RulesForGiftRepository>();
builder.Services.AddScoped<iSettingRepository, SettingRepository>();
builder.Services.AddScoped<iTimeFrameRepository, TimeFrameRepository>();
builder.Services.AddScoped<iTypeBarcodeRepository, TypeBarcodeRepository>();
builder.Services.AddScoped<iTypeCodeRepository, TypeCodeRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

