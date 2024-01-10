using RodriguezMMiniChallengeFiveToSeven_Endpoints.MadLib;
using RodriguezMMiniChallengeFiveToSeven_Endpoints.OddOrEven;
using RodriguezMMiniChallengeFiveToSeven_Endpoints.ReverseItAlpha;
using RodriguezMMiniChallengeFiveToSeven_Endpoints.ReverseItNum;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMadLib, MadLibService>();
builder.Services.AddScoped<IOddOrEven, OddOrEvenService>();
builder.Services.AddScoped<IReverseAlpha, ReverseAlphaService>();
builder.Services.AddScoped<IReverseNum, ReverseNumService>();

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
