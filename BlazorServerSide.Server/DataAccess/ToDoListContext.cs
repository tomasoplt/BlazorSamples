using BlazorServerSide.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerSide.Server.DataAccess
{
    public class ToDoListContext : DbContext
    {
        public ToDoListContext(DbContextOptions<ToDoListContext> options) : base(options)
        {
        }

        public DbSet<ToDoListItem> ToDoListItems { get; set; }
    }
}
