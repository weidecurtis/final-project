﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCFinalProject.Models
{
    public class Game
    {
        public int ID { get; set; }
        public string Venue { get; set; }
        public int VenueID { get; set; }
        public DateTime GameDate { get; set; }
        public int GameID { get; set; }
    }
}
