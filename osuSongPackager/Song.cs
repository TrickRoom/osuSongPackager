using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace osuSongPackager {
    class Song {
        //should have fields for title, title unicode, artist, artist unicode, etc.
        //maybe even picture
        private string directory, title, titleUnicode, artist, artistUnicode, creator, source, audioFilename, background;
        private String[] tags;
        private int songID, duration;
        private DateTime dateDownloaded;
        public Song() {
            songID = -1;
            directory = "";               //Required
            title = "t";                   //Required
            titleUnicode = "tu";
            artist = "";
            artistUnicode = "";
            creator = "";
            source = "";
            tags = new String[0];
            audioFilename = "";           //Required
            duration = -1;
            dateDownloaded = new DateTime();
            background = "";
        }

        public string Directory { get => directory; set => directory = value; }
        public string Title { get => title; set => title = value; }
        public string Artist { get => artist; set => artist = value; }
        public string Creator { get => creator; set => creator = value; }
        public string Source { get => source; set => source = value; }
        public string AudioFilename { get => audioFilename; set => audioFilename = value; }
        public string Background { get => background; set => background = value; }
        public string[] Tags { get => tags; set => tags = value; }
        public int SongID { get => songID; set => songID = value; }
        public int Duration { get => duration; set => duration = value; }
        public DateTime DateDownloaded { get => dateDownloaded; set => dateDownloaded = value; }

        //not working
        public string TitleUnicode {
            get {
                return titleUnicode;
            }
            set {
                titleUnicode = value;
            }
        }


        public string ArtistUnicode {
            get {
                return artistUnicode;
            }
            set {
                artistUnicode = value;
            }
        }

public override string ToString() {
            return SongID + "\n" + directory + "\n" + title + "\n" + titleUnicode + "\n" 
                + artist + "\n" + artistUnicode + "\n" + creator + "\n" + source + "\n" + tags + "\n"
                + audioFilename + "\n" + duration + "\n" + dateDownloaded + "\n" + background;
        }
    }
}
