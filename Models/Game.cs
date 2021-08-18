using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSelector.Models
{
    public class Game
    {
        public string Title { get; set; }

        public Game(string title)
        {
            Title = title;
        }
    }
}
