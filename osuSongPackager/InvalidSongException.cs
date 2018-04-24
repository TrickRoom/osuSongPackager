using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osuSongPackager {
    public class InvalidSongException : Exception {
        public InvalidSongException()
            :base ("Song is not valid!") { 
        }
    }
}
