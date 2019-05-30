using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCFinalProject.Models
{
    public class TopGame
    {
        public int ID { get; set; }
        public int Score { get; set; }
        public string Position { get; set; }
        public DateTime Date { get; set; }
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }

    }
}
