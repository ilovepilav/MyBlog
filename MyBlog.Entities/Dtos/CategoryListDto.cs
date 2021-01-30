using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System.Collections.Generic;

namespace MyBlog.Entities.Dtos
{
    public class CategoryListDto : DtoGetBase
    {
        public IList<Category> Categories { get; set; }
    }
}