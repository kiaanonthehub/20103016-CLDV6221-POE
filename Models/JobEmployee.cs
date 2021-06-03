using System;
using System.Collections.Generic;

#nullable disable

namespace Domingo_Roof_Works.Models
{
    public partial class JobEmployee
    {
        public int JobCardNo { get; set; }
        public string EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Job JobCardNoNavigation { get; set; }
    }
}
