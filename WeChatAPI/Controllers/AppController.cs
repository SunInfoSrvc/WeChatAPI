using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeChatAPI.DataAccess;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WeChatAPI.Controllers
{
    [Route("api/[controller]")]
    public class AppController : Controller
    {
        private readonly SunInfoContext _context;
        public AppController(SunInfoContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Get()
        {
           var apps = _context.Apps.ToList();
            return Ok(apps);
        }
    }
}
