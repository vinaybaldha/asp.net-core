using ModelValidationsExample.CustomModelBlinders;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(options =>
{
    //options.ModelBinderProviders.Insert(0, new PersonBinderProvider());
});
builder.Services.AddControllers().AddXmlSerializerFormatters();
var app = builder.Build();

app.UseRouting();

app.MapControllers();

app.Run();
