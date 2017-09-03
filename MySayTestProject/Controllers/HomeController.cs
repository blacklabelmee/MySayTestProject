using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySayTestProject;
namespace MySayTestProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(MvcApplication.Topics);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult usersFeedBack(int topicId)
        {
            var topic = MvcApplication.Topics.Where(t => t.id == topicId).FirstOrDefault();
            return View(topic);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult addFeedBack(int topicId, string title, string description, string email)
        {
            //code for adding to database will goes here ...
            var feedBackToAdd= new Models.feedBack()
            {
                id = new Random().Next(1500,2500),
                title = title,
                description = description,
                addingDate = DateTime.Now.ToString(),
                userEmail = email,
                topicId = topicId
            };

            MvcApplication.Topics.Where(a => a.id == topicId).FirstOrDefault().feedBacks.Add(feedBackToAdd);

            //returning the parameters as json to show it in the feedbacks list.
            return Json(feedBackToAdd, JsonRequestBehavior.AllowGet);
        }
    }
}