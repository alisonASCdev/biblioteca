using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace biblioteca.Models
{
    [Table("Publishers")]
    public class Publisher
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Column("PublisherName")]
        public string? Name { get; set; }
        [Required]
        [StringLength(50)]
        [MaxLength(80), MinLength(4)]
        public string? Site { get; set; }


    }
}
