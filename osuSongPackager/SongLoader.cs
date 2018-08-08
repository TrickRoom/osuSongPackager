using System;
using System.Diagnostics;
using System.IO;

namespace osuSongPackager
{
    class LoadSong
    {
        public static Song SongLoader(String dirPath)
        {
            Song tempSong = new Song();
            int validityCount = 0;
            String line, mask = "*.osu";
            String[] files = Directory.GetFiles(dirPath, mask);
            //ERRCHECK
            if (files.Length == 0)
            {
                Debug.WriteLine(validityCount);
                throw new InvalidSongException();
            }
            String targetFile = files[0];
            StreamReader reader = File.OpenText(targetFile);
            //ERRCHECK

            //add directory to song
            tempSong.Directory = dirPath;
            tempSong.DateDownloaded = File.GetCreationTime(targetFile);
            //add everything else to song 
            while ((line = reader.ReadLine()) != null)
            {
                string temp = "";
                if (line.StartsWith("AudioFilename"))
                {
                    temp = line.Substring(line.IndexOf(":") + 2);
                    validityCount++;
                    tempSong.AudioFilename = temp;
                }
                else if (line.StartsWith("Title"))
                {
                    if (line.Substring(line.IndexOf("Title") + 5).StartsWith("Unicode"))
                    { //In case of titleUnicode
                        temp = line.Substring(line.IndexOf(":") + 1);
                        tempSong.TitleUnicode = temp;
                    }
                    else
                    { //normal Title
                        temp = line.Substring(line.IndexOf(":") + 1);
                        tempSong.Title = temp;
                    }
                    validityCount++;
                }
                else if (line.StartsWith("Artist"))
                {
                    if (line.Substring(line.IndexOf("Artist") + 6).StartsWith("Unicode"))
                    { //In case of artistUnicode
                        temp = line.Substring(line.IndexOf(":") + 1);
                        tempSong.ArtistUnicode = temp;
                    }
                    else
                    { //normal Artist
                        temp = line.Substring(line.IndexOf(":") + 1);
                        tempSong.Artist = temp;
                    }
                }
                else if (line.StartsWith("Creator"))
                {
                    temp = line.Substring(line.IndexOf(":") + 1);
                    tempSong.Creator = temp;
                }
                else if (line.StartsWith("Source"))
                {
                    temp = line.Substring(line.IndexOf(":") + 1);
                    tempSong.Source = temp;
                }
                else if (line.StartsWith("Tags"))
                {
                    temp = line.Substring(line.IndexOf(":") + 1);
                    tempSong.Tags = temp.Split(' ');
                }
                else if (line.StartsWith("BeatmapSetID"))
                {
                    temp = line.Substring(line.IndexOf(":") + 1);
                    int id;
                    if (Int32.TryParse(temp, out id))
                    {
                        tempSong.SongID = id;
                    }
                    else
                    {
                        Debug.WriteLine(temp + ": Could not be parsed int an int");
                    }
                }
                else if (line.IndexOf("0,0,") == 0)
                {
                    temp = line.Substring(line.IndexOf("0"), line.Length - 1);
                    temp = temp.Substring(5);
                    tempSong.Background = temp;
                }
            }

            if (validityCount < 2)
            {
                Debug.WriteLine(validityCount);
                throw new InvalidSongException();
            }
            else
            {
                return tempSong;
            }
        }
    }
}
/*
 * take in song folder
 * identify .osu file
 * read in specific parts of beatmap file
 * copy to song object
 * verify validity of song object 
 * return song object
*/
