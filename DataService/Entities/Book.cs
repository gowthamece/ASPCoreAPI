using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreAPIDemo.Entities
{
    [Table("Book", Schema = "dbo")]
    public class Book
    {
        [Key]
        
        public  Guid BookId { get; set; }
        [Required]
        [MaxLength(150)]
        public string Title { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }

        [ForeignKey("AuthorId")]
        public Author Author { get; set; }

        public Guid AuthorId { get; set; }

    }
}
