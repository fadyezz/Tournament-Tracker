using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        public List<MatchpEntryModel> Entries { get; set; } = new List<MatchpEntryModel>();

        public TeamModel Winner { get; set; }

        public int MatchupRound { get; set; }

        public  int  Id { get; set; }


    }
}
