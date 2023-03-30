using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sessions.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public RedirectToRouteResult Index1(int? id,string name, int? mobilenumber)
        {
            Session["id"] = id;
            Session["name"] = name;
            Session["mobilenumber"] = mobilenumber;
            return RedirectToAction("index2");
        }
        public ViewResult index2()
        {
            return View();
        }
    }
}