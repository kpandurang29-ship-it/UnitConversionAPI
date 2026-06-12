var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddScoped<IConversionService, ConversionService>();
builder.Services.AddScoped<IConversionStrategy,
    LengthConversionStrategy>();
builder.Services.AddScoped<IConversionStrategy,
    WeightConversionStrategy>();
builder.Services.AddScoped<IConversionStrategy,
    TemperatureConversionStrategy>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();
app.Run();