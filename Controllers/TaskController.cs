using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tasks_Manager.Models;

namespace Tasks_Manager.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        public ActionResult Index()
        {
            using (TaskModel model = new TaskModel())
            {
                List<Task> list = model.Read();
                return View();
            }    
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            Task task = new Task();
            task.Title = form["Title"];
            task.Description = form["Description"];
            task.Status = 1;

            using (TaskModel model = new TaskModel())
            {
                model.Create(task);
                return RedirectToAction("Index");
            }
        }
    }
}