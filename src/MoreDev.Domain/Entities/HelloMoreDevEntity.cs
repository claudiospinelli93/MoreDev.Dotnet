using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoreDev.Domain.Entities
{
    [Table("HelloMoreDev")]
    public class HelloMoreDevEntity : BaseEntity
    {
        [Required]
        [MaxLength(150)]
        public string Nome { get; set; }

        [Required]
        public int Idade { get; set; }
    }
}
