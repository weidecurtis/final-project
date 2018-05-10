using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCFinalProject.Models
{
    public class ProjectedPitcher
    {
        public int ID { get; set; }
        public int PlayerID { get; set; }
        public string Name { get; set; }
        public decimal ProjectedScore { get; set; }
    }
}
