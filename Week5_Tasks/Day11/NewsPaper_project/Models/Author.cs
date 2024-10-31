using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newsproject.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "date")]
        public DateTime JoinDate { get; set; }
        [Required , StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50) , Required]
        public string Password { get; set; }
        [NotMapped]
        public string Confirm_password { get; set; }
        public string bref { get; set; }
        public virtual List<News> News { get; set; } = new List<News>();
    }
}
