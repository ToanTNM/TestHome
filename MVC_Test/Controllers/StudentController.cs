using MVC_Test.DataBinding;
using MVC_Test.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Test.Controllers
{
    public class StudentController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    unitOfWork.StudentRepository.Insert(student);
                    unitOfWork.Save();
                    return Json(new { code = 1, message = "Success" });
                }
                else
                {
                    var error = ModelState.Values.SelectMany(v => v.Errors);
                    return Json(new { code = 0, message = error });
                }
            }
            catch (DataException dex)
            {
                return Json(new { code = 0, message = dex.Message });
            }
        }
    }
}