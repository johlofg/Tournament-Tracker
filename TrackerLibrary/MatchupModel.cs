using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Rep all params for competing team
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Rep the winner of each round
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Rep which round of the tournament it is
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
