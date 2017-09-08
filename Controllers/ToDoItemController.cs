namespace gorillaspace.Controllers
{
    using System.Linq;
    using gorillaspace.Models;
    using Microsoft.AspNetCore.Mvc;
    public class ToDoItemController : Controller
    {
        private readonly DatabaseContext _dbContext;
        public ToDoItemController(DatabaseContext dbContext)
        {
            _dbContext = dbContext;

            var ls = _dbContext.Blogs.ToList();
        }
    }
}
