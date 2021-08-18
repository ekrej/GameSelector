using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSelector.Models
{
    public class GamesCollection: ObservableCollection<Game>
    {
        public GamesCollection()
        {
            Add( new Game("Add a Game"));
        }

        public void AddGame() => Add(new Game("New Game"));
    }
}
