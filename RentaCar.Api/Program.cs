using RentaCar.Infraestructura;
using RentaCar.Infraestructura.Data;
using RentaCar.Infraestructura.Repositorios;
using RentaCar.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<RentaCarDBContext>();
builder.Services.AddScoped<ClienteRepositorio>();
builder.Services.AddScoped<VehiculoRepositorio>();
builder.Services.AddScoped<MarcaRepositorio>();
builder.Services.AddScoped<ModeloRepositorio>();
builder.Services.AddScoped<ColorRepositorio>();
builder.Services.AddScoped<CombustibleRepositorio>();
builder.Services.AddScoped<TipoVehiculoRepositorio>();
builder.Services.AddScoped<EstadoVehiculoRepositorio>();
builder.Services.AddScoped<ReservaRepositorio>();
builder.Services.AddScoped<EstadoReservaRepositorio>();
builder.Services.AddScoped<AlquilerRepositorio>();
builder.Services.AddScoped<EstadoAlquilerRepositorio>();
builder.Services.AddScoped<ConductorRepositorio>();
builder.Services.AddScoped<TarifaRepositorio>();
builder.Services.AddScoped<DevolucionRepositorio>();
builder.Services.AddScoped<UsuarioRepositorio>();
builder.Services.AddScoped<JwtService>();

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
