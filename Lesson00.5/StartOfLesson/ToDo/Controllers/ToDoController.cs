using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class ToDoController : Controller
    {
        public List<Models.ToDo> list = new List<Models.ToDo>()
        {
            new Models.ToDo {Id = 1, Description = "Do Laundry", Status = new Status() { Id = 1, Value = "Pending"} },
            new Models.ToDo {Id = 2, Description = "HEB", Status = new Status() { Id = 1, Value = "Pending"}},
            new Models.ToDo {Id = 3, Description = "Code and Chill", Status = new Status() { Id = 1, Value = "Complete"}},
        };

        public IActionResult Index()
        {
            return View(list);
        }
    }
}