var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


// Add loging and auth config

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// DI resovler
// Resolve services(interface => implemantations)

// Dependent on particular DataAccess(needed for DI), agonostic of BusinessLogic

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


// Potential migartions apply

//void ApplyMigration()
//{
//    using (var scope = app.Services.CreateScope())
//    {
//        var _Db = scope.ServiceProvider.GetRequiredService<Action>(); 

//        if (_Db != null)
//        {
//            if (_Db.Database.GetPendingMigrations().Any())
//            {
//                _Db.Database.Migrate();
//            }
//        }
//    }
//}