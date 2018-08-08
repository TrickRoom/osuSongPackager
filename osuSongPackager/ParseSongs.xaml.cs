using System;
using System.Windows;
using System.Windows.Input;

namespace osuSongPackager
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class ParseSongs : Window
    {
        public ParseSongs(String dirPath)
        {
            InitializeComponent();

        }
        private void Border_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var clickedElement = e.OriginalSource;
            Console.WriteLine(clickedElement);
        }

        private void SongParser(String diPath)
        {
            //take directory and for each path, load song
        }

        private void SongIndexer()
        {
            //create songCache.json but only make the file at the end to avoid corruption
        }
    }
}
