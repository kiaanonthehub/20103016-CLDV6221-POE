﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Domingo_Roof_Works.Models
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
    }
}
