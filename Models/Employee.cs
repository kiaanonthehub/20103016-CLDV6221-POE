using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Domingo_Roof_Works.Models
{
    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        [Column("EmployeeID")]
        [StringLength(6)]
        public string EmployeeId { get; set; }
        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        [Required]
        [StringLength(25)]
        public string Surname { get; set; }
    }
}
