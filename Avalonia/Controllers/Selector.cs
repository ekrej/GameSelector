using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSelector.Models;

namespace GameSelector.Controllers
{
    public class Selector
    {
        public Selector()
        {

        }

        public string SelectGame(GamesCollection games)
        {
            if (games.Count > 0)
            {
                Byte gamesByteLength = Convert.ToByte(games.Count);
                return games[Dice.Roll(Convert.ToByte(games.Count))].Title;
            }
            
            return "No games found";
        }
    }
}
