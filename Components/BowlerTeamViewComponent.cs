using BowlingLeague.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingLeague.Components
{
    public class BowlerTeamViewComponent : ViewComponent
    {
        private BowlingLeagueContext context;
        public BowlerTeamViewComponent (BowlingLeagueContext ctx)
        {
            context = ctx;
        }
        //Select teams and display them, allow selected team to be highlighted
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedTeam = RouteData?.Values["teamname"];
            return View(context.Teams
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
