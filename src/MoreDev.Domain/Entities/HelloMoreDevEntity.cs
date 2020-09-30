using System.ComponentModel.DataAnnotations;

namespace MoreDev.Domain.Entities
{
    public class HelloMoreDevEntity : BaseEntity
    {
        [Required]
        [MaxLength(150)]
        public string Nome { get; set; }

        [Required]
        public int Idade { get; set; }
    }
}
