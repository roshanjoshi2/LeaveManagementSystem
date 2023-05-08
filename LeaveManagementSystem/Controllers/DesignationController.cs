using AutoMapper;
using LeaveManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Controllers
{
    public class DesignationController : Controller
    {
        private readonly LMDbContext _dbContext;
        private readonly IMapper _mapper;

        public DesignationController(LMDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;   
        }

        public IActionResult Index()
        {
            var data = _dbContext.Designations.ToList();
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Designation designation)
        {
            _dbContext.Add(designation);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
                return RedirectToAction("Index");
            var data = _dbContext.Designations.Find(id);
            if (data == null)
                return RedirectToAction("Index");
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(Designation designation)
        {
            _dbContext.Update(designation);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if(id == null)
                return RedirectToAction("Index");
            var data = _dbContext.Designations.Find(id);
            if(data == null)
                return RedirectToAction("Index");
            return View(data);
        }
        [HttpPost]
        public IActionResult Delete(Designation designation)
        {
            _dbContext.Remove(designation);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");   
        }

            
    }
}
