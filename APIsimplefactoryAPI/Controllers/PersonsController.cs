using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLClassLibrary.Implements;

namespace APIsimplefactoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : Controller
    {
        [Route("GetPeople")]
        [HttpGet]
        public IActionResult GetPeople ()
        {
            PersonImplements objPerson = new PersonImplements();
            var st = objPerson.GetFirstName("Student Jack");
            return Json(st);
        }

        [Route("GetTeachersHike")]
        [HttpGet]
        public IActionResult GetTeachersHike(int salary)
        {
            PersonImplements objPerson = new PersonImplements();
            var st = objPerson.GetIncrement(salary);
            return Json(st);
        }
    }
}
