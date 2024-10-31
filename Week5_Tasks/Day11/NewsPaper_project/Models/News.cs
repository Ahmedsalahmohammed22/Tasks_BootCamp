using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newsproject.Models
{
    public class News
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [ForeignKey("Author")]
        public int Author_id { get; set; }
        public virtual Author Author { get; set; }
        [ForeignKey("Catalog")]
        public int Catalog_id { get; set; }
        public virtual Catalog Catalog { get; set; }

    }
}
