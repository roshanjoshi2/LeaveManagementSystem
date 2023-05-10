using AutoMapper;
using LeaveManagementSystem.Models;
using LeaveManagementSystem.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Diagnostics;


namespace LeaveManagementSystem.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly LMDbContext _dbContext;
        private readonly IMapper _mapper;
        public EmployeeController(LMDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }




        //public EmployeeController(IMapper mapper)
        //{
        //    _mapper = mapper;
        //}


        public ActionResult Index()
        {

            // var hvhghg = _dbContext.Employees.ToList();

            DbSet<Employee> LMDbContext = _dbContext.Employees;
            List<EmployeeListViewModel> gccgc = _mapper.ProjectTo<EmployeeListViewModel>(LMDbContext).ToList();
            //var employee = _dbContext.Employees;

            return View(gccgc);
        }








        public ActionResult Create()
        {
            var departments = _dbContext.Departments.Select(department => new SelectListItem
            {
                Text = department.Name,
                Value = department.Id.ToString()
            }).ToList();

            ViewData["departments"] = departments;

            var designations = _dbContext.Designations.Select(designation => new SelectListItem
            {
                Text = designation.Name,
                Value = designation.Id.ToString()
            }).ToList();
            ViewData["designations"] = designations;
            return View();

        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {



            _dbContext.Add(employee);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");




        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return RedirectToAction("Index");
            var departments = _dbContext.Departments.Select(department => new SelectListItem
            {
                Text = department.Name,
                Value = department.Id.ToString()
            }).ToList();

            ViewData["departments"] = departments;

            var designations = _dbContext.Designations.Select(designation => new SelectListItem
            {
                Text = designation.Name,
                Value = designation.Id.ToString()
            }).ToList();
            ViewData["designations"] = designations;


            var data = _dbContext.Employees.Where(x => x.Id == id);
            EmployeeUpdateViewModel? ujjwal = _mapper.ProjectTo<EmployeeUpdateViewModel>(data).FirstOrDefault();
            if (ujjwal == null)
                return RedirectToAction("Index");
            return View(ujjwal);
        }

        [HttpPost]
        public IActionResult Edit(EmployeeUpdateViewModel employee)
        {
            Employee data = _dbContext.Employees.Where(x => x.Id == employee.Id).First();
            _mapper.Map(employee, data);
            _dbContext.Update(data);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            //var data = _dbContext.Employees.Find(id);
            //return View(data);
            if (id == null)
                return RedirectToAction("Index");
            var data = _dbContext.Employees.Find(id);
            if (data == null)
                return RedirectToAction("Index");
            return View(data);


        }
        [HttpPost]
        public IActionResult Delete(Employee employee)
        {
            _dbContext.Remove(employee);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
                return RedirectToAction("Index");

            IQueryable<Employee> data = _dbContext.Employees.Where(x => x.Id == id);


            var ujjwal = _mapper.ProjectTo<EmployeeDetailsViewModel>(data).FirstOrDefault();
            if (ujjwal == null)
                return RedirectToAction("Index");

            return View(ujjwal);
        }



    }

}
