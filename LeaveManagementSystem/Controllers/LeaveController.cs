using LeaveManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Controllers
{
    public class LeaveController : Controller
    {
        private readonly LMDbContext _dbContext;
        public LeaveController(LMDbContext context)
        {
            _dbContext = context;
        }
        // GET: LeaveController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LeaveController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public IActionResult Create(int id)
        {
            var data = _dbContext.Employees.Where(x => x.Id == id).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public IActionResult Create(Leave leave)
        {
            _dbContext.Add(leave);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");

        }

        //// GET: LeaveController/Create
        //public ActionResult Create(int? id)
        //{
        //    var data  = _dbContext.Employees.Find(id);
        //    return View(data);
        //}

        //// POST: LeaveController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    var Employee = _dbContext.Employees.Select(Employee => new SelectListItem
        //    {
        //        Text = Employee.Name,
        //        Value = Employee.Id.ToString()
        //    }).ToList();

        //    ViewData["Employee"] = Employee;

        //    try
        //    {

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: LeaveController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LeaveController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LeaveController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LeaveController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
