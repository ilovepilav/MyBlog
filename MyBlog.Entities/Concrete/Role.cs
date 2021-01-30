using MyBlog.Shared.Entities.Abstract;
using System.Collections.Generic;

namespace MyBlog.Entities.Concrete
{
    public class Role : EntityBase, IEntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<User> Users { get; set; }
    }
}