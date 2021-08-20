using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterTodo.Model
{
    public class TodoContext : DbContext
    {
        DbSet<Todo> Todos { get; set; }
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }
    }
}
