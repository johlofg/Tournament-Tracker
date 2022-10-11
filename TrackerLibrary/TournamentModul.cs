using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModul
    {
        /// <summary>
        /// Rep the name of the tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Rep the entry fee of the tournament
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Rep the entered teams of the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Rep the prizemoney for the T
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// creates the competion teams of each rounds
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
