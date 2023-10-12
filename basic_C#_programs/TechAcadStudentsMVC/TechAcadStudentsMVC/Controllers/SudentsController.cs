using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechAcadStudentsMVC.Controllers
{
    public class SudentsController : Controller
    {
        // GET: Sudents
        public ActionResult Index()
        {
            return View();
        }
    }
}