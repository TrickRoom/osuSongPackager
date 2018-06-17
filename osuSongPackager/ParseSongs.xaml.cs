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
using System.Windows.Shapes;

namespace osuSongPackager {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class ParseSongs : Window {
        public ParseSongs(String dirPath) {
            InitializeComponent();

        }
        private void Border_PreviewMouseDown(object sender, MouseButtonEventArgs e) {
            var clickedElement = e.OriginalSource;
            Console.WriteLine(clickedElement);
        }

        private void songParser(String diPath) {
            //take directory and for each path, load song
        }

        private void songIndexer() {
            //create songCache.json but only make the file at the end to avoid corruption
        }
    }
}
