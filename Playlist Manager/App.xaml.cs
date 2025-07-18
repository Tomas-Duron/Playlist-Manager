using System.Configuration;
using System.Data;
using System.IO;
using System.Windows;

namespace Playlist_Manager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Console.WriteLine("Application is opening");

            string playlistFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Playlists");
            if(!Directory.Exists(playlistFolderPath))
            {
                Directory.CreateDirectory(playlistFolderPath);
                Console.WriteLine($"Created playlist folder at: {playlistFolderPath}");
            }
            else
            {
                Console.WriteLine($"Playlist folder already exists at: {playlistFolderPath}");
            }

            string songPlaylistFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Songs");

            base.OnStartup(e);
        }
        protected override void OnExit(ExitEventArgs e)
        {
            // Clean up resources or save settings if necessary
            Console.WriteLine("Application is closing");
            base.OnExit(e);
        }

        private void CreatePlaylist()
        {
            Console.WriteLine("Creating a new playlist...");
        }

        private void LoadPlaylists()
        {
            Console.WriteLine("Loading an existing playlist...");
        }
    }

}
