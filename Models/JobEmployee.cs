using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Domingo_Roof_Works.Models
{
    [Keyless]
    [Table("Job_Employee")]
    public partial class JobEmployee
    {
        public int JobCardNo { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(6)]
        public string EmployeeId { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        public virtual Employee Employee { get; set; }
        [ForeignKey(nameof(JobCardNo))]
        public virtual Job JobCardNoNavigation { get; set; }
    }
}
