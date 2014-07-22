using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week5CodeChallenge.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/
        [HttpGet]
        public ActionResult Index()
        {
            Models.ContactForm cf = new Models.ContactForm();
            return View(cf);
        }
        //POST: /Home/Contact
        [HttpPost]
        public ActionResult Index(Models.ContactForm cf)
        {
            Models.ContactFormsEntities2 db = new Models.ContactFormsEntities2();
            db.ContactForms.Add(cf);
            //save changes
            db.SaveChanges();

            return RedirectToAction("ThankYou");
        }
        //GET: /Home/ThankYOU
        public ActionResult ThankYou()
        {
            return View();
        }

    }
}
