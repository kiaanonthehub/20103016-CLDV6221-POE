using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Domingo_Roof_Works.Models
{
    [Table("Customer")]
    public partial class Customer
    {
        [Key]
        [Column("CustomerID")]
        public int CustomerId { get; set; }
        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        [Required]
        [StringLength(25)]
        public string Surname { get; set; }
        [Required]
        [StringLength(60)]
        public string Address { get; set; }
        [Required]
        [StringLength(25)]
        public string City { get; set; }
        [Required]
        [StringLength(5)]
        public string PostalCode { get; set; }
    }
}
