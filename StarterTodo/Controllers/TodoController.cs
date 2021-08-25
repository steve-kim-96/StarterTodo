using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StarterTodo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterTodo.Controllers
{
    [ApiController]
    public class TodoController : ControllerBase

    {
        private readonly TodoContext _context;
        public TodoController(TodoContext context)
        {
            _context = context;
        }
        // api/todo
        [HttpGet("api/[controller]")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
