using Student_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_MVC.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(student_1346920 n)
        {
            DB01TEST01Entities m = new DB01TEST01Entities();
            ObjectParameter obj = new ObjectParameter("sid",0);
            m.strudent_1346920(n.name, n.dob, n.gender, n.percen, obj);

            int id=Convert.ToInt16(obj.Value);
            Response.Write("<script>alert('Your ID is" + id + "')</script>");
            return View();

            
        }
    }
}
