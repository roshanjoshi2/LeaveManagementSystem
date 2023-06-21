using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementSystem.Models
{
    public class Employee
    {
        [Key]
        public int Id{ get; set; }
        [Required(ErrorMessage ="Enter your name.")]
        [StringLength(50)]
        public string  Name { get; set; }

        [Required   ]
        [StringLength(100)] 




        public string Address { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOFBirth{ get; set; }

        [DisplayName("Date Of Join")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateOfJoin { get; set; }

        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "ContactNumber")]
        [DataType(DataType.PhoneNumber)]

        public string ContactNumber { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        
        public string? Email { get; set; }


        public Department Department{ get; set; }
        [ForeignKey(nameof(Department)) ]
        public int DepartmentId { get; set; }


        public Designation Designation { get; set; }
        [ForeignKey(nameof(Designation))]
        public int DesignationId { get; set; }
    }
}
