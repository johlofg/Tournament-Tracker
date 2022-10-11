using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Rep the place each team ends in the tournament
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Creates posibility to name each standing, like champion, first runner up etc.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Rep the prizemoney each standing should get
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Summon the prizemoney out of the decided percentage
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
