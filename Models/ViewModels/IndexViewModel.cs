﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingLeague.Models.ViewModels
{
    public class IndexViewModel
    {
        public List<Bowler> Bowlers { get; set; }

        public PageNumberingInfo PageNumberingInfo { get; set; }

        //Provide controller with reference
        public string TeamName {get;set;}
    }
}
