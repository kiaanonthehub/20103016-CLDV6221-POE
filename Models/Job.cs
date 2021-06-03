using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Domingo_Roof_Works.Models
{
    [Table("Job")]
    public partial class Job
    {
        [Key]
        public int JobCardNo { get; set; }
        [Column("CustomerID")]
        public int CustomerId { get; set; }
        [Required]
        [Column("JobTypeID")]
        [StringLength(20)]
        public string JobTypeId { get; set; }
        public int Days { get; set; }
    }
}
