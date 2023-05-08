using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Models
{
    public class Designation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
