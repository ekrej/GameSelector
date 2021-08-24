using System;
using System.Collections.Generic;
using System.Linq;
using GameSelector.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Selector = GameSelector.Controllers.Selector;

namespace GameSelector.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

        public GamesCollection Games { get; set; }
        
        private Selector Selector { get; set; }
        
        public MainWindowViewModel()
        {
            Games = new GamesCollection();
            Selector = new Selector();
        }

        public void AddGame() => Games.AddGame();

        public void RemoveGame(int row) => Games.Remove(Games[row]);
        public void RemoveGame() => Games.Remove(Games.Last());

        public string SelectGame() => this.Selector.SelectGame(Games);
        
        
    }
}
