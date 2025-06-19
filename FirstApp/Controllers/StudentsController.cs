using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FirstApp.Data;
using FirstApp.Models;
using FirstApp.Repo;

namespace FirstApp.Controllers
{
    public class StudentsController : Controller
    {
        private readonly DataContext _context;
        private readonly IStudent _student;

        public StudentsController(DataContext context,IStudent student)
        {
            _context = context;
            _student = student;
          
        }

        
        // GET: Students

        [HttpGet]
        public IActionResult Index()
        {
            //var students = _context.Students.ToList();
            var students = _student.GetAll();
            return View(students);
        }

        // GET: Students/Details/5
        [HttpGet]
        public IActionResult Details(int id)
        {
            //var student = _context.Students.FirstOrDefault(s => s.ID == id);

            var student = _student.GetStudent(id);

            return View(student);
        }

        // GET: Students/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        
        [HttpPost]
        public IActionResult Create(Student student)
        {
            //_context.Students.Add(student);
            //_context.SaveChanges();
            _student.Create(student);
            return RedirectToAction(nameof(Index));
        }

       
        // GET: Students/Details/5
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = _context.Students.FirstOrDefault(s => s.ID == id);
            return View(student);
        }

        // POST: Students/Edit/5
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
       
        // GET: Students/Delete/5
        public IActionResult Delete(int id)
        {
            var student = _context.Students.FirstOrDefault(s => s.ID == id);
            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                _context.Students.Remove(student);
            }

            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
