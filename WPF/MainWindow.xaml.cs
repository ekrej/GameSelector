using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GameSelector.ViewModel;

namespace GameSelector
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainViewModel _vm;
        public MainWindow()
        {
            InitializeComponent();
            _vm = (this.DataContext as MainViewModel);
        }

        // application menu events
        private void Minimize_Click(object sender, RoutedEventArgs e) 
            => Application.Current.MainWindow.WindowState = WindowState.Minimized;


        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
            => Application.Current.Shutdown();

        // gameselector events
        private void AddButton_Click(object sender, RoutedEventArgs e)
            => _vm?.AddNewGame();

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (GamesListBox.SelectedItem != null)
                _vm?.RemoveGame(GamesListBox.SelectedIndex);
            else
                _vm?.RemoveGame();
        }

        private void SelectButton_Click(object sender, RoutedEventArgs e)
        {
            SelectedGame.Text = _vm?.SelectGame();
        }
    }
}