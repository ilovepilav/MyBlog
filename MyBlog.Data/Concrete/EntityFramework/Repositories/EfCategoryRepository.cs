using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Abstracts;
using MyBlog.Entities.Concrete;
using MyBlog.Shared.Data.Concrete.EntityFramework;

namespace MyBlog.Data.Concrete.EntityFramework.Repositories
{
    public class EfCategoryRepository : EfEntityRepositoryBase<Category>, ICategoryRepository
    {
        public EfCategoryRepository(DbContext context) : base(context)
        {
        }
    }
}