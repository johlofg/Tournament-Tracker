using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represent the teams in a game
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Rep the score of each game
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Rep the previous game for each team
        /// </summary>
        public MatchupModel ParentMatchUp { get; set; }           
    }
}
