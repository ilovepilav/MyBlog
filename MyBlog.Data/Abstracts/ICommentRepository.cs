using MyBlog.Entities.Concrete;
using MyBlog.Shared.Data.Abstract;

namespace MyBlog.Data.Abstracts
{
    public interface ICommentRepository : IEntityRepository<Comment>
    {
    }
}