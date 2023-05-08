using LeaveManagementSystem.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementSystem.Models
{
    public class LeaveApproved
    {
        [Key]
        public int Id { get; set; }
        public int TotalLeave { get; set; }

        public bool Approved { get; set; }

        public Leave? Leave { get; set; }
        [ForeignKey(nameof(Leave))]
        public int LeaveId { get; set; }
        [Required]
        public LeaveType LeaveType{ get; set; }
    }
}
