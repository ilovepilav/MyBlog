using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyBlog.Entities.Dtos
{
    public class CategoryUpdateDto
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("Category Name")]
        [Required(ErrorMessage = "{0} cannot be left blank.")]
        [MaxLength(70, ErrorMessage = "{0} cannot be greater than {1} characters.")]
        [MinLength(3, ErrorMessage = "{0} cannot have less than {1} characters.")]
        public string Name { get; set; }

        [DisplayName("Category Description")]
        [MaxLength(500, ErrorMessage = "{0} cannot be greater than {1} characters.")]
        [MinLength(3, ErrorMessage = "{0} cannot have less than {1} characters.")]
        public string Description { get; set; }

        [DisplayName("Category Specified Notes")]
        [MaxLength(500, ErrorMessage = "{0} cannot be greater than {1} characters.")]
        [MinLength(3, ErrorMessage = "{0} cannot have less than {1} characters.")]
        public string Note { get; set; }

        [DisplayName("Is Active ?")]
        [Required(ErrorMessage = "{0} cannot be left blank.")]
        public bool IsActive { get; set; }

        [DisplayName("Is Deleted ?")]
        [Required(ErrorMessage = "{0} cannot be left blank.")]
        public bool IsDeleted { get; set; }
    }
}