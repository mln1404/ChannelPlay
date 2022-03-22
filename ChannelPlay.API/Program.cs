using AutoMapper;
using ChannelPlay.Repository;
using ChannelPlay.Repository.Interfaces;
using ChannelPlay.Repository.Repositories;
using ChannelPlay.Services;
using ChannelPlay.Services.Interfaces;
using ChannelPlay.Services.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();

// Add services to the container.
builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddTransient<IChannelService, ChannelService>();
builder.Services.AddTransient<IInformationService, InformationService>();

builder.Services.AddTransient<IChannelRepository, ChannelRepository>();
builder.Services.AddTransient<IInformationRepository, InformationRepository>();

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
