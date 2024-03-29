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
 ��:
1. ������� ���������� �� ������� ASP.NET Core MVC
2. ������� ���������, ��������, UsersController
3. ������� ������ UserInfo
4. ������� ��� �������������. ���� ������������� ��������� ����������������
������������ � ����������: ������������ ���� ���������� ���, ���� ��������,
���, ���������� � ����; ������ ���� ������, ������� ��������� �� ��������� ������ �� ����������. 
������ ����� ������ ���������� ������ ������������������ �������������.
5. ���������� � ������������� ����� ��������� � ���� � ��������������� ����
 */