using Courses_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Courses_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        CoursesDBContext crsDB;
        public CoursesController(CoursesDBContext coursesDB)
        {
            crsDB = coursesDB;
        }
        [HttpGet]
        public IActionResult get()
        {
            var courses = crsDB.Courses.ToList();
            if(courses == null) return NotFound();
            return Ok(courses);
        }
        [HttpGet("{id:int}")]
        public IActionResult getById(int id) 
        {
            var course = crsDB.Courses.Where(c => c.ID == id).SingleOrDefault();
            if(course == null) return NotFound();
            return Ok(course);
        }
        [HttpGet("{name}")]
        public IActionResult courseByName(string name)
        {
            Course course = crsDB.Courses.Where(c => c.Crs_name ==  name).FirstOrDefault();
            if(course == null) return NotFound();
            return Ok(course);
        }
        [HttpPost]
        public IActionResult post(Course course)
        {
            if (course == null) return BadRequest();
            if (ModelState.IsValid)
            {

                crsDB.Courses.Add(course);
                crsDB.SaveChanges();
                return CreatedAtAction("getById" , new {id = course.ID} , course);

            }else return BadRequest(ModelState.Select(e => e.Value.Errors).ToList());
        }
        [HttpPut("{id}")]
        public IActionResult put(int id , Course course)
        {
            if(id != course.ID) return BadRequest();
            Course crs = crsDB.Courses.Where(c => c.ID == id).SingleOrDefault();
            if(crs == null) return NotFound();
            if (ModelState.IsValid)
            {
                // doesn't work because The instance of entity type 'Course' cannot be tracked 
                //crsDB.Entry(course).State = EntityState.Modified;
                crs.Crs_name = course.Crs_name;
                crs.Crs_desc = course.Crs_desc;
                crs.Duration = course.Duration;
                crsDB.SaveChanges();
                return NoContent();

            }
            else return BadRequest(); 
        }
        [HttpDelete("{cid}")]
        public IActionResult deleteCourse(int cid) 
        {
            Course course = crsDB.Courses.Where(c => c.ID==cid).SingleOrDefault();
            if (course == null) return NotFound();
            crsDB.Courses.Remove(course); 
            crsDB.SaveChanges();
            return Ok(crsDB.Courses.ToList());
        }
    }
}
