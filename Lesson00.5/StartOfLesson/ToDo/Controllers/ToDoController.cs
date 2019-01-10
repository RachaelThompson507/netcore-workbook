using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ToDoApp.Controllers
{
    public class ToDoController : Controller
    {
        public List<Models.ToDo> list = new List<Models.ToDo>;
        public IActionResult Index()
        {
            return View();
        }
    }
}