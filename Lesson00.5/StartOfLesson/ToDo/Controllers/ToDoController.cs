using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ToDoApp.Controllers
{
    public class ToDoController : Controller
    {
        public List<Models.ToDo> list = new List<Models.ToDo>()
        {
            new Models.ToDo {Id = 1, Description = "Do Laundry"},
            new Models.ToDo {Id = 2, Description = "HEB"},
            new Models.ToDo {Id = 3, Description = "Code and Chill"},
        };

        public IActionResult Index()
        {
            return View(list);
        }
    }
}