using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog.Entities.Concrete;
using System;

namespace MyBlog.Data.Concrete.EntityFramework.Mappings
{
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Text).HasMaxLength(1000).IsRequired();
            builder.HasOne<Article>(c => c.Article).WithMany(a => a.Comments).HasForeignKey(a => a.ArticleId);
            builder.Property(c => c.CreatedByName).HasMaxLength(50).IsRequired();
            builder.Property(c => c.ModifiedByName).HasMaxLength(50).IsRequired();
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.ModifiedDate).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.Note).HasMaxLength(500).IsRequired(false);
            builder.ToTable("Comments");

            builder.HasData(new Comment
            {
                Id = 1,
                ArticleId = 1,
                Text = "Example comment eyy!",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "Comment for C# Blog Article",
            });
        }
    }
}