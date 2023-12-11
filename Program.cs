var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(o => o.AddPolicy("AllowOrigins", builder =>
{
    builder.WithOrigins("http://localhost:5500")
           .AllowAnyMethod()
           .AllowAnyHeader();
}));


var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI()

app.UseCors("AllowOrigins");

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

app.Run();
