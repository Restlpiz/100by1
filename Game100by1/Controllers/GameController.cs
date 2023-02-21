using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Game100by1.Controllers
{
    public class GameController : Controller
    {
        public ActionResult Game()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Information(string input, bool auth, string numberQuestion)
        {
            return Json("student saved successfully");
        }

        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }
    }
}