using AutoMapper;
using LeaveManagementSystem.Models.ViewModel;

namespace LeaveManagementSystem.Models
{
    public class Mapper: Profile        
    {
        public Mapper()
        {
            CreateMap<Employee, EmployeeViewModel>()
               .ForMember(x => x.DepartmentName, a => a.MapFrom(x => x.Department.Name))
               .ForMember(y=>y.DesignationName, z => z.MapFrom(y => y.Designation.Name));
                
                
                CreateMap<Department, DepartmentViewModel>();
            CreateMap<Designation, DesignationViewModel>();
            CreateMap<EmployeeUpdateViewModel, Employee>()
;        }
    }
}
    