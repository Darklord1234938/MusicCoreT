using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCoreT
{
    public class NoteInfo
    {
        int high;
        char note;
        int duration;

        public NoteInfo(int _high, char _note, int _duration)
        {
            high = _high;
            note = _note;
            duration = _duration;
        }

        public int GetHigh()
        {
            return high;
        }

        public char GetNote()
        {
            return note;
        }

        public int GetDuration()
        {
            return duration;
        }
    }
}
