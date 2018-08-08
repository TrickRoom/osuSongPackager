using System;

namespace osuSongPackager
{
    class Song
    {
        // string's are unicode by default (UTF-16)
        // Required properties
        public string Directory { get; set; } = "";
        public string Title { get; set; } = "t";
        public string AudioFilename { get; set; } = "";

        public string Artist { get; set; } = "";
        public string Creator { get; set; } = "";
        public string Source { get; set; } = "";
        public string Background { get; set; } = "";
        public string[] Tags { get; set; } = new string[0];
        public int SongID { get; set; } = 0;
        public int Duration { get; set; } = 0;
        public DateTime DateDownloaded { get; set; } = DateTime.Now;

        public Song()
        { }

        public override string ToString()
        {
            return SongID + "\n" + Directory + "\n" + Title + "\n"
                + Artist + "\n" + Creator + "\n" + Source + "\n" + Tags + "\n"
                + AudioFilename + "\n" + Duration + "\n" + DateDownloaded + "\n" + Background;
        }
    }
}
