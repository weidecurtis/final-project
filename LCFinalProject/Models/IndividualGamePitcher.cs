﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCFinalProject.Models
{
    public class IndividualGamePitcher
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PlayerID { get; set; }
        public int IP { get; set; }
        public int StrikeOuts { get; set; }
        public int Walks { get; set; }
        public int EarnedRuns { get; set; }
        public int RunsAllowed { get; set; }
        public int HitsAllowed { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public DateTime GameDate { get; set; }
    }
}