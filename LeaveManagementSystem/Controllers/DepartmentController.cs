using AutoMapper;
using LeaveManagementSystem.Models;
using LeaveManagementSystem.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System.Security.Permissions;

namespace LeaveManagementSystem.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly LMDbContext _dbContext;
        private readonly IMapper _mapper;


        public DepartmentController(LMDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var data = _dbContext.Departments;
            return View(_mapper.ProjectTo<DepartmentViewModel>(data));


            //if (data != null && data.Count() > 0)
            //{

            //    return View(_mapper.ProjectTo<DepartmentViewModel>(data));


            //}
            //else
            //{
            //    return View(data);
            //}


        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department department)
        {
            _dbContext.Add(department);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        //get 
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return RedirectToAction("Index");
            var data = _dbContext.Departments.Find(id);
            if (data == null)
                return RedirectToAction("Index");
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(Department department)
        {
            _dbContext.Update(department);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int? id)
        {
            if (id == null)

                return RedirectToAction("Index");
            var data = _dbContext.Departments.Find(id);

            if (data == null)

                return RedirectToAction("Index");
            return View(data);




        }

        [HttpPost]
        public IActionResult Delete(Department department)
        {
            _dbContext.Remove(department);
            _dbContext.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Details(int? id)
        {
            if(id == null)
                return RedirectToAction("Index");
            var details = _dbContext.Departments.Find(id);
                if(details == null)
                return RedirectToAction("Index");
            return View(details);

        }
      

    }
}
