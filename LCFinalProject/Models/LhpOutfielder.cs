using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCFinalProject.Models
{
    public class LhpOutfielder
    {
        public int ID { get; set; }
        public int PlayerID { get; set; }
        public string Name { get; set; }
        public decimal TotalScore { get; set; }
        public decimal PointPerAtBat { get; set; }
        public string Team { get; set; }
    }
}
