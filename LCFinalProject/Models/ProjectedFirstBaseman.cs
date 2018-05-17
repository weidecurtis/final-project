﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCFinalProject.Models
{
    public class ProjectedFirstBaseman
    {
        public int ID { get; set; }
        public int PlayerID { get; set; }
        public string Name { get; set; }
        public decimal ProjectedScore { get; set; }
        public string Team { get; set; }
    }
}
