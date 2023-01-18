using BancoMaster.RotasCRUD.Application.Authenticate.Configurations;
using BancoMaster.RotasCRUD.Application.Authenticate.Services;
using BancoMaster.RotasCRUD.Application.Queries.Login;
using BancoMaster.RotasCRUD.Domain.Notifications;
using BancoMaster.RotasCRUD.Services.Api.Configutations;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using BancoMaster.RotasCRUD.Application.AutoMapper;
using BancoMaster.RotasCRUD.Domain.Contexts;
using Microsoft.EntityFrameworkCore;
using BancoMaster.RotasCRUD.Domain.Authorization;

var builder = WebApplication.CreateBuilder(args);

// DBContexts
//builder.Services.AddDatabaseConfiguration(builder.Configuration);

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();

// Swagger
builder.Services.AddSwaggerConfiguration();

// HTTP Context Accessor
builder.Services.AddHttpContextAccessor();


builder.Services.AddScoped<INotificador, Notificador>();
builder.Services.AddScoped<IAppUsuario, AppUsuario>();
builder.Services.AddScoped<IGeneratorToken, GeneratorToken>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// JWT Token
builder.Services.ResolveJwtConfig();
builder.Services.AddJwtConfiguration(builder.Configuration);

// MediatR
builder.Services.AddMediatR(typeof(LoginRequest));

//AutoMapper
builder.Services.AddAutoMapper(typeof(MappingProfile));

// Versionamento
builder.Services.AddApiVersioning(opt =>
{
    opt.DefaultApiVersion = new ApiVersion(1, 0);
    opt.AssumeDefaultVersionWhenUnspecified = true;
    opt.ReportApiVersions = true;
    opt.ApiVersionReader = ApiVersionReader.Combine(new UrlSegmentApiVersionReader(),
                                                    new HeaderApiVersionReader("x-api-version"),
                                                    new MediaTypeApiVersionReader("x-api-version"));
});

builder.Services.Configure<ApiBehaviorOptions>(options => options.SuppressModelStateInvalidFilter = true);


var app = builder.Build();

app.UseSwaggerSetup();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

