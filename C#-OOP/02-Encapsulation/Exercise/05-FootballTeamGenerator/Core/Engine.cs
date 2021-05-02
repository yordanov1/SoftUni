using Exer_05.FootballTeamGenerator.Common;
using Exer_05.FootballTeamGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exer_05.FootballTeamGenerator.Core
{
    public class Engine
    {
        private List<Team> teams;

        public Engine()
        {
            this.teams = new List<Team>();
        }

        public void Run()
        {
            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                try
                {
                    string[] cmdArgs = command
                                    .Split(';', StringSplitOptions.None)
                                    .ToArray();

                    string cmdType = cmdArgs[0];

                    if (cmdType == "Team")
                    { 
                        AddTeam(cmdArgs);
                    }
                    else if (cmdType == "Add")
                    {
                        AddPlayerToTeam(cmdArgs);
                    }
                    else if (cmdType == "Remove")
                    {
                        RemovePlayer(cmdArgs);
                    }
                    else if (cmdType == "Rating")
                    {
                        PrintRating(cmdArgs);
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ae.Message);
                    Console.ForegroundColor = ConsoleColor.White;

                }
                catch (InvalidOperationException ioe)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ioe.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        private void PrintRating(string[] cmdArgs)
        {
            string teamName = cmdArgs[1];

            this.ValidateTeamExists(teamName);
            Team team = this.teams
                .First(t => t.Name == teamName);

            Console.WriteLine(team);
        }

        private void RemovePlayer(string[] cmdArgs)
        {
            string teamName = cmdArgs[1];
            string playerName = cmdArgs[2];

            this.ValidateTeamExists(teamName);

            Team team = this.teams
                .First(t => t.Name == teamName);

            team.RemovePlayer(playerName);
        }

        private void AddPlayerToTeam(string[] cmdArgs)
        {
            string teamName = cmdArgs[1];
            string playerName = cmdArgs[2];

            this.ValidateTeamExists(teamName);

            Team team = this.teams
                .First(t => t.Name == teamName);

            Stats stats =
                this.CreateStats(cmdArgs.Skip(3).ToArray());

            Player player = new Player(playerName, stats);
            team.AddPlayer(player);
        }

        private Stats CreateStats(string[] cmdArgs)
        {
            int endurance = int.Parse(cmdArgs[0]);
            int sprint = int.Parse(cmdArgs[1]);
            int dribble = int.Parse(cmdArgs[2]);
            int passing = int.Parse(cmdArgs[3]);
            int shooting = int.Parse(cmdArgs[4]);

            Stats stats = new Stats(endurance, sprint, dribble, passing, shooting);
            return stats;
        }

        private void ValidateTeamExists(string name)
        {
            if (!this.teams.Any(t => t.Name == name))
            {
                throw new ArgumentException(String.Format
                    (GlobalConstants.MissingTeamExeptionMessage, name));
            }
        }

        private void AddTeam(string[] cmdArgs)
        {
            string teamName = cmdArgs[1];

            Team team = new Team(teamName);

            this.teams.Add(team);
        }
    }
}
