using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCFinalProject.Models
{
    public class ProjectedGame
    {
        public int ID { get; set; }
        public int PlayerID { get; set; }
        public decimal TotalScore { get; set; }
        public decimal Projection { get; set; }
        public DateTime GameDate { get; set; }
    }
}
