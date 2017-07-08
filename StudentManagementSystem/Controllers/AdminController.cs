using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentManagementSystem.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Students()
        {
            throw new NotImplementedException();
        }

        public ActionResult Teachers()
        {
            throw new NotImplementedException();
        }

        public ActionResult Courses()
        {
            throw new NotImplementedException();
        }
    }
}