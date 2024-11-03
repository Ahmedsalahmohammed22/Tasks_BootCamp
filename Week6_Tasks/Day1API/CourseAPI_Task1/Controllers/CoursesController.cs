using CourseAPI_Task1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseAPI_Task1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        static List<Course> crs = new List<Course>()
        {
           new  Course(){id=1,name="CS",duration=30,status=true},
           new  Course(){id=2,name="SW",duration=45,status=true},
           new  Course(){id=3,name="Network",duration=60,status=false},
        };
        [HttpGet]
        public List<Course> GetAll()
        {
            return crs;
        }
        [HttpGet("{id}")]
        public Course GetById(int id)
        {
            return crs.Where(c => c.id == id).SingleOrDefault();
        }
    }
}
