using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Models.ViewModel
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "ContactNumber")]
        [DataType(DataType.PhoneNumber)]

        public string ContactNumber { get; set; }
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfJoin { get; set; }
        public string DepartmentName { get; set; }
        public string DesignationName { get; set; }
    }




    public class EmployeeListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string DesignationName { get; set; }
        public string ContactNumber { get; set; }

    }
    public class EmployeeUpdateViewModel
    {
        public int Id { get; set; }

        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string DepartmentId { get; set; }
        public string Email { get; set; }

        public int DesignationId { get; set; }
    }


}
