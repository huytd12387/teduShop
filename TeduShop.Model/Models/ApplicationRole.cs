using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Models
{
    public class ApplicationRole : IdentityRole
    {
        [StringLength(250)]
        public string Description { get; set; }
    }
}