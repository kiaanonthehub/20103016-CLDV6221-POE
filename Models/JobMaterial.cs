using System;
using System.Collections.Generic;

#nullable disable

namespace Domingo_Roof_Works.Models
{
    public partial class JobMaterial
    {
        public int JobCardNo { get; set; }
        public int MaterialId { get; set; }
        public int Quantity { get; set; }

        public virtual Job JobCardNoNavigation { get; set; }
        public virtual Material Material { get; set; }
    }
}
