using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System.Collections.Generic;

namespace MyBlog.Entities.Dtos
{
    public class ArticleListDto : DtoGetBase
    {
        public IList<Article> Articles { get; set; }
    }
}