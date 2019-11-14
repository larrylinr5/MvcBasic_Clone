using MvcBasic_Clone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic_Clone.Controllers
{
    public class FamilysController : Controller
    {
        // GET: Familys
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Family()
        {
            List<Family> family = new List<Family>
            {
                new Family { Id = 10001, Name = "David", Phone = "0933-154228", Age = 10,City= "Tpe" },
                new Family { Id = 10002, Name = "Mary", Phone = "0925-157886", Age = 20,City= "Tch" },
                new Family { Id = 10003, Name = "John", Phone = "0921-335884", Age = 30,City= "Tpe"},
                
            };
            return View(family);
        }
    }
}