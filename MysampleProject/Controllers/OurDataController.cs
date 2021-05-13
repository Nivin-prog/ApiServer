using MySampleProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataLibrary.Buisness.StudentPreprocess;

namespace MysampleProject.Controllers
{
    public class OurDataController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Student Manager Application";
            List<Student> students = new List<Student>();

            students = LoadEmployees1();
            foreach(Student data in students.ToList())
            {
                if (data.MARKS1 < 500 || data.MARKS2 < 500)
                {
                    students.Remove(data);
                }

            }

            return View(students);
        }

       
        public ActionResult Details(int id)
        {
            Student details = new Student();
            List<Student> students = LoadEmployee(id);
            details = students.First();
            return View(details);
        }

       

      
    }
}