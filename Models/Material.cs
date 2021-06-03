using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Domingo_Roof_Works.Models
{
    [Table("Material")]
    public partial class Material
    {
        [Key]
        [Column("MaterialID")]
        public int MaterialId { get; set; }
        [Required]
        [StringLength(250)]
        public string Description { get; set; }
    }
}
