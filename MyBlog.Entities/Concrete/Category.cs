using MyBlog.Shared.Entities.Abstract;
using System.Collections.Generic;

namespace MyBlog.Entities.Concrete
{
    public class Category : EntityBase, IEntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}