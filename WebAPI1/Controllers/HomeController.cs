using WebAPI1.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI1.Controllers
{
    [Route("api/Home")]
    [ApiController]
    public class HomeController : Controller
    {
        [HttpGet]
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
