using Microsoft.AspNetCore.Mvc;
using UniversityWebApp.Models;

namespace UniversityWebApp.Controllers
{
    public class StudentController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult ShowAll()
        {
            StudentBL studentBL = new StudentBL();
            List<Student> StudentsListModel = studentBL.GetAllStudents();
            return View("ShowAll", StudentsListModel);
        }
        public IActionResult Details(int id)
        {
            StudentBL studentBL = new StudentBL();
            Student studentModel = studentBL.GetById(id);
            return View("Details", studentModel);
        }
    }
}
