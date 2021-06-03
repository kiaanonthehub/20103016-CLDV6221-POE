using System;
using System.Collections.Generic;

#nullable disable

namespace Domingo_Roof_Works.Models
{
    public partial class Job
    {
        public int JobId { get; set; }
        public int CustomerId { get; set; }
        public string JobTypeId { get; set; }
        public int Days { get; set; }
    }
}
