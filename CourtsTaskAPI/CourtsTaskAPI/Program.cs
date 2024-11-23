using CourtsTaskAPI.Interface;
using CourtsTaskAPI.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddAuthorization(); // הוספת Authorization
builder.Services.AddAuthentication(); // הוספת Authentication
builder.Services.AddControllers();
builder.Services.AddScoped<ICaseService, CaseService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IDocumentService, DocumentService>();
builder.Services.AddScoped<IHearingService, HearingService>();
builder.Services.AddScoped<INotificationService, NotificationService>();
builder.Services.AddScoped<IAuditService, AuditService>();
builder.Services.AddScoped<ISearchService, SearchService>();
// הוספת CORS אם צריך (למשל, אם אתה עובד עם Frontend ב- localhost:4200)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

var app = builder.Build();

// הפעלת CORS אם יש צורך
app.UseCors("AllowAll");

// אם אתה רוצה להשתמש ב-Authentication ו-Authorization
app.UseAuthentication();
app.UseAuthorization();

// Map את ה-Controllers
app.MapControllers();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// אם ברצונך להפעיל הפניית HTTPS
// app.UseHttpsRedirection();

app.Run();

