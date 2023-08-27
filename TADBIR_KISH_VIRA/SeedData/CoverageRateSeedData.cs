using TADBIR_KISH_VIRA.Data;
using TADBIR_KISH_VIRA.Models;

namespace TADBIR_KISH_VIRA.SeedData
{
    public class CoverageRateSeedData
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.CoverageRates.Any())
            {
                var coverageRates = new List<CoverageRate>
            {
                new CoverageRate { CoverageType = 1, Rate = 0.0052m },
                new CoverageRate { CoverageType = 2, Rate = 0.0042m },
                new CoverageRate { CoverageType = 3, Rate = 0.005m }
            };

                context.CoverageRates.AddRange(coverageRates);
                context.SaveChanges();
            }
        }
    }

}
