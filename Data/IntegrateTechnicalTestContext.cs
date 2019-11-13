using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IntegrateTechnicalTest.Model;

namespace IntegrateTechnicalTest.Data
{
    public class IntegrateTechnicalTestContext : DbContext
    {
        public IntegrateTechnicalTestContext (DbContextOptions<IntegrateTechnicalTestContext> options)
            : base(options)
        {
        }

        public DbSet<IntegrateTechnicalTest.Model.LeadClass> LeadClass { get; set; }
    }
}
