using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_05.FootballTeamGenerator.Common
{
    public class GlobalConstants
    {
        public static string InvalidStatExceptionMessage = "{0} should be between {1} and {2}.";
        public static string EmptyNameExceptionMessage = "A name should not be empty.";
        public static string RemovingMissingPlayerExceptionMessage = "Player {0} is not in {1} team.";
        public static string MissingTeamExeptionMessage = "Team {0} does not exist.";
    }
}
