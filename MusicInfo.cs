using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCoreT
{
    public class MusicInfo
    {
        List<NoteInfo> noteList;

        public MusicInfo(List<NoteInfo> _nList)
        {
            noteList = _nList;
        }

        public int Count()
        {
            return noteList.Count;
        }

        public NoteInfo GetNoteInfo(int _num)
        {
            return noteList[_num];
        }
    }
}
