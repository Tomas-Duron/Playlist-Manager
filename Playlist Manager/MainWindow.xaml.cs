using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Playlist_Manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Geometry PauseButtonGeometry;
        private Geometry PlayButtonGeometry;

        public MainWindow()
        {
            InitializeGeometry();
            InitializeComponent();
            Console.WriteLine("MainWindow initialized.");
        }

        private void InitializeGeometry()
        {
            PauseButtonGeometry = Geometry.Parse("M360-320h80v-320h-80v320Zm160 0h80v-320h-80v320ZM480-80q-83 0-156-31.5T197-197q-54-54-85.5-127T80-480q0-83 31.5-156T197-763q54-54 127-85.5T480-880q83 0 156 31.5T763-763q54 54 85.5 127T880-480q0 83-31.5 156T763-197q-54 54-127 85.5T480-80Zm0-80q134 0 227-93t93-227q0-134-93-227t-227-93q-134 0-227 93t-93 227q0 134 93 227t227 93Zm0-320Z");
            PlayButtonGeometry = Geometry.Parse("m380-300 280-180-280-180v360ZM480-80q-83 0-156-31.5T197-197q-54-54-85.5-127T80-480q0-83 31.5-156T197-763q54-54 127-85.5T480-880q83 0 156 31.5T763-763q54 54 85.5 127T880-480q0 83-31.5 156T763-197q-54 54-127 85.5T480-80Zm0-80q134 0 227-93t93-227q0-134-93-227t-227-93q-134 0-227 93t-93 227q0 134 93 227t227 93Zm0-320Z");
        }

        private void CreatePlaylistDropdownButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Create Playlist button clicked.");
            CreatePlaylistDropdownButton.ContextMenu.IsOpen = true;
        }

        private void ImportPlaylistFromYoutubeButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Import Playlist from YouTube button clicked.");
            // Logic to import playlist from YouTube
        }

        private void ImportPlaylistFromSpotifyButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Import Playlist from Spotify button clicked.");
            // Logic to import playlist from Spotify
        }

        private void CreateEmptyPlaylistButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Create Empty Playlist button clicked.");
            // Logic to create an empty playlist
        }

        private void PausePlayButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Pause/Play button clicked.");

            if(PausePlayButtonPath.Data == PauseButtonGeometry)
            {
                PausePlayButtonPath.Data = PlayButtonGeometry;
                Console.WriteLine("Switched to Play button.");
            }
            else
            {
                PausePlayButtonPath.Data = PauseButtonGeometry;
                Console.WriteLine("Switched to Pause button.");
            }
        }
    }
}