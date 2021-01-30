using System;
using System.Threading.Tasks;

namespace MyBlog.Data.Abstracts
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IArticleRepository Articles { get; }
        ICategoryRepository Categories { get; }
        ICommentRepository Comments { get; }
        IUserRepository Users { get; }

        Task<int> SaveAsync();
    }
}