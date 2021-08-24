using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;
using GameSelector.Models;

namespace GameSelector.ViewModels
{
    public class ViewModelBase : ReactiveObject
    {
        int selectedIndex;

        public int SelectedIndex
        {
            get => selectedIndex;
            set => this.RaiseAndSetIfChanged(ref selectedIndex, value);
        }
        
       Game selectedItem;

        public Game SelectedItem
        {
            get => selectedItem;
            set => this.RaiseAndSetIfChanged(ref selectedItem, value);
        }
    }
    }
}
