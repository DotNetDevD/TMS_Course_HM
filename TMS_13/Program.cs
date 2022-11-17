using TMS_13.Extensions;
using TMS_13.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add global filters
builder.Services.AddMvc(options =>
{
    // ����������� �� ����
    options.Filters.Add(typeof(MyAuthorizationFilter));
    // ����������� �� �������
    options.Filters.Add(new MyResourceFilter());
    // ���������� ��������������� ������
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
1. C������ ���������������� Middleware � �������� ��� � �������� ��������� ������� ����� ����������� �����. 
������ ����� ���������� ��������� ������ � ���� �����, �� �������� ������������ ��������� � ����������.
2. ������� ������ Worker c ������: Name, Age, DateOfBirth, Address.
3. ������� ����������, ������� ����� ��������� ���������������� �������. 
��������, ���������� ����� ���������� � ����� ������������ ������������� � ������� ������ Worker. 
�������� ���������� ������ Worker ������������, ����� ��������� � ������ ���������� ������ �����������.
4. ������� ��� ���� ����� �������� � �������� � ���������� �������. ������ �������� ������ ��������� ������ � ��������� ����.
���������������� ����� � � ����� ������������������ ���������� ������ ��������.
 */