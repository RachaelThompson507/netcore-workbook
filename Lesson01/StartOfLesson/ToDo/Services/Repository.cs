using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using ToDoApp.Models;

namespace ToDoApp.Services
{
    public class Repository
    {
        public static Dictionary<int, Status> status = new Dictionary<int, Status>
        {
            { 1, new Status { Id = 1, Value = "Not Started" } },
            { 2, new Status { Id = 2, Value = "In Progress" } },
            { 3, new Status { Id = 3, Value = "Done" } }
        };

        public static List<ToDo> list = new List<ToDo>
        {
            new ToDo { Id = 1, Title = "My First ToDo", Description = "Get the app working", Status = status[2] }
        };

        public static ToDo GetTodoById(int id)
        {
            var todo = list.SingleOrDefault( t => t.Id == id );
            return todo;
        }

        public static List<ToDo> SaveTodo(int id, IFormCollection collection)
        {
            //add logic to pass to the controller
            //get the current Todo based on ID
            //override each property with values from collection
           // list.Where(i => i.Id == id).ToList().ForEach(i1 => i1.Id = Convert.ToInt32(collection["Id"]));
            list.Where(t1 => t1.Id == id).ToList().ForEach(t2 => t2.Title = collection["Title"]);
            list.Where(t3 => t3.Id == id).ToList().ForEach(t4 => t4.Description = collection["Description"]);
            list.Where(t5 => t5.Id == id).ToList().ForEach(t6 => t6.Status = status[2]);
            //return saved todo
            return list;
        }
        public static void CreateTodo(IFormCollection collection)
        {
            //no need to get anything from the list.
            //create a new object of type todo and append values from collection 
            ToDo todoNew = new ToDo()
            {
                Id = Convert.ToInt32(collection["Id"]),
                Title = collection["Title"],
                Description = collection["Description"],
                Status = status[1]
            };

            list.Add(todoNew);
        }
        public static void DeleteTodo(int id, IFormCollection collection)
        {
            //find todo 
            var DeleteTodo = list.SingleOrDefault(t => t.Id == id);
            // delete from list
            list.Remove(DeleteTodo);

        }
    }
}
