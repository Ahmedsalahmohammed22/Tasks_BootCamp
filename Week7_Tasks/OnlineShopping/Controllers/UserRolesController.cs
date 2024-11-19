using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRolesController : ControllerBase
    {
        UserManager<IdentityUser> _userManager;
        RoleManager<IdentityRole> _roleManager;
        public UserRolesController(UserManager<IdentityUser> userManager , RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
        [HttpPost]
        public IActionResult AddRole(string Role)
        {
            IdentityRole role = new IdentityRole(Role);
            var r = _roleManager.CreateAsync(role).Result;
            if(r.Succeeded) 
                return Ok(role);
            else
                return BadRequest(r.Errors);
            
        }
        [HttpGet("{username} , {role}")]
        public IActionResult AddUserRole(string username , string role) 
        {
            IdentityUser user = _userManager.FindByNameAsync(username).Result;
            var r = _userManager.AddToRoleAsync(user, role).Result;
            if (r.Succeeded) return Ok();
            else return BadRequest(r.Errors);
        }
        [HttpGet]
        public IActionResult Userroles(string username) 
        {
            IdentityUser user = _userManager.FindByNameAsync(username).Result;
            if (user == null) return NotFound();
            var userroles = _userManager.GetRolesAsync(user).Result;
            if(userroles != null) return Ok(userroles);
            else return NotFound();
        }
        [HttpDelete]
        public IActionResult RemoveRole(string rolename)
        {
            IdentityRole role = _roleManager.FindByNameAsync(rolename).Result;
            var r = _roleManager.DeleteAsync(role).Result;
            if (r.Succeeded) return Ok(_roleManager.Roles.ToList());
            else return BadRequest(r.Errors);
        }


    }
}
