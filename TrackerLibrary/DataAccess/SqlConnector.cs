using Dapper;
using Microsoft.IdentityModel.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string db = "Tournaments";
        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString
                 (db)))
            {
                var p = new DynamicParameters();

                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@CellPhoneNumber", model.CellPhoneNumber);

                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");


                return model;

            }
        }

        public PrizeModel CreatePrize(PrizeModel model)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString
                (db)))
            {
                var p = new DynamicParameters();

                p.Add("@PlaceNumber" , model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage",model.PrizePercentage);

                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                connection.Execute("dbo.spPrizes_Insert",p,commandType:CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");


                return model;

            }

        }

        public TeamModel CreateTeam(TeamModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString
                (db)))
            {
                var p = new DynamicParameters();

                p.Add("@TeamName", model.TeamName);
                

                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
                foreach (PersonModel tm in model.TeamMembers)
                {
                    p = new DynamicParameters();
                    p.Add("@TeamId", model.Id);
                    p.Add("@PersonId", tm.Id);

                    connection.Execute("dbo.spTeamMembers_Insert",p, commandType: CommandType.StoredProcedure);
                }


                return model;

            }

        }

        public void CreateTournament(TournamentModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                // Validate team IDs
                var teamIds = model.EnteredTeams.Select(t => t.Id).ToList();
                if (!AreTeamsValid(teamIds))
                {
                    throw new Exception("One or more teams are invalid. Ensure all teams exist in the Teams table.");
                }

                SaveTournament(model, connection);
                SaveTournamentPrizes(model, connection);
                SaveTournamentEnteries(model, connection);
                SaveTournamentRounds(model, connection);
            }
        }

        private void SaveTournament(TournamentModel model, IDbConnection connection)
        {
            var p = new DynamicParameters();

            p.Add("@TournamentName", model.TournamentName);
            p.Add("@EntryFee", model.EntryFee);

            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


            connection.Execute("dbo.spTournaments_Insert", p, commandType: CommandType.StoredProcedure);

            model.Id = p.Get<int?>("@id") ?? 0;
        }

        private void SaveTournamentPrizes(TournamentModel model, IDbConnection connection)
        {
            foreach (PrizeModel pz in model.Prizes)
            {
                var p = new DynamicParameters();
                p.Add("@TournamentId", model.Id);
                p.Add("@PrizeId", pz.Id);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.sptournamentPrizes_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }
        private void SaveTournamentEnteries(TournamentModel model, IDbConnection connection)
        {
            foreach (TeamModel tm in model.EnteredTeams)
            {

                var p = new DynamicParameters();
                p.Add("@TournamentId", model.Id);
                p.Add("@TeamId", tm.Id);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spTournamentEntries_insert", p, commandType: CommandType.StoredProcedure);

            }
        }
        private void SaveTournamentRounds(TournamentModel model, IDbConnection connection)
        {
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    var p = new DynamicParameters();
                    p.Add("@TournamentId", model.Id);
                    p.Add("@MatchupRound", matchup.MatchupRound);
                   
                    p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);

                    // Call the procedure
                    connection.Execute("dbo.spMatchups_Insert", p, commandType: CommandType.StoredProcedure);
                    matchup.Id = p.Get<int>("@id");

                    foreach (MatchpEntryModel entryModel in matchup.Entries)
                    {
                        p = new DynamicParameters();
                        p.Add("@MatchupId", matchup.Id);
                        p.Add("@ParentMatchupId", entryModel.ParentMatchup?.Id ?? 0);
                        p.Add("@TeamCompetingId", entryModel.TeamCompeting?.Id ?? 0);
                        connection.Execute("dbo.spMatchupEntries_Insert", p, commandType: CommandType.StoredProcedure);
                    }
                }
            }
        }
        

        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString
                  (db)))
            {
                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();

            }

            return output;

        }

        public List<TeamModel> GetTeam_All()
        {
            List<TeamModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString
                  (db)))
            {
                output = connection.Query<TeamModel>("dbo.spTeam_GetAll").ToList();

                foreach (TeamModel team in output)
                {
                    var p = new DynamicParameters();
                    p.Add("@TeamId", team.Id);


                    team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam",p, 
                        commandType: CommandType.StoredProcedure).ToList();

                }
            }

            return output;
        }
        public bool AreTeamsValid(List<int> teamIds)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@TeamIds", string.Join(",", teamIds));

                var result = connection.Query<int>("dbo.spTeams_Validate", p, commandType: CommandType.StoredProcedure).ToList();

                return result.Count == teamIds.Count;
            }
        }
        public void AddTeams(List<TeamModel> teams)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                foreach (var team in teams)
                {
                    var p = new DynamicParameters();
                    p.Add("@TeamName", team.TeamName);
                    p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);

                    team.Id = p.Get<int>("@id");

                    foreach (PersonModel tm in team.TeamMembers)
                    {
                        p = new DynamicParameters();
                        p.Add("@TeamId", team.Id);
                        p.Add("@PersonId", tm.Id);

                        connection.Execute("dbo.spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);
                    }
                }
            }
        }
    }
}
