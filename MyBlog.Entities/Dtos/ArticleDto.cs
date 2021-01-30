using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;

namespace MyBlog.Entities.Dtos
{
    public class ArticleDto : DtoGetBase
    {
        public Article Article { get; set; }
    }
}