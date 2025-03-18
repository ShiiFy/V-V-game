using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace V_V_game.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Sing()
        {
            return View();
        }
        public ActionResult Reg()
        {
            return View();
        }
    }
}