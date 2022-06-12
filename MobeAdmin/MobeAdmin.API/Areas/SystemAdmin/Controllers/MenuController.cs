using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobeAdmin.API.Controllers;
using MobeAdmin.API.ViewModels.SystemAdmin;

namespace MobeAdmin.API.Areas.SystemAdmin.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuController : BaseApiController
    {
        [HttpGet]
        public IActionResult GetMenu()
        {
            return Ok(Success());
        }

        [HttpGet("{Id}", Name = "GetMenu")]
        public IActionResult GetMenu(int Id)
        {
            return Ok(Success());
        }

        [HttpPost]
        public IActionResult PostMenu(PostMenu model)
        {
            return Ok(Success());
        }

        [HttpPut("{Id}")]
        public IActionResult PutMenu(int Id, PutMenu model)
        {
            return Ok(Success());
        }

        [HttpDelete("{Id}")]
        public IActionResult DeleteMenu(int Id)
        {
            return Ok(Success());
        }

        //[HttpPost]
        //[Route("[action]")]
        //public IActionResult Test()
        //{
        //    return Ok();
        //}


        //[HttpPost]
        //[Route("test2")]
        //public IActionResult Test2()
        //{
        //    return Ok();
        //}
    }
}
