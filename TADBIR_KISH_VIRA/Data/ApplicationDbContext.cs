using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TADBIR_KISH_VIRA.Models;

namespace TADBIR_KISH_VIRA.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CoverageRate> CoverageRates { get; set; }
        public DbSet<InsuranceResponse> InsuranceResponses { get; set; }
    }
}
