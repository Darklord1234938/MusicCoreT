
namespace MusicCoreT
{
    public class MusicPlayer
    {

        MusicInfo loadedMusicInfo;
        bool isPlaying = false;

        public MusicPlayer(MusicInfo _mInfo)
        {
            loadedMusicInfo = _mInfo;
        }

        public void Load(MusicInfo _loadMInfo)
        {
            loadedMusicInfo = _loadMInfo;
        }

        public void Start()
        {
            Thread MusicChannel = new Thread(Update);
            MusicChannel.Start();
            isPlaying = true;
        }

        void Update()
        {
            while (isPlaying)
            {
                for (int i = 0; i < loadedMusicInfo.Count(); i++)
                {
                    if (loadedMusicInfo.GetNoteInfo(i) != null)
                    {
                        MusicNotes.PlayeNote(loadedMusicInfo.GetNoteInfo(i));
                    }
                    else
                    {
                        Thread.Sleep(250);
                    }
                }
            }
        }

        public void End()
        {
            isPlaying = false;
        }
    }
}
