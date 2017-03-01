using SchoolRepository.Entities;
using SchoolRepository.Models;
using SchoolRepository.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SchoolRepository.Controllers
{
    public class StudentController : Controller
    {
        private UnityOfWork uofw;

        public StudentController()
        {
            uofw = new UnityOfWork();
        }

        // GET: Student
        public ActionResult Index()
        {
            var lst = uofw.Student.GetAll();

            var lstView = new List<StudentViewModel>();

            foreach (var item in lst)
            {
                lstView.Add(
                    new StudentViewModel()
                    {
                        StudentId = item.StudentId,
                        FirstName = item.FirstName,
                        LastName = item.LastName,
                        EnrollmentDate = item.EnrollmentDate
                    }
                    );
            }

            return View(lstView);
        }

        // GET: Student/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var student = uofw.Student.Get(id.Value);

            if (student == null)
            {
                return HttpNotFound();
            }

            var view = new StudentViewModel()
            {
                StudentId = student.StudentId,
                FirstName = student.FirstName,
                LastName = student.LastName,
                EnrollmentDate = student.EnrollmentDate
            };

            return View(view);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentViewModel view)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var objStudent = new Student()
                    {
                        StudentId = view.StudentId,
                        FirstName = view.FirstName,
                        LastName = view.LastName,
                        EnrollmentDate = view.EnrollmentDate
                    };

                    uofw.Student.Add(objStudent);
                    uofw.Save();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Error = "Ocurrio un error al guardar el estudiante";
                    return View(view);
                }
            }
            catch
            {
                return View(view);
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var student = uofw.Student.Get(id.Value);

            if (student == null)
            {
                return HttpNotFound();
            }

            var view = new StudentViewModel()
            {
                StudentId = student.StudentId,
                FirstName = student.FirstName,
                LastName = student.LastName,
                EnrollmentDate = student.EnrollmentDate
            };

            return View(view);
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, StudentViewModel view)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var objStudent = new Student()
                    {
                        StudentId = view.StudentId,
                        FirstName = view.FirstName,
                        LastName = view.LastName,
                        EnrollmentDate = view.EnrollmentDate
                    };

                    uofw.Student.Update(objStudent);
                    uofw.Save();

                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Error = "Ocurrio un error al guardar el estudiante";
                    return View(view);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var student = uofw.Student.Get(id.Value);

            if (student == null)
            {
                return HttpNotFound();
            }

            var view = new StudentViewModel()
            {
                StudentId = student.StudentId,
                FirstName = student.FirstName,
                LastName = student.LastName,
                EnrollmentDate = student.EnrollmentDate
            };

            return View(view);
        }

        // POST: Student/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {

                var objStudent = uofw.Student.Get(id);

                uofw.Student.Remove(objStudent);
                uofw.Save();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                uofw.Dispose();
            }
            base.Dispose(disposing);    
        }
    }
}
