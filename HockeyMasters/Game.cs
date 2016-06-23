using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HockeyMasters
{
    class Game
    {
        private string HomeTeam;
        private string AwayTeam;
        private int HomeScore;
        private int AwayScore;
        private Random rndNumber;
        private string Result;

        public Game(string homeTeam, string awayTeam)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            rndNumber = new Random();
            HomeScore = rndNumber.Next(0, 5);
            AwayScore = rndNumber.Next(0, 5);
            Result = string.Format("{0} {1} vs {2} {3}", HomeTeam, HomeScore, AwayTeam, AwayScore);
        }

        public string GameResult()
        {
            return Result;
        }
    }
}
