using Types.Data.Access.Extensions;
using Types.Entities;
using Types.Entities.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<MongoDbSettings>(builder.Configuration.GetSection(nameof(MongoDbSettings)));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMongoDbSettings(builder.Configuration);
builder.Services.AddDataServices();

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddCors(option => { option.AddPolicy(builder.Environment.EnvironmentName, p => { p.AllowAnyMethod().AllowAnyOrigin().AllowAnyHeader(); }); });
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthorization();

app.UseHttpsRedirection();
app.UseRouting();


app.MapControllers();

app.Run();