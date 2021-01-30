using Microsoft.Extensions.DependencyInjection;
using MyBlog.Data.Abstracts;
using MyBlog.Data.Concrete;
using MyBlog.Data.Concrete.EntityFramework.Contexts;
using MyBlog.Services.Abstract;
using MyBlog.Services.Concrete;

namespace MyBlog.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<MyBlogContext>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<ICategoryService, CategoryManager>();
            serviceCollection.AddScoped<IArticleService, ArticleManager>();
            return serviceCollection;
        }
    }
}