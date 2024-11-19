using Microsoft.AspNetCore.Identity;

namespace OnlineShopping.Models
{
    public class Customer:IdentityUser
    {
        public string Fullname { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }



    }
}
