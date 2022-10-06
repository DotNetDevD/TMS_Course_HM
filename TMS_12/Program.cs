var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

/*
 ДЗ:
1. Создать приложение по шаблону ASP.NET Core MVC
2. Создать контролер, например, UsersController
3. Создать модель UserInfo
4. Создать два представления. Одно представление позволяет регистрироваться
пользователю в приложение: предлагается ввод информации ФИО, дата рождения,
пол, информация о себе; должна быть кнопка, которая позволила бы отправить данные на контроллер. 
Вторая форма должна отображать список зарегистрированных пользователей.
5. Информацию о пользователях можно сохранять в файл в сериализованном виде
 */