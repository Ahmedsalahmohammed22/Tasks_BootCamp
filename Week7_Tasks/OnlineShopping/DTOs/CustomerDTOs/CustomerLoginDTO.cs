using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.DTOs.CustomerDTOs
{
    public class CustomerLoginDTO
    {
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
    }
}
