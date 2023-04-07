using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportskaOblozuvalnica
{
    public class Game
    {
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
        public string Code { get; set; }
        public decimal Coef1 { get; set; }
        public decimal CoefX { get; set; }
        public decimal Coef2 { get; set; }

        public Game(Team homeTeam, Team awayTeam, string code, decimal coef1, decimal coefX, decimal coef2)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            Code = code;
            Coef1 = coef1;
            CoefX = coefX;
            Coef2 = coef2;
        }

        public override string ToString()
        {
            return $"{HomeTeam} vs {AwayTeam} Code{Code}";
        }
    }
}
