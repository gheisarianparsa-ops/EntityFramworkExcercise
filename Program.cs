using Microsoft.EntityFrameworkCore;
using EntityFramworkExcercise.Data;

var builder = WebApplication.CreateBuilder(args);

// 1️⃣ Connection string
var conn = builder.Configuration.GetConnectionString("SchoolManagmentDbContext");

// 2️⃣ DbContext
builder.Services.AddDbContext<SchoolManagmentDbContext>(options =>
    options.UseSqlServer(conn, sqlOptions =>
        sqlOptions.EnableRetryOnFailure()
    )
);

// 3️⃣ Controllers + Views
builder.Services.AddControllersWithViews(); // ⚡ مهم

// 4️⃣ Authorization
builder.Services.AddAuthorization();

var app = builder.Build();

// Middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization(); // بعد از Routing

// Map default controller route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();