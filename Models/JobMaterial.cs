using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Domingo_Roof_Works.Models
{
    [Keyless]
    [Table("Job_Material")]
    public partial class JobMaterial
    {
        public int JobCardNo { get; set; }
        [Column("MaterialID")]
        public int MaterialId { get; set; }
        public int Quantity { get; set; }

        [ForeignKey(nameof(JobCardNo))]
        public virtual Job JobCardNoNavigation { get; set; }
        [ForeignKey(nameof(MaterialId))]
        public virtual Material Material { get; set; }
    }
}
