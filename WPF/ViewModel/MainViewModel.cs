using System;
using System.Linq;
using GameSelector.Controllers;
using GameSelector.Models;

namespace GameSelector.ViewModel
{
    public class MainViewModel: ObservableObject
    {
        public GamesCollection Games { get; set; }
        private Selector _gameSelector { get; set; }

        public MainViewModel()
        {
            Games = new GamesCollection();
            _gameSelector = new Selector();
        }

        public void AddNewGame() =>Games.AddGame();

        public void RemoveGame() => Games.Remove(Games.Last());
        public void RemoveGame(int index) => Games.Remove(Games[index]);

        public string SelectGame()
        {
            return _gameSelector.SelectGame(Games);
        }
    }
}