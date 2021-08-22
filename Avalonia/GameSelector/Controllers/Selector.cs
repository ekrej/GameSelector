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

        public string SelectGame(List<Game> games)
        {
            Byte gamesByteLength = Convert.ToByte(games.Count);
            return games[Dice.Roll(gamesByteLength)].Title;
        }
    }
}
