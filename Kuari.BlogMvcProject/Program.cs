using Kuari.Blog.Core.Repositories;
using Kuari.Blog.Core.Services;
using Kuari.Blog.Core.UnitOfWork;
using Kuari.Blog.Repository.Contexts;
using Kuari.Blog.Repository.Repositories;
using Kuari.Blog.Repository.UnitOfWork;
using Kuari.Blog.Service.Services;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BlogDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), options =>
    {
        options.MigrationsAssembly(Assembly.GetAssembly(typeof(BlogDbContext)).GetName().Name);
    });
});

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IService<,,>), typeof(Service<,,>));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

//CustomRepositories
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IArticleRepository,ArticleRepository>();
builder.Services.AddScoped<IAuthorRepository,AuthorRepository>();
builder.Services.AddScoped<IContactRepository,ContactRepository>();
builder.Services.AddScoped<IAboutRepository,AboutRepository>(); 
builder.Services.AddScoped<ICommentRepository,CommentRepository>();
// CustomServices
builder.Services.AddScoped<ICategoryService,CategoryService>();
builder.Services.AddScoped<IArticleService, ArticleService>();
builder.Services.AddScoped<ICommentService,CommentService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
