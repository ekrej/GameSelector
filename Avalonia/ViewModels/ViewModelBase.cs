using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;
using GameSelector.Models;

namespace GameSelector.ViewModels
{
    public class ViewModelBase : ReactiveObject
    {
        private int selectedIndex;
        private Game selectedItem;

        public int SelectedIndex
        {
            get => selectedIndex;
            set => this.RaiseAndSetIfChanged(ref selectedIndex, value);
        }
        
        public Game SelectedItem
        {
            get => selectedItem;
            set => this.RaiseAndSetIfChanged(ref selectedItem, value);
        }
    }
}
