using System;
using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using GameSelector.Models;
using GameSelector.ViewModels;

namespace GameSelector.Views
{
    public partial class MainWindow : Window
    {
        //private static readonly RoutedEvent<>

        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void AddButton_OnClick(object? sender, RoutedEventArgs e)
        {
            (DataContext as MainWindowViewModel)?.AddGame();
        }

        private void DeleteButton_OnClick(object? sender, RoutedEventArgs e)
        {
            var gamesList = this.FindControl<ListBox>("GamesListBox");
            if (gamesList != null)
            {
                if (gamesList.SelectedItem != null) 
                    (DataContext as MainWindowViewModel)?.RemoveGame(gamesList.SelectedIndex);
                else 
                    (DataContext as MainWindowViewModel)?.RemoveGame();
            }
        }

        private void SelectButton_OnClick(object? sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
