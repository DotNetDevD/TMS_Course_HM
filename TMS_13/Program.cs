using TMS_13.Extensions;
using TMS_13.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add global filters
builder.Services.AddMvc(options =>
{
    // подключение по типу
    options.Filters.Add(typeof(MyAuthorizationFilter));
    // подключение по объекту
    options.Filters.Add(new MyResourceFilter());
    // применение типизированного метода
    options.Filters.Add<MyHybridFilter>();  
    options.Filters.Add<MyExceptionFilter>();  
});

var app = builder.Build();

//Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.SaveURL();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

/*
1. Cоздать пользовательский Middleware и добавить его в конвейер обработки запроса через расширяющий метод. 
Задача этого компонента выполнять запись в файл адрес, по которому пользователь обратился к приложению.
2. Создать модель Worker c полями: Name, Age, DateOfBirth, Address.
3. Создать контроллер, который будет принимать пользовательские запросы. 
Например, контроллер будет возвращать в ответ пользователю представление с данными модели Worker. 
Создание экземпляра класса Worker произвольное, можно создавать в момент выполнения метода контроллера.
4. Создать все пять типов фильтров и добавить в глобальную область. Методы фильтров должны выполнять запись в отдельный файл.
Проанализировать когда и в какой последовательности вызываются методы фильтров.
 */