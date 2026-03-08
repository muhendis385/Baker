using Baker.WebApi.Context;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BakerContext>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ✅ CORS ekle
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// ✅ CORS middleware'i ekle - UseAuthorization'dan önce olmalı
app.UseCors("AllowAll");

app.UseAuthorization();
app.MapControllers();
app.Run();