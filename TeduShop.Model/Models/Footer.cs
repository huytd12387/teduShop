using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Footers")]
    public class Footer : Switchable
    {
        [Key]
        [MaxLength(50)]
        public string Id { get ; set ; }

        [Required]
        public string Content { get ; set ; }
    }
}