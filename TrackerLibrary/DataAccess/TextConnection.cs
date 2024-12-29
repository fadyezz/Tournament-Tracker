using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelper;
using Microsoft.IdentityModel.Tokens;
using System.Reflection.Metadata.Ecma335;
namespace TrackerLibrary.DataAccess
{
    public class TextConnection : IDataConnection
    {
        private const string PrizeFile = "PrizeModel.csv";

        private const string PeopleFile = "PersonModels.csv";

        private const string TeamFile = "TeamModel.csv";

        private const string TournamentFile = "TournamentMode.csv";
        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            int currentId = 1;
            if (people.Count > 0) { currentId = people.OrderByDescending(x => x.Id).First().Id + 1; }

            model.Id = currentId;
            people.Add(model);

            people.SaveToPeopleFile(PeopleFile);

            return model;

        }

        public PrizeModel CreatePrize(PrizeModel model)
        {

            //load the text file
            // convert text  to list prizemodel
            List<PrizeModel> prizes = PrizeFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            // find MAx id
            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }



            model.Id = currentId;
            // add the new record with the new id = Max + 1
            prizes.Add(model);
        
            
           
            // convert prizes to list
            // save the list to text file

            prizes.SaveToPrizeFile(PrizeFile);

            return model;


        }

        public TeamModel CreateTeam(TeamModel model)
        {
           List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModel(PeopleFile);

            int currentId = 1;

            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }



            model.Id = currentId;
            // add the new record with the new id = Max + 1
            teams.Add(model);



            // convert prizes to list
            // save the list to text file

            teams.SaveToTeamFile(TeamFile);

            return model;

        }

        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = TournamentFile.FullFilePath()
                .LoadFile().ConvertTournamentModels(TeamFile,PeopleFile,PrizeFile);

            int currentId = 1;
            if(tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x=>x.Id).First().Id + 1;

            }
            model.Id = currentId;
            tournaments.Add(model);
            tournaments.SaveToTournamentFile(TournamentFile);

        }

        public List<PersonModel> GetPerson_All()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

        }

        public List<TeamModel> GetTeam_All()
        {
            return TeamFile.FullFilePath().LoadFile().ConvertToTeamModel(PeopleFile);
        }

        
    }
}
