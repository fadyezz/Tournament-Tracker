using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchpEntryModel
    {
        /// <summary>
        /// Represent one team in the match-up
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represent the score of that Team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represent the match-up that this team came from as the winner
        /// will be the winner 
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="intialScore">
        /// 
        /// </param>
        public MatchpEntryModel(double intialScore)
        {

        }

        public int Id { get; set; }
    }
}
