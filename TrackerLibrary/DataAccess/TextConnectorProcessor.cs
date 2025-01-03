﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TrackerLibrary.Models;
using System.Diagnostics;
using System.Collections.Immutable;
using System.Security.Cryptography.X509Certificates;

namespace TrackerLibrary.DataAccess.TextHelper
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName) // ex. PrizeModels.csv
        {
            // C:\data\Tou\p.csv


            return Path.Combine(ConfigurationManager.AppSettings["filePath"], fileName);
        }

        public static List<string> LoadFile(this string file) 
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList() ;
        }

        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();
            foreach (string line in lines) 
            {
                string[] cols = line.Split(',');

                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);
                output.Add(p);

            }
            return output ;
        }


        public static void SaveToPrizeFile(this List<PrizeModel> models,string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            }
            File.WriteAllLines(fileName.FullFilePath(),lines);

        }


        public static List<PersonModel> ConvertToPersonModels(this List<string> lines) 
        {
            List<PersonModel> output  = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(",");
                PersonModel p = new PersonModel();
                p.Id=int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.CellPhoneNumber = cols[3];
                p.EmailAddress = cols[4];

                output.Add(p);

            }

            return output ;
        }

        public static void SaveToPeopleFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellPhoneNumber}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);

        }



        public static List<TeamModel> ConvertToTeamModel(this List<string> lines,string peopleFileName) 
        {
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();

            foreach(string line in lines)
            {
                string[] cols = line.Split(',');

                TeamModel t = new TeamModel();
                t.Id = int.Parse(cols[0]);
                t.TeamName =cols[1];

                string[] personIds = cols[2].Split(":");

                foreach (string id in personIds) 
                {
                    if (!string.IsNullOrWhiteSpace(id) && int.TryParse(id, out int personId))
                    {
                        var person = people.FirstOrDefault(x => x.Id == personId);
                        if (person != null)
                        {
                            t.TeamMembers.Add(person);
                        }
                        else
                        {
                            Console.WriteLine($"Person with ID {personId} not found.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid ID: '{id}' found in team member list.");
                    }
                    output.Add(t);
                }
            }
            return output ;
        }



        public static List<TournamentModel> ConvertTournamentModels(this List<string> lines,
            string teamFileName, 
            string peopleFileName,
            string prizeFileName)
        {
            List<TournamentModel> output = new List<TournamentModel>();
            List<PrizeModel> prizes = prizeFileName.FullFilePath().LoadFile().ConvertToPrizeModels();
            List<TeamModel> teams = teamFileName.FullFilePath().LoadFile().ConvertToTeamModel(peopleFileName);
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                TournamentModel tm = new TournamentModel();
                tm.Id = int.Parse(cols[0]);
                tm.TournamentName = cols[1];
                tm.EntryFee = decimal.Parse(cols[2]);

                string[] teamsIds = cols[3].Split('|');

                foreach (string id in teamsIds)
                {
                    tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }

                string[] prizeIds = cols[4].Split('|');

                foreach (string id in prizeIds) 
                {
                    tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                }

                // capture the round informations

                output.Add(tm);
            }
            return output;
        }
        public static void SaveToTeamFile(this  List<TeamModel> models,string fileName)
        {
            List<string> lines = new List<string>();
            
            foreach (TeamModel t in models) 
            {
                lines.Add($"{t.Id},{t.TeamName},{ConvertPeopleListToString(t.TeamMembers)}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);


        }

        private static string ConvertTeamListToString(List<TeamModel> teams)
        {
            string output = "";
            if (teams.Count == 0) { return ""; }


            foreach (TeamModel t in teams)
            {
                output += $"{t.Id}";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }
        private static string ConvertPrizeListToString(List<PrizeModel> prizes)
        {
            string output = "";
            if (prizes.Count == 0) { return ""; }


            foreach (PrizeModel t in prizes)
            {
                output += $"{t.Id}";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }
        private static string ConvertRoundsListToString(List<List<MatchupModel>> rounds)
        {
            string output = "";
            if (rounds.Count == 0) { return ""; }


            foreach (List<MatchupModel> r in rounds)
            {
                output += $"{ConvertMatchUpListToString(r)}";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertMatchUpListToString(List<MatchupModel> matchups)
        {
            string output = "";
            if (matchups.Count == 0) { return ""; }


            foreach (MatchupModel m in matchups)
            {
                output += $"{m.Id}^";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        public static void SaveToTournamentFile(this List<TournamentModel> models,string fileName)
        {
            List<string> lines = new List<string>();
            foreach(TournamentModel t in models)
            {
                lines.Add($@"{t.Id},
                {t.TournamentName},{t.EntryFee},{ConvertTeamListToString(t.EnteredTeams)},
                {ConvertPrizeListToString(t.Prizes)},{ConvertRoundsListToString(t.Rounds)}
                ");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);

        }



        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            string output = "";
            if (people.Count == 0 ) { return ""; }


            foreach (PersonModel p in people)
            {
                output += $"{p.Id}";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }
    }
}
