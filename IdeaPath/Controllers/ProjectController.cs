using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IdeaPath.Controllers
{
    public class ProjectController : Controller
    {
        //private DailyDoEntities Db = new DailyDoEntities();
        public ActionResult Index()
        {
            //var projectList = Db.Projects.ToList();
            //return View(projectList);
            return View();
        }

   
    }
}