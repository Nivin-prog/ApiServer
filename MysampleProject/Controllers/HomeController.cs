using MysampleProject.Models;
using MySampleProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataLibrary.Buisness.StudentPreprocess;

namespace MysampleProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Student Manager Application";
            List<Student> students = new List<Student>();
            students = LoadEmployees1();
           
            return View(students);
        }

        public ActionResult Edit(int Id)
        {
            Student details = new Student();
            List<Student> students = LoadEmployee(Id);
            details = students.First();
            return View(details);
        }

        [HttpPost]
        public ActionResult Edit(Student details, int Id)
        {


            var MydataList = UpdateData(details, Id);


            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            ViewBag.Message = "Create new Student data";
            StudentViewModel modelData = new StudentViewModel();
            modelData.StudentDetails = new Student();
            modelData.subjects = Collection();
            modelData.sex = GenderCollection();

            return View(modelData);
        }

       

        public ActionResult Details(int id)
        {
            Student details = new Student();
            List<Student> students = LoadEmployee(id);
            details = students.First();
            return View(details);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentViewModel modelData)
        {
            Student details = modelData.StudentDetails;
            if (ModelState.IsValid)
            {
                string records = CreateNewData(details);
                return RedirectToAction("Index");

            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        private IEnumerable<Subjects> Collection()
        {
            List<Subjects> returnval = new List<Subjects>();

            returnval.Add(new Subjects
            { Subject = "MATHS" });
            returnval.Add(new Subjects
            { Subject = "SCIENCE" });
            returnval.Add(new Subjects
            { Subject = "LITERATURE" });
            returnval.Add(new Subjects
            { Subject = "SOCIAL SCIENCE" });
            returnval.Add(new Subjects
            { Subject = "HUMAN MIND" });

            return returnval;

        }

        private IEnumerable<SexModel> GenderCollection()
        {
            List<SexModel> returnval = new List<SexModel>();

            returnval.Add(new SexModel
            { Sex = "Male" });
            returnval.Add(new SexModel
            { Sex = "Female" });


            return returnval;
        }
    }
}