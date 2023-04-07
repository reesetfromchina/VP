using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportskaOblozuvalnica
{
    public class GameForTicket
    {
        public Game Game { get; set; }
        public string Tip { get; set; }

        public decimal getCoef()
        {
            switch (Tip)
            {
                case "1":
                    return Game.Coef1;
                case "2":
                    return Game.Coef2;
                default:
                    return Game.CoefX;
            }
        }

        public GameForTicket(Game game, string tip)
        {
            Game = game;
            Tip = tip;
        }

        public override string ToString()
        {
            return $"{Game.ToString()} Tip: {Tip} Coef: {getCoef()}";
        }
    }
}
