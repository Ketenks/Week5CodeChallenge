using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week5CodeChallenge.Controllers
{
    public class AboutController : Controller
    {
        //
        // GET: /About/

        public ActionResult Index()
        {
            return View();
        }
        // GET: /About/Who

        public ActionResult Who()
        {
            

                return PartialView();    
        }
        // GET: /About/What

        public ActionResult What()
        {
            return PartialView();
        }
        // GET: /About/Why

        public ActionResult Why()
        {
            return PartialView();
        }
        // GET: /About/How

        public ActionResult How()
        {
            return PartialView();
        }
        // GET: /About/Where

        public ActionResult Where()
        {
            return PartialView();
        }
        

    }
}
