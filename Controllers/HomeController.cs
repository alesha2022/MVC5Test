using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Products()
        {
            return View("OurCompanyProducts");
        }
        public ActionResult Contact()
        {
            ViewBag.TollFree = "123123123";
            return View();
        }

        //Get EmpName by EmpId
        public ActionResult GetEmpName(int EmpId)
        {
            //creating  employee object
            var employees = new[]
            {
              new {EmpId=1,EmpName="Scott", Salary=8000},
            new {EmpId=2,EmpName="Smith", Salary=2000 },
             new {EmpId=3,EmpName="Allen", Salary=2000 }
            };
            string matchEmpName = null;
            foreach (var item in employees)
            {
                if (item.EmpId == EmpId)
                {
                    matchEmpName = item.EmpName;
                }
            }
            //return new ContentResult() { Content = matchEmpName, ContentType = "text/plain" };
            return Content(matchEmpName, "text/plain");
        }

        public ActionResult GetPaySlip(int EmpId)
        {
            string filename = "~/PaySlip" + EmpId + ".pdf";
            return File(filename, "application/pdf");

        }
        public ActionResult EmpFacebookPage(int EmpId)
        {
            string fbUrl = "http://www.facebook.com/emp" + EmpId;
            return Redirect(fbUrl);
        }

        public ActionResult StudentDetails()
        {
            ViewBag.StudentId = 101;
            ViewBag.StudentName = "Scott";
            ViewBag.Marks = 80;
            ViewBag.NoOfSemesters = 6;
            ViewBag.Subjects = new List<string>() { "Physics", "Chemistry", "Maths", "Computers" };
            return View();
        }
    }
}