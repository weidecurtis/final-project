using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LCFinalProject.ViewModels
{
    public class PredictorViewModel
    {
        [Required]
        [Display(Name ="Base Stats (HR, RBI, Hits, etc")]
        public int BasicStats { get; set; }

        [Required]
        [Display(Name = "Exit Velocity")]
        public int ExitVelocity { get; set; }

        [Required]
        [Display(Name = "Versus Pitcher Handedness")]
        public int PitcherHand { get; set; }

        [Required]
        [Display(Name = "Stadium Factor")]
        public int Stadium { get; set; }

        [Required]
        [Display(Name = "Weather Factor")]
        public int Weather { get; set; }

        [Required]
        [Display(Name ="Launch Angle")]
        public int LaunchAngle { get; set; }


       public PredictorViewModel() { }
    }
}
