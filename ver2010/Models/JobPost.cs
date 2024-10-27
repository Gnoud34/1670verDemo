using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ver2010.Models
{
    public class JobPost
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Job name is required.")]
        public string JobName { get; set; }

        public string Description { get; set; }
        public string Industry { get; set; }

        [Required(ErrorMessage = "Required skills are required.")]
        public string RequireSkill { get; set; }

        [Required(ErrorMessage = "Salary is required.")]
        [Range(0, 99999999, ErrorMessage = "Salary must be a positive number and cannot exceed 8 digits.")]
        public int Salary { get; set; }

        public string Image { get; set; }

        [Required]
        public string EmployerId { get; set; }
        public User Employer { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<Application> Applications { get; set; }
    }
}
