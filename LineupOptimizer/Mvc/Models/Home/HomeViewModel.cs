using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace LineupOptimizer.Models.Home
{
    public class HomeViewModel : BaseModel
    {
        public List<PlayerModel> MyTeamMyPlayerModels { get; set; }
    }
}