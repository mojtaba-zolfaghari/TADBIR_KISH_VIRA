using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace TADBIR_KISH_VIRA.Models
{
    public class CoverageRate
    {
        public Guid Id { get; set; }
        public int CoverageType { get; set; }

        [Column(TypeName = "decimal(9, 4)")] // Adjust precision and scale 
        public decimal Rate { get; set; }
    }
}
