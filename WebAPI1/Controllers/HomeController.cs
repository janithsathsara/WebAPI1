using WebAPI1.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI1.Controllers
{

    [ApiController]
    public class HomeController : Controller
    {
        public IEnumerable<Villa> GetVillas()
        {
            return new List<Villa>
            {
                new Villa{ Id= 1, Name="Villa 1"},
                new Villa{ Id= 1, Name="Villa 2"},
            };
        } 
    }
}
