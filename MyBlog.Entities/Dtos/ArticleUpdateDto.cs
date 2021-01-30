using MyBlog.Entities.Concrete;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyBlog.Entities.Dtos
{
    public class ArticleUpdateDto
    {
        [Required]
        public int ArticleId { get; set; }

        [Required(ErrorMessage = "{0} section cannot be left blank.")]
        [MaxLength(100, ErrorMessage = "{0} cannot be greater than {1} characters.")]
        [MinLength(5, ErrorMessage = "{0} cannot be lesser than {1} characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "{0} section cannot be left blank.")]
        [MinLength(20, ErrorMessage = "{0} cannot be lesser than {1} characters.")]
        public string Content { get; set; }

        [Required(ErrorMessage = "{0} section cannot be left blank.")]
        [MaxLength(250, ErrorMessage = "{0} cannot be greater than {1} characters.")]
        [MinLength(5, ErrorMessage = "{0} cannot be lesser than {1} characters.")]
        public string Thumbnail { get; set; }

        [DisplayName("Created Date")]
        [Required(ErrorMessage = "{0} section cannot be left blank.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [DisplayName("Seo Author")]
        [Required(ErrorMessage = "{0} section cannot be left blank.")]
        [MaxLength(50, ErrorMessage = "{0} cannot be greater than {1} characters.")]
        [MinLength(0, ErrorMessage = "{0} cannot be lesser than {1} characters.")]
        public string SeoAuthor { get; set; }

        [DisplayName("Seo Description")]
        [Required(ErrorMessage = "{0} section cannot be left blank.")]
        [MaxLength(150, ErrorMessage = "{0} cannot be greater than {1} characters.")]
        [MinLength(0, ErrorMessage = "{0} cannot be lesser than {1} characters.")]
        public string SeoDescription { get; set; }

        [DisplayName("Seo Tags")]
        [Required(ErrorMessage = "{0} section cannot be left blank.")]
        [MaxLength(70, ErrorMessage = "{0} cannot be greater than {1} characters.")]
        [MinLength(0, ErrorMessage = "{0} cannot be lesser than {1} characters.")]
        public string SeoTags { get; set; }

        [DisplayName("Category")]
        [Required(ErrorMessage = "{0} section cannot be left blank.")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        [Required(ErrorMessage = "{0} section cannot be left blank.")]
        [DisplayName("Is Active ?")]
        public bool IsActive { get; set; }

        [Required(ErrorMessage = "{0} section cannot be left blank.")]
        [DisplayName("Is Deleted ?")]
        public bool IsDeleted { get; set; }
    }
}