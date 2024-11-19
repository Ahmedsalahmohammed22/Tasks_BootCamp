using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.DTOs.CustomerDTOs
{
    public class CustomerDTO
    {
        [StringLength(50)]
        public string Fullname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        [StringLength(11)]
        public string Phone { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        public int age { get; set; }

    }
}
