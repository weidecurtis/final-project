using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCFinalProject.Models
{
    public class HitData
    {
        public int ID { get; set; }
        public decimal LaunchAngle { get; set; }
        public decimal LaunchSpeed { get; set; }
        public decimal Distance { get; set; }
        public DateTime Date { get; set; }
        public int PlayerID { get; set; }
    }
}
