using System;

namespace osuSongPackager
{
    public class InvalidSongException : Exception
    {
        public InvalidSongException()
            : base("Song is not valid!")
        {
        }
    }
}
