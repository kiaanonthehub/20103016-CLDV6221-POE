using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Domingo_Roof_Works.Models
{
    [Table("JobType")]
    public partial class JobType
    {
        [Key]
        [Column("JobTypeID")]
        public int JobTypeId { get; set; }
        [Required]
        [Column("JobType")]
        [StringLength(20)]
        public string JobType1 { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Rate { get; set; }
    }
}
