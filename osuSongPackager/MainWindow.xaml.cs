using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace osuSongPackager {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            populateListView();
        }

        private void populateListView() {
            List<Song> songs = new List<Song>();
            songs.Add(new Song() { Title = "song1", Artist = "swoog swog", AudioFilename="temp.mp3"});
            songs.Add(new Song() { Title = "song2", Artist = "swoog swog", AudioFilename = "temp.mp3" });
            songs.Add(new Song() { Title = "song1", Artist = "swoog sw2og", AudioFilename = "temp.mp3" });
            lView.ItemsSource = songs;
        }

        private void Open_Click(object sender, RoutedEventArgs e) {
            // Create OpenFileDialog 
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            System.Windows.Forms.DialogResult result = dialog.ShowDialog();

            // Get the selected file name and display in a TextBox 
            if (result == System.Windows.Forms.DialogResult.OK) {
                // Open document 

                string mDirectory = dialog.SelectedPath;
                ParseSongs pw = new ParseSongs(mDirectory);
                pw.Owner = this;
                pw.ShowDialog();

                /*
                string[] directories = System.IO.Directory.GetDirectories(mdirectory);
                try {
                    Song temp = LoadSong.SongLoader(mdirectory);
                    Console.WriteLine(temp.ToString());

                }
                catch {
                    Console.WriteLine("Bad Song");
                }
                
               //ArrayList songs = sl.LoadSongs(filename);
               */
            } 
        }

        private void Exit_Click(object sender, RoutedEventArgs e) {
         
        }

    }
}