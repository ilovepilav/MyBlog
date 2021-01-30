using MyBlog.Shared.Entities.Abstract;

namespace MyBlog.Entities.Concrete
{
    public class Comment : EntityBase, IEntityBase
    {
        public string Text { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }
    }
}