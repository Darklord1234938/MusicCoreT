using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCoreT
{
    static public class MusicNotes
    {
        static public void PlayeNote(NoteInfo _note)
        {
            int frequency = 0;

            switch (_note.GetHigh())
            {
                case -1: //low
                    switch (_note.GetNote())
                    {
                        case 'a':
                            frequency = 110;
                            break;
                        case 'b':
                            frequency = 123;
                            break;
                        case 'c':
                            frequency = 130;
                            break;
                        case 'd':
                            frequency = 146;
                            break;
                        case 'f':
                            frequency = 174;
                            break;
                        case 'e':
                            frequency = 164;
                            break;
                        case 'g':
                            frequency = 196;
                            break;
                    }
                    break;
                case 0: //normale
                    switch (_note.GetNote())
                    {
                        case 'a':
                            frequency = 440;
                            break;
                        case 'b':
                            frequency = 493;
                            break;
                        case 'c':
                            frequency = 261;
                            break;
                        case 'd':
                            frequency = 294;
                            break;
                        case 'f':
                            frequency = 349;
                            break;
                        case 'e':
                            frequency = 329;
                            break;
                        case 'g':
                            frequency = 392;
                            break;
                    }
                    break; // high
                case 1:
                    switch (_note.GetNote())
                    {
                        case 'a':
                            frequency = 880;
                            break;
                        case 'b':
                            frequency = 987;
                            break;
                        case 'c':
                            frequency = 523;
                            break;
                        case 'd':
                            frequency = 587;
                            break;
                        case 'f':
                            frequency = 698;
                            break;
                        case 'e':
                            frequency = 659;
                            break;
                        case 'g':
                            frequency = 783;
                            break;
                    }
                    break;
            }

            Console.Beep(frequency, _note.GetDuration());
            Thread.Sleep(50);
        }

        static public void PlayeNote(int _high, char _note, int _duration)
        {
            int frequency = 0;

            switch (_high)
            {
                case -1: //low
                    switch (_note)
                    {
                        case 'a':
                            frequency = 110;
                            break;
                        case 'b':
                            frequency = 123;
                            break;
                        case 'c':
                            frequency = 130;
                            break;
                        case 'd':
                            frequency = 146;
                            break;
                        case 'f':
                            frequency = 174;
                            break;
                        case 'e':
                            frequency = 164;
                            break;
                        case 'g':
                            frequency = 196;
                            break;
                    }
                    break;
                case 0: //normale
                    switch (_note)
                    {
                        case 'a':
                            frequency = 440;
                            break;
                        case 'b':
                            frequency = 493;
                            break;
                        case 'c':
                            frequency = 261;
                            break;
                        case 'd':
                            frequency = 294;
                            break;
                        case 'f':
                            frequency = 349;
                            break;
                        case 'e':
                            frequency = 329;
                            break;
                        case 'g':
                            frequency = 392;
                            break;
                    }
                    break; // high
                case 1:
                    switch (_note)
                    {
                        case 'a':
                            frequency = 880;
                            break;
                        case 'b':
                            frequency = 987;
                            break;
                        case 'c':
                            frequency = 523;
                            break;
                        case 'd':
                            frequency = 587;
                            break;
                        case 'f':
                            frequency = 698;
                            break;
                        case 'e':
                            frequency = 659;
                            break;
                        case 'g':
                            frequency = 783;
                            break;
                    }
                    break;
            }


            Console.Beep(frequency, _duration);
            Thread.Sleep(50);
        }


    }
}
