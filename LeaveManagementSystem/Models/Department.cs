using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace LeaveManagementSystem.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }
        //used  to make reference table.
        public List<Employee>? Employees { get; set; }
    }
}
