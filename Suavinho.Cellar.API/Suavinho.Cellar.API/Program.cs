using Suavinho.Cellar.API.Configurations;
using Suavinho.Cellar.Applicarion.Contracts.Inbound;
using Suavinho.Cellar.Applicarion.Services;
using Suavinho.Cellar.Application.Contracts.Inbound;
using Suavinho.Cellar.Application.Contracts.Outbound;
using Suavinho.Cellar.Application.Services;
using Suavinho.Cellar.Infrastructure.Model.EFCore;
using Suavinho.Cellar.Infrastructure.Model.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region AUTO MAPPER INJECTION

builder.Services.AddAutoMapperConfiguration();

#endregion

#region EF DB CONTEXT INJECTION

builder.Services.AddDbContext<CellarDataContext>();

#endregion

#region SERVICES INJECTION

builder.Services.AddScoped<ICellarService, CellarService>();
builder.Services.AddScoped<IWineService, WineService>();

#endregion

#region REPOSITORIES INJECTION

builder.Services.AddScoped<ICellarRepository, CellarRepository>();
builder.Services.AddScoped<IWineRepository, WineRepository>();

#endregion

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
