using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;

namespace MyBlog.Entities.Dtos
{
    public class CategoryDto : DtoGetBase
    {
        public Category Category { get; set; }
    }
}