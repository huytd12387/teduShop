﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("SystemConfigs")]
    public class SystemConfig
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Code { get; set; }

        [MaxLength(50)]
        public string ValueString { get; set; }

        public int? ValueInt { get; set; }
    }
}