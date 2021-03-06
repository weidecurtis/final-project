﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LCFinalProject.Models
{
    public class Pitcher
    {
        public int ID { get; set; }
        public int PlayerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TeamName { get; set; }
        public int Hits { get; set; }
        public int Doubles { get; set; }
        public int Triples { get; set; }
        public int HomeRuns { get; set; }
        public int Walks { get; set; }
        public int RBIs { get; set; }
        public int SB { get; set; }
        public int CS { get; set; }
        public int Runs { get; set; }




    }
}
