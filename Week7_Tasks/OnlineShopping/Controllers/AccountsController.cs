using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineShopping.DTOs.CustomerDTOs;
using OnlineShopping.Models;

namespace OnlineShopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        UserManager<IdentityUser> _manager;
        SignInManager<IdentityUser> _signInManager;
        public AccountsController(UserManager<IdentityUser> manager , SignInManager<IdentityUser> signInManager)
        {
            _manager = manager;
            _signInManager = signInManager;

        }
        [HttpPost]
        public IActionResult Register(CustomerDTO customerDTO)
        {
            if (customerDTO == null)  return BadRequest();
            Customer customer = new Customer()
            {
                UserName = customerDTO.Fullname, 
                Email = customerDTO.Email,
                PhoneNumber = customerDTO.Phone,
                Address = customerDTO.Address,
                Age = customerDTO.age
            };
            IdentityResult result = _manager.CreateAsync(customer, customerDTO.Password).Result;
            if(result.Succeeded)
            {
                return Ok(customerDTO);
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }
        [HttpPut]
        public IActionResult Login(CustomerLoginDTO ct)
        {
            if (ModelState.IsValid)
            {
                var r = _signInManager.PasswordSignInAsync(ct.username, ct.password, false, false).Result;
                if(r.Succeeded)
                {
                    return Ok("token");
                }
                else
                {
                    return Unauthorized();
                }
            }else return BadRequest(ModelState);
        }

    }
}
