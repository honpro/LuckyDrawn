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
builder.Services.AddScoped<IAccountRepository, AccountRepository>();
builder.Services.AddScoped<IBarcodeRepository, BarcodesRepository>();
builder.Services.AddScoped<IBarcodesUsageHistoryRepository, BarcodesUsageHistoryRepository>();
builder.Services.AddScoped<ICharsetBarcodeRepository, CharsetBarcodeRepository>();
builder.Services.AddScoped<ICharsetTypeRepository, CharsetTypeRepository>();
builder.Services.AddScoped<ICodeDetailRepository, CodeDetailRepository>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ICustomerTypeRepository, CustomerTypeRepository>();
builder.Services.AddScoped<ICustomerTypeofBussinessRepository, CustomerTypeofBussinessRepository>();
builder.Services.AddScoped<IGiftRepository, GiftRepository>();
builder.Services.AddScoped<IGiftsOfCampignRepository, GiftsOfCampignRepository>();
builder.Services.AddScoped<IProgramSizeRepository, ProgramSizeRepository>();
builder.Services.AddScoped<IRulesForGiftRepository, RulesForGiftRepository>();
builder.Services.AddScoped<ISettingRepository, SettingRepository>();
builder.Services.AddScoped<ITimeFrameRepository, TimeFrameRepository>();
builder.Services.AddScoped<ITypeBarcodeRepository, TypeBarcodeRepository>();
builder.Services.AddScoped<ITypeCodeRepository, TypeCodeRepository>();

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

