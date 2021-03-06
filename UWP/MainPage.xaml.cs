using GameSelector.Models;
using System.Linq;
using System.Windows;
using Windows.Foundation;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using GameSelector.Controllers;
using Selector = GameSelector.Controllers.Selector;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GameSelector
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Selector selector { get; set; }
        public GamesCollection Games = new GamesCollection();



        public MainPage()
        {
            this.InitializeComponent();

            ApplicationView.PreferredLaunchViewSize = new Size(548, 500);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;

            selector = new Selector();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            GridShadow.Receivers.Add(BackgroundGrid);
        }

        private void AddButtonClick(object sender, RoutedEventArgs e)
            => Games.AddGame();
        

        private void DeleteButtonClick(object sender, RoutedEventArgs e)
        {
            if (GamesListBox.SelectedItem != null)
                Games.RemoveAt(GamesListBox.SelectedIndex);
            else if (Games.Count > 0)
                Games.Remove(Games.Last());
        }

        private void SelectButtonClick(object sender, RoutedEventArgs e)
        {
            GameResult.Text = selector.SelectGame(Games);
        }
    }
}