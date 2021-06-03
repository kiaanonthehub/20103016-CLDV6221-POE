using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domingo_Roof_Works.Models;

namespace Domingo_Roof_Works.Data
{
    public class Domingo_Roof_WorksContext : DbContext
    {
        public Domingo_Roof_WorksContext (DbContextOptions<Domingo_Roof_WorksContext> options)
            : base(options)
        {
        }

        public DbSet<Domingo_Roof_Works.Models.Customer> Customer { get; set; }

        public DbSet<Domingo_Roof_Works.Models.Employee> Employee { get; set; }

        public DbSet<Domingo_Roof_Works.Models.JobType> JobType { get; set; }

        public DbSet<Domingo_Roof_Works.Models.Material> Material { get; set; }

        public DbSet<Domingo_Roof_Works.Models.Job> Job { get; set; }
    }
}
