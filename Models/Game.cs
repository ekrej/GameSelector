using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSelector.Models
{
    public class Game
    {
        public string ID { get; set; }
        public string Title { get; set; }
        
        public Game(int id, string title)
        {
            ID = "Game" + id;
            Title = title;
        }
    }
}
