using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LeaveManagementSystem.Models.Enums;



namespace LeaveManagementSystem.Models
{
    public class Leave
    {
        [Key]
        public int Id { get; set; }
        public Employee Employee { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        [Required]
        
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public string LeaveDescription { get; set; }
        [Required]
        public LeaveType LeaveType { get; set; }

    }
}
